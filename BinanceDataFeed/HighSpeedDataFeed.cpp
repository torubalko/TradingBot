#include "HighSpeedDataFeed.h"
#include "HttpClient.h"  // ← ADD HTTP CLIENT
#include "UserStream.h"
#include <iostream>
#include <sstream>
#include <iomanip>
#include <algorithm>
#include <cstring>
#include <openssl/x509.h>
#include <openssl/x509v3.h>
#ifdef _MSC_VER
#include <immintrin.h>
#endif
#ifdef _WIN32
#include <windows.h>
#include <wincrypt.h>
#pragma comment(lib, "crypt32.lib")
#endif
#include "../TradingBot.Core/ThreadPriority.h"

namespace hft {

namespace {
    void AddWindowsRootCerts(ssl::context& ctx) {
#ifdef _WIN32
        HCERTSTORE storeHandle = CertOpenSystemStoreA(0, "ROOT");
        if (!storeHandle) return;
        X509_STORE* store = SSL_CTX_get_cert_store(ctx.native_handle());
        PCCERT_CONTEXT certCtx = nullptr;
        while ((certCtx = CertEnumCertificatesInStore(storeHandle, certCtx)) != nullptr) {
            const unsigned char* encoded = certCtx->pbCertEncoded;
            X509* cert = d2i_X509(nullptr, &encoded, certCtx->cbCertEncoded);
            if (cert) {
                X509_STORE_add_cert(store, cert);
                X509_free(cert);
            }
        }
        CertCloseStore(storeHandle, 0);
#endif
    }

    bool VerifyHostName(bool preverified, ssl::verify_context& ctx, const std::string& host) {
        if (!preverified) {
            return false;
        }
        X509* cert = X509_STORE_CTX_get_current_cert(ctx.native_handle());
        if (!cert) {
            return false;
        }
        return X509_check_host(cert, host.c_str(), host.size(), 0, nullptr) == 1;
    }
}

WebSocketSession::WebSocketSession(
    net::io_context& ioc,
    ssl::context& sslCtx,
    const std::string& host,
    const std::string& port,
    const std::string& path,
    IMessageQueue& messageQueue,
    std::atomic<bool>& running,
    std::atomic<int64_t>& droppedCounter,
    std::atomic<size_t>& highWaterMark
)
    : ioc_(ioc)
    , sslCtx_(sslCtx)
    , resolver_(net::make_strand(ioc))
    , ws_(net::make_strand(ioc), sslCtx)
    , host_(host)
    , port_(port)
    , path_(path)
    , messageQueue_(messageQueue)
    , running_(running)
    , droppedCounter_(droppedCounter)
    , highWaterMark_(highWaterMark)
{
    buffer_.reserve(64 * 1024);
}

void WebSocketSession::Restart() {
    connected_.store(false, std::memory_order_relaxed);
    buffer_.consume(buffer_.size());
    resolver_ = tcp::resolver(net::make_strand(ioc_));
    using WsType = websocket::stream<beast::ssl_stream<beast::tcp_stream>>;
    ws_.~WsType();
    new (&ws_) WsType(net::make_strand(ioc_), sslCtx_);
    if (running_.load()) {
        Start();
    }
}

void WebSocketSession::Start() {
    // Start async resolve
    resolver_.async_resolve(
        host_,
        port_,
        beast::bind_front_handler(&WebSocketSession::OnResolve, shared_from_this())
    );
}

void WebSocketSession::Stop() {
    connected_.store(false);
    
    if (ws_.is_open()) {
        beast::error_code ec;
        ws_.close(websocket::close_code::normal, ec);
    }
}

void WebSocketSession::OnResolve(beast::error_code ec, tcp::resolver::results_type results) {
    if (ec) {
        return Fail(ec, "resolve");
    }
    
    // Connect
    beast::get_lowest_layer(ws_).async_connect(
        results,
        beast::bind_front_handler(&WebSocketSession::OnConnect, shared_from_this())
    );
}

void WebSocketSession::OnConnect(beast::error_code ec, tcp::resolver::results_type::endpoint_type ep) {
    if (ec) {
        return Fail(ec, "connect");
    }

    // Disable Nagle to minimize latency
    beast::get_lowest_layer(ws_).socket().set_option(tcp::no_delay(true));
    
    // Set SNI
    if (!SSL_set_tlsext_host_name(ws_.next_layer().native_handle(), host_.c_str())) {
        ec = beast::error_code(static_cast<int>(::ERR_get_error()), net::error::get_ssl_category());
        return Fail(ec, "SNI");
    }
    
    // SSL handshake
    ws_.next_layer().async_handshake(
        ssl::stream_base::client,
        beast::bind_front_handler(&WebSocketSession::OnSslHandshake, shared_from_this())
    );
}

void WebSocketSession::OnSslHandshake(beast::error_code ec) {
    if (ec) {
        return Fail(ec, "ssl_handshake");
    }
    
    // Turn off timeout for websocket - we handle keepalive ourselves
    beast::get_lowest_layer(ws_).expires_never();
    
    // Set websocket timeout and keepalive options
    websocket::stream_base::timeout opt{
        std::chrono::seconds(30),   // handshake timeout
        std::chrono::seconds(60),   // idle timeout (Binance pings every 3 min)
        true                         // enable automatic pings
    };
    ws_.set_option(opt);

    ws_.control_callback([self = shared_from_this()](websocket::frame_type kind, beast::string_view payload) {
        if (kind == websocket::frame_type::ping) {
            websocket::ping_data data;
            data.assign(payload.data(), payload.size());
            beast::error_code pongEc;
            self->ws_.pong(data, pongEc);
        }
    });
    
    // Set a decorator to change the User-Agent
    ws_.set_option(websocket::stream_base::decorator([](websocket::request_type& req) {
        req.set(beast::http::field::user_agent, "HFT-DataFeed/1.0");
    }));
    
    // WebSocket handshake
    ws_.async_handshake(
        host_,
        path_,
        beast::bind_front_handler(&WebSocketSession::OnHandshake, shared_from_this())
    );
}

void WebSocketSession::OnHandshake(beast::error_code ec) {
    if (ec) {
        return Fail(ec, "ws_handshake");
    }
    
    connected_.store(true);
    
    // Start reading
    DoRead();
}

void WebSocketSession::DoRead() {
    if (!running_.load()) return;
    
    // Clear buffer
    buffer_.consume(buffer_.size());
    
    // Read message
    ws_.async_read(
        buffer_,
        beast::bind_front_handler(&WebSocketSession::OnRead, shared_from_this())
    );
}

void WebSocketSession::OnRead(beast::error_code ec, std::size_t bytesTransferred) {
    if (ec) {
        connected_.store(false);
        if (ec != websocket::error::closed) {
            std::cerr << "[WS] read error: " << ec.message() << std::endl;
        }
        std::cerr << "[WS] Connection closed." << std::endl;
        if (running_.load()) Restart();
        return;
    }

    const char* data = static_cast<const char*>(buffer_.data().data());
    // Cheap timestamp for metrics (monotonic ms -> ns)
    int64_t recvNs = HighResTimer::UnixMs() * 1'000'000;

    RawMessage msg;
    if (!msg.Set(data, bytesTransferred, recvNs)) {
        droppedCounter_.fetch_add(1, std::memory_order_relaxed);
    } else if (!messageQueue_.TryPush(std::move(msg))) {
        droppedCounter_.fetch_add(1, std::memory_order_relaxed);
    } else {
        size_t sz = messageQueue_.Size();
        size_t cur = highWaterMark_.load(std::memory_order_relaxed);
        while (sz > cur && !highWaterMark_.compare_exchange_weak(cur, sz, std::memory_order_relaxed)) {}
    }

    DoRead();
}

void WebSocketSession::OnClose(beast::error_code ec) {
    connected_.store(false);
    if (ec) {
        std::cerr << "[WS] Close error: " << ec.message() << std::endl;
    }
    if (running_.load()) Restart();
}

void WebSocketSession::Fail(beast::error_code ec, const char* what) {
    connected_.store(false);
    std::cerr << "[WS] " << what << " error: " << ec.message() << std::endl;
    if (running_.load()) Restart();
}

// ═══════════════════════════════════════════════════════════════════════════════
// BinanceDataFeed Implementation
// ═══════════════════════════════════════════════════════════════════════════════

BinanceDataFeed::BinanceDataFeed(const DataFeedConfig& config)
    : config_(config)
{
    // Configure SSL
    sslCtx_.set_default_verify_paths();
    AddWindowsRootCerts(sslCtx_);
    sslCtx_.set_verify_mode(ssl::verify_peer);
    
    // Create work guard to keep io_context running
    workGuard_ = std::make_unique<WorkGuard>(net::make_work_guard(ioc_));

    // Create message queue
    messageQueue_ = CreateMessageQueue(config_.messageQueueSize);

    // Create depth delta queue for Tiger pipeline
    depthQueue_ = std::make_unique<LockFreeQueue<DepthDelta, 262144>>();
    
    // Create thread pool for parsing
    parserPool_ = std::make_unique<ThreadPool>(config_.numParserThreads, true);
    
    // Create order books for each symbol
    for (const auto& symbol : config_.symbols) {
        std::string upperSymbol = symbol;
        std::transform(upperSymbol.begin(), upperSymbol.end(), upperSymbol.begin(), ::toupper);
        orderBooks_[upperSymbol] = std::make_unique<OrderBook>(upperSymbol);
    }
}

BinanceDataFeed::~BinanceDataFeed() {
    Stop();
}

void BinanceDataFeed::Start() {
    if (running_.load()) return;
    
    running_.store(true);
    
    std::cout << "\n";
    std::cout << "╔════════════════════════════════════════════════════════════════╗\n";
    std::cout << "║         BINANCE HFT DATA FEED - STARTING                       ║\n";
    std::cout << "╠════════════════════════════════════════════════════════════════╣\n";
    std::cout << "║ Host: " << std::setw(55) << std::left << config_.host << "║\n";
    std::cout << "║ Symbols: ";
    for (const auto& s : config_.symbols) std::cout << s << " ";
    std::cout << std::setw(50) << " " << "║\n";
    std::cout << "║ Streams: ";
    if (config_.subscribeDepth) std::cout << "depth ";
    if (config_.subscribeBookTicker) std::cout << "bookTicker ";
    if (config_.subscribeAggTrade) std::cout << "aggTrade ";
    std::cout << std::setw(40) << " " << "║\n";
    std::cout << "║ Parser threads: " << std::setw(45) << config_.numParserThreads << "║\n";
    std::cout << "╚════════════════════════════════════════════════════════════════╝\n\n";
    
    // WebSocket first to start buffering deltas
    CreateSessions();
    for (auto& session : sessions_) {
        session->Start();
    }

    if (config_.enableUserStream) {
        const auto apiKey = ResolveApiKey();
        if (!apiKey.empty()) {
            userStream_ = std::make_unique<UserStreamClient>(
                apiKey,
                "fapi.binance.com",
                "fstream.binance.com",
                config_.port,
                config_.userStreamKeepAliveSeconds,
                [this](const std::string& payload) {
                    if (userStreamCallback_) {
                        userStreamCallback_(payload);
                    }
                }
            );
            userStream_->Start();
        }
    }

    int numIoThreads = std::max(2, static_cast<int>(sessions_.size()));
    for (int i = 0; i < numIoThreads; ++i) {
        ioThreads_.emplace_back([this, i] {
            IoThreadFunc();
        });
    }

    // Fetch REST snapshots while WS buffers messages
#ifdef _WIN32
    OutputDebugStringA("[Snapshot] Fetching initial order book snapshots...\n");
#endif
    std::cout << "[Snapshot] Fetching initial order book snapshots...\n";
    for (const auto& symbol : config_.symbols) {
        if (!FetchInitialSnapshot(symbol)) {
            std::cerr << "[ERROR] Failed to fetch snapshot for " << symbol << "\n";
#ifdef _WIN32
            std::string msg = "[ERROR] Failed to fetch snapshot for " + symbol + "\n";
            OutputDebugStringA(msg.c_str());
#endif
        }
    }

#ifdef _WIN32
    OutputDebugStringA("[Snapshot] All snapshots loaded. Starting processors...\n\n");
#endif
    std::cout << "[Snapshot] All snapshots loaded. Starting processors...\n\n";

    // Processor threads must be single consumer for SPSC queue
    processorThreads_.emplace_back([this] {
        ProcessorThreadFunc();
    });

    // OrderBook thread consuming depth deltas
    obThreadRunning_.store(true, std::memory_order_release);
    orderBookThread_ = std::thread([this] {
        while (obThreadRunning_.load(std::memory_order_relaxed)) {
            // Burst-drain to keep up with producer bursts
            for (int batch = 0; batch < 1024; ++batch) {
                auto delta = depthQueue_->TryPop();
                if (!delta) break;
                if (rawDeltaCallback_) {
                    rawDeltaCallback_(*delta);
                }
            }
#ifdef _MSC_VER
            _mm_pause();
#endif
        }
    });

    if (connectedCallback_) {
        connectedCallback_();
    }

    // Start clock sync thread
    timeSyncThread_ = std::thread([this] { SyncClockThread(); });
}

void BinanceDataFeed::Stop() {
    if (!running_.load()) return;
    
    running_.store(false);

    obThreadRunning_.store(false, std::memory_order_release);
    
    // Stop sessions
    for (auto& session : sessions_) {
        session->Stop();
    }

    if (userStream_) {
        userStream_->Stop();
        userStream_.reset();
    }
    
    // Release work guard to allow io_context to finish
    workGuard_.reset();
    
    // Stop I/O context
    ioc_.stop();
    
    // Join threads
    for (auto& t : ioThreads_) {
        if (t.joinable()) t.join();
    }

    for (auto& t : processorThreads_) {
        if (t.joinable()) t.join();
    }

    if (orderBookThread_.joinable()) orderBookThread_.join();

    if (timeSyncThread_.joinable()) timeSyncThread_.join();
    
    sessions_.clear();
    ioThreads_.clear();
    processorThreads_.clear();
    
    if (disconnectedCallback_) {
        disconnectedCallback_();
    }
    
    std::cout << "[DataFeed] Stopped\n";
}

std::string BinanceDataFeed::ResolveApiKey() const {
#ifdef _WIN32
    if (!config_.apiKey.empty()) return config_.apiKey;
    char buffer[512];
    DWORD size = GetEnvironmentVariableA("BINANCE_API_KEY", buffer, static_cast<DWORD>(sizeof(buffer)));
    if (size > 0 && size < sizeof(buffer)) {
        return std::string(buffer, buffer + size);
    }
#endif
    return config_.apiKey;
}

void BinanceDataFeed::SyncClockThread() {
    while (running_.load()) {
        int64_t t0 = HighResTimer::UnixMs();
        int64_t serverMs = FetchServerTimeMs();
        int64_t t1 = HighResTimer::UnixMs();
        if (serverMs > 0) {
            int64_t rtt = t1 - t0;
            int64_t midpoint = t0 + rtt / 2;
            int64_t offset = serverMs - midpoint;
            clockOffsetMs_.store(offset, std::memory_order_relaxed);
            lastTimeSyncRttMs_.store(rtt, std::memory_order_relaxed);
            timeSyncOk_.store(true, std::memory_order_relaxed);
        }
        else {
            timeSyncOk_.store(false, std::memory_order_relaxed);
#ifdef _WIN32
            OutputDebugStringA("[TimeSync] Failed to fetch server time\n");
#else
            std::cerr << "[TimeSync] Failed to fetch server time" << std::endl;
#endif
        }

        for (int i = 0; i < 30 && running_.load(); ++i) {
            std::this_thread::sleep_for(std::chrono::seconds(1));
        }
    }
}

void BinanceDataFeed::CreateSessions() {
    // Build combined stream path
    std::string path = BuildStreamPath();
    
    if (!path.empty()) {
        auto session = std::make_shared<WebSocketSession>(
            ioc_,
            sslCtx_,
            config_.host,
            config_.port,
            path,
            *messageQueue_,
            running_,
            droppedMessages_,
            queueHighWaterMark_
        );
        sessions_.push_back(session);
    }
}

std::string BinanceDataFeed::BuildStreamPath() {
    std::vector<std::string> streams;
    
    for (const auto& symbol : config_.symbols) {
        std::string lowerSymbol = symbol;
        std::transform(lowerSymbol.begin(), lowerSymbol.end(), lowerSymbol.begin(), ::tolower);
        
        if (config_.subscribeDepth) {
            streams.push_back(lowerSymbol + "@depth" + config_.depthSpeed);
        }
        
        if (config_.subscribeBookTicker) {
            streams.push_back(lowerSymbol + "@bookTicker");
        }
        
        if (config_.subscribeAggTrade) {
            streams.push_back(lowerSymbol + "@aggTrade");
        }
    }
    
    if (streams.empty()) return "";
    
    // For single stream: /ws/btcusdt@depth@100ms
    // For multiple streams: /stream?streams=btcusdt@depth@100ms/btcusdt@bookTicker
    
    if (streams.size() == 1) {
        return "/ws/" + streams[0];
    }
    
    std::string combined = "/stream?streams=";
    for (size_t i = 0; i < streams.size(); ++i) {
        if (i > 0) combined += "/";
        combined += streams[i];
    }
    
    return combined;
}

void BinanceDataFeed::ProcessorThreadFunc() {
    // BOOST PRIORITY
    TradingBot::Core::ThreadPriorityManager::SetCurrentThreadPriority(
        TradingBot::Core::ThreadPriority::TimeCritical
    );
    
    int idleSpins = 0;
    while (running_.load(std::memory_order_relaxed)) {
        auto msg = messageQueue_->TryPop();

        if (!msg) {
            // Aggressive spinning for low latency
            for (int spin = 0; spin < 100; ++spin) {
#ifdef _MSC_VER
                _mm_pause();
#endif
                msg = messageQueue_->TryPop();
                if (msg) break;
            }
            
            if (!msg) {
                if (++idleSpins >= 5000) {
                    idleSpins = 0;
                    std::this_thread::sleep_for(std::chrono::microseconds(100));
                    MaybeLogDiagnostics();
                }
                continue;
            }
        }
        idleSpins = 0;
        ProcessMessage(std::move(*msg));
        
        // Process additional messages in burst (batch processing)
        for (int batch = 0; batch < 16; ++batch) {
            auto nextMsg = messageQueue_->TryPop();
            if (!nextMsg) break;
            ProcessMessage(std::move(*nextMsg));
        }
        
        MaybeLogDiagnostics();
    }
}

void BinanceDataFeed::IoThreadFunc() {
    // BOOST PRIORITY
    TradingBot::Core::ThreadPriorityManager::SetCurrentThreadPriority(
        TradingBot::Core::ThreadPriority::TimeCritical
    );
    
    try {
        ioc_.run();
    } catch (const std::exception& e) {
        std::cerr << "[IO] Exception: " << e.what() << std::endl;
    }
}

void BinanceDataFeed::ProcessMessage(RawMessage&& msg) {
    messagesReceived_++;
    bytesReceived_ += msg.Size();

    if (config_.enableLatencyTracking) {
        latencyTracker_.RecordMessage(msg.Size());
    }

    auto& parser = ParserPool::GetParser();

    const char* jsonData = msg.Data();
    size_t jsonSize = msg.Size();

    auto msgType = parser.DetectMessageType(jsonData, jsonSize);

    // Buffer for unwrapped data (thread-local to avoid allocations)
    thread_local std::string unwrappedBuffer;

    if (msgType == SimdJsonParser::MessageType::CombinedStream) {
        CombinedStreamMessage wrapper;
        if (parser.UnwrapCombinedStream(jsonData, jsonSize, wrapper)) {
            unwrappedBuffer.clear();
            unwrappedBuffer.reserve(wrapper.data.size() + simdjson::SIMDJSON_PADDING);
            unwrappedBuffer.assign(wrapper.data.data(), wrapper.data.size());
            unwrappedBuffer.resize(wrapper.data.size() + simdjson::SIMDJSON_PADDING, '\0');

            jsonData = unwrappedBuffer.data();
            jsonSize = wrapper.data.size();

            msgType = parser.DetectMessageType(jsonData, jsonSize);
        }
    }

    const int64_t processStartNs = HighResTimer::NowNs();
    // Cache adjusted time once for this message
    const int64_t recvMsAdjusted = HighResTimer::UnixMs() + clockOffsetMs_.load(std::memory_order_relaxed);
    
    if (config_.enableLatencyTracking) {
        latencyTracker_.RecordEnqueueLatencyNs(processStartNs - msg.ReceiveTimestampNs());
    }

    switch (msgType) {
        case SimdJsonParser::MessageType::DepthUpdate: {
            static constexpr size_t kDepthReserve = 256;
            thread_local ParsedDepthUpdate update;

            update.isValid = false;
            if (update.bids.capacity() < kDepthReserve) update.bids.reserve(kDepthReserve);
            if (update.asks.capacity() < kDepthReserve) update.asks.reserve(kDepthReserve);
            update.bids.clear();
            update.asks.clear();

            if (parser.ParseDepthUpdate(jsonData, jsonSize, update)) {
                const int64_t afterParseNs = config_.enableLatencyTracking ? HighResTimer::NowNs() : 0;

                if (config_.enableLatencyTracking) {
                    latencyTracker_.RecordParseLatency(afterParseNs - processStartNs);
                    latencyTracker_.RecordExchangeLatency(update.eventTime, update.transactionTime);
                    int64_t netDeltaMs = recvMsAdjusted - update.transactionTime;
                    lastNetworkDeltaMs_.store(netDeltaMs, std::memory_order_relaxed);
                    latencyTracker_.RecordNetworkLatency(update.transactionTime, recvMsAdjusted);
                }
                
                // Raw network delta (always update for diagnostics)
                lastRawNetworkDeltaMs_.store(HighResTimer::UnixMs() - update.transactionTime, std::memory_order_relaxed);

                // VALIDATE SYNC FIRST - Only process if internal orderbook accepts it
                // Build DepthDelta and enqueue to SPSC ring for OrderBook thread
                DepthDelta delta{};
                delta.eventTime = update.eventTime;
                delta.transactionTime = update.transactionTime;
                delta.firstUpdateId = update.firstUpdateId;
                delta.lastUpdateId = update.lastUpdateId;
                std::memset(delta.symbol, 0, sizeof(delta.symbol));
                const std::string& sym = update.symbol;
                std::memcpy(delta.symbol, sym.data(), std::min<size_t>(sym.size(), sizeof(delta.symbol) - 1));

                const int bcnt = static_cast<int>(std::min<size_t>(update.bids.size(), MAX_DELTA_LEVELS));
                const int acnt = static_cast<int>(std::min<size_t>(update.asks.size(), MAX_DELTA_LEVELS));
                delta.bidCount = bcnt;
                delta.askCount = acnt;
                for (int i = 0; i < bcnt; ++i) {
                    delta.bids[i].price = update.bids[i].first;
                    delta.bids[i].qty = update.bids[i].second;
                }
                for (int i = 0; i < acnt; ++i) {
                    delta.asks[i].price = update.asks[i].first;
                    delta.asks[i].qty = update.asks[i].second;
                }

                if (!depthQueue_->TryPush(std::move(delta))) {
                    droppedMessages_.fetch_add(1, std::memory_order_relaxed);
                }

                if (depthCallback_) {
                    int64_t cbStart = HighResTimer::NowNs();
                    depthCallback_(update.symbol, update);
                    if (config_.enableLatencyTracking) {
                        latencyTracker_.RecordCallbackLatency(HighResTimer::NowNs() - cbStart);
                    }
                }

                if (config_.enableLatencyTracking) {
                    latencyTracker_.RecordProcessLatency(HighResTimer::NowNs() - afterParseNs);
                    latencyTracker_.RecordEndToEndNs(HighResTimer::NowNs() - msg.ReceiveTimestampNs());
                }
            }
            break;
        }

        case SimdJsonParser::MessageType::BookTicker: {
            ParsedBookTicker ticker;
            if (parser.ParseBookTicker(jsonData, jsonSize, ticker)) {
                int64_t parseTime = HighResTimer::NowNs() - processStartNs;

                int64_t recvMsRaw = HighResTimer::UnixMs();
                int64_t recvMs = recvMsAdjusted;
                int64_t netDeltaRaw = recvMsRaw - ticker.transactionTime;
                lastRawNetworkDeltaMs_.store(netDeltaRaw, std::memory_order_relaxed);

                if (config_.enableLatencyTracking) {
                    latencyTracker_.RecordParseLatency(parseTime);
                    latencyTracker_.RecordExchangeLatency(ticker.eventTime, ticker.transactionTime);
                    int64_t netDeltaMs = recvMs - ticker.transactionTime;
                    lastNetworkDeltaMs_.store(netDeltaMs, std::memory_order_relaxed);
                    latencyTracker_.RecordNetworkLatency(ticker.transactionTime, recvMs);
                }

                auto it = orderBooks_.find(ticker.symbol);
                if (it != orderBooks_.end()) {
                    it->second->UpdateBestBidAsk(
                        ticker.bestBidPrice,
                        ticker.bestBidQty,
                        ticker.bestAskPrice,
                        ticker.bestAskQty
                    );
                }

                if (bookTickerCallback_) {
                    int64_t cbStart = HighResTimer::NowNs();
                    bookTickerCallback_(ticker.symbol, ticker);
                    if (config_.enableLatencyTracking) {
                        latencyTracker_.RecordCallbackLatency(HighResTimer::NowNs() - cbStart);
                    }
                }

                if (config_.enableLatencyTracking) {
                    latencyTracker_.RecordEndToEndNs(HighResTimer::NowNs() - msg.ReceiveTimestampNs());
                }
            }
            break;
        }

        case SimdJsonParser::MessageType::AggTrade: {
            ParsedAggTrade trade;
            if (parser.ParseAggTrade(jsonData, jsonSize, trade)) {
                int64_t parseTime = HighResTimer::NowNs() - processStartNs;

                int64_t recvMsRaw = HighResTimer::UnixMs();
                int64_t recvMs = recvMsAdjusted;
                int64_t netDeltaRaw = recvMsRaw - trade.tradeTime;
                lastRawNetworkDeltaMs_.store(netDeltaRaw, std::memory_order_relaxed);

                if (config_.enableLatencyTracking) {
                    latencyTracker_.RecordParseLatency(parseTime);
                    latencyTracker_.RecordExchangeLatency(trade.eventTime, trade.tradeTime);
                    int64_t netDeltaMs = recvMs - trade.tradeTime;
                    lastNetworkDeltaMs_.store(netDeltaMs, std::memory_order_relaxed);
                    latencyTracker_.RecordNetworkLatency(trade.tradeTime, recvMs);
                }

                if (aggTradeCallback_) {
                    int64_t cbStart = HighResTimer::NowNs();
                    aggTradeCallback_(trade.symbol, trade);
                    if (config_.enableLatencyTracking) {
                        latencyTracker_.RecordCallbackLatency(HighResTimer::NowNs() - cbStart);
                    }
                }

                if (config_.enableLatencyTracking) {
                    latencyTracker_.RecordEndToEndNs(HighResTimer::NowNs() - msg.ReceiveTimestampNs());
                }
            }
            break;
        }

        default:
            break;
    }
}

void BinanceDataFeed::MaybeLogDiagnostics() {
    const int64_t nowMs = HighResTimer::NowMs();
    int64_t expected = lastDiagLogMs_.load(std::memory_order_relaxed);
    if (nowMs - expected < 1000) return;
    if (!lastDiagLogMs_.compare_exchange_strong(expected, nowMs, std::memory_order_relaxed)) {
        return;
    }

    size_t qSize = messageQueue_ ? messageQueue_->Size() : 0;
    size_t qCap = messageQueue_ ? messageQueue_->Capacity() : 0;
    int64_t dropped = droppedMessages_.load(std::memory_order_relaxed);
    size_t qHigh = queueHighWaterMark_.load(std::memory_order_relaxed);
    int64_t msgs = messagesReceived_.load(std::memory_order_relaxed);
    int64_t offset = clockOffsetMs_.load(std::memory_order_relaxed);
    int64_t syncRtt = lastTimeSyncRttMs_.load(std::memory_order_relaxed);
    int64_t netDelta = lastNetworkDeltaMs_.load(std::memory_order_relaxed);
    int64_t netDeltaRaw = lastRawNetworkDeltaMs_.load(std::memory_order_relaxed);
    bool syncOk = timeSyncOk_.load(std::memory_order_relaxed);

    // Get orderbook sync stats
    int64_t obDropped = 0, obOOS = 0, obApplied = 0;
    bool obSynced = false;
    for (const auto& [sym, ob] : orderBooks_) {
        obDropped += ob->GetDroppedUpdates();
        obOOS += ob->GetOutOfSyncCount();
        obApplied += ob->GetAppliedUpdates();
        obSynced = ob->IsSynced();  // Use last one for single-symbol case
    }

    std::stringstream ss;
    ss << "[FeedDiag] now=" << nowMs
       << " ms q=" << qSize << "/" << qCap
       << " qHigh=" << qHigh
       << " dropped=" << dropped
       << " msgs=" << msgs
       << " | offset=" << offset << "ms rtt=" << syncRtt << "ms netDelta=" << netDelta << "ms raw=" << netDeltaRaw << "ms"
       << " sync=" << (syncOk ? "ok" : "fail")
       << " | OB: " << (obSynced ? "SYNCED" : "WAITING") 
       << " applied=" << obApplied << " skip=" << obDropped << " oos=" << obOOS
       << " | " << latencyTracker_.GetSummaryString();

#ifdef _WIN32
    OutputDebugStringA(ss.str().c_str());
    OutputDebugStringA("\n");
#else
    std::cout << ss.str() << std::endl;
#endif
}

OrderBook& BinanceDataFeed::GetOrderBook(const std::string& symbol) {
    std::string upperSymbol = symbol;
    std::transform(upperSymbol.begin(), upperSymbol.end(), upperSymbol.begin(), ::toupper);
    
    std::shared_lock lock(orderBookMutex_);
    auto it = orderBooks_.find(upperSymbol);
    if (it == orderBooks_.end()) {
        throw std::runtime_error("Order book not found for symbol: " + symbol);
    }
    return *it->second;
}

const OrderBook& BinanceDataFeed::GetOrderBook(const std::string& symbol) const {
    std::string upperSymbol = symbol;
    std::transform(upperSymbol.begin(), upperSymbol.end(), upperSymbol.begin(), ::toupper);
    
    std::shared_lock lock(orderBookMutex_);
    auto it = orderBooks_.find(upperSymbol);
    if (it == orderBooks_.end()) {
        throw std::runtime_error("Order book not found for symbol: " + symbol);
    }
    return *it->second;
}

bool BinanceDataFeed::HasOrderBook(const std::string& symbol) const {
    std::string upperSymbol = symbol;
    std::transform(upperSymbol.begin(), upperSymbol.end(), upperSymbol.begin(), ::toupper);
    
    std::shared_lock lock(orderBookMutex_);
    return orderBooks_.find(upperSymbol) != orderBooks_.end();
}

void BinanceDataFeed::PrintStatistics() {
    std::cout << "\n";
    std::cout << "╔════════════════════════════════════════════════════════════════╗\n";
    std::cout << "║                   DATA FEED STATISTICS                         ║\n";
    std::cout << "╠════════════════════════════════════════════════════════════════╣\n";
    std::cout << "║ Messages received: " << std::setw(42) << messagesReceived_.load() << "║\n";
    std::cout << "║ Bytes received:    " << std::setw(42) << bytesReceived_.load() << "║\n";
    std::cout << "╠════════════════════════════════════════════════════════════════╣\n";
    
    // Print order book stats
    for (const auto& [symbol, ob] : orderBooks_) {
        std::cout << "║ " << std::setw(10) << symbol 
                  << " | Bids: " << std::setw(5) << ob->BidLevels()
                  << " | Asks: " << std::setw(5) << ob->AskLevels()
                  << " | Spread: " << std::fixed << std::setprecision(2) << std::setw(8) << ob->GetSpreadBps() << " bps"
                  << " ║\n";
    }
    
    std::cout << "╚════════════════════════════════════════════════════════════════╝\n";
    
    // Print latency report
    if (config_.enableLatencyTracking) {
        latencyTracker_.PrintReport();
    }
}

int64_t BinanceDataFeed::FetchServerTimeMs() {
    auto tryEndpoint = [&](const std::string& host, const std::string& port, const std::string& path) -> int64_t {
        try {
            net::io_context ioc;
            ssl::context ctx{ssl::context::tlsv12_client};
            ctx.set_default_verify_paths();
            AddWindowsRootCerts(ctx);
            ctx.set_verify_mode(ssl::verify_peer);

            tcp::resolver resolver(ioc);
            auto const results = resolver.resolve(host, port);

            beast::ssl_stream<beast::tcp_stream> stream(ioc, ctx);
            beast::error_code ec;

            stream.set_verify_mode(ssl::verify_peer);
            stream.set_verify_callback([host](bool preverified, ssl::verify_context& ctx) {
                return VerifyHostName(preverified, ctx, host);
            });

            beast::get_lowest_layer(stream).connect(results, ec);
            if (ec) {
#ifdef _WIN32
                OutputDebugStringA((std::string("[TimeSync] connect error (" + host + "): ") + ec.message() + "\n").c_str());
#endif
                return -1;
            }

            if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str())) {
#ifdef _WIN32
                OutputDebugStringA((std::string("[TimeSync] SNI set failed (") + host + ")\n").c_str());
#endif
                return -1;
            }

            stream.handshake(ssl::stream_base::client, ec);
            if (ec) {
#ifdef _WIN32
                OutputDebugStringA((std::string("[TimeSync] handshake error (") + host + "): " + ec.message() + "\n").c_str());
#endif
                return -1;
            }

            namespace http = beast::http;
            http::request<http::string_body> req{http::verb::get, path, 11};
            req.set(http::field::host, host);
            req.set(http::field::user_agent, "TradingBot/1.0");

            http::write(stream, req, ec);
            if (ec) {
#ifdef _WIN32
                OutputDebugStringA((std::string("[TimeSync] write error (") + host + "): " + ec.message() + "\n").c_str());
#endif
                return -1;
            }

            beast::flat_buffer buffer;
            http::response<http::string_body> res;
            http::read(stream, buffer, res, ec);
            if (ec) {
#ifdef _WIN32
                OutputDebugStringA((std::string("[TimeSync] read error (") + host + "): " + ec.message() + "\n").c_str());
#endif
                return -1;
            }

            beast::get_lowest_layer(stream).socket().shutdown(tcp::socket::shutdown_both, ec);

            auto body = res.body();
            auto pos = body.find("serverTime");
            if (pos != std::string::npos) {
                pos = body.find(":", pos);
                if (pos != std::string::npos) {
                    size_t endNum = body.find_first_not_of("0123456789", pos + 1);
                    std::string num = body.substr(pos + 1, endNum == std::string::npos ? endNum : endNum - (pos + 1));
                    return std::stoll(num);
                }
            }
#ifdef _WIN32
            OutputDebugStringA((std::string("[TimeSync] serverTime missing (") + host + ") status=" + std::to_string(res.result_int()) + " body=\"" + body.substr(0, 256) + "\"\n").c_str());
#else
            std::cerr << "[TimeSync] serverTime missing (" << host << ") status=" << res.result_int() << " body=\"" << body.substr(0, 256) << "\"" << std::endl;
#endif
        } catch (const std::exception& e) {
#ifdef _WIN32
            OutputDebugStringA((std::string("[TimeSync] exception: ") + e.what() + "\n").c_str());
#endif
        } catch (...) {
#ifdef _WIN32
            OutputDebugStringA("[TimeSync] unknown exception\n");
#endif
        }
        return -1;
    };

    std::vector<std::tuple<std::string, std::string, std::string>> endpoints;
    endpoints.emplace_back("fapi.binance.com", "443", "/fapi/v1/time");
    endpoints.emplace_back("api.binance.com", "443", "/api/v3/time");

    for (const auto& ep : endpoints) {
        int64_t t = tryEndpoint(std::get<0>(ep), std::get<1>(ep), std::get<2>(ep));
        if (t > 0) return t;
    }
    return -1;
}

bool BinanceDataFeed::FetchInitialSnapshot(const std::string& symbol) {
    std::string upperSymbol = symbol;
    std::transform(upperSymbol.begin(), upperSymbol.end(), upperSymbol.begin(), ::toupper);
    
#ifdef _WIN32
    std::string dbgMsg = "[Snapshot] Fetching " + upperSymbol + "...\n";
    OutputDebugStringA(dbgMsg.c_str());
#endif
    
    // REST API: https://fapi.binance.com/fapi/v1/depth?symbol=BTCUSDT&limit=1000
    std::string url = "https://fapi.binance.com/fapi/v1/depth?symbol=" + upperSymbol + "&limit=1000";
    
    // Fetch HTTP using WinHTTP
    std::string response = SimpleHttpClient::HttpGet(url);
    if (response.empty()) {
        std::cerr << "[Snapshot] HTTP GET failed for " << upperSymbol << "\n";
#ifdef _WIN32
        std::string errMsg = "[Snapshot] HTTP GET failed for " + upperSymbol + "\n";
        OutputDebugStringA(errMsg.c_str());
#endif
        return false;
    }
    
#ifdef _WIN32
    std::string okMsg = "[Snapshot] Got " + std::to_string(response.size()) + " bytes for " + upperSymbol + "\n";
    OutputDebugStringA(okMsg.c_str());
    
    // DEBUG: Show first 500 chars of response
    std::string preview = response.substr(0, std::min<size_t>(500, response.size()));
    OutputDebugStringA(("[Snapshot] JSON preview: " + preview + "\n").c_str());
#endif
    
    // Parse JSON snapshot - Add simdjson padding
    size_t originalSize = response.size();
    response.resize(response.size() + simdjson::SIMDJSON_PADDING, '\0');
    
    try {
        simdjson::ondemand::parser parser;
        // IMPORTANT: use originalSize for json_len, full buffer size for capacity
        auto doc = parser.iterate(response.data(), originalSize, response.size());
        
        // Get lastUpdateId
        int64_t lastUpdateId = 0;
        auto idResult = doc["lastUpdateId"].get_int64();
        if (!idResult.error()) {
            lastUpdateId = idResult.value();
        }
#ifdef _WIN32
        else {
            OutputDebugStringA(("[Snapshot] Failed to get lastUpdateId: " + std::to_string(static_cast<int>(idResult.error())) + "\n").c_str());
        }
#endif
        
        // Parse bids
        std::vector<std::pair<double, double>> bids;
        auto bidsResult = doc["bids"];
        if (bidsResult.error()) {
#ifdef _WIN32
            OutputDebugStringA(("[Snapshot] Failed to get bids array: " + std::to_string(static_cast<int>(bidsResult.error())) + "\n").c_str());
#endif
        } else {
            auto bidsArray = bidsResult.value();
            for (auto bid : bidsArray) {
                auto arr = bid.get_array();
                std::string_view priceStr, qtyStr;
                
                size_t idx = 0;
                for (auto val : arr) {
                    if (idx == 0) {
                        auto ps = val.get_string();
                        if (!ps.error()) priceStr = ps.value();
                    } else if (idx == 1) {
                        auto qs = val.get_string();
                        if (!qs.error()) qtyStr = qs.value();
                        break;
                    }
                    idx++;
                }
                
                double price = FastStringToDouble(priceStr);
                double qty = FastStringToDouble(qtyStr);
                
                if (price > 0.0 && qty > 0.0) {
                    bids.emplace_back(price, qty);
                }
            }
        }
        
        // Parse asks
        std::vector<std::pair<double, double>> asks;
        auto asksResult = doc["asks"];
        if (asksResult.error()) {
#ifdef _WIN32
            OutputDebugStringA(("[Snapshot] Failed to get asks array: " + std::to_string(static_cast<int>(asksResult.error())) + "\n").c_str());
#endif
        } else {
            auto asksArray = asksResult.value();
            for (auto ask : asksArray) {
                auto arr = ask.get_array();
                std::string_view priceStr, qtyStr;
                
                size_t idx = 0;
                for (auto val : arr) {
                    if (idx == 0) {
                        auto ps = val.get_string();
                        if (!ps.error()) priceStr = ps.value();
                    } else if (idx == 1) {
                        auto qs = val.get_string();
                        if (!qs.error()) qtyStr = qs.value();
                        break;
                    }
                    idx++;
                }
                
                double price = FastStringToDouble(priceStr);
                double qty = FastStringToDouble(qtyStr);
                
                if (price > 0.0 && qty > 0.0) {
                    asks.emplace_back(price, qty);
                }
            }
        }
        
        // Apply snapshot to legacy OrderBook (for diagnostics)
        auto it = orderBooks_.find(upperSymbol);
        if (it != orderBooks_.end()) {
            it->second->ApplySnapshot(lastUpdateId, bids, asks);
        }

        // Convert to RAW depth levels
        std::vector<DepthLevel> rawBids;
        std::vector<DepthLevel> rawAsks;
        rawBids.reserve(bids.size());
        rawAsks.reserve(asks.size());
        for (const auto& [p, q] : bids) rawBids.push_back({p, q});
        for (const auto& [p, q] : asks) rawAsks.push_back({p, q});

        std::cout << "[Snapshot] " << upperSymbol << " initialized with " 
                  << bids.size() << " bids, " 
                  << asks.size() << " asks, lastUpdateId=" << lastUpdateId << "\n";
                  
#ifdef _WIN32
        std::ostringstream oss;
        oss << "[Snapshot] " << upperSymbol << " initialized with " 
            << bids.size() << " bids, " 
            << asks.size() << " asks, lastUpdateId=" << lastUpdateId << "\n";
        OutputDebugStringA(oss.str().c_str());
#endif
        
        // Propagate snapshot to SharedState via callbacks
        if (snapshotCallback_) {
            snapshotCallback_(upperSymbol, bids, asks);
        }
        if (rawSnapshotCallback_) {
            rawSnapshotCallback_(upperSymbol, lastUpdateId, rawBids, rawAsks);
        }
        
        return true;
        
    } catch (const std::exception& e) {
        std::cerr << "[Snapshot] Parse error: " << e.what() << "\n";
#ifdef _WIN32
        std::string errMsg = "[Snapshot] Parse error: " + std::string(e.what()) + "\n";
        OutputDebugStringA(errMsg.c_str());
#endif
        return false;
    }
}

} // namespace hft
