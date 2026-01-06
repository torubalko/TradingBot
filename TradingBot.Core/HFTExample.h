#pragma once
// Example integration showing how to use the HFT components together
// This demonstrates the "bounce from density" scalping strategy

#include "LocalOrderBook.h"
#include "TakerFlowAnalyzer.h"
#include "DensityDetector.h"
#include "ObjectPool.h"
#include "FastParser.h"
#include <memory>
#include <iostream>

namespace TradingBot::Core::Examples {
    
    // Example: Complete HFT trading system integration
    class HFTTradingSystem {
    public:
        HFTTradingSystem() {
            // Configure density detection parameters
            Strategy::DensityConfig config;
            config.minWallVolume = 50.0;     // 50 BTC minimum wall
            config.minLevels = 5;             // At least 5 price levels
            config.priceRange = 0.003;        // 0.3% price range
            config.flowThreshold = 0.65;      // 65% flow pressure
            config.distanceToWall = 0.002;    // 0.2% distance to wall
            config.minConfidence = 0.6;       // 60% minimum confidence
            
            densityDetector_ = std::make_unique<Strategy::DensityDetector>(config);
            
            // Initialize components
            orderBook_ = std::make_unique<Models::LocalOrderBook>();
            flowAnalyzer_ = std::make_unique<Strategy::TakerFlowAnalyzer>(100, 10000);
            updatePool_ = std::make_unique<Utils::ObjectPool<Models::OrderBookUpdate>>(100);
        }

        // Process order book snapshot (from REST API)
        void OnSnapshot(const Models::OrderBookSnapshot& snapshot) {
            orderBook_->ApplySnapshot(snapshot);
            std::cout << "Snapshot applied. Best bid: " << orderBook_->GetBestBid()
                     << " Best ask: " << orderBook_->GetBestAsk() << std::endl;
        }

        // Process order book update (from WebSocket depth stream)
        void OnDepthUpdate(const Models::OrderBookUpdate& update) {
            // Use object pool for efficiency (can be integrated with lock-free queue)
            orderBook_->ApplyUpdate(update);
            
            // Optional: Check for density changes
            CheckDensityLevels();
        }

        // Process trade (from WebSocket aggTrade stream)
        void OnTrade(const Trade& trade) {
            flowAnalyzer_->ProcessTrade(trade);
            
            // Generate trading signals after each trade
            GenerateSignals(trade.timestamp);
        }

        // Check for liquidity walls
        void CheckDensityLevels() {
            double avgBidVolume = orderBook_->GetBidVolumeAtDepth(10) / 10.0;
            
            // Find bid walls (support levels)
            auto bidWalls = orderBook_->FindBidWalls(avgBidVolume * 3.0, 5, 0.005);
            if (!bidWalls.empty()) {
                std::cout << "Found " << bidWalls.size() << " bid walls:" << std::endl;
                for (const auto& wall : bidWalls) {
                    std::cout << "  Price: " << wall.price 
                             << " Volume: " << wall.totalVolume 
                             << " Levels: " << wall.levelCount << std::endl;
                }
            }

            double avgAskVolume = orderBook_->GetAskVolumeAtDepth(10) / 10.0;
            
            // Find ask walls (resistance levels)
            auto askWalls = orderBook_->FindAskWalls(avgAskVolume * 3.0, 5, 0.005);
            if (!askWalls.empty()) {
                std::cout << "Found " << askWalls.size() << " ask walls:" << std::endl;
                for (const auto& wall : askWalls) {
                    std::cout << "  Price: " << wall.price 
                             << " Volume: " << wall.totalVolume 
                             << " Levels: " << wall.levelCount << std::endl;
                }
            }
        }

        // Generate trading signals
        void GenerateSignals(long long timestamp) {
            auto signal = densityDetector_->DetectSignal(*orderBook_, *flowAnalyzer_, timestamp);
            
            if (signal.IsValid()) {
                std::cout << "SIGNAL DETECTED!" << std::endl;
                std::cout << "  Type: " << (signal.type == Strategy::SignalType::BUY_AT_SUPPORT ? "BUY" : "SELL") << std::endl;
                std::cout << "  Entry Price: " << signal.entryPrice << std::endl;
                std::cout << "  Wall Price: " << signal.wallPrice << std::endl;
                std::cout << "  Wall Volume: " << signal.wallVolume << std::endl;
                std::cout << "  Confidence: " << (signal.confidence * 100) << "%" << std::endl;
                
                // Here you would place your order
                // PlaceOrder(signal);
            }
        }

        // Get flow statistics
        void PrintFlowStats() {
            auto stats = flowAnalyzer_->GetFlowStats();
            std::cout << "Flow Stats:" << std::endl;
            std::cout << "  Buy Volume: " << stats.buyVolume << std::endl;
            std::cout << "  Sell Volume: " << stats.sellVolume << std::endl;
            std::cout << "  Buy Pressure: " << (stats.GetBuyPressure() * 100) << "%" << std::endl;
            std::cout << "  Net Flow: " << stats.GetNetFlow() << std::endl;
            std::cout << "  VWAP: " << flowAnalyzer_->GetVWAP() << std::endl;
        }

        // Example: Using FastParser for zero-copy parsing
        void ParseExample(const std::string& priceStr, const std::string& volumeStr) {
            // Fast parsing without string allocation
            auto price = Utils::FastParser::ParseDouble(priceStr);
            auto volume = Utils::FastParser::ParseDouble(volumeStr);
            
            if (price.has_value() && volume.has_value()) {
                std::cout << "Parsed - Price: " << price.value() 
                         << " Volume: " << volume.value() << std::endl;
            }
        }

    private:
        std::unique_ptr<Models::LocalOrderBook> orderBook_;
        std::unique_ptr<Strategy::TakerFlowAnalyzer> flowAnalyzer_;
        std::unique_ptr<Strategy::DensityDetector> densityDetector_;
        std::unique_ptr<Utils::ObjectPool<Models::OrderBookUpdate>> updatePool_;
    };

    // Example usage function
    inline void RunHFTExample() {
        HFTTradingSystem system;
        
        // Simulate snapshot
        Models::OrderBookSnapshot snapshot;
        snapshot.lastUpdateId = 12345;
        
        // Add some bid levels
        snapshot.bids.push_back({50000.0, 1.5});
        snapshot.bids.push_back({49999.0, 2.0});
        snapshot.bids.push_back({49998.0, 1.8});
        
        // Add some ask levels
        snapshot.asks.push_back({50001.0, 1.2});
        snapshot.asks.push_back({50002.0, 1.7});
        snapshot.asks.push_back({50003.0, 1.9});
        
        system.OnSnapshot(snapshot);
        
        // Simulate trades
        Trade trade1{1, 50001.0, 0.5, true, 1640000000000LL};
        system.OnTrade(trade1);
        
        Trade trade2{2, 50002.0, 0.3, false, 1640000001000LL};
        system.OnTrade(trade2);
        
        system.PrintFlowStats();
        system.CheckDensityLevels();
    }
}
