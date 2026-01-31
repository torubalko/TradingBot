#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <algorithm>
#include <cmath>
#include <atomic>
#include <chrono>
#include <sstream>
#include <string_view>
#include <thread>
#include <immintrin.h>
#include <deque>
#include <array>

#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>
#include <processthreadsapi.h>
#endif

#include "Types.h"
#include "MarketDetails.h"
#include "OrderBook.h"
#include "RawOrderBook.h"
#include "UserStreamState.h"

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
    // Batch Update System - Tiger Architecture Enhancement
    // ═══════════════════════════════════════════════════════════════
    struct BatchUpdate {
        std::vector<Models::PriceLevel> bids;
        std::vector<Models::PriceLevel> asks;
        int64_t timestampNs{0};
        
        BatchUpdate() {
            bids.reserve(50);
            asks.reserve(50);
        }

    };

    struct BatchMetrics {
        std::atomic<int64_t> totalBatches{0};
        std::atomic<int64_t> messageFlushCount{0};
        std::atomic<int64_t> timeFlushCount{0};
        std::atomic<int64_t> priceFlushCount{0};
        std::atomic<int64_t> avgBatchSize{0};
        std::atomic<int64_t> maxBatchSize{0};
        std::atomic<int64_t> batchLatencyNs{0};
    };

    enum class FlushReason {
        MessageCount,
        TimeElapsed,
        BestPriceChange
    };

    // ═══════════════════════════════════════════════════════════════
    // SharedState: decoupled push/pull bridge between OrderBook and UI
    // ═══════════════════════════════════════════════════════════════
    class SharedState {
    public:
        MarketCache marketData;
        std::mutex instrumentsMutex;

        struct RawMetrics {
            double spread{0.0};
            double imbalance{0.0};
            double microprice{0.0};
            double mid{0.0};
            int64_t lastUpdateId{0};
        };

        SharedState() {
            // Initialize double buffers for lock-free UI reads
            renderStateA_ = std::make_shared<RenderSnapshot>();
            renderStateB_ = std::make_shared<RenderSnapshot>();
            
            renderStateA_->Bids.reserve(200);
            renderStateA_->Asks.reserve(200);
            renderStateA_->BidsQuote.reserve(200);
            renderStateA_->AsksQuote.reserve(200);

            renderStateB_->Bids.reserve(200);
            renderStateB_->Asks.reserve(200);
            renderStateB_->BidsQuote.reserve(200);
            renderStateB_->AsksQuote.reserve(200);

            // Set initial active buffer
            activeSnapshot_.store(renderStateA_, std::memory_order_release);
            
            tempBids_.reserve(200);
            tempAsks_.reserve(200);
            
            // Initialize batch system
            batchBuffer_.bids.reserve(500);
            batchBuffer_.asks.reserve(500);
            lastBatchFlushNs_.store(HighResNowNs(), std::memory_order_relaxed);
            
            // Initialize best prices
            lastBestBid_.store(0.0, std::memory_order_relaxed);
            lastBestAsk_.store(0.0, std::memory_order_relaxed);
        }

        // ═══════════════════════════════════════════════════════════════
        // User-stream (positions)
        // ═══════════════════════════════════════════════════════════════
        void ApplyUserStreamPayload(std::string_view payload) {
            userStreamState_.ApplyPayload(payload);
        }

        const UserStreamState& GetUserStreamState() const {
            return userStreamState_;
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
        // BATCH UPDATE SYSTEM - High-Performance Batching
        // ═══════════════════════════════════════════════════════════════

        void BatchUpdate(const std::vector<OrderBookLevel>& bids,
                        const std::vector<OrderBookLevel>& asks) {
            std::lock_guard<SpinLock> lock(batchLock_);
            
            // Add to batch buffer
            for (const auto& level : bids) {
                batchBuffer_.bids.push_back({level.price, level.quantity});
            }
            for (const auto& level : asks) {
                batchBuffer_.asks.push_back({level.price, level.quantity});
            }
            
            batchMessageCount_.fetch_add(1, std::memory_order_relaxed);
            
            // Check flush conditions
            bool shouldFlush = false;
            FlushReason reason = FlushReason::MessageCount;
            
            // 1. Message count trigger (10 messages)
            if (batchMessageCount_.load(std::memory_order_relaxed) >= kBatchMessageThreshold) {
                shouldFlush = true;
                reason = FlushReason::MessageCount;
            }
            
            // 2. Time-based trigger (5ms)
            int64_t nowNs = HighResNowNs();
            int64_t lastFlush = lastBatchFlushNs_.load(std::memory_order_relaxed);
            if ((nowNs - lastFlush) >= kBatchTimeThresholdNs) {
                shouldFlush = true;
                reason = FlushReason::TimeElapsed;
            }
            
            // 3. Best price change trigger (priority flush)
            if (!bids.empty() || !asks.empty()) {
                double newBestBid = bids.empty() ? lastBestBid_.load(std::memory_order_relaxed) : bids[0].price;
                double newBestAsk = asks.empty() ? lastBestAsk_.load(std::memory_order_relaxed) : asks[0].price;
                
                double oldBestBid = lastBestBid_.load(std::memory_order_relaxed);
                double oldBestAsk = lastBestAsk_.load(std::memory_order_relaxed);
                
                if (std::abs(newBestBid - oldBestBid) > 1e-9 || 
                    std::abs(newBestAsk - oldBestAsk) > 1e-9) {
                    shouldFlush = true;
                    reason = FlushReason::BestPriceChange;
                    
                    lastBestBid_.store(newBestBid, std::memory_order_relaxed);
                    lastBestAsk_.store(newBestAsk, std::memory_order_relaxed);
                }
            }
            
            if (shouldFlush) {
                FlushBatchLocked(reason);
            }
        }

        void ForceFlushBatch() {
            std::lock_guard<SpinLock> lock(batchLock_);
            FlushBatchLocked(FlushReason::MessageCount);
        }

        void GetBatchMetrics(TradingBot::Core::BatchMetrics& out) const {
            out.totalBatches.store(batchMetrics_.totalBatches.load(std::memory_order_relaxed), std::memory_order_relaxed);
            out.messageFlushCount.store(batchMetrics_.messageFlushCount.load(std::memory_order_relaxed), std::memory_order_relaxed);
            out.timeFlushCount.store(batchMetrics_.timeFlushCount.load(std::memory_order_relaxed), std::memory_order_relaxed);
            out.priceFlushCount.store(batchMetrics_.priceFlushCount.load(std::memory_order_relaxed), std::memory_order_relaxed);
            out.avgBatchSize.store(batchMetrics_.avgBatchSize.load(std::memory_order_relaxed), std::memory_order_relaxed);
            out.maxBatchSize.store(batchMetrics_.maxBatchSize.load(std::memory_order_relaxed), std::memory_order_relaxed);
            out.batchLatencyNs.store(batchMetrics_.batchLatencyNs.load(std::memory_order_relaxed), std::memory_order_relaxed);
        }
        void ApplySnapshot(const std::vector<OrderBookLevel>& bids,
                           const std::vector<OrderBookLevel>& asks) {
            tempBids_.clear();
            tempAsks_.clear();
            tempBids_.reserve(bids.size());
            tempAsks_.reserve(asks.size());

            for (const auto& level : bids) tempBids_.push_back({ level.price, level.quantity });
            for (const auto& level : asks) tempAsks_.push_back({ level.price, level.quantity });

            // Update OrderBook - NO render snapshot copy!
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

            // Update OrderBook - NO render snapshot copy!
            {
                std::lock_guard<SpinLock> lock(stateLock_);
                orderBook_.ApplyUpdate(tempBids_, tempAsks_);
                version_.fetch_add(1, std::memory_order_release);
                lastUpdateNs_.store(HighResNowNs(), std::memory_order_release);
            }
            
            SetAppliedNow();
        }

        // ═══════════════════════════════════════════════════════════════
        // ULTRA LOW LATENCY: Direct Update Path - ZERO COPY
        // Data from Binance is ALREADY SORTED - no need to sort again!
        // ═══════════════════════════════════════════════════════════════
        void ApplyUpdateDirect(const std::vector<OrderBookLevel>& bids,
                               const std::vector<OrderBookLevel>& asks) {
            // CRITICAL: Minimal lock scope for maximum throughput
            {
                std::lock_guard<SpinLock> lock(stateLock_);
                
                // Direct application - data is pre-sorted from Binance
                // Use fast incremental update (no sorting, no copying)
                for (const auto& level : bids) {
                    if (level.quantity < 1e-8) {
                        orderBook_.RemoveBidDirect(level.price);
                    } else {
                        orderBook_.UpsertBidDirect(level.price, level.quantity);
                    }
                }
                
                for (const auto& level : asks) {
                    if (level.quantity < 1e-8) {
                        orderBook_.RemoveAskDirect(level.price);
                    } else {
                        orderBook_.UpsertAskDirect(level.price, level.quantity);
                    }
                }
                
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
        // Pull-based rendering snapshot - UI pulls when needed (PULL MODEL)
        // Throttling happens in OrderBookRenderer, not here!
        // ═══════════════════════════════════════════════════════════════
        RenderSnapshot GetSnapshotForRender(int /*depth*/, double /*priceStep*/) {
            // Check version first (lock-free)
            const int64_t currentVersion = version_.load(std::memory_order_acquire);
            auto currentActive = activeSnapshot_.load(std::memory_order_acquire);
            
            // If already up-to-date, return cached snapshot (NO LOCK!)
            if (currentActive && currentActive->Version == currentVersion) {
                return *currentActive;
            }
            
            // Need fresh snapshot - copy ALL levels from OrderBook
            auto backBuffer = (currentActive == renderStateA_) ? renderStateB_ : renderStateA_;
            
            {
                std::lock_guard<SpinLock> lock(stateLock_);
                const auto& bids = orderBook_.GetBids();
                const auto& asks = orderBook_.GetAsks();

                backBuffer->Bids.clear();
                backBuffer->Asks.clear();
                backBuffer->BidsQuote.clear();
                backBuffer->AsksQuote.clear();

                backBuffer->Bids.reserve(bids.size());
                backBuffer->Asks.reserve(asks.size());
                backBuffer->BidsQuote.reserve(bids.size());
                backBuffer->AsksQuote.reserve(asks.size());

                // Copy ALL levels - no compromises!
                for (const auto& b : bids) {
                    backBuffer->Bids.emplace_back(b.price, b.quantity);
                    backBuffer->BidsQuote.emplace_back(b.price, b.price * b.quantity);
                }
                for (const auto& a : asks) {
                    backBuffer->Asks.emplace_back(a.price, a.quantity);
                    backBuffer->AsksQuote.emplace_back(a.price, a.price * a.quantity);
                }

                backBuffer->Version = currentVersion;
                backBuffer->TimestampNs = lastUpdateNs_.load(std::memory_order_relaxed);
            }
            
            // Atomic swap
            activeSnapshot_.store(backBuffer, std::memory_order_release);
            return *backBuffer;
        }

        // Direct access to OrderBook (read-only)
        const Models::OrderBook& GetOrderBookDirect() const {
            return orderBook_;
        }

        // ═══════════════════════════════════════════════════════════════
        // FAST PATH: BookTicker updates (fastest price source!)
        // These come from @bookTicker stream - instant updates on best price change
        // ═══════════════════════════════════════════════════════════════
        void UpdateBestPrices(double bidPrice, double bidQty, double askPrice, double askQty) {
            tickerBestBid_.store(bidPrice, std::memory_order_release);
            tickerBestBidQty_.store(bidQty, std::memory_order_relaxed);
            tickerBestAsk_.store(askPrice, std::memory_order_release);
            tickerBestAskQty_.store(askQty, std::memory_order_relaxed);
            tickerVersion_.fetch_add(1, std::memory_order_release);
            SetAppliedNow();
        }
        
        // Get best prices from bookTicker (faster than orderbook)
        double GetTickerBestBid() const { return tickerBestBid_.load(std::memory_order_acquire); }
        double GetTickerBestAsk() const { return tickerBestAsk_.load(std::memory_order_acquire); }
        double GetTickerBestBidQty() const { return tickerBestBidQty_.load(std::memory_order_relaxed); }
        double GetTickerBestAskQty() const { return tickerBestAskQty_.load(std::memory_order_relaxed); }
        int64_t GetTickerVersion() const { return tickerVersion_.load(std::memory_order_acquire); }

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
            // No render snapshot update - UI will pull when needed
        }

        // ═══════════════════════════════════════════════════════════════
        // Tiger RAW BOOK (fixed arrays, zero alloc) - separate path
        // ═══════════════════════════════════════════════════════════════
        void ApplyRawSnapshot(int64_t lastUpdateId,
                               const Raw::Level* bids, int bidCount,
                               const Raw::Level* asks, int askCount) {
            rawBook_.ApplySnapshot(lastUpdateId, bids, bidCount, asks, askCount);
            rawSnapshotPtr_.store(rawBook_.SnapshotPtr(), std::memory_order_release);
        }

        bool ApplyRawDelta(int64_t U, int64_t u,
                            const Raw::Level* bids, int bidCount,
                            const Raw::Level* asks, int askCount) {
            bool ok = rawBook_.ApplyDelta(U, u, bids, bidCount, asks, askCount);
            if (ok) {
                rawSnapshotPtr_.store(rawBook_.SnapshotPtr(), std::memory_order_release);
            }
            return ok;
        }

        Raw::SnapshotView GetRawSnapshot() const {
            const Raw::BookState* ptr = rawSnapshotPtr_.load(std::memory_order_acquire);
            if (!ptr) {
                Raw::SnapshotView empty{};
                empty.bids = nullptr;
                empty.asks = nullptr;
                empty.lastUpdateId = 0;
                return empty;
            }
            return Raw::SnapshotView{ &ptr->bids, &ptr->asks, ptr->lastUpdateId };
        }

        // Core metrics from RAW snapshot (spread, imbalance, microprice)
        RawMetrics GetRawMetrics(int depthLevels) const {
            RawMetrics m{};
            auto snap = GetRawSnapshot();
            const auto* bids = snap.bids;
            const auto* asks = snap.asks;
            if (!bids || !asks || bids->size == 0 || asks->size == 0) return m;

            const int depth = depthLevels > 0 ? depthLevels : 1;
            const int bidDepth = (bids->size < depth) ? bids->size : depth;
            const int askDepth = (asks->size < depth) ? asks->size : depth;

            double bestBidP = bids->levels[0].price;
            double bestBidQ = bids->levels[0].qty;
            double bestAskP = asks->levels[0].price;
            double bestAskQ = asks->levels[0].qty;

            m.spread = bestAskP - bestBidP;
            m.mid = (bestBidP + bestAskP) * 0.5;

            double bidSum = 0.0;
            double askSum = 0.0;
            for (int i = 0; i < bidDepth; ++i) bidSum += bids->levels[i].qty;
            for (int i = 0; i < askDepth; ++i) askSum += asks->levels[i].qty;
            double total = bidSum + askSum;
            if (total > 1e-12) {
                m.imbalance = bidSum / total;
            }

            double denom = bestBidQ + bestAskQ;
            if (denom > 1e-12) {
                m.microprice = (bestBidP * bestAskQ + bestAskP * bestBidQ) / denom;
            } else {
                m.microprice = m.mid;
            }
            m.lastUpdateId = snap.lastUpdateId;
            return m;
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

        // ═══════════════════════════════════════════════════════════════
        // Batch Processing - Private Implementation
        // ═══════════════════════════════════════════════════════════════
        void FlushBatchLocked(FlushReason reason) {
            // Must be called with batchLock_ held!
            if (batchBuffer_.bids.empty() && batchBuffer_.asks.empty()) {
                return;
            }
            
            const auto flushStart = HighResNowNs();
            const size_t batchSize = batchBuffer_.bids.size() + batchBuffer_.asks.size();
            
            // Apply merged updates using optimized sorted merge
            {
                std::lock_guard<SpinLock> lock(stateLock_);
                
                // Use sorted merge instead of incremental binary search + insert
                ApplyBatchOptimized(batchBuffer_.bids, batchBuffer_.asks);
                
                version_.fetch_add(1, std::memory_order_release);
                lastUpdateNs_.store(HighResNowNs(), std::memory_order_release);
            }
            
            // Clear batch
            batchBuffer_.bids.clear();
            batchBuffer_.asks.clear();
            batchMessageCount_.store(0, std::memory_order_relaxed);
            lastBatchFlushNs_.store(HighResNowNs(), std::memory_order_relaxed);
            
            // Update metrics
            batchMetrics_.totalBatches.fetch_add(1, std::memory_order_relaxed);
            
            switch (reason) {
                case FlushReason::MessageCount:
                    batchMetrics_.messageFlushCount.fetch_add(1, std::memory_order_relaxed);
                    break;
                case FlushReason::TimeElapsed:
                    batchMetrics_.timeFlushCount.fetch_add(1, std::memory_order_relaxed);
                    break;
                case FlushReason::BestPriceChange:
                    batchMetrics_.priceFlushCount.fetch_add(1, std::memory_order_relaxed);
                    break;
            }
            
            // Update batch size stats
            int64_t oldMax = batchMetrics_.maxBatchSize.load(std::memory_order_relaxed);
            if (static_cast<int64_t>(batchSize) > oldMax) {
                batchMetrics_.maxBatchSize.store(batchSize, std::memory_order_relaxed);
            }
            
            int64_t oldAvg = batchMetrics_.avgBatchSize.load(std::memory_order_relaxed);
            int64_t newAvg = oldAvg + ((static_cast<int64_t>(batchSize) - oldAvg) / 8);
            batchMetrics_.avgBatchSize.store(newAvg, std::memory_order_relaxed);
            
            const auto flushEnd = HighResNowNs();
            batchMetrics_.batchLatencyNs.store(flushEnd - flushStart, std::memory_order_relaxed);
            
            SetAppliedNow();
        }

        // Optimized batch application using sorted merge
        void ApplyBatchOptimized(const std::vector<Models::PriceLevel>& bids,
                                const std::vector<Models::PriceLevel>& asks) {
            // Pre-sort batch updates by price
            auto sortedBids = bids;
            auto sortedAsks = asks;
            
            // Sort bids descending (highest price first)
            std::sort(sortedBids.begin(), sortedBids.end(),
                [](const auto& a, const auto& b) { return a.price > b.price; });
            
            // Sort asks ascending (lowest price first)
            std::sort(sortedAsks.begin(), sortedAsks.end(),
                [](const auto& a, const auto& b) { return a.price < b.price; });
            
            // Merge updates efficiently
            orderBook_.ApplyBatchUpdate(sortedBids, sortedAsks);
        }

        // ═══════════════════════════════════════════════════════════════
        // Data Members
        // ═══════════════════════════════════════════════════════════════

        SpinLock stateLock_;
        mutable SpinLock symbolLock_;
        SpinLock batchLock_;  // Separate lock for batch buffer

        // Current trading symbol
        std::string currentSymbol_{ "BTCUSDT" };

        // Core OrderBook (protected by stateLock_)
        Models::OrderBook orderBook_;

        // Tiger RAW order book (single-writer) with atomic snapshot pointer
        Raw::RawOrderBook rawBook_;
        std::atomic<const Raw::BookState*> rawSnapshotPtr_{ nullptr };

        // ═══════════════════════════════════════════════════════════════
        // DOUBLE BUFFERING for ZERO-LOCK UI reads
        // ═══════════════════════════════════════════════════════════════
        std::shared_ptr<RenderSnapshot> renderStateA_;
        std::shared_ptr<RenderSnapshot> renderStateB_;
        std::atomic<std::shared_ptr<const RenderSnapshot>> activeSnapshot_;

        // ═══════════════════════════════════════════════════════════════
        // BATCH PROCESSING STATE
        // ═══════════════════════════════════════════════════════════════
        TradingBot::Core::BatchUpdate batchBuffer_;
        std::atomic<int> batchMessageCount_{0};
        std::atomic<int64_t> lastBatchFlushNs_{0};
        std::atomic<double> lastBestBid_{0.0};
        std::atomic<double> lastBestAsk_{0.0};
        TradingBot::Core::BatchMetrics batchMetrics_;
        
        // Batch configuration
        static constexpr int kBatchMessageThreshold = 10;
        static constexpr int64_t kBatchTimeThresholdNs = 5'000'000; // 5ms

        // ═══════════════════════════════════════════════════════════════
        // BOOK TICKER - Fastest price source (real-time best bid/ask)
        // ═══════════════════════════════════════════════════════════════
        std::atomic<double> tickerBestBid_{0.0};
        std::atomic<double> tickerBestBidQty_{0.0};
        std::atomic<double> tickerBestAsk_{0.0};
        std::atomic<double> tickerBestAskQty_{0.0};
        std::atomic<int64_t> tickerVersion_{0};

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
        std::vector<Models::PriceLevel> tempBids_;
        std::vector<Models::PriceLevel> tempAsks_;
        std::atomic<int64_t> lastUpdateNs_{0};

        UserStreamState userStreamState_;

        static int64_t HighResNowNs() {
            return std::chrono::duration_cast<std::chrono::nanoseconds>(
                std::chrono::steady_clock::now().time_since_epoch()).count();
        }
    };

} // namespace TradingBot::Core