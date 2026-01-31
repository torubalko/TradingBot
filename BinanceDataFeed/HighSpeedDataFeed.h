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
#include "DepthDelta.h"
#include "UserStream.h"

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
    // Binance FUTURES WebSocket streams:
    // - @depth@100ms - Diff depth every 100ms (fastest for full book)
    // - @bookTicker  - Real-time best bid/ask (FASTEST for prices!)
    // - @aggTrade    - Aggregated trades
    bool subscribeDepth = true;
    bool subscribeBookTicker = true;     // CRITICAL: Real-time best prices!
    bool subscribeAggTrade = false;
    
    // Depth stream speed for Binance FUTURES:
    // "@100ms" - fastest available (100ms batches)
    // "@250ms" - medium
    // "@500ms" - slowest
    // NOTE: Futures does NOT support real-time @depth like Spot!
    std::string depthSpeed = "@100ms";
    
    // Performance settings
    int numParserThreads = 2;
    bool enableLatencyTracking = true;
    bool enableDetailedLogging = false;
    
    // Reconnection
    int reconnectDelayMs = 1000;
    int maxReconnectAttempts = 10;
    
    // Buffer sizes
    size_t readBufferSize = 64 * 1024;    // 64KB
    size_t messageQueueSize = 65536;      // Larger queue for bursts

    // User stream (private account events)
    bool enableUserStream = true;
    std::string apiKey;
    int userStreamKeepAliveSeconds = 25 * 60;
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

// Snapshot callback: (symbol, bids[price,qty], asks[price,qty])
using SnapshotCallback = std::function<void(const std::string& symbol, 
    const std::vector<std::pair<double, double>>& bids, 
    const std::vector<std::pair<double, double>>& asks)>;

// Raw snapshot / delta callbacks for Tiger RAW path
using RawSnapshotCallback = std::function<void(const std::string& symbol, int64_t lastUpdateId,
    const std::vector<DepthLevel>& bids, const std::vector<DepthLevel>& asks)>;
using RawDeltaCallback = std::function<void(const DepthDelta&)>;
using UserStreamCallback = std::function<void(const std::string& payload)>;

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
    void SetSnapshotCallback(SnapshotCallback cb) { snapshotCallback_ = std::move(cb); }
    void SetRawSnapshotCallback(RawSnapshotCallback cb) { rawSnapshotCallback_ = std::move(cb); }
    void SetRawDeltaCallback(RawDeltaCallback cb) { rawDeltaCallback_ = std::move(cb); }
    void SetUserStreamCallback(UserStreamCallback cb) { userStreamCallback_ = std::move(cb); }
    
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
    bool FetchInitialSnapshot(const std::string& symbol);

private:
    void CreateSessions();
    void IoThreadFunc();
    void ProcessorThreadFunc();
    void ProcessMessage(RawMessage&& msg);
    void SyncClockThread();
    int64_t FetchServerTimeMs();
    void MaybeLogDiagnostics();
    
    std::string BuildStreamPath();

    std::string ResolveApiKey() const;
    
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
    SnapshotCallback snapshotCallback_;
    
    // Latency tracking
    LatencyTracker latencyTracker_;
    std::atomic<int64_t> clockOffsetMs_{0};
    std::atomic<int64_t> lastTimeSyncRttMs_{0};
    std::thread timeSyncThread_;
    std::atomic<int64_t> lastDiagLogMs_{0};
    std::atomic<int64_t> lastNetworkDeltaMs_{0};
    std::atomic<int64_t> lastRawNetworkDeltaMs_{0};
    std::atomic<bool> timeSyncOk_{false};

    // Tiger pipeline: WS -> SPSC ring -> OrderBook thread
    std::unique_ptr<LockFreeQueue<DepthDelta, 262144>> depthQueue_;
    std::thread orderBookThread_;
    std::atomic<bool> obThreadRunning_{false};
    RawSnapshotCallback rawSnapshotCallback_;
    RawDeltaCallback rawDeltaCallback_;
    UserStreamCallback userStreamCallback_;
    std::unique_ptr<UserStreamClient> userStream_;
};

inline std::string upper_symbol(const std::string& s) {
    std::string out = s;
    std::transform(out.begin(), out.end(), out.begin(), ::toupper);
    return out;
}

} // namespace hft
