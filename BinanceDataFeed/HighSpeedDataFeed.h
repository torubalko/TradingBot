#pragma once

#include <string>
#include <memory>
#include <atomic>
#include <functional>
#include <thread>
#include <vector>
#include <unordered_map>
#include <algorithm>

#include <boost/asio.hpp>
#include <boost/asio/ssl.hpp>
#include <boost/beast.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/websocket.hpp>
#include <boost/beast/websocket/ssl.hpp>
#include <boost/beast/http.hpp>

#include "OrderBook.h"
#include "SimdJsonParser.h"
#include "ThreadPool.h"
#include "LockFreeQueue.h"
#include "LatencyTracker.h"

namespace beast = boost::beast;
namespace websocket = beast::websocket;
namespace net = boost::asio;
namespace ssl = boost::asio::ssl;
using tcp = boost::asio::ip::tcp;

namespace hft {

// ═══════════════════════════════════════════════════════════════════════════════
// BINANCE HFT DATA FEED - PROFESSIONAL GRADE
// ═══════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════════════════════════════════════════════════════
// Configuration
// ═══════════════════════════════════════════════════════════════════════════════
struct DataFeedConfig {
    // Connection settings
    std::string host = "fstream.binance.com";
    std::string port = "443";
    
    // Symbols to subscribe
    std::vector<std::string> symbols = {"btcusdt"};
    
    // Streams to subscribe (per symbol)
    bool subscribeDepth = true;           // @depth@100ms - Full order book diff
    bool subscribeBookTicker = true;      // @bookTicker - Best bid/ask (fastest)
    bool subscribeAggTrade = false;       // @aggTrade - Aggregated trades
    
    // Depth stream settings
    std::string depthSpeed = "@100ms";    // @100ms or @500ms
    
    // Performance settings
    int numParserThreads = static_cast<int>(std::max(4u, std::thread::hardware_concurrency()));             // Threads for JSON parsing
    bool enableLatencyTracking = true;
    bool enableDetailedLogging = false;
    
    // Reconnection
    int reconnectDelayMs = 1000;
    int maxReconnectAttempts = 10;
    
    // Buffer sizes
    size_t readBufferSize = 64 * 1024;    // 64KB
    size_t messageQueueSize = 32768;
};

// ═══════════════════════════════════════════════════════════════════════════════
// Callbacks
// ═══════════════════════════════════════════════════════════════════════════════
using DepthUpdateCallback = std::function<void(const std::string& symbol, const ParsedDepthUpdate&)>;
using BookTickerCallback = std::function<void(const std::string& symbol, const ParsedBookTicker&)>;
using AggTradeCallback = std::function<void(const std::string& symbol, const ParsedAggTrade&)>;
using ErrorCallback = std::function<void(const std::string& error)>;
using ConnectedCallback = std::function<void()>;
using DisconnectedCallback = std::function<void()>;

// ═══════════════════════════════════════════════════════════════════════════════
// WebSocket Session (one per stream)
// ═══════════════════════════════════════════════════════════════════════════════
class WebSocketSession : public std::enable_shared_from_this<WebSocketSession> {
public:
    WebSocketSession(
        net::io_context& ioc,
        ssl::context& sslCtx,
        const std::string& host,
        const std::string& port,
        const std::string& path,
        IMessageQueue& messageQueue,
        std::atomic<bool>& running,
        std::atomic<int64_t>& droppedCounter,
        std::atomic<size_t>& highWaterMark
    );

    void Start();
    void Stop();
    bool IsConnected() const { return connected_.load(); }

private:
    void Restart();
private:
    void OnResolve(beast::error_code ec, tcp::resolver::results_type results);
    void OnConnect(beast::error_code ec, tcp::resolver::results_type::endpoint_type ep);
    void OnSslHandshake(beast::error_code ec);
    void OnHandshake(beast::error_code ec);
    void DoRead();
    void OnRead(beast::error_code ec, std::size_t bytesTransferred);
    void OnClose(beast::error_code ec);
    void Fail(beast::error_code ec, const char* what);

    net::io_context& ioc_;
    ssl::context& sslCtx_;
    tcp::resolver resolver_;
    websocket::stream<beast::ssl_stream<beast::tcp_stream>> ws_;
    beast::flat_buffer buffer_;

    std::string host_;
    std::string port_;
    std::string path_;

    IMessageQueue& messageQueue_;
    std::atomic<bool>& running_;
    std::atomic<bool> connected_{false};
    std::atomic<int64_t>& droppedCounter_;
    std::atomic<size_t>& highWaterMark_;
};

// ═══════════════════════════════════════════════════════════════════════════════
// Main Data Feed Class
// ═══════════════════════════════════════════════════════════════════════════════
class BinanceDataFeed {
public:
    explicit BinanceDataFeed(const DataFeedConfig& config = DataFeedConfig{});
    ~BinanceDataFeed();
    
    // Lifecycle
    void Start();
    void Stop();
    bool IsRunning() const { return running_.load(); }
    
    // Callbacks
    void SetDepthUpdateCallback(DepthUpdateCallback cb) { depthCallback_ = std::move(cb); }
    void SetBookTickerCallback(BookTickerCallback cb) { bookTickerCallback_ = std::move(cb); }
    void SetAggTradeCallback(AggTradeCallback cb) { aggTradeCallback_ = std::move(cb); }
    void SetErrorCallback(ErrorCallback cb) { errorCallback_ = std::move(cb); }
    void SetConnectedCallback(ConnectedCallback cb) { connectedCallback_ = std::move(cb); }
    void SetDisconnectedCallback(DisconnectedCallback cb) { disconnectedCallback_ = std::move(cb); }
    
    // Order Book Access
    OrderBook& GetOrderBook(const std::string& symbol);
    const OrderBook& GetOrderBook(const std::string& symbol) const;
    bool HasOrderBook(const std::string& symbol) const;
    
    // Statistics
    LatencyTracker& GetLatencyTracker() { return latencyTracker_; }
    const LatencyTracker& GetLatencyTracker() const { return latencyTracker_; }
    
    int64_t GetMessagesReceived() const { return messagesReceived_.load(); }
    int64_t GetBytesReceived() const { return bytesReceived_.load(); }
    int64_t GetDroppedMessages() const { return droppedMessages_.load(); }
    size_t GetQueueHighWaterMark() const { return queueHighWaterMark_.load(); }

    void PrintStatistics();

private:
    void CreateSessions();
    void IoThreadFunc();
    void ProcessorThreadFunc();
    void ProcessMessage(RawMessage&& msg);
    void SyncClockThread();
    int64_t FetchServerTimeMs();
    void MaybeLogDiagnostics();
    
    std::string BuildStreamPath();
    
    DataFeedConfig config_;
    
    // Network - IMPORTANT: work_guard keeps io_context running
    net::io_context ioc_;
    using WorkGuard = net::executor_work_guard<net::io_context::executor_type>;
    std::unique_ptr<WorkGuard> workGuard_;
    
    ssl::context sslCtx_{ssl::context::tlsv12_client};
    std::vector<std::shared_ptr<WebSocketSession>> sessions_;
    
    // Threading
    std::vector<std::thread> ioThreads_;
    std::vector<std::thread> processorThreads_;
    std::unique_ptr<ThreadPool> parserPool_;
    
    // Message queue
    std::unique_ptr<IMessageQueue> messageQueue_;
    
    // Order books
    std::unordered_map<std::string, std::unique_ptr<OrderBook>> orderBooks_;
    mutable std::shared_mutex orderBookMutex_;
    
    // State
    std::atomic<bool> running_{false};
    std::atomic<int64_t> messagesReceived_{0};
    std::atomic<int64_t> bytesReceived_{0};
    std::atomic<int64_t> droppedMessages_{0};
    std::atomic<size_t> queueHighWaterMark_{0};

    // Callbacks
    DepthUpdateCallback depthCallback_;
    BookTickerCallback bookTickerCallback_;
    AggTradeCallback aggTradeCallback_;
    ErrorCallback errorCallback_;
    ConnectedCallback connectedCallback_;
    DisconnectedCallback disconnectedCallback_;
    
    // Latency tracking
    LatencyTracker latencyTracker_;
    std::atomic<int64_t> clockOffsetMs_{0};
    std::atomic<int64_t> lastTimeSyncRttMs_{0};
    std::thread timeSyncThread_;
    std::atomic<int64_t> lastDiagLogMs_{0};
    std::atomic<int64_t> lastNetworkDeltaMs_{0};
    std::atomic<int64_t> lastRawNetworkDeltaMs_{0};
    std::atomic<bool> timeSyncOk_{false};
};

inline std::string upper_symbol(const std::string& s) {
    std::string out = s;
    std::transform(out.begin(), out.end(), out.begin(), ::toupper);
    return out;
}

} // namespace hft} // namespace hft