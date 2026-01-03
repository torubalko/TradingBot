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
            }

            beast::error_code ec;
            stream.shutdown(ec);
            return lastUpdateId;
        }
        catch (std::exception const&) {
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
            pendingDepth.clear();

            auto lastAppliedTime = std::chrono::steady_clock::now();

            auto resync = [&]() {
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

                if (msg.find("depthUpdate") == std::string::npos) {
                    continue;
                }

                auto update = Utils::JsonParser::ParseDepthUpdate(msg);
                if (update.u <= 0 || update.U <= 0) {
                    continue;
                }

                long long currentSnapId = snapshotLastUpdateId_.load(std::memory_order_relaxed);

                if (currentSnapId == 0) {
                    if (pendingDepth.size() < 10000) {
                        pendingDepth.push_back(std::move(update));
                    }
                    continue;
                }

                if (lastAppliedUpdateId == 0) {
                    lastAppliedUpdateId = currentSnapId;

                    const long long want = currentSnapId + 1;
                    bool synced = false;

                    while (!pendingDepth.empty()) {
                        const auto& ev = pendingDepth.front();
                        if (ev.u <= currentSnapId) {
                            pendingDepth.pop_front();
                            continue;
                        }
                        if ((ev.pu != 0 && ev.pu == currentSnapId) || (ev.U <= want && want <= ev.u)) {
                            state_->ApplyUpdate(ev.bids, ev.asks);
                            lastAppliedUpdateId = ev.u;
                            lastAppliedTime = std::chrono::steady_clock::now();
                            state_->SetAppliedNow();
                            pendingDepth.pop_front();
                            synced = true;
                            break;
                        }
                        pendingDepth.pop_front();
                    }

                    if (!synced) {
                        resync();
                        continue;
                    }
                }

                auto canApply = [&](const OrderBookUpdate& u) -> bool {
                    if (u.u <= lastAppliedUpdateId) return true;

                    if (u.pu != 0) {
                        if (u.pu != lastAppliedUpdateId) {
                            return false;
                        }
                    }
                    else {
                        const long long nextId = lastAppliedUpdateId + 1;
                        if (!(u.U <= nextId && nextId <= u.u)) {
                            return false;
                        }
                    }

                    state_->ApplyUpdate(u.bids, u.asks);
                    lastAppliedUpdateId = u.u;
                    lastAppliedTime = std::chrono::steady_clock::now();
                    state_->SetAppliedNow();
                    return true;
                };

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

                if (!canApply(update)) {
                    resync();
                    continue;
                }

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
                    resync();
                }
            }
        }
        catch (std::exception const&) {
            // swallow here; caller retries
            throw;
        }
    }
}