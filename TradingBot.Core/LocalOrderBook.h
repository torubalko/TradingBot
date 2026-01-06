#pragma once
#include <map>
#include <vector>
#include <algorithm>
#include "Types.h"

namespace TradingBot::Core::Models {
    // Density level representing a liquidity wall
    struct DensityLevel {
        double price;
        double totalVolume;
        int levelCount;
        bool isBid; // true for bid wall, false for ask wall
    };

    // Enhanced order book with density detection for HFT scalping
    class LocalOrderBook {
    public:
        LocalOrderBook() {
            // Pre-allocate for performance
            bids_.reserve(1000);
            asks_.reserve(1000);
        }

        // Apply snapshot from REST API
        void ApplySnapshot(const OrderBookSnapshot& snapshot) {
            lastUpdateId_ = snapshot.lastUpdateId;
            bids_.clear();
            asks_.clear();
            
            for (const auto& level : snapshot.bids) {
                if (level.quantity > 0) {
                    bids_[level.price] = level.quantity;
                }
            }
            for (const auto& level : snapshot.asks) {
                if (level.quantity > 0) {
                    asks_[level.price] = level.quantity;
                }
            }
        }

        // Apply incremental update from WebSocket
        void ApplyUpdate(const OrderBookUpdate& update) {
            constexpr double epsilon = 1e-8;
            
            for (const auto& level : update.bids) {
                if (level.quantity < epsilon) {
                    bids_.erase(level.price);
                } else {
                    bids_[level.price] = level.quantity;
                }
            }
            
            for (const auto& level : update.asks) {
                if (level.quantity < epsilon) {
                    asks_.erase(level.price);
                } else {
                    asks_[level.price] = level.quantity;
                }
            }
        }

        // Find liquidity walls (density levels) on bid side
        std::vector<DensityLevel> FindBidWalls(double minVolume, int minLevels = 3, double priceRange = 0.01) const {
            std::vector<DensityLevel> walls;
            if (bids_.empty()) return walls;

            auto it = bids_.rbegin(); // Start from highest bid
            while (it != bids_.rend()) {
                double basePrice = it->first;
                double totalVolume = 0;
                int levelCount = 0;
                double maxPrice = basePrice;
                double minPrice = basePrice * (1.0 - priceRange);

                // Aggregate volume in price range
                auto rangeIt = it;
                while (rangeIt != bids_.rend() && rangeIt->first >= minPrice) {
                    totalVolume += rangeIt->second;
                    ++levelCount;
                    ++rangeIt;
                }

                // Check if this forms a wall
                if (totalVolume >= minVolume && levelCount >= minLevels) {
                    DensityLevel wall;
                    wall.price = basePrice;
                    wall.totalVolume = totalVolume;
                    wall.levelCount = levelCount;
                    wall.isBid = true;
                    walls.push_back(wall);
                    
                    // Skip processed levels
                    it = rangeIt;
                } else {
                    ++it;
                }
            }

            return walls;
        }

        // Find liquidity walls (density levels) on ask side
        std::vector<DensityLevel> FindAskWalls(double minVolume, int minLevels = 3, double priceRange = 0.01) const {
            std::vector<DensityLevel> walls;
            if (asks_.empty()) return walls;

            auto it = asks_.begin(); // Start from lowest ask
            while (it != asks_.end()) {
                double basePrice = it->first;
                double totalVolume = 0;
                int levelCount = 0;
                double maxPrice = basePrice * (1.0 + priceRange);

                // Aggregate volume in price range
                auto rangeIt = it;
                while (rangeIt != asks_.end() && rangeIt->first <= maxPrice) {
                    totalVolume += rangeIt->second;
                    ++levelCount;
                    ++rangeIt;
                }

                // Check if this forms a wall
                if (totalVolume >= minVolume && levelCount >= minLevels) {
                    DensityLevel wall;
                    wall.price = basePrice;
                    wall.totalVolume = totalVolume;
                    wall.levelCount = levelCount;
                    wall.isBid = false;
                    walls.push_back(wall);
                    
                    // Skip processed levels
                    it = rangeIt;
                } else {
                    ++it;
                }
            }

            return walls;
        }

        // Get best bid price
        double GetBestBid() const {
            return bids_.empty() ? 0.0 : bids_.rbegin()->first;
        }

        // Get best ask price
        double GetBestAsk() const {
            return asks_.empty() ? 0.0 : asks_.begin()->first;
        }

        // Get mid price
        double GetMidPrice() const {
            double bestBid = GetBestBid();
            double bestAsk = GetBestAsk();
            return (bestBid > 0 && bestAsk > 0) ? (bestBid + bestAsk) / 2.0 : 0.0;
        }

        // Get total volume at depth
        double GetBidVolumeAtDepth(int depth) const {
            double total = 0;
            int count = 0;
            for (auto it = bids_.rbegin(); it != bids_.rend() && count < depth; ++it, ++count) {
                total += it->second;
            }
            return total;
        }

        double GetAskVolumeAtDepth(int depth) const {
            double total = 0;
            int count = 0;
            for (auto it = asks_.begin(); it != asks_.end() && count < depth; ++it, ++count) {
                total += it->second;
            }
            return total;
        }

        long long GetLastUpdateId() const { return lastUpdateId_; }
        const std::map<double, double, std::greater<double>>& GetBids() const { return bids_; }
        const std::map<double, double>& GetAsks() const { return asks_; }

    private:
        std::map<double, double, std::greater<double>> bids_; // Descending order
        std::map<double, double> asks_; // Ascending order
        long long lastUpdateId_ = 0;
    };
}
