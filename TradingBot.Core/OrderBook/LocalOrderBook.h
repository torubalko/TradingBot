#pragma once
#include <map>
#include <vector>
#include <mutex>
#include "../Types.h"

namespace TradingBot::Core::OrderBook {
    struct DensityLevel {
        double price;
        double volume;
        bool isBid;
    };

    class LocalOrderBook {
    public:
        LocalOrderBook() = default;

        void ApplyDiff(const std::vector<OrderBookLevel>& bids, const std::vector<OrderBookLevel>& asks) {
            std::lock_guard<std::mutex> lock(mutex_);
            
            for (const auto& level : bids) {
                if (level.quantity < 0.0000001) {
                    bids_.erase(level.price);
                } else {
                    bids_[level.price] = level.quantity;
                }
            }
            
            for (const auto& level : asks) {
                if (level.quantity < 0.0000001) {
                    asks_.erase(level.price);
                } else {
                    asks_[level.price] = level.quantity;
                }
            }
        }

        void SetSnapshot(const std::vector<OrderBookLevel>& bids, const std::vector<OrderBookLevel>& asks) {
            std::lock_guard<std::mutex> lock(mutex_);
            bids_.clear();
            asks_.clear();
            
            for (const auto& level : bids) {
                bids_[level.price] = level.quantity;
            }
            
            for (const auto& level : asks) {
                asks_[level.price] = level.quantity;
            }
        }

        std::vector<DensityLevel> FindDensities(double threshold, int maxLevels = 10) const {
            std::lock_guard<std::mutex> lock(mutex_);
            std::vector<DensityLevel> densities;

            // Find bid densities
            for (auto it = bids_.rbegin(); it != bids_.rend(); ++it) {
                if (it->second >= threshold) {
                    densities.push_back({it->first, it->second, true});
                    if (densities.size() >= static_cast<size_t>(maxLevels)) break;
                }
            }

            // Find ask densities
            for (const auto& [price, volume] : asks_) {
                if (volume >= threshold) {
                    densities.push_back({price, volume, false});
                    if (densities.size() >= static_cast<size_t>(maxLevels * 2)) break;
                }
            }

            return densities;
        }

        std::map<double, double> GetBids() const {
            std::lock_guard<std::mutex> lock(mutex_);
            return bids_;
        }

        std::map<double, double> GetAsks() const {
            std::lock_guard<std::mutex> lock(mutex_);
            return asks_;
        }

        double GetBestBid() const {
            std::lock_guard<std::mutex> lock(mutex_);
            return bids_.empty() ? 0.0 : bids_.rbegin()->first;
        }

        double GetBestAsk() const {
            std::lock_guard<std::mutex> lock(mutex_);
            return asks_.empty() ? 0.0 : asks_.begin()->first;
        }

    private:
        mutable std::mutex mutex_;
        std::map<double, double> bids_;  // price -> quantity (descending by default for bids)
        std::map<double, double> asks_;  // price -> quantity (ascending by default for asks)
    };
}
