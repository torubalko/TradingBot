#include "BinanceConnection.h"
#include "JsonParser.h"
#include "Types.h"
#include "Logger.h"
#include <iostream>
#include <algorithm>
#include <cctype>
#include <deque>
#include <chrono>
#include <thread>
#include <boost/beast/http.hpp>

#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>

namespace TradingBot::Core::Network {

    BinanceConnection::BinanceConnection(std::shared_ptr<SharedState> state)
        : state_(state) {
        ctx_.set_verify_mode(boost::asio::ssl::verify_none);
    }

    BinanceConnection::~BinanceConnection() {
        Stop();
    }

    void BinanceConnection::Stop() {
        running_ = false;
        if (!ioc_.stopped()) ioc_.stop();
    }

    long long BinanceConnection::DownloadSnapshot(const std::string& symbol, bool useTestnet) {
        try {
            std::string host = useTestnet ? "testnet.binancefuture.com" : "fapi.binance.com";
            std::string target = "/fapi/v1/depth?symbol=" + symbol + "&limit=1000";

            // Create a NEW io_context for the snapshot thread to avoid any interference
            net::io_context snap_ioc;
            ssl::context snap_ctx{ ssl::context::tlsv12_client };
            snap_ctx.set_verify_mode(boost::asio::ssl::verify_none);

            tcp::resolver resolver(snap_ioc);
            beast::ssl_stream<beast::tcp_stream> stream(snap_ioc, snap_ctx);

            if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str())) return 0;

            auto const results = resolver.resolve(host, "443");
            beast::get_lowest_layer(stream).connect(results);
            stream.handshake(ssl::stream_base::client);

            http::request<http::string_body> req{ http::verb::get, target, 11 };
            req.set(http::field::host, host);
            req.set(http::field::user_agent, "TigerBot/1.0");

            http::write(stream, req);

            beast::flat_buffer buffer;
            http::response<http::string_body> res;
            http::read(stream, buffer, res);

            auto snap = Utils::JsonParser::ParseSnapshot(res.body());

            long long lastUpdateId = 0;
            if (!snap.bids.empty() && snap.lastUpdateId > 0) {
                state_->ApplyUpdate(snap.bids, snap.asks);
                lastUpdateId = snap.lastUpdateId;
                
                Logger::Log("[Snapshot] Downloaded. LastUpdateId: " + std::to_string(lastUpdateId));
            } else {
                Logger::Log("[Snapshot] Empty or invalid.");
            }

            beast::error_code ec;
            stream.shutdown(ec);
            return lastUpdateId;
        }
        catch (std::exception const& e) {
            Logger::Log(std::string("[Snapshot] Error: ") + e.what());
            return 0;
        }
    }

    void BinanceConnection::DownloadSnapshotAsync(const std::string& symbol, bool useTestnet) {
        isSnapshotDownloading_ = true;
        std::thread([this, symbol, useTestnet]() {
            long long id = DownloadSnapshot(symbol, useTestnet);
            snapshotLastUpdateId_ = id;
            isSnapshotDownloading_ = false;
        }).detach();
    }

    void BinanceConnection::Connect(const std::string& symbol, bool useTestnet) {
        std::string upperSymbol = symbol;
        std::string lowerSymbol = symbol;
        std::transform(upperSymbol.begin(), upperSymbol.end(), upperSymbol.begin(), ::toupper);
        std::transform(lowerSymbol.begin(), lowerSymbol.end(), lowerSymbol.begin(), ::tolower);

        try {
            std::string host = useTestnet ? "stream.binancefuture.com" : "fstream.binance.com";
            std::string target = "/stream?streams=" + lowerSymbol + "@depth@100ms";

            tcp::resolver resolver(ioc_);
            auto const results = resolver.resolve(host, "443");

            websocket::stream<beast::ssl_stream<tcp::socket>> ws(ioc_, ctx_);
            auto ep = net::connect(get_lowest_layer(ws), results);

            net::socket_base::receive_buffer_size option(1024 * 1024);
            get_lowest_layer(ws).set_option(option);

            if (!SSL_set_tlsext_host_name(ws.next_layer().native_handle(), host.c_str()))
                throw std::runtime_error("SNI Error");

            ws.next_layer().handshake(ssl::stream_base::client);
            std::string host_header = host + ":" + std::to_string(ep.port());

            ws.binary(false);
            ws.auto_fragment(false);
            ws.read_message_max(4 * 1024 * 1024);

            ws.handshake(host_header, target);

            beast::flat_buffer buffer;

            // Start snapshot download in background
            snapshotLastUpdateId_ = 0;
            DownloadSnapshotAsync(upperSymbol, useTestnet);

            long long lastAppliedUpdateId = 0;
            std::deque<TradingBot::Core::OrderBookUpdate> pendingDepth;
            auto lastAppliedTime = std::chrono::steady_clock::now();

            auto resync = [&]() {
                Logger::Log("[WS] Resyncing order book...");
                pendingDepth.clear();
                snapshotLastUpdateId_ = 0;
                lastAppliedUpdateId = 0;
                DownloadSnapshotAsync(upperSymbol, useTestnet);
                lastAppliedTime = std::chrono::steady_clock::now();
            };

            while (running_) {
                ws.read(buffer);
                const std::string msg = beast::buffers_to_string(buffer.data());
                buffer.consume(buffer.size());

                // Basic validation
                if (msg.find("depthUpdate") == std::string::npos) {
                    // Ignore non-depth messages (e.g. subscription confirmation)
                    continue;
                }

                auto update = Utils::JsonParser::ParseDepthUpdate(msg);
                if (update.u <= 0 || update.U <= 0) {
                    std::string shortMsg = msg.substr(0, (std::min)(msg.length(), (size_t)200));
                    Logger::Log("[WS] Parse failed for: " + shortMsg);
                    continue;
                }

                long long currentSnapId = snapshotLastUpdateId_.load();

                // Debug: Log first few buffered messages to diagnose gap
                if (currentSnapId == 0 && pendingDepth.size() < 10) {
                    Logger::Log("[WS] Buffering: U=" + std::to_string(update.U) + " u=" + std::to_string(update.u));
                }

                // Latency logging
                auto now = std::chrono::system_clock::now();
                long long nowMs = std::chrono::duration_cast<std::chrono::milliseconds>(now.time_since_epoch()).count();
                long long latency = nowMs - update.E;
                static int logCounter = 0;
                logCounter++;
                if (logCounter % 100 == 0) {
                     Logger::Log("[WS] Latency: " + std::to_string(latency) + "ms | U=" + std::to_string(update.U) + " u=" + std::to_string(update.u));
                }

                // If snapshot is still downloading or failed, just buffer or wait
                if (currentSnapId == 0) {
                    // Buffer everything while waiting for snapshot
                    // Limit buffer size to avoid memory issues if snapshot hangs
                    if (pendingDepth.size() < 10000) {
                        pendingDepth.push_back(std::move(update));
                    }
                    continue;
                }

                // Snapshot just finished?
                if (lastAppliedUpdateId == 0) {
                    lastAppliedUpdateId = currentSnapId;
                    Logger::Log("[WS] Snapshot ready. Processing buffer of size: " + std::to_string(pendingDepth.size()));

                    const long long want = currentSnapId + 1;
                    bool synced = false;

                    // Discard outdated updates and find the first one that bridges the snapshot
                    while (!pendingDepth.empty()) {
                        const auto& ev = pendingDepth.front();
                        if (ev.u <= currentSnapId) {
                            pendingDepth.pop_front();
                            continue;
                        }
                        // Binance continuity: allow if ev.pu matches snapshot or U<=want<=u
                        if ((ev.pu != 0 && ev.pu == currentSnapId) || (ev.U <= want && want <= ev.u)) {
                            state_->ApplyUpdate(ev.bids, ev.asks);
                            lastAppliedUpdateId = ev.u;
                            lastAppliedTime = std::chrono::steady_clock::now();
                            Logger::Log("[WS] Synced with snapshot via buffer!");
                            pendingDepth.pop_front();
                            synced = true;
                            break;
                        }
                        // Otherwise discard and continue searching
                        pendingDepth.pop_front();
                    }

                    if (!synced) {
                        Logger::Log("[WS] No bridging update found after snapshot, resyncing...");
                        resync();
                        continue;
                    }
                }

                auto canApply = [&](const OrderBookUpdate& u) -> bool {
                    // Ignore outdated
                    if (u.u <= lastAppliedUpdateId) return true;

                    // Binance rule: continuity via pu (futures). If pu is present, it MUST equal lastAppliedUpdateId.
                    if (u.pu != 0) {
                        if (u.pu != lastAppliedUpdateId) {
                            Logger::Log("[WS] Gap detected via pu. Expected pu=" + std::to_string(lastAppliedUpdateId) + " got pu=" + std::to_string(u.pu));
                            return false;
                        }
                    }
                    else {
                        // Fallback for streams without pu: require U..u to cover next id
                        const long long nextId = lastAppliedUpdateId + 1;
                        if (!(u.U <= nextId && nextId <= u.u)) {
                            Logger::Log("[WS] Gap detected. Expected range covering " + std::to_string(nextId) + " got U=" + std::to_string(u.U));
                            return false;
                        }
                    }

                    state_->ApplyUpdate(u.bids, u.asks);
                    lastAppliedUpdateId = u.u;
                    lastAppliedTime = std::chrono::steady_clock::now();
                    return true;
                };

                // Drain buffered updates after we have a valid lastAppliedUpdateId
                bool resyncNeeded = false;
                while (!pendingDepth.empty()) {
                    if (!canApply(pendingDepth.front())) {
                        resyncNeeded = true;
                        break;
                    }
                    pendingDepth.pop_front();
                }

                if (resyncNeeded) {
                    resync();
                    continue;
                }

                // Process current update
                if (!canApply(update)) {
                    resync();
                    continue;
                }

                // Try to drain again if buffered while we were processing
                while (!pendingDepth.empty()) {
                    if (!canApply(pendingDepth.front())) {
                        resyncNeeded = true;
                        break;
                    }
                    pendingDepth.pop_front();
                }

                if (resyncNeeded) {
                    resync();
                    continue;
                }

                auto nowSteady = std::chrono::steady_clock::now();
                if (std::chrono::duration_cast<std::chrono::seconds>(nowSteady - lastAppliedTime).count() > 10) {
                    Logger::Log("[WS] Stall detected (10s), resyncing...");
                    resync();
                }
            }
        }
        catch (std::exception const& e) {
            Logger::Log(std::string("[WS] Error: ") + e.what());
            throw;
        }
    }
}