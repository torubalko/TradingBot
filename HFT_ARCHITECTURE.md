# HFT Bot Architecture - V3.0 Implementation Documentation

## Overview
This document describes the implementation of the C++ HFT (High-Frequency Trading) bot for Binance Spot and Futures markets with the "Bounce from Density" scalping strategy.

## Architecture Components

### 1. Connection Layer

#### BinanceConnection (`BinanceConnection.h/cpp`)
- **Dual WebSocket connections**: Separate threads for Spot and Futures
- **Subscriptions**: `@depth@100ms` and `@aggTrade` streams
- **Enhanced reconnect logic**: Exponential backoff with configurable parameters
- **Connection state tracking**: DISCONNECTED, CONNECTING, CONNECTED, RECONNECTING, FAILED
- **Heartbeat monitoring**: Detects stale connections with timeout detection

#### ConnectionMonitor (`ConnectionMonitor.h`)
- **Health monitoring**: Tracks last activity timestamp
- **Timeout detection**: Configurable timeout for dead connection detection
- **Heartbeat tracking**: Ensures connection liveness
- **Message counting**: Statistics for monitoring throughput

#### ReconnectStrategy (`ConnectionMonitor.h`)
- **Exponential backoff**: 1s initial delay, up to 60s max delay
- **Configurable multiplier**: Default 2.0x backoff
- **Attempt tracking**: Records connection attempts and failures
- **Auto-reset**: Resets on successful connection

### 2. Order Book Management

#### LocalOrderBook (`LocalOrderBook.h`)
- **Efficient data structure**: Uses `std::map` with appropriate comparators
- **Snapshot application**: Full order book initialization from REST API
- **Incremental updates**: WebSocket depth update processing
- **Density detection**: Finds liquidity walls (bid/ask walls)
- **Pre-allocation**: Reserves capacity for performance

**Key Methods:**
```cpp
void ApplySnapshot(const OrderBookSnapshot& snapshot);
void ApplyUpdate(const OrderBookUpdate& update);
std::vector<DensityLevel> FindBidWalls(double minVolume, int minLevels, double priceRange);
std::vector<DensityLevel> FindAskWalls(double minVolume, int minLevels, double priceRange);
double GetBestBid() const;
double GetBestAsk() const;
double GetMidPrice() const;
```

### 3. Strategy Components

#### TakerFlowAnalyzer (`TakerFlowAnalyzer.h`)
- **Trade aggregation**: Processes `aggTrade` stream data
- **Time window**: Configurable time-based and count-based windows
- **Flow statistics**: Buy/sell volume, pressure, and directionality
- **VWAP calculation**: Volume-weighted average price
- **Pressure detection**: Identifies strong buy/sell pressure

**Key Methods:**
```cpp
void ProcessTrade(const Trade& trade);
FlowStats GetFlowStats() const;
bool HasStrongBuyPressure(double threshold) const;
bool HasStrongSellPressure(double threshold) const;
double GetVWAP() const;
```

#### DensityDetector (`DensityDetector.h`)
- **Signal generation**: "Bounce from density" strategy
- **Wall detection**: Identifies support/resistance from order book
- **Flow integration**: Combines flow analysis with density levels
- **Confidence scoring**: 0-1 confidence based on wall strength and flow
- **Configurable parameters**: Thresholds for volume, distance, confidence

**Signal Types:**
- `BUY_AT_SUPPORT`: Buy signal when price approaches bid wall with sell pressure
- `SELL_AT_RESISTANCE`: Sell signal when price approaches ask wall with buy pressure

**Configuration:**
```cpp
struct DensityConfig {
    double minWallVolume = 100.0;      // Minimum volume for wall detection
    int minLevels = 3;                  // Minimum price levels
    double priceRange = 0.005;          // 0.5% aggregation range
    double flowThreshold = 0.65;        // Flow pressure threshold
    double distanceToWall = 0.002;      // 0.2% max distance
    double minConfidence = 0.5;         // Minimum signal confidence
};
```

### 4. Performance Optimization

#### ObjectPool (`ObjectPool.h`)
- **Object reuse**: Pool for `OrderBookUpdate` objects
- **Thread-safe**: Mutex-protected acquire/release
- **Configurable size**: Initial and maximum pool size
- **Allocation tracking**: Monitors pool efficiency

**Usage:**
```cpp
auto pool = std::make_unique<ObjectPool<OrderBookUpdate>>(100);
auto update = pool->Acquire();
// Use update...
pool->Release(std::move(update));
```

#### FastParser (`FastParser.h`)
- **Zero-copy parsing**: Uses `std::from_chars` for numeric types
- **No allocations**: String_view based parsing
- **Fast conversions**: Direct memory parsing without intermediate strings

**Methods:**
```cpp
std::optional<double> ParseDouble(std::string_view str);
std::optional<long long> ParseInt64(std::string_view str);
bool ParseBool(std::string_view str);
std::string_view ExtractString(std::string_view str);
```

### 5. Current Parsing Implementation

**Note**: The current implementation uses `nlohmann::json` for JSON parsing. For optimal HFT performance, the following improvements are recommended:

#### Recommended: simdjson Integration
To achieve true zero-copy parsing:
1. Add simdjson dependency to `packages.config`
2. Replace `JsonParser` implementation to use simdjson's DOM or On-Demand API
3. Use `FastParser::ParseDouble()` for string-to-number conversion
4. Eliminate string allocations in hot path

Example simdjson integration:
```cpp
#include <simdjson.h>
using namespace simdjson;

Models::OrderBookUpdate ParseDepthUpdate(const std::string& data) {
    ondemand::parser parser;
    auto doc = parser.iterate(data);
    
    Models::OrderBookUpdate update;
    
    for (auto bid : doc["data"]["b"]) {
        auto price_view = bid.at(0).get_string();
        auto qty_view = bid.at(1).get_string();
        
        update.bids.push_back({
            FastParser::ParseDouble(price_view).value_or(0),
            FastParser::ParseDouble(qty_view).value_or(0)
        });
    }
    
    return update;
}
```

### 6. Lock-Free Queue (Future Enhancement)

**Recommended**: For production HFT, integrate `boost::lockfree::spsc_queue`:

```cpp
#include <boost/lockfree/spsc_queue.hpp>

// In WebSocket thread (producer)
boost::lockfree::spsc_queue<OrderBookUpdate*, 
    boost::lockfree::capacity<1024>> updateQueue;

// Producer
auto update = updatePool.Acquire();
// Fill update...
updateQueue.push(update.release());

// Consumer (strategy thread)
OrderBookUpdate* update = nullptr;
while (updateQueue.pop(update)) {
    orderBook.ApplyUpdate(*update);
    updatePool.Release(std::unique_ptr<OrderBookUpdate>(update));
}
```

## Integration Example

See `HFTExample.h` for complete integration example showing:
- Order book management
- Trade flow analysis
- Signal generation
- Density detection
- Object pool usage

## Performance Considerations

### Current State
✅ Dual WebSocket connections (Spot + Futures)
✅ Subscriptions to `@depth` and `@aggTrade`
✅ Pre-allocation of buffers and containers
✅ Object Pool implementation
✅ Fast numeric parsing with `std::from_chars`
✅ Enhanced reconnect logic with exponential backoff
✅ Connection state tracking and monitoring

### Recommended Improvements
⚠️ Replace `nlohmann::json` with `simdjson` for zero-copy parsing
⚠️ Integrate `boost::lockfree::spsc_queue` for lock-free message passing
⚠️ Profile hot paths to eliminate remaining heap allocations
⚠️ Use memory-mapped I/O for logging to avoid I/O blocking
⚠️ Consider CPU pinning for critical threads

### Hot Path Optimization Checklist
- [ ] Replace JSON parser with simdjson
- [ ] Add lock-free queue between WebSocket and strategy threads
- [ ] Pre-allocate all WebSocket buffers (currently: 8KB buffer)
- [ ] Eliminate string copies in message processing
- [ ] Use string_view throughout parsing pipeline
- [ ] Profile with `-O3 -march=native` optimizations
- [ ] Measure latency: WebSocket receive → Signal generation

## Testing Strategy

### Unit Tests (Recommended)
1. **LocalOrderBook**: Snapshot/update application, density detection
2. **TakerFlowAnalyzer**: Trade processing, flow statistics, VWAP
3. **DensityDetector**: Signal generation with various configurations
4. **ObjectPool**: Thread-safety, allocation tracking
5. **FastParser**: Numeric parsing accuracy and edge cases

### Integration Tests
1. **End-to-end flow**: WebSocket → Parser → OrderBook → Strategy → Signal
2. **Reconnection**: Simulate network failures, validate state recovery
3. **Performance**: Measure latency under high message throughput
4. **Memory**: Profile for heap allocations in hot path

### Performance Benchmarks
- **Parsing**: JSON parse time for depth update (target: <10μs)
- **Order book update**: Apply depth update (target: <5μs)
- **Signal generation**: Complete strategy cycle (target: <50μs)
- **End-to-end latency**: WebSocket receive to signal (target: <100μs)

## Deployment Notes

### Configuration
- Adjust `DensityConfig` parameters based on market conditions
- Monitor connection statistics via `ConnectionMonitor`
- Tune object pool size based on message rate
- Configure reconnect backoff based on network stability

### Monitoring
- Track connection state transitions
- Monitor message processing rate
- Alert on excessive reconnection attempts
- Profile memory usage and allocation rate

## Future Enhancements

1. **Multi-market support**: Parallel processing of multiple symbols
2. **Risk management**: Position limits, stop-loss integration
3. **Backtesting framework**: Historical data replay
4. **Order execution**: Smart order routing and execution
5. **Machine learning**: Pattern recognition for density prediction
6. **Hardware acceleration**: FPGA/GPU for parsing and calculation

## References
- Binance WebSocket API: https://binance-docs.github.io/apidocs/spot/en/#websocket-market-streams
- Binance Futures WebSocket: https://binance-docs.github.io/apidocs/futures/en/#websocket-market-streams
- simdjson: https://github.com/simdjson/simdjson
- Boost.Lockfree: https://www.boost.org/doc/libs/release/doc/html/lockfree.html
