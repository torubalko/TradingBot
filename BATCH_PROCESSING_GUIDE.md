# Tiger Architecture - Batch Processing Integration Guide

## Overview
This document describes how to integrate the new batch processing system into your existing HFT application.

## Architecture Components

### 1. Batch Processing Infrastructure (SharedState.h)
- **BatchUpdate**: Accumulator for order book updates
- **BatchMetrics**: Performance tracking
- **Flush Triggers**:
  - Message count: 10 messages
  - Time-based: 5ms
  - Priority: Best price change

### 2. Sorted Merge Optimization (OrderBook.h)
- Replaced O(n log n) binary search with O(n) sorted merge
- Pre-sorted batch updates merged efficiently
- Zero reallocation for most updates

### 3. Thread Priority Management (ThreadPriority.h)
- Windows THREAD_PRIORITY_TIME_CRITICAL for network/parser threads
- RAII guards for temporary priority boosts
- CPU affinity pinning support

## Integration Steps

### Step 1: Update Callback to Use Batch Mode

**Before (Per-Message)**:
```cpp
void OnDepthUpdate(const std::string& symbol, const ParsedDepthUpdate& update) {
    std::vector<OrderBookLevel> bids, asks;
    
    for (const auto& [price, qty] : update.bids) {
        bids.push_back({price, qty});
    }
    for (const auto& [price, qty] : update.asks) {
        asks.push_back({price, qty});
    }
    
    sharedState->ApplyUpdate(bids, asks);  // OLD: One lock per message
}
```

**After (Batch Mode)**:
```cpp
void OnDepthUpdate(const std::string& symbol, const ParsedDepthUpdate& update) {
    std::vector<OrderBookLevel> bids, asks;
    
    for (const auto& [price, qty] : update.bids) {
        bids.push_back({price, qty});
    }
    for (const auto& [price, qty] : update.asks) {
        asks.push_back({price, qty});
    }
    
    sharedState->BatchUpdate(bids, asks);  // ← ИСПОЛЬЗУЙТЕ ЭТО!
}
```

### Step 2: Boost Thread Priority for Parser Threads

**In HighSpeedDataFeed::ProcessorThreadFunc()**:
```cpp
void BinanceDataFeed::ProcessorThreadFunc() {
    // Boost priority for ultra-low latency
    ThreadPriorityManager::SetCurrentThreadPriority(ThreadPriority::TimeCritical);
    
    int idleSpins = 0;
    while (running_.load()) {
        auto msg = messageQueue_->TryPop();
        // ... processing logic ...
    }
}
```

**For Network I/O threads**:
```cpp
void BinanceDataFeed::IoThreadFunc() {
    // Boost priority for network thread
    ThreadPriorityManager::SetCurrentThreadPriority(ThreadPriority::TimeCritical);
    
    try {
        ioc_.run();
    } catch (const std::exception& e) {
        std::cerr << "[IO] Exception: " << e.what() << std::endl;
    }
}
```

### Step 3: Monitor Batch Metrics

```cpp
// In your main loop or metrics reporting
void PrintBatchMetrics() {
    TradingBot::Core::BatchMetrics metrics;
    sharedState->GetBatchMetrics(metrics);
    
    std::cout << "Batch Metrics:\n";
    std::cout << "  Total Batches: " << metrics.totalBatches.load() << "\n";
    std::cout << "  Message Flush: " << metrics.messageFlushCount.load() << "\n";
    std::cout << "  Time Flush: " << metrics.timeFlushCount.load() << "\n";
    std::cout << "  Price Flush: " << metrics.priceFlushCount.load() << "\n";
    std::cout << "  Avg Batch Size: " << metrics.avgBatchSize.load() << "\n";
    std::cout << "  Max Batch Size: " << metrics.maxBatchSize.load() << "\n";
    std::cout << "  Batch Latency: " << metrics.batchLatencyNs.load() / 1000 << " µs\n";
}
```

### Step 4: Force Flush on Critical Events

```cpp
// Force flush before critical operations
sharedState->ForceFlushBatch();

// Now safe to read consistent state
auto snapshot = sharedState->GetSnapshotForRender(100, 0.0);
```

## Performance Benefits

### Lock Contention Reduction
- **Before**: 1 lock per message (100-1000 locks/sec)
- **After**: 1 lock per 10 messages (~10-100 locks/sec)
- **Improvement**: 80-90% reduction in lock contention

### Best Price Latency
- Priority flush ensures best price changes propagate immediately
- UI never shows stale top-of-book
- Critical for HFT decision making

### Batch Processing Efficiency
- Sorted merge: O(n) vs O(n log n)
- Single memory allocation for merged result
- Cache-friendly sequential access

## Tuning Parameters

### Batch Size (SharedState.h)
```cpp
static constexpr int kBatchMessageThreshold = 10;  // Adjust 5-20
```

### Batch Time Window (SharedState.h)
```cpp
static constexpr int64_t kBatchTimeThresholdNs = 5'000'000;  // 5ms, adjust 1-10ms
```

### Thread Priority
```cpp
// For less aggressive priority:
ThreadPriorityManager::SetCurrentThreadPriority(ThreadPriority::High);

// For maximum performance:
ThreadPriorityManager::SetCurrentThreadPriority(ThreadPriority::TimeCritical);
```

## Expected Latency Improvements

### Before Batch Processing
- Enqueue Latency: 10-50µs (variable due to contention)
- Lock Wait Time: 5-30µs per message
- Update Frequency: Limited by lock contention

### After Batch Processing
- Enqueue Latency: 1-5µs (lock-free accumulation)
- Lock Wait Time: Amortized to <1µs per message
- Update Frequency: 10x improvement in high-volatility conditions

## Monitoring Flush Reasons

Track which flush trigger fires most often to optimize thresholds:

```cpp
TradingBot::Core::BatchMetrics metrics;
sharedState->GetBatchMetrics(metrics);

double totalFlushes = metrics.totalBatches.load();

if (totalFlushes > 0) {
    double msgFlushPct = 100.0 * metrics.messageFlushCount.load() / totalFlushes;
    double timeFlushPct = 100.0 * metrics.timeFlushCount.load() / totalFlushes;
    double priceFlushPct = 100.0 * metrics.priceFlushCount.load() / totalFlushes;
    
    std::cout << "Flush Distribution:\n";
    std::cout << "  Message Count: " << msgFlushPct << "%\n";
    std::cout << "  Time Elapsed: " << timeFlushPct << "%\n";
    std::cout << "  Price Change: " << priceFlushPct << "%\n";
}
```

### Interpretation
- **High Message Flush %**: Market very active, consider increasing batch size
- **High Time Flush %**: Market quiet, batch timeout working well
- **High Price Flush %**: Optimal - best price changes trigger immediate updates

## Thread Affinity for Ultra-Low Latency

Pin critical threads to dedicated cores:

```cpp
// Pin parser thread to core 0
ThreadPriorityManager::SetThreadAffinity(parserThread, 0);

// Pin network thread to core 1
ThreadPriorityManager::SetThreadAffinity(networkThread, 1);

// Pin UI thread to core 2
ThreadPriorityManager::SetThreadAffinity(uiThread, 2);
```

## RCU (Read-Copy-Update) Pattern

Already implemented via atomic double buffering:

```cpp
// Writer (Network thread) - NO LOCK on read path!
auto backBuffer = (currentActive == renderStateA_) ? renderStateB_ : renderStateA_;
// ... update backBuffer ...
activeSnapshot_.store(backBuffer, std::memory_order_release);

// Reader (UI thread) - ZERO WAIT!
auto snapshot = activeSnapshot_.load(std::memory_order_acquire);
// ... use snapshot without any locks ...
```

## Compatibility Note

The batch system is **backward compatible**:
- Old `ApplyUpdate()` still works
- New `BatchUpdate()` is opt-in
- Mix both in same application during migration

## Troubleshooting

### Problem: UI not updating
**Solution**: Check if ForceFlushBatch() is called periodically or reduce kBatchTimeThresholdNs

### Problem: High batch latency
**Solution**: Reduce batch size or check if OrderBook has too many levels

### Problem: Missed price changes
**Solution**: Priority flush should catch this, verify best price detection logic

## Next Steps

1. Update your depth callback to use `BatchUpdate()`
2. Add thread priority boost to parser/network threads
3. Monitor batch metrics
4. Tune batch size and time threshold for your workload
5. Consider CPU affinity for ultimate performance

## Benchmark Results (Expected)

| Metric | Before | After | Improvement |
|--------|--------|-------|-------------|
| Lock Contention | High | Low | 80% reduction |
| Enqueue Latency | 10-50µs | 1-5µs | 5-10x faster |
| UI Drops | Frequent | Rare | 95% reduction |
| Throughput | 1K msg/s | 10K+ msg/s | 10x increase |
| Best Price Latency | 10-20ms | <5ms | 2-4x faster |

---

**Tiger Architecture Philosophy**: 
- Zero-copy where possible
- Lock-free reads everywhere
- Batch writes for efficiency
- Priority for critical events
- Hardware-aware thread management
