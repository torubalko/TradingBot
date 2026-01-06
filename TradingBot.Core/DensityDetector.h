#pragma once
#include <vector>
#include <optional>
#include "LocalOrderBook.h"
#include "TakerFlowAnalyzer.h"

namespace TradingBot::Core::Strategy {
    // Signal types for density bounce strategy
    enum class SignalType {
        NONE,
        BUY_AT_SUPPORT,   // Buy when price bounces from bid wall
        SELL_AT_RESISTANCE // Sell when price bounces from ask wall
    };

    // Trading signal with context
    struct DensitySignal {
        SignalType type = SignalType::NONE;
        double entryPrice = 0;
        double wallPrice = 0;
        double wallVolume = 0;
        double confidence = 0; // 0-1 confidence score
        long long timestamp = 0;
        
        bool IsValid() const { return type != SignalType::NONE && confidence > 0; }
    };

    // Configuration for density detection
    struct DensityConfig {
        double minWallVolume = 100.0;      // Minimum volume for a wall
        int minLevels = 3;                  // Minimum price levels
        double priceRange = 0.005;          // 0.5% price range for aggregation
        double flowThreshold = 0.65;        // Flow pressure threshold
        double distanceToWall = 0.002;      // 0.2% max distance to wall
        double minConfidence = 0.5;         // Minimum signal confidence
    };

    // Detector for "bounce from density" scalping strategy
    class DensityDetector {
    public:
        explicit DensityDetector(const DensityConfig& config = DensityConfig())
            : config_(config) {}

        // Analyze order book and flow to generate trading signals
        DensitySignal DetectSignal(
            const Models::LocalOrderBook& orderBook,
            const TakerFlowAnalyzer& flowAnalyzer,
            long long currentTime) {
            
            DensitySignal signal;
            signal.timestamp = currentTime;

            double midPrice = orderBook.GetMidPrice();
            if (midPrice <= 0) return signal;

            auto flowStats = flowAnalyzer.GetFlowStats();
            
            // Look for buy signal: strong sell pressure + bid wall support
            if (flowStats.GetBuyPressure() < (1.0 - config_.flowThreshold)) {
                auto bidWalls = orderBook.FindBidWalls(
                    config_.minWallVolume,
                    config_.minLevels,
                    config_.priceRange
                );

                for (const auto& wall : bidWalls) {
                    double distanceRatio = (midPrice - wall.price) / midPrice;
                    
                    // Check if price is close to wall
                    if (distanceRatio <= config_.distanceToWall && distanceRatio >= 0) {
                        signal.type = SignalType::BUY_AT_SUPPORT;
                        signal.entryPrice = wall.price * 1.0001; // Slightly above wall
                        signal.wallPrice = wall.price;
                        signal.wallVolume = wall.totalVolume;
                        
                        // Calculate confidence based on wall strength and flow
                        double wallStrength = std::min(1.0, wall.totalVolume / (config_.minWallVolume * 5.0));
                        double flowStrength = (1.0 - flowStats.GetBuyPressure()) / (1.0 - config_.flowThreshold);
                        signal.confidence = (wallStrength * 0.6 + flowStrength * 0.4);
                        
                        if (signal.confidence >= config_.minConfidence) {
                            return signal;
                        }
                    }
                }
            }
            
            // Look for sell signal: strong buy pressure + ask wall resistance
            if (flowStats.GetBuyPressure() > config_.flowThreshold) {
                auto askWalls = orderBook.FindAskWalls(
                    config_.minWallVolume,
                    config_.minLevels,
                    config_.priceRange
                );

                for (const auto& wall : askWalls) {
                    double distanceRatio = (wall.price - midPrice) / midPrice;
                    
                    // Check if price is close to wall
                    if (distanceRatio <= config_.distanceToWall && distanceRatio >= 0) {
                        signal.type = SignalType::SELL_AT_RESISTANCE;
                        signal.entryPrice = wall.price * 0.9999; // Slightly below wall
                        signal.wallPrice = wall.price;
                        signal.wallVolume = wall.totalVolume;
                        
                        // Calculate confidence
                        double wallStrength = std::min(1.0, wall.totalVolume / (config_.minWallVolume * 5.0));
                        double flowStrength = (flowStats.GetBuyPressure() - config_.flowThreshold) / (1.0 - config_.flowThreshold);
                        signal.confidence = (wallStrength * 0.6 + flowStrength * 0.4);
                        
                        if (signal.confidence >= config_.minConfidence) {
                            return signal;
                        }
                    }
                }
            }

            return signal;
        }

        void SetConfig(const DensityConfig& config) { config_ = config; }
        const DensityConfig& GetConfig() const { return config_; }

    private:
        DensityConfig config_;
    };
}
