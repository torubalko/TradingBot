#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <algorithm>
#include <cmath>
#include <atomic>
#include <chrono>
#include <sstream>
#include <thread>
#include <immintrin.h>

#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>
#endif

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

        int64_t Version{ -1 };
        int64_t TimestampNs{ 0 };
    };

    struct MetricsSnapshot {
        long long latencyMs;
        long long stalenessMs;
    };

    struct ExternalMetricsSnapshot {
        long long exchLatencyNs{0};
        long long netLatencyNs{0};
        long long enqueueLatencyNs{0};
        long long parseLatencyNs{0};
        long long processLatencyNs{0};
        long long callbackLatencyNs{0};
        long long procChainLatencyNs{0};
        long long endToEndP99Ns{0};
        long long messagesPerSecond{0};
        long long droppedMessages{0};
        size_t queueHighWater{0};
    };

    // ═══════════════════════════════════════════════════════════════
    // SharedState: decoupled push/pull bridge between OrderBook and UI
    // ═══════════════════════════════════════════════════════════════
    class SharedState {
    public:
        MarketCache marketData;
        std::mutex instrumentsMutex;

        SharedState() {
            renderCache_.Bids.reserve(200);
            renderCache_.Asks.reserve(200);
            renderCache_.BidsQuote.reserve(200);
            renderCache_.AsksQuote.reserve(200);

            tempBids_.reserve(200);
            tempAsks_.reserve(200);
        }

        // ═══════════════════════════════════════════════════════════════
        // Symbol Management
        // ═══════════════════════════════════════════════════════════════
        void SetSymbol(const std::string& symbol) {
            std::lock_guard<SpinLock> lock(symbolLock_);
            currentSymbol_ = symbol;
        }

        std::string GetSymbol() const {
            std::lock_guard<SpinLock> lock(symbolLock_);
            return currentSymbol_;
        }

        // ═══════════════════════════════════════════════════════════════
        // Metrics Management
        // ═══════════════════════════════════════════════════════════════
        void UpdateLatency(long long latencyMs) {
            SetLatencySample(latencyMs);
            SetAppliedNow();
        }

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
        // Apply snapshot (REST) - replaces entire book
        // ═══════════════════════════════════════════════════════════════
        void ApplySnapshot(const std::vector<OrderBookLevel>& bids,
                           const std::vector<OrderBookLevel>& asks) {
            tempBids_.clear();
            tempAsks_.clear();
            tempBids_.reserve(bids.size());
            tempAsks_.reserve(asks.size());

            for (const auto& level : bids) tempBids_.push_back({ level.price, level.quantity });
            for (const auto& level : asks) tempAsks_.push_back({ level.price, level.quantity });

            {
                std::lock_guard<SpinLock> lock(stateLock_);
                orderBook_.ApplySnapshot(tempBids_, tempAsks_);
                version_.fetch_add(1, std::memory_order_release);
                lastUpdateNs_.store(HighResNowNs(), std::memory_order_release);
            }
            SetAppliedNow();
        }

        // ═══════════════════════════════════════════════════════════════
        // Apply incremental update (WebSocket diff)
        // ═══════════════════════════════════════════════════════════════
        void ApplyUpdate(const std::vector<OrderBookLevel>& bids,
                         const std::vector<OrderBookLevel>& asks) {
            tempBids_.clear();
            tempAsks_.clear();
            tempBids_.reserve(bids.size());
            tempAsks_.reserve(asks.size());

            for (const auto& level : bids) tempBids_.push_back({ level.price, level.quantity });
            for (const auto& level : asks) tempAsks_.push_back({ level.price, level.quantity });

            {
                std::lock_guard<SpinLock> lock(stateLock_);
                orderBook_.ApplyUpdate(tempBids_, tempAsks_);
                version_.fetch_add(1, std::memory_order_release);
                lastUpdateNs_.store(HighResNowNs(), std::memory_order_release);
            }
            SetAppliedNow();
        }

        // ═══════════════════════════════════════════════════════════════
        // LEGACY map copy for old UI
        // ═══════════════════════════════════════════════════════════════
        void CopyOrderBook(std::map<double, double>& bids,
                           std::map<double, double>& asks) {
            std::lock_guard<SpinLock> lock(stateLock_);

            bids.clear();
            asks.clear();

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
        // Pull-based rendering snapshot with versioning
        // ═══════════════════════════════════════════════════════════════
        const RenderSnapshot& GetSnapshotForRender(int /*depth*/, double /*priceStep*/) {
            const int64_t curVer = version_.load(std::memory_order_acquire);
            if (renderCache_.Version == curVer) {
                return renderCache_; // cached, no copy from book
            }

            const int64_t curStamp = lastUpdateNs_.load(std::memory_order_acquire);
            if (renderCache_.TimestampNs == curStamp) {
                return renderCache_;
            }

            std::lock_guard<SpinLock> lock(stateLock_);
            const int64_t freshVer = version_.load(std::memory_order_relaxed);
            if (renderCache_.Version != freshVer) {
                const auto& bids = orderBook_.GetBids();
                const auto& asks = orderBook_.GetAsks();

                renderCache_.Bids.clear();
                renderCache_.Asks.clear();
                renderCache_.BidsQuote.clear();
                renderCache_.AsksQuote.clear();

                renderCache_.Bids.reserve(bids.size());
                renderCache_.Asks.reserve(asks.size());
                renderCache_.BidsQuote.reserve(bids.size());
                renderCache_.AsksQuote.reserve(asks.size());

                for (const auto& b : bids) {
                    renderCache_.Bids.emplace_back(b.price, b.quantity);
                    renderCache_.BidsQuote.emplace_back(b.price, b.price * b.quantity);
                }
                for (const auto& a : asks) {
                    renderCache_.Asks.emplace_back(a.price, a.quantity);
                    renderCache_.AsksQuote.emplace_back(a.price, a.price * a.quantity);
                }

                renderCache_.Version = freshVer;
                renderCache_.TimestampNs = curStamp;
            }
            return renderCache_;
        }

        // Direct access to OrderBook (read-only)
        const Models::OrderBook& GetOrderBookDirect() const {
            return orderBook_;
        }

        void UpdateExternalMetrics(const ExternalMetricsSnapshot& snap) {
            exchLatencyNs_.store(snap.exchLatencyNs, std::memory_order_relaxed);
            netLatencyNs_.store(snap.netLatencyNs, std::memory_order_relaxed);
            enqueueLatencyNs_.store(snap.enqueueLatencyNs, std::memory_order_relaxed);
            parseLatencyNs_.store(snap.parseLatencyNs, std::memory_order_relaxed);
            processLatencyNs_.store(snap.processLatencyNs, std::memory_order_relaxed);
            callbackLatencyNs_.store(snap.callbackLatencyNs, std::memory_order_relaxed);
            procChainLatencyNs_.store(snap.procChainLatencyNs, std::memory_order_relaxed);
            endToEndP99Ns_.store(snap.endToEndP99Ns, std::memory_order_relaxed);
            messagesPerSecond_.store(snap.messagesPerSecond, std::memory_order_relaxed);
            droppedMessages_.store(snap.droppedMessages, std::memory_order_relaxed);
            queueHighWater_.store(snap.queueHighWater, std::memory_order_relaxed);
        }

        ExternalMetricsSnapshot GetExternalMetrics() const {
            ExternalMetricsSnapshot out;
            out.exchLatencyNs = exchLatencyNs_.load(std::memory_order_relaxed);
            out.netLatencyNs = netLatencyNs_.load(std::memory_order_relaxed);
            out.enqueueLatencyNs = enqueueLatencyNs_.load(std::memory_order_relaxed);
            out.parseLatencyNs = parseLatencyNs_.load(std::memory_order_relaxed);
            out.processLatencyNs = processLatencyNs_.load(std::memory_order_relaxed);
            out.callbackLatencyNs = callbackLatencyNs_.load(std::memory_order_relaxed);
            out.procChainLatencyNs = procChainLatencyNs_.load(std::memory_order_relaxed);
            out.endToEndP99Ns = endToEndP99Ns_.load(std::memory_order_relaxed);
            out.messagesPerSecond = messagesPerSecond_.load(std::memory_order_relaxed);
            out.droppedMessages = droppedMessages_.load(std::memory_order_relaxed);
            out.queueHighWater = queueHighWater_.load(std::memory_order_relaxed);
            return out;
        }

        void ResetOrderBook() {
            tempBids_.clear();
            tempAsks_.clear();
            {
                std::lock_guard<SpinLock> lock(stateLock_);
                orderBook_.ApplySnapshot(tempBids_, tempAsks_);
                version_.fetch_add(1, std::memory_order_release);
            }
        }

    private:
        struct SpinLock {
            std::atomic_flag flag = ATOMIC_FLAG_INIT;
            void lock() {
                while (flag.test_and_set(std::memory_order_acquire)) {
#ifdef _MSC_VER
                    _mm_pause();
#else
                    std::this_thread::yield();
#endif
                }
            }
            void unlock() { flag.clear(std::memory_order_release); }
        };

        SpinLock stateLock_;
        mutable SpinLock symbolLock_;

        // Current trading symbol
        std::string currentSymbol_{ "BTCUSDT" };

        // Optimized OrderBook (vector-based)
        Models::OrderBook orderBook_;

        // Metrics
        std::atomic<long long> lastLatencyMs_{ 0 };
        std::atomic<long long> latencyAvgMs_{ 0 };
        std::atomic<long long> lastAppliedMs_{ 0 };
        std::atomic<long long> lastAppliedSteadyNs_{ 0 };
        std::atomic<long long> stalenessAvgMs_{ 0 };

        // External latency/queue metrics (atomic, no locks)
        std::atomic<long long> exchLatencyNs_{0};
        std::atomic<long long> netLatencyNs_{0};
        std::atomic<long long> enqueueLatencyNs_{0};
        std::atomic<long long> parseLatencyNs_{0};
        std::atomic<long long> processLatencyNs_{0};
        std::atomic<long long> callbackLatencyNs_{0};
        std::atomic<long long> procChainLatencyNs_{0};
        std::atomic<long long> endToEndP99Ns_{0};
        std::atomic<long long> messagesPerSecond_{0};
        std::atomic<long long> droppedMessages_{0};
        std::atomic<size_t> queueHighWater_{0};

        // Pull-model versioning
        std::atomic<int64_t> version_{0};
        RenderSnapshot renderCache_;
        std::vector<Models::PriceLevel> tempBids_;
        std::vector<Models::PriceLevel> tempAsks_;
        std::atomic<int64_t> lastUpdateNs_{0};

        static int64_t HighResNowNs() {
            return std::chrono::duration_cast<std::chrono::nanoseconds>(
                std::chrono::steady_clock::now().time_since_epoch()).count();
        }
    };

} // namespace TradingBot::Core