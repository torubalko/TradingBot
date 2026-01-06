#pragma once
// Example usage of the HFT bot modules
// This file demonstrates how to use the newly implemented modules

#include "OrderBook/LocalOrderBook.h"
#include "Strategy/DensityDetector.h"
#include "Strategy/TakerFlowAnalyzer.h"
#include "Memory/ObjectPool.h"
#include "LockFree/SPSCQueue.h"
#include "Parsing/FastParser.h"
#include "Network/DataFeedManager.h"
#include "Network/WebSocketSession.h"
#include "Types.h"
#include <iostream>

namespace TradingBot::Core::Examples {
    
    // Example 1: Using LocalOrderBook
    void ExampleLocalOrderBook() {
        using namespace TradingBot::Core::OrderBook;
        
        LocalOrderBook orderBook;
        
        // Set initial snapshot
        std::vector<OrderBookLevel> bids = {
            {50000.0, 1.5},
            {49999.0, 2.0},
            {49998.0, 0.8}
        };
        std::vector<OrderBookLevel> asks = {
            {50001.0, 1.2},
            {50002.0, 1.8},
            {50003.0, 0.9}
        };
        
        orderBook.SetSnapshot(bids, asks);
        
        // Apply diff
        std::vector<OrderBookLevel> bidUpdates = {{50000.5, 3.0}};
        std::vector<OrderBookLevel> askUpdates = {{50001.5, 2.5}};
        orderBook.ApplyDiff(bidUpdates, askUpdates);
        
        // Find densities
        auto densities = orderBook.FindDensities(1.0);
        
        std::cout << "Found " << densities.size() << " density levels" << std::endl;
    }
    
    // Example 2: Using DensityDetector
    void ExampleDensityDetector() {
        using namespace TradingBot::Core::Strategy;
        using namespace TradingBot::Core::OrderBook;
        
        LocalOrderBook orderBook;
        DensityDetector detector(100.0, 5); // threshold = 100, max walls = 5
        
        // Setup order book...
        std::vector<OrderBookLevel> bids = {{50000.0, 150.0}, {49990.0, 80.0}};
        std::vector<OrderBookLevel> asks = {{50010.0, 200.0}, {50020.0, 90.0}};
        orderBook.SetSnapshot(bids, asks);
        
        // Detect liquidity walls
        auto walls = detector.DetectWalls(orderBook);
        
        // Calculate imbalance
        double imbalance = detector.CalculateImbalance(walls);
        
        std::cout << "Found " << walls.size() << " liquidity walls" << std::endl;
        std::cout << "Imbalance: " << imbalance << std::endl;
    }
    
    // Example 3: Using TakerFlowAnalyzer
    void ExampleTakerFlowAnalyzer() {
        using namespace TradingBot::Core::Strategy;
        
        TakerFlowAnalyzer analyzer(60000, 1000); // 60 sec window, max 1000 trades
        
        // Add some trades
        Trade t1 = {1, 50000.0, 1.5, false, 1234567890000LL}; // buyer initiated
        Trade t2 = {2, 50001.0, 0.8, true, 1234567891000LL};  // seller initiated
        
        analyzer.AddTrade(t1);
        analyzer.AddTrade(t2);
        
        // Calculate flow
        auto metrics = analyzer.CalculateFlow();
        
        std::cout << "Buyer volume: " << metrics.buyerVolume << std::endl;
        std::cout << "Seller volume: " << metrics.sellerVolume << std::endl;
        std::cout << "Aggression: " << metrics.aggression << std::endl;
    }
    
    // Example 4: Using ObjectPool
    void ExampleObjectPool() {
        using namespace TradingBot::Core::Memory;
        
        struct Message {
            std::string data;
            int priority;
            
            void reset() {
                data.clear();
                priority = 0;
            }
        };
        
        ObjectPool<Message> pool(10, 100);
        
        // Acquire object from pool
        auto msg = pool.acquire();
        msg->data = "Test message";
        msg->priority = 1;
        
        // Object is automatically returned to pool when unique_ptr is destroyed
        
        std::cout << "Pool size: " << pool.size() << std::endl;
    }
    
    // Example 5: Using SPSCQueue
    void ExampleSPSCQueue() {
        using namespace TradingBot::Core::LockFree;
        
        SPSCQueue<int, 1024> queue;
        
        // Producer
        queue.push(42);
        queue.push(100);
        
        // Consumer
        auto value1 = queue.pop();
        if (value1) {
            std::cout << "Popped: " << *value1 << std::endl;
        }
        
        std::cout << "Queue empty: " << (queue.empty() ? "yes" : "no") << std::endl;
    }
    
    // Example 6: Using FastParser
    void ExampleFastParser() {
        using namespace TradingBot::Core::Parsing;
        
        std::string json = R"({"p":"50000.5","q":"1.5","m":false,"T":1234567890})";
        
        // Extract price using zero-copy parsing
        auto priceStr = FastParser::ExtractQuotedString(json, "\"p\"");
        auto price = FastParser::ParseDouble(priceStr);
        
        if (price) {
            std::cout << "Parsed price: " << *price << std::endl;
        }
        
        // Extract boolean
        auto isMaker = FastParser::ExtractBool(json, "\"m\"");
        if (isMaker) {
            std::cout << "Is buyer maker: " << (*isMaker ? "true" : "false") << std::endl;
        }
    }
    
    // Example 7: Using DataFeedManager
    void ExampleDataFeedManager() {
        using namespace TradingBot::Core::Network;
        
        DataFeedManager feedManager;
        
        FeedConfig config;
        config.symbol = "BTCUSDT";
        config.mode = MarketMode::FUTURES;
        config.subscribeDepth = true;
        config.subscribeAggTrades = true;
        config.depthUpdateSpeed = "100ms";
        
        // Subscribe to data feed
        feedManager.Subscribe(
            config,
            [](const std::string& msg, MarketMode mode) {
                std::cout << "Received message for " 
                          << (mode == MarketMode::FUTURES ? "FUTURES" : "SPOT") 
                          << std::endl;
            },
            [](const std::string& error) {
                std::cerr << "Error: " << error << std::endl;
            }
        );
        
        // Check if connected
        bool connected = feedManager.IsConnected("BTCUSDT", MarketMode::FUTURES);
        std::cout << "Connected: " << (connected ? "yes" : "no") << std::endl;
        
        // Cleanup
        feedManager.DisconnectAll();
    }
}
