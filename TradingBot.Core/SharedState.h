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
        long long latencyMs;
        long long stalenessMs;
    };

    class SharedState {
    public:
        MarketCache marketData;
        std::mutex instrumentsMutex;

    public:
        void SetLatencySample(long long latencyMs) {
            lastLatencyMs_.store(latencyMs, std::memory_order_relaxed);
            long long prev = latencyAvgMs_.load(std::memory_order_relaxed);
            long long smoothed = (prev == 0) ? latencyMs : prev + ((latencyMs - prev) / 4); // alpha=0.25
            latencyAvgMs_.store(smoothed, std::memory_order_relaxed);
        }

        void SetAppliedNow() {
            auto nowSys = std::chrono::system_clock::now();
            auto nowSteady = std::chrono::steady_clock::now();
            long long nowMs = std::chrono::duration_cast<std::chrono::milliseconds>(nowSys.time_since_epoch()).count();
            long long nowNsSteady = std::chrono::duration_cast<std::chrono::nanoseconds>(nowSteady.time_since_epoch()).count();
            lastAppliedMs_.store(nowMs, std::memory_order_relaxed);
            lastAppliedSteadyNs_.store(nowNsSteady, std::memory_order_relaxed);
        }

        MetricsSnapshot GetMetrics() {
            MetricsSnapshot m{};
            long long latAvg = latencyAvgMs_.load(std::memory_order_relaxed);
            m.latencyMs = (latAvg > 0) ? latAvg : lastLatencyMs_.load(std::memory_order_relaxed);

            long long appliedNs = lastAppliedSteadyNs_.load(std::memory_order_relaxed);
            if (appliedNs > 0) {
                long long nowNs = std::chrono::duration_cast<std::chrono::nanoseconds>(
                    std::chrono::steady_clock::now().time_since_epoch()).count();
                long long rawMs = (nowNs - appliedNs) / 1'000'000;
                long long prev = stalenessAvgMs_.load(std::memory_order_relaxed);
                long long smoothed = (prev == 0) ? rawMs : prev + ((rawMs - prev) / 4); // alpha=0.25
                stalenessAvgMs_.store(smoothed, std::memory_order_relaxed);
                m.stalenessMs = smoothed;
            }
            else {
                m.stalenessMs = stalenessAvgMs_.load(std::memory_order_relaxed);
            }
            return m;
        }

        void ApplyUpdate(const std::vector<OrderBookLevel>& bids,
            const std::vector<OrderBookLevel>& asks) {
            std::lock_guard<std::mutex> lock(mutex_);
            double epsilon = 0.0000001;

            for (const auto& level : bids) {
                if (level.quantity < epsilon) Bids_.erase(level.price);
                else Bids_[level.price] = level.quantity;
            }
            for (const auto& level : asks) {
                if (level.quantity < epsilon) Asks_.erase(level.price);
                else Asks_[level.price] = level.quantity;
            }
        }

        void CopyOrderBook(std::map<double, double>& bids, std::map<double, double>& asks) {
            std::lock_guard<std::mutex> lock(mutex_);
            bids = Bids_;
            asks = Asks_;
        }

        void PublishRenderSnapshot(RenderSnapshot snap) {
            int next = 1 - publishedIndex_.load(std::memory_order_relaxed);
            published_[next] = std::move(snap);
            publishedIndex_.store(next, std::memory_order_release);
        }

        RenderSnapshot GetSnapshotForRender(int /*depth*/, double /*priceStep*/) {
            int idx = publishedIndex_.load(std::memory_order_acquire);
            return published_[idx];
        }

    private:
        std::mutex mutex_;
        std::map<double, double> Bids_;
        std::map<double, double> Asks_;
        std::atomic<long long> lastLatencyMs_{ 0 };
        std::atomic<long long> latencyAvgMs_{ 0 };
        std::atomic<long long> lastAppliedMs_{ 0 };
        std::atomic<long long> lastAppliedSteadyNs_{ 0 };
        std::atomic<long long> stalenessAvgMs_{ 0 };

        RenderSnapshot published_[2];
        std::atomic<int> publishedIndex_{ 0 };
    };
}