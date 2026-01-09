#include "HighSpeedDataFeed.h"
#include <iostream>
#include <sstream>
#include <iomanip>
#include <algorithm>
#ifdef _MSC_VER
#include <immintrin.h>
#endif

namespace hft {

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
        return;
    }

    const char* data = static_cast<const char*>(buffer_.data().data());
    int64_t recvNs = HighResTimer::NowNs();

    RawMessage msg(data, bytesTransferred, recvNs);

    if (!messageQueue_.TryPush(std::move(msg))) {
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
}

void WebSocketSession::Fail(beast::error_code ec, const char* what) {
    connected_.store(false);
    std::cerr << "[WS] " << what << " error: " << ec.message() << std::endl;
}

// ═══════════════════════════════════════════════════════════════════════════════
// BinanceDataFeed Implementation
// ═══════════════════════════════════════════════════════════════════════════════

BinanceDataFeed::BinanceDataFeed(const DataFeedConfig& config)
    : config_(config)
{
    // Configure SSL
    sslCtx_.set_default_verify_paths();
    sslCtx_.set_verify_mode(ssl::verify_none);
    
    // Create work guard to keep io_context running
    workGuard_ = std::make_unique<WorkGuard>(net::make_work_guard(ioc_));

    // Create message queue
    messageQueue_ = CreateMessageQueue(config_.messageQueueSize);
    
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
    
    CreateSessions();
    
    int numProcessors = config_.numParserThreads;
    for (int i = 0; i < numProcessors; ++i) {
        processorThreads_.emplace_back([this, i] {
            ProcessorThreadFunc();
        });
    }
    
    for (auto& session : sessions_) {
        session->Start();
    }
    
    int numIoThreads = std::max(2, static_cast<int>(sessions_.size()));
    for (int i = 0; i < numIoThreads; ++i) {
        ioThreads_.emplace_back([this, i] {
            IoThreadFunc();
        });
    }
    
    if (connectedCallback_) {
        connectedCallback_();
    }

    // Start clock sync thread
    timeSyncThread_ = std::thread([this] { SyncClockThread(); });
}

void BinanceDataFeed::Stop() {
    if (!running_.load()) return;
    
    running_.store(false);
    
    // Stop sessions
    for (auto& session : sessions_) {
        session->Stop();
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

    if (timeSyncThread_.joinable()) timeSyncThread_.join();
    
    sessions_.clear();
    ioThreads_.clear();
    processorThreads_.clear();
    
    if (disconnectedCallback_) {
        disconnectedCallback_();
    }
    
    std::cout << "[DataFeed] Stopped\n";
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

void BinanceDataFeed::IoThreadFunc() {
    try {
        ioc_.run();
    } catch (const std::exception& e) {
        std::cerr << "[IO] Exception: " << e.what() << std::endl;
    }
}

void BinanceDataFeed::ProcessorThreadFunc() {
    int idleSpins = 0;
    while (running_.load()) {
        auto msg = messageQueue_->TryPop();

        if (!msg) {
#ifdef _MSC_VER
            _mm_pause();
#endif
            if (++idleSpins >= 1000) {
                idleSpins = 0;
                std::this_thread::sleep_for(std::chrono::milliseconds(1));
            }
            continue;
        }
        idleSpins = 0;
        ProcessMessage(std::move(*msg));
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
    int64_t recvMsAdjusted = HighResTimer::UnixMs() + clockOffsetMs_.load(std::memory_order_relaxed);
    int64_t rttHalf = lastTimeSyncRttMs_.load(std::memory_order_relaxed) / 2;
    if (rttHalf > 0 && rttHalf < 5000) {
        recvMsAdjusted -= rttHalf; // remove half RTT to approximate one-way
    }
    if (config_.enableLatencyTracking) {
        latencyTracker_.RecordEnqueueLatencyNs(processStartNs - msg.ReceiveTimestampNs());
    }

    switch (msgType) {
        case SimdJsonParser::MessageType::DepthUpdate: {
            ParsedDepthUpdate update;
            if (parser.ParseDepthUpdate(jsonData, jsonSize, update)) {
                int64_t parseTime = HighResTimer::NowNs() - processStartNs;

                if (config_.enableLatencyTracking) {
                    latencyTracker_.RecordParseLatency(parseTime);
                    latencyTracker_.RecordExchangeLatency(update.eventTime, update.transactionTime);
                    int64_t recvMs = recvMsAdjusted;
                    latencyTracker_.RecordNetworkLatency(update.transactionTime, recvMs);
                }

                int64_t processApplyStart = HighResTimer::NowNs();

                auto it = orderBooks_.find(update.symbol);
                if (it != orderBooks_.end()) {
                    it->second->ApplyDepthUpdate(
                        update.eventTime,
                        update.transactionTime,
                        update.firstUpdateId,
                        update.lastUpdateId,
                        update.bids,
                        update.asks
                    );
                }

                if (config_.enableLatencyTracking) {
                    latencyTracker_.RecordProcessLatency(HighResTimer::NowNs() - processApplyStart);
                }

                if (depthCallback_) {
                    int64_t cbStart = HighResTimer::NowNs();
                    depthCallback_(update.symbol, update);
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

        case SimdJsonParser::MessageType::BookTicker: {
            ParsedBookTicker ticker;
            if (parser.ParseBookTicker(jsonData, jsonSize, ticker)) {
                int64_t parseTime = HighResTimer::NowNs() - processStartNs;

                if (config_.enableLatencyTracking) {
                    latencyTracker_.RecordParseLatency(parseTime);
                    latencyTracker_.RecordExchangeLatency(ticker.eventTime, ticker.transactionTime);
                    int64_t recvMs = recvMsAdjusted;
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

                if (config_.enableLatencyTracking) {
                    latencyTracker_.RecordParseLatency(parseTime);
                    latencyTracker_.RecordExchangeLatency(trade.eventTime, trade.tradeTime);
                    int64_t recvMs = recvMsAdjusted;
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
    try {
        net::io_context ioc;
        ssl::context ctx{ssl::context::tlsv12_client};
        ctx.set_default_verify_paths();
        ctx.set_verify_mode(ssl::verify_none);

        tcp::resolver resolver(ioc);
        auto const results = resolver.resolve(config_.host, config_.port);

        beast::ssl_stream<beast::tcp_stream> stream(ioc, ctx);
        beast::get_lowest_layer(stream).connect(results);
        stream.handshake(ssl::stream_base::client);

        namespace http = beast::http;
        std::string path = (config_.host.find("fstream") != std::string::npos) ? "/fapi/v1/time" : "/api/v3/time";
        http::request<http::string_body> req{http::verb::get, path, 11};
        req.set(http::field::host, config_.host);
        req.set(http::field::user_agent, "TradingBot/1.0");

        auto start = HighResTimer::NowMs();
        http::write(stream, req);
        beast::flat_buffer buffer;
        http::response<http::string_body> res;
        http::read(stream, buffer, res);
        auto end = HighResTimer::NowMs();

        beast::error_code ec;
        stream.shutdown(ec);

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
    } catch (...) {
    }
    return -1;
}

} // namespace hft