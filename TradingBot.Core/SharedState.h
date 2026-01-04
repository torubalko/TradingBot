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
        // price -> aggregated base quantity (lots)
        std::vector<std::pair<double, double>> Bids;
        std::vector<std::pair<double, double>> Asks;

        // price -> aggregated quote quantity (USDT)
        std::vector<std::pair<double, double>> BidsQuote;
        std::vector<std::pair<double, double>> AsksQuote;
    };

    struct MetricsSnapshot {
        long long latencyMs;
        long long stalenessMs;
    };

    // ═══════════════════════════════════════════════════════════════
    // SharedState: Bridge между новым OrderBook и старым UI
    // ═══════════════════════════════════════════════════════════════
    class SharedState {
    public:
        MarketCache marketData;
        std::mutex instrumentsMutex;

        SharedState() {
            // PRE-ALLOCATION для rendering snapshots
            published_[0].Bids.reserve(200);
            published_[0].Asks.reserve(200);
            published_[0].BidsQuote.reserve(200);
            published_[0].AsksQuote.reserve(200);

            published_[1].Bids.reserve(200);
            published_[1].Asks.reserve(200);
            published_[1].BidsQuote.reserve(200);
            published_[1].AsksQuote.reserve(200);
        }

        // ═══════════════════════════════════════════════════════════════
        // Metrics Management
        // ═══════════════════════════════════════════════════════════════
        void SetLatencySample(long long latencyMs) {
            lastLatencyMs_.store(latencyMs, std::memory_order_relaxed);
            long long prev = latencyAvgMs_.load(std::memory_order_relaxed);
            long long smoothed = (prev == 0) ? latencyMs : prev + ((latencyMs - prev) / 4);
            latencyAvgMs_.store(smoothed, std::memory_order_relaxed);
        }

        void SetAppliedNow() {
            auto nowSys = std::chrono::system_clock::now();
            auto nowSteady = std::chrono::steady_clock::now();
            long long nowMs = std::chrono::duration_cast<std::chrono::milliseconds>(
                nowSys.time_since_epoch()).count();
            long long nowNsSteady = std::chrono::duration_cast<std::chrono::nanoseconds>(
                nowSteady.time_since_epoch()).count();
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
                long long smoothed = (prev == 0) ? rawMs : prev + ((rawMs - prev) / 4);
                stalenessAvgMs_.store(smoothed, std::memory_order_relaxed);
                m.stalenessMs = smoothed;
            }
            else {
                m.stalenessMs = stalenessAvgMs_.load(std::memory_order_relaxed);
            }
            return m;
        }

        // ═══════════════════════════════════════════════════════════════
        // NEW: Применение обновлений к OrderBook (std::vector based)
        // Вызывается из BinanceConnector
        // ═══════════════════════════════════════════════════════════════
        void ApplyUpdate(const std::vector<OrderBookLevel>& bids,
                        const std::vector<OrderBookLevel>& asks) {
            std::lock_guard<std::mutex> lock(mutex_);

            // Конвертируем OrderBookLevel -> PriceLevel
            std::vector<Models::PriceLevel> bidLevels;
            std::vector<Models::PriceLevel> askLevels;

            bidLevels.reserve(bids.size());
            askLevels.reserve(asks.size());

            for (const auto& level : bids) {
                bidLevels.push_back({ level.price, level.quantity });
            }

            for (const auto& level : asks) {
                askLevels.push_back({ level.price, level.quantity });
            }

            // Применяем к новому OrderBook (std::vector)
            orderBook_.ApplyUpdate(bidLevels, askLevels);
        }

        // ═══════════════════════════════════════════════════════════════
        // LEGACY: Поддержка старого UI (std::map interface)
        // Конвертируем std::vector -> std::map для совместимости
        // ═══════════════════════════════════════════════════════════════
        void CopyOrderBook(std::map<double, double>& bids, 
                          std::map<double, double>& asks) {
            std::lock_guard<std::mutex> lock(mutex_);

            bids.clear();
            asks.clear();

            // Конвертация: std::vector -> std::map
            const auto& bidLevels = orderBook_.GetBids();
            const auto& askLevels = orderBook_.GetAsks();

            for (const auto& level : bidLevels) {
                bids[level.price] = level.quantity;
            }

            for (const auto& level : askLevels) {
                asks[level.price] = level.quantity;
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // Rendering Snapshot Management (Lock-free double buffering)
        // ═══════════════════════════════════════════════════════════════
        void PublishRenderSnapshot(RenderSnapshot snap) {
            int next = 1 - publishedIndex_.load(std::memory_order_relaxed);
            published_[next] = std::move(snap);
            publishedIndex_.store(next, std::memory_order_release);
        }

        RenderSnapshot GetSnapshotForRender(int /*depth*/, double /*priceStep*/) {
            int idx = publishedIndex_.load(std::memory_order_acquire);
            return published_[idx];
        }

        // ═══════════════════════════════════════════════════════════════
        // NEW: Direct access to OrderBook (для будущей оптимизации UI)
        // ═══════════════════════════════════════════════════════════════
        const Models::OrderBook& GetOrderBookDirect() const {
            return orderBook_;
        }

    private:
        std::mutex mutex_;

        // NEW: Оптимизированный OrderBook (std::vector)
        Models::OrderBook orderBook_;

        // Metrics
        std::atomic<long long> lastLatencyMs_{ 0 };
        std::atomic<long long> latencyAvgMs_{ 0 };
        std::atomic<long long> lastAppliedMs_{ 0 };
        std::atomic<long long> lastAppliedSteadyNs_{ 0 };
        std::atomic<long long> stalenessAvgMs_{ 0 };

        // Double buffering for rendering
        RenderSnapshot published_[2];
        std::atomic<int> publishedIndex_{ 0 };
    };

} // namespace TradingBot::Core