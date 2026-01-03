#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <algorithm>
#include <cmath>
#include <atomic>
#include <chrono>

#include "Types.h"
#include "MarketDetails.h"
#include "OrderBook.h"

namespace TradingBot::Core {

    struct RenderSnapshot {
        std::vector<std::pair<double, double>> Bids;
        std::vector<std::pair<double, double>> Asks;
    };

    struct MetricsSnapshot {
        long long lastLatencyMs;
        long long stalenessMs;
    };

    class SharedState {
    public:
        MarketCache marketData;
        std::mutex instrumentsMutex;

    public:
        void SetLatency(long long latencyMs) {
            lastLatencyMs_.store(latencyMs, std::memory_order_relaxed);
        }

        void SetAppliedTimestamp(long long appliedMs) {
            lastAppliedMs_.store(appliedMs, std::memory_order_relaxed);
        }

        MetricsSnapshot GetMetrics() {
            MetricsSnapshot m{};
            m.lastLatencyMs = lastLatencyMs_.load(std::memory_order_relaxed);
            long long applied = lastAppliedMs_.load(std::memory_order_relaxed);
            if (applied > 0) {
                long long nowMs = std::chrono::duration_cast<std::chrono::milliseconds>(
                    std::chrono::system_clock::now().time_since_epoch()).count();
                m.stalenessMs = nowMs - applied;
            } else {
                m.stalenessMs = 0;
            }
            return m;
        }

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

            double mid = (bestAsk + bestBid) / 2.0;
            double center = std::floor(mid / priceStep + 0.0000001) * priceStep;

            double maxPrice = center + depth * priceStep;
            double minPrice = center - depth * priceStep;

            std::map<double, double> aggBids;
            std::map<double, double> aggAsks;

            // Aggregate Asks within visible range using fixed bins (ceil)
            for (auto it = Asks.lower_bound(minPrice); it != Asks.end(); ++it) {
                if (it->first > maxPrice) break;
                double key = std::ceil(it->first / priceStep - 0.000001) * priceStep;
                if (key == -0.0) key = 0.0;
                aggAsks[key] += it->second;
            }

            // Aggregate Bids within visible range using fixed bins (floor)
            for (auto it = Bids.lower_bound(minPrice); it != Bids.end() && it->first <= maxPrice; ++it) {
                double key = std::floor(it->first / priceStep + 0.000001) * priceStep;
                aggBids[key] += it->second;
            }

            double gridBid = center;
            double gridAsk = center + priceStep;

            for (int i = 0; i < depth; i++) {
                double price = gridAsk + (i * priceStep);
                double vol = 0;
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
        std::atomic<long long> lastLatencyMs_{ 0 };
        std::atomic<long long> lastAppliedMs_{ 0 };
    };
}