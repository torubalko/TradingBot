#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <algorithm>
#include <cmath>
#include <atomic>
#include <chrono>
#include <sstream>

#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN
#define NOMINMAX  // ← КРИТИЧНО! Предотвращает конфликт min/max макросов
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
    // SharedState: Bridge mellan новом OrderBook и старом UI
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
        // Symbol Management
        // ═══════════════════════════════════════════════════════════════
        void SetSymbol(const std::string& symbol) {
            std::lock_guard<std::mutex> lock(symbolMutex_);
            currentSymbol_ = symbol;
        }

        std::string GetSymbol() const {
            std::lock_guard<std::mutex> lock(symbolMutex_);
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
        // NEW: Применение снэпшота (snapshot from REST API)
        // ОТЛИЧАЕТСЯ от ApplyUpdate - заменяет ВЕСЬ Order Book
        // ═══════════════════════════════════════════════════════════
        void ApplySnapshot(const std::vector<OrderBookLevel>& bids,
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

            // Применяем snapshot (заменяет ВСЁ + сортирует)
            orderBook_.ApplySnapshot(bidLevels, askLevels);
            
            // Немедленно публикуем
            PublishCurrentOrderBook();
        }

        // ═══════════════════════════════════════════════════════════
        // NEW: Применение обновлений к OrderBook (std::vector based)
        // Вызывается из BinanceConnector для DIFF updates
        // ОПТИМИЗИРОВАНО: Минимальное логирование для низкой latency
        // ═══════════════════════════════════════════════════════════
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
            
            // Немедленно публикуем snapshot для UI!
            PublishCurrentOrderBook();
            
            // DEBUG: Логирование ТОЛЬКО каждые 500 обновлений (было 100)
            static std::atomic<int> updateCount{0};
            int count = updateCount.fetch_add(1, std::memory_order_relaxed);
            
            if (count % 500 == 0) {
                const auto& currentBids = orderBook_.GetBids();
                const auto& currentAsks = orderBook_.GetAsks();
                
                std::ostringstream oss;
                oss << "[SharedState] Update #" << count 
                    << " | OB: bids=" << currentBids.size() 
                    << " asks=" << currentAsks.size();
                
                if (!currentBids.empty() && !currentAsks.empty()) {
                    double spread = currentAsks[0].price - currentBids[0].price;
                    double spreadPct = (spread / currentBids[0].price) * 100.0;
                    oss << " | Best: " << currentBids[0].price 
                        << " / " << currentAsks[0].price 
                        << " (spread: " << spread << " / " << spreadPct << "%)";
                }
                
                OutputDebugStringA(oss.str().c_str());
                OutputDebugStringA("\n");
            }
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

    private:
        std::mutex mutex_;
        mutable std::mutex symbolMutex_;

        // Current trading symbol
        std::string currentSymbol_{ "BTCUSDT" };

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

        // ═══════════════════════════════════════════════════════════
        // Публикация текущего Order Book в double buffer для UI
        // ═══════════════════════════════════════════════════════════
        void PublishCurrentOrderBook() {
            // Вызывается УЖЕ под mutex_, поэтому безопасно
            
            RenderSnapshot snapshot;
            
            const auto& bids = orderBook_.GetBids();
            const auto& asks = orderBook_.GetAsks();
            
            constexpr int MAX_LEVELS = 50;
            int bidCount = (std::min)((int)bids.size(), MAX_LEVELS);
            int askCount = (std::min)((int)asks.size(), MAX_LEVELS);
            
            snapshot.Bids.reserve(bidCount);
            snapshot.Asks.reserve(askCount);
            
            for (int i = 0; i < bidCount; ++i) {
                snapshot.Bids.emplace_back(bids[i].price, bids[i].quantity);
            }
            
            for (int i = 0; i < askCount; ++i) {
                snapshot.Asks.emplace_back(asks[i].price, asks[i].quantity);
            }
            
            // Атомарная публикация в double buffer
            int next = 1 - publishedIndex_.load(std::memory_order_relaxed);
            published_[next] = std::move(snapshot);
            publishedIndex_.store(next, std::memory_order_release);
        }
    };

} // namespace TradingBot::Core