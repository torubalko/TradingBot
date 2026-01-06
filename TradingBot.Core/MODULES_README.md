# HFT Bot Modular Architecture V3.0 - Module Documentation

This document describes the implementation of all modules for the High-Frequency Trading (HFT) bot according to the V3.0 specification.

## Module Overview

All modules have been implemented and are ready for use. The modular architecture provides clean separation of concerns and high-performance components optimized for low-latency trading.

## Implemented Modules

### 1. LocalOrderBook (`OrderBook/LocalOrderBook.h`)
**Purpose:** Manages local order book state with efficient data structures.

**Key Features:**
- Uses `std::map<double, double>` for bids and asks (price -> quantity)
- Thread-safe with mutex protection
- Methods:
  - `ApplyDiff()` - Apply incremental updates to the order book
  - `SetSnapshot()` - Set complete order book snapshot
  - `FindDensities()` - Identify price levels with high volume (liquidity walls)
  - `GetBestBid()` / `GetBestAsk()` - Get top of book prices

**Usage Example:**
```cpp
LocalOrderBook orderBook;
std::vector<OrderBookLevel> bids = {{50000.0, 1.5}, {49999.0, 2.0}};
std::vector<OrderBookLevel> asks = {{50001.0, 1.2}, {50002.0, 1.8}};
orderBook.SetSnapshot(bids, asks);
auto densities = orderBook.FindDensities(100.0); // Find levels with volume > 100
```

### 2. DensityDetector (`Strategy/DensityDetector.h`)
**Purpose:** Detects liquidity walls and order book imbalances.

**Key Features:**
- Configurable volume threshold
- Identifies "walls" (large orders) on both bid and ask sides
- Calculates distance from mid-price
- Computes bid/ask imbalance ratio

**Usage Example:**
```cpp
DensityDetector detector(100.0, 5); // threshold = 100, max 5 walls
auto walls = detector.DetectWalls(orderBook);
double imbalance = detector.CalculateImbalance(walls);
// Positive imbalance = more bid pressure, negative = more ask pressure
```

### 3. TakerFlowAnalyzer (`Strategy/TakerFlowAnalyzer.h`)
**Purpose:** Analyzes aggressive taker flow from trade data.

**Key Features:**
- Tracks buyer vs seller initiated trades
- Configurable time window (default 60 seconds)
- Calculates aggression ratio: (buyVolume - sellVolume) / totalVolume
- Returns comprehensive flow metrics including trade counts and values

**Usage Example:**
```cpp
TakerFlowAnalyzer analyzer(60000, 1000); // 60s window, max 1000 trades
analyzer.AddTrade(trade);
auto metrics = analyzer.CalculateFlow();
std::cout << "Aggression: " << metrics.aggression << std::endl;
// Positive aggression = buyers aggressive, negative = sellers aggressive
```

### 4. ObjectPool<T> (`Memory/ObjectPool.h`)
**Purpose:** Reusable memory pool to reduce allocations.

**Key Features:**
- Template-based generic object pool
- Thread-safe with mutex protection
- Automatic object recycling via custom deleter
- Configurable initial and maximum pool size
- Supports objects with `reset()` method for cleanup

**Usage Example:**
```cpp
ObjectPool<Message> pool(10, 100); // initial 10, max 100
auto msg = pool.acquire(); // Returns unique_ptr with custom deleter
msg->data = "Hello";
// Object automatically returns to pool when unique_ptr goes out of scope
```

### 5. SPSCQueue (`LockFree/SPSCQueue.h`)
**Purpose:** Lock-free single-producer single-consumer queue.

**Key Features:**
- Wraps `boost::lockfree::spsc_queue`
- Zero-copy operations where possible
- Fixed capacity template version
- Dynamic capacity version via heap allocation
- Returns `std::optional<T>` for clean error handling

**Usage Example:**
```cpp
SPSCQueue<Trade, 1024> queue;
queue.push(trade); // Producer thread
auto trade = queue.pop(); // Consumer thread
if (trade) {
    // Process trade
}
```

### 6. FastParser (`Parsing/FastParser.h`)
**Purpose:** High-performance zero-copy JSON parsing.

**Key Features:**
- Uses `std::from_chars` for numeric parsing (C++17 zero-copy)
- `std::string_view` based for zero-copy string extraction
- No allocations for number parsing
- Helper methods for extracting JSON values
- Optimized for Binance API response format

**Usage Example:**
```cpp
std::string json = R"({"p":"50000.5","q":"1.5"})";
auto priceStr = FastParser::ExtractQuotedString(json, "\"p\"");
auto price = FastParser::ParseDouble(priceStr);
if (price) {
    std::cout << "Price: " << *price << std::endl;
}
```

### 7. WebSocketSession (`Network/WebSocketSession.h`)
**Purpose:** Encapsulates a single WebSocket connection.

**Key Features:**
- SSL/TLS support via Boost.Beast
- Automatic reconnection on disconnect
- Callback-based message handling
- Thread-safe connection management
- Graceful shutdown

**Usage Example:**
```cpp
WebSocketSession session;
session.Connect(
    "stream.binance.com",
    "/ws/btcusdt@depth",
    [](const std::string& msg) {
        // Handle message
    },
    [](const std::string& error) {
        // Handle error
    }
);
```

### 8. DataFeedManager (`Network/DataFeedManager.h`)
**Purpose:** Manages multiple market data feeds (Spot/Futures).

**Key Features:**
- Manages multiple WebSocket connections
- Automatic stream path construction
- Support for both Spot and Futures markets
- Depth updates and aggregate trade subscriptions
- Configurable update speeds (100ms, 1000ms)
- Helper methods for REST API endpoints

**Usage Example:**
```cpp
DataFeedManager feedManager;
FeedConfig config;
config.symbol = "BTCUSDT";
config.mode = MarketMode::FUTURES;
config.subscribeDepth = true;
config.subscribeAggTrades = true;
config.depthUpdateSpeed = "100ms";

feedManager.Subscribe(
    config,
    [](const std::string& msg, MarketMode mode) {
        // Handle market data
    }
);
```

## Architecture Benefits

1. **Modularity:** Each component has a single, well-defined responsibility
2. **Performance:** Lock-free data structures and zero-copy parsing where possible
3. **Reusability:** Generic templates (ObjectPool, SPSCQueue) can be used across the application
4. **Thread Safety:** All modules properly handle concurrent access
5. **Low Latency:** Optimized for high-frequency trading scenarios

## Integration with Existing Code

The new modules can be integrated with the existing `BinanceConnection` and `SharedState` classes:

```cpp
// Example integration
LocalOrderBook localBook;
DensityDetector detector(100.0);
TakerFlowAnalyzer flowAnalyzer(60000);
DataFeedManager feedManager;

FeedConfig config;
config.symbol = "BTCUSDT";
config.mode = MarketMode::FUTURES;
config.subscribeDepth = true;
config.subscribeAggTrades = true;

feedManager.Subscribe(config, [&](const std::string& msg, MarketMode mode) {
    // Parse message
    if (msg.find("depthUpdate") != std::string::npos) {
        auto update = JsonParser::ParseDepthUpdate(msg);
        localBook.ApplyDiff(update.bids, update.asks);
        
        // Detect walls
        auto walls = detector.DetectWalls(localBook);
    }
    else if (msg.find("aggTrade") != std::string::npos) {
        auto trade = JsonParser::ParseAggTrade(msg);
        flowAnalyzer.AddTrade(trade);
        
        // Get flow metrics
        auto metrics = flowAnalyzer.CalculateFlow();
    }
});
```

## Dependencies

- **Boost** (1.84.0+): For lockfree queues and Beast WebSocket
- **C++20**: For concepts, std::from_chars, and modern features
- **nlohmann/json**: For complex JSON parsing (existing dependency)

## Building

All modules are header-only except where they integrate with existing `.cpp` files. They are automatically included when building the `TradingBot.Core` project.

## Testing

See `ModuleExamples.h` for detailed usage examples of each module. These examples demonstrate:
- Basic usage patterns
- Common scenarios
- Integration patterns
- Error handling

## Performance Considerations

1. **LocalOrderBook:** O(log n) for updates due to std::map
2. **DensityDetector:** O(n) where n is number of price levels
3. **TakerFlowAnalyzer:** O(1) for adding trades, O(n) for calculating metrics
4. **ObjectPool:** O(1) for acquire/release operations
5. **SPSCQueue:** O(1) wait-free for both producer and consumer
6. **FastParser:** O(n) where n is length of input, but zero-copy for numbers
7. **WebSocketSession:** Async I/O with minimal overhead
8. **DataFeedManager:** O(1) for connection management

## Future Enhancements

Possible improvements for future versions:
- Add support for custom allocators in ObjectPool
- Implement multi-producer multi-consumer queue variant
- Add SIMD optimizations to FastParser
- Support for compression in WebSocket connections
- Metrics and monitoring hooks
- Circuit breaker patterns for connection management
