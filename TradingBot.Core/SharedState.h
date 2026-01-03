#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <algorithm>
#include <cmath>

#include "Types.h"
#include "MarketDetails.h"
#include "OrderBook.h"

namespace TradingBot::Core {

    struct RenderSnapshot {
        std::vector<std::pair<double, double>> Bids;
        std::vector<std::pair<double, double>> Asks;
    };

    class SharedState {
    public:
        MarketCache marketData;
        std::mutex instrumentsMutex;

    public:
        void ApplyUpdate(const std::vector<OrderBookLevel>& bids,
            const std::vector<OrderBookLevel>& asks) {
            std::lock_guard<std::mutex> lock(mutex_);
            double epsilon = 0.0000001;

            for (const auto& level : bids) {
                if (level.quantity < epsilon) Bids.erase(level.price);
                else Bids[level.price] = level.quantity;
            }
            for (const auto& level : asks) {
                if (level.quantity < epsilon) Asks.erase(level.price);
                else Asks[level.price] = level.quantity;
            }
        }

        RenderSnapshot GetSnapshotForRender(int depth, double priceStep) {
            std::lock_guard<std::mutex> lock(mutex_);
            RenderSnapshot snap;

            if (Asks.empty() || Bids.empty()) return snap;

            double bestAsk = Asks.begin()->first;
            double bestBid = Bids.rbegin()->first;

            // Calculate visible range with safety margin
            double range = depth * priceStep * 1.5;
            double maxAsk = bestAsk + range;
            double minBid = bestBid - range;

            std::map<double, double> aggBids;
            std::map<double, double> aggAsks;

            // Aggregate Asks (only visible range)
            for (auto it = Asks.begin(); it != Asks.end(); ++it) {
                if (it->first > maxAsk) break;

                double key = std::ceil(it->first / priceStep - 0.000001) * priceStep;
                if (key == -0.0) key = 0.0;
                aggAsks[key] += it->second;
            }

            // Aggregate Bids (only visible range)
            // Iterate backwards from highest price
            for (auto it = Bids.rbegin(); it != Bids.rend(); ++it) {
                if (it->first < minBid) break;

                double key = std::floor(it->first / priceStep + 0.000001) * priceStep;
                aggBids[key] += it->second;
            }

            double gridAsk = std::ceil(bestAsk / priceStep - 0.000001) * priceStep;
            double gridBid = std::floor(bestBid / priceStep + 0.000001) * priceStep;

            if (gridAsk <= gridBid) gridAsk = gridBid + priceStep;

            for (int i = 0; i < depth; i++) {
                double price = gridAsk + (i * priceStep);
                double vol = 0;
                auto it = aggAsks.find(price);
                // Use find with tolerance or just direct lookup since we constructed keys exactly
                // But floating point keys in map are tricky.
                // Let's use lower_bound with epsilon as before for safety
                auto itLb = aggAsks.lower_bound(price - 0.00001);
                if (itLb != aggAsks.end() && std::abs(itLb->first - price) < 0.00001) vol = itLb->second;

                snap.Asks.push_back({ price, vol });
            }

            for (int i = 0; i < depth; i++) {
                double price = gridBid - (i * priceStep);
                double vol = 0;
                auto itLb = aggBids.lower_bound(price - 0.00001);
                if (itLb != aggBids.end() && std::abs(itLb->first - price) < 0.00001) vol = itLb->second;

                snap.Bids.push_back({ price, vol });
            }

            return snap;
        }

    private:
        std::mutex mutex_;
        std::map<double, double> Bids;
        std::map<double, double> Asks;
    };
}