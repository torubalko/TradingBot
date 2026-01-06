# Integration Guide: HFT Components into TradingBot

This guide shows how to integrate the new HFT components into the existing TradingBot application.

## Step 1: Update SharedState to use LocalOrderBook

### Current: SharedState.h
```cpp
// Current implementation uses std::map directly
std::map<double, double> Bids;
std::map<double, double> Asks;
```

### Recommended: Add LocalOrderBook instance
```cpp
#include "LocalOrderBook.h"

class SharedState {
private:
    Models::LocalOrderBook orderBook_;  // Add this
    std::map<double, double> Bids;      // Keep for rendering
    std::map<double, double> Asks;      // Keep for rendering
    
public:
    // Add method to get order book for strategy
    const Models::LocalOrderBook& GetOrderBook() const {
        return orderBook_;
    }
    
    void SetSnapshot(const Models::OrderBookSnapshot& snap) {
        std::lock_guard<std::mutex> lock(mutex_);
        orderBook_.ApplySnapshot(snap);  // Use LocalOrderBook
        
        // Update rendering maps
        Bids.clear();
        Asks.clear();
        for (const auto& level : snap.bids) 
            Bids[level.price] = level.quantity;
        for (const auto& level : snap.asks) 
            Asks[level.price] = level.quantity;
    }
};
```

## Step 2: Add TakerFlowAnalyzer to SharedState

```cpp
#include "TakerFlowAnalyzer.h"

class SharedState {
private:
    Strategy::TakerFlowAnalyzer flowAnalyzer_;  // Add this
    
public:
    SharedState() 
        : flowAnalyzer_(100, 10000)  // 100 trades, 10s window
    {
        // ...
    }
    
    void AddTrade(const Trade& trade) {
        std::lock_guard<std::mutex> lock(mutex_);
        trades_.push_back(trade);
        if (trades_.size() > 150) trades_.pop_front();
        
        flowAnalyzer_.ProcessTrade(trade);  // Add this
    }
    
    Strategy::FlowStats GetFlowStats() const {
        std::lock_guard<std::mutex> lock(mutex_);
        return flowAnalyzer_.GetFlowStats();
    }
};
```

## Step 3: Create Strategy Thread in Runner

### Update TradingBot.Runner.cpp

```cpp
#include "DensityDetector.h"

// Global strategy state
Strategy::DensityDetector g_DensityDetector;
std::atomic<bool> g_StrategyRunning(false);
std::thread g_StrategyThread;

// Strategy thread function
void StrategyThreadFunc() {
    using namespace std::chrono;
    
    while (g_StrategyRunning) {
        try {
            // Get current order book and flow
            const auto& orderBook = g_SharedState->GetOrderBook();
            auto flowStats = g_SharedState->GetFlowStats();
            
            // Generate signal
            long long timestamp = duration_cast<milliseconds>(
                system_clock::now().time_since_epoch()).count();
            
            auto signal = g_DensityDetector.DetectSignal(
                orderBook, 
                g_SharedState->GetFlowAnalyzer(),
                timestamp
            );
            
            // Handle signal
            if (signal.IsValid()) {
                std::cout << "SIGNAL: " 
                         << (signal.type == Strategy::SignalType::BUY_AT_SUPPORT 
                             ? "BUY" : "SELL")
                         << " @ " << signal.entryPrice
                         << " (confidence: " << signal.confidence << ")"
                         << std::endl;
                
                // TODO: Place order via Binance REST API
                // PlaceOrder(signal);
            }
            
            // Run at 10 Hz
            std::this_thread::sleep_for(milliseconds(100));
        }
        catch (const std::exception& e) {
            std::cerr << "Strategy error: " << e.what() << std::endl;
            std::this_thread::sleep_for(seconds(1));
        }
    }
}

// In WinMain, start strategy thread
int APIENTRY WinMain(...) {
    // ... existing code ...
    
    // Configure density detector
    Strategy::DensityConfig config;
    config.minWallVolume = 50.0;      // 50 BTC
    config.minLevels = 5;
    config.priceRange = 0.005;        // 0.5%
    config.flowThreshold = 0.65;      // 65% pressure
    config.distanceToWall = 0.002;    // 0.2% distance
    config.minConfidence = 0.6;       // 60% confidence
    g_DensityDetector.SetConfig(config);
    
    // Start threads
    std::thread networkThread(NetworkThreadFunc);
    
    g_StrategyRunning = true;
    g_StrategyThread = std::thread(StrategyThreadFunc);
    
    // ... rendering loop ...
    
    // Cleanup
    g_Running = false;
    g_StrategyRunning = false;
    if (networkThread.joinable()) networkThread.join();
    if (g_StrategyThread.joinable()) g_StrategyThread.join();
    
    return 0;
}
```

## Step 4: Add Visual Indicators to UI

### Display Strategy State in Graphics

```cpp
// In WinMain rendering loop, after drawing order book

// Draw flow statistics
auto flowStats = g_SharedState->GetFlowStats();
std::wstringstream flowText;
flowText << L"Buy Pressure: " << std::fixed << std::setprecision(1) 
         << (flowStats.GetBuyPressure() * 100.0) << L"%"
         << L"  |  VWAP: " << std::setprecision(2) 
         << flowAnalyzer.GetVWAP();

g_Graphics->DrawRectPixels(0, 40, screenW, 30, 0.15f, 0.15f, 0.15f, 1.0f);
g_Graphics->DrawTextPixels(flowText.str(), 10, 45, 600, 25, 14, 1, 1, 1, 1);

// Highlight density walls
const auto& orderBook = g_SharedState->GetOrderBook();
auto bidWalls = orderBook.FindBidWalls(50.0, 5, 0.005);
auto askWalls = orderBook.FindAskWalls(50.0, 5, 0.005);

// Draw wall indicators
for (const auto& wall : bidWalls) {
    float y = centerY - (float)((wall.price - g_SmoothCenterPrice) / currentStep * rowH);
    // Draw special marker for walls
    g_Graphics->DrawRectPixels(280, y - 2, 10, 4, 1.0f, 1.0f, 0.0f, 1.0f);
}
for (const auto& wall : askWalls) {
    float y = centerY - (float)((wall.price - g_SmoothCenterPrice) / currentStep * rowH);
    g_Graphics->DrawRectPixels(280, y - 2, 10, 4, 1.0f, 1.0f, 0.0f, 1.0f);
}
```

## Step 5: Add Dual Market Support

### Create Separate Connections for Spot and Futures

```cpp
// In NetworkThreadFunc
std::shared_ptr<SharedState> g_SpotState;
std::shared_ptr<SharedState> g_FuturesState;

void NetworkThreadFunc() {
    g_SpotState = std::make_shared<SharedState>();
    g_SpotState->currentMode = MarketMode::SPOT;
    
    g_FuturesState = std::make_shared<SharedState>();
    g_FuturesState->currentMode = MarketMode::FUTURES;
    
    while (g_Running) {
        try {
            // Spot connection
            auto spotConn = std::make_shared<BinanceConnection>(g_SpotState);
            spotConn->Connect(g_TargetSymbol, MarketMode::SPOT);
            
            // Futures connection
            auto futuresConn = std::make_shared<BinanceConnection>(g_FuturesState);
            futuresConn->Connect(g_TargetSymbol, MarketMode::FUTURES);
            
            // Wait for connections
            while (g_Running && 
                   spotConn->GetState() == ConnectionState::CONNECTED &&
                   futuresConn->GetState() == ConnectionState::CONNECTED) {
                std::this_thread::sleep_for(std::chrono::seconds(1));
            }
        }
        catch (...) {
            std::this_thread::sleep_for(std::chrono::seconds(5));
        }
    }
}
```

## Step 6: Performance Optimization

### Add ObjectPool for Updates

```cpp
#include "ObjectPool.h"

// Global object pool
Utils::ObjectPool<Models::OrderBookUpdate> g_UpdatePool(100);

// In JsonParser, use pool
Models::OrderBookUpdate JsonParser::ParseDepthUpdate(const std::string& data) {
    // Parse into pooled object
    // Note: Current implementation returns by value
    // For zero-copy, need to return unique_ptr from pool
    
    // Future enhancement:
    // auto update = g_UpdatePool.Acquire();
    // ... fill update ...
    // return update;  // Transfer ownership
}
```

### Use FastParser in JsonParser

```cpp
#include "FastParser.h"

// Replace std::stod with FastParser
Models::OrderBookSnapshot JsonParser::ParseSnapshot(const std::string& data) {
    Models::OrderBookSnapshot book;
    auto j = json::parse(data);
    
    if (j.contains("bids")) {
        for (const auto& item : j["bids"]) {
            std::string priceStr = item[0].get<std::string>();
            std::string qtyStr = item[1].get<std::string>();
            
            auto price = Utils::FastParser::ParseDouble(priceStr);
            auto qty = Utils::FastParser::ParseDouble(qtyStr);
            
            if (price && qty) {
                book.bids.push_back({price.value(), qty.value()});
            }
        }
    }
    
    return book;
}
```

## Step 7: Configuration Management

### Create Configuration File

```cpp
// config.h
struct TradingBotConfig {
    // Connection
    std::string symbol = "BTCUSDT";
    int reconnectInitialDelayMs = 1000;
    int reconnectMaxDelayMs = 60000;
    
    // Strategy
    double minWallVolume = 50.0;
    int minWallLevels = 5;
    double wallPriceRange = 0.005;
    double flowThreshold = 0.65;
    double distanceToWall = 0.002;
    double minConfidence = 0.6;
    
    // Performance
    int updatePoolSize = 100;
    int flowWindowSize = 100;
    int flowWindowMs = 10000;
    
    // Load from JSON file
    static TradingBotConfig LoadFromFile(const std::string& path);
};
```

## Complete Integration Checklist

- [ ] Update SharedState with LocalOrderBook and TakerFlowAnalyzer
- [ ] Add strategy thread with DensityDetector
- [ ] Update UI to show flow stats and walls
- [ ] Implement dual market support (Spot + Futures)
- [ ] Add ObjectPool for OrderBookUpdate
- [ ] Replace std::stod with FastParser
- [ ] Create configuration system
- [ ] Add signal handling and order execution
- [ ] Implement logging and monitoring
- [ ] Test reconnection under failure
- [ ] Profile for heap allocations
- [ ] Benchmark end-to-end latency

## Next Steps

1. **Testing**: Run ValidationTests.cpp to verify components
2. **Integration**: Follow steps above to integrate into main application
3. **Optimization**: Profile with production data
4. **Deployment**: Test in paper trading mode first
5. **Monitoring**: Add metrics and alerting
6. **Production**: Deploy with proper risk management

## Additional Resources

- See `HFT_ARCHITECTURE.md` for detailed component documentation
- See `HFTExample.h` for standalone usage example
- See `VALIDATION_REPORT.md` for implementation status
