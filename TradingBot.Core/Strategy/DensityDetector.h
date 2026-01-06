#pragma once
#include <vector>
#include <map>
#include "../OrderBook/LocalOrderBook.h"

namespace TradingBot::Core::Strategy {
    struct LiquidityWall {
        double price;
        double volume;
        bool isBid;
        double distanceFromMid;  // Distance from mid price in percentage
    };

    class DensityDetector {
    public:
        DensityDetector(double volumeThreshold = 100.0, int maxWalls = 5)
            : volumeThreshold_(volumeThreshold), maxWalls_(maxWalls) {}

        void SetVolumeThreshold(double threshold) {
            volumeThreshold_ = threshold;
        }

        void SetMaxWalls(int maxWalls) {
            maxWalls_ = maxWalls;
        }

        std::vector<LiquidityWall> DetectWalls(const OrderBook::LocalOrderBook& orderBook) const {
            std::vector<LiquidityWall> walls;

            auto bids = orderBook.GetBids();
            auto asks = orderBook.GetAsks();

            if (bids.empty() || asks.empty()) {
                return walls;
            }

            double bestBid = orderBook.GetBestBid();
            double bestAsk = orderBook.GetBestAsk();
            double midPrice = (bestBid + bestAsk) / 2.0;

            // Detect bid walls
            int bidWallCount = 0;
            for (auto it = bids.rbegin(); it != bids.rend() && bidWallCount < maxWalls_; ++it) {
                if (it->second >= volumeThreshold_) {
                    LiquidityWall wall;
                    wall.price = it->first;
                    wall.volume = it->second;
                    wall.isBid = true;
                    wall.distanceFromMid = ((it->first - midPrice) / midPrice) * 100.0;
                    walls.push_back(wall);
                    bidWallCount++;
                }
            }

            // Detect ask walls
            int askWallCount = 0;
            for (const auto& [price, volume] : asks) {
                if (askWallCount >= maxWalls_) break;
                if (volume >= volumeThreshold_) {
                    LiquidityWall wall;
                    wall.price = price;
                    wall.volume = volume;
                    wall.isBid = false;
                    wall.distanceFromMid = ((price - midPrice) / midPrice) * 100.0;
                    walls.push_back(wall);
                    askWallCount++;
                }
            }

            return walls;
        }

        // Detects imbalance between bid and ask walls
        double CalculateImbalance(const std::vector<LiquidityWall>& walls) const {
            double bidVolume = 0.0;
            double askVolume = 0.0;

            for (const auto& wall : walls) {
                if (wall.isBid) {
                    bidVolume += wall.volume;
                } else {
                    askVolume += wall.volume;
                }
            }

            if (bidVolume + askVolume < 0.0000001) {
                return 0.0;
            }

            return (bidVolume - askVolume) / (bidVolume + askVolume);
        }

    private:
        double volumeThreshold_;
        int maxWalls_;
    };
}
