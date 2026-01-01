#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <deque>
#include <algorithm>
#include <cmath>

#include "Types.h"
#include "MarketDetails.h" 
#include "OrderBook.h"     

namespace TradingBot::Core {

    struct RenderSnapshot {
        std::vector<std::pair<double, double>> Bids;
        std::vector<std::pair<double, double>> Asks;
        std::vector<Trade> RecentTrades;
    };

    class SharedState {
    public:
        MarketCache marketData;
        std::mutex instrumentsMutex;

    public:
        // <--- ГЛАВНОЕ ИСПРАВЛЕНИЕ: Полная очистка памяти --->
        void Clear() {
            std::lock_guard<std::mutex> lock(mutex_);
            Bids.clear();
            Asks.clear();
            trades_.clear();
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

        void AddTrade(const Trade& trade) {
            std::lock_guard<std::mutex> lock(mutex_);
            trades_.push_back(trade);
            if (trades_.size() > 1000) trades_.pop_front(); // Храним больше истории
        }

        RenderSnapshot GetSnapshotForRender(int depth, double priceStep) {
            std::lock_guard<std::mutex> lock(mutex_);
            RenderSnapshot snap;

            // Если стакан пуст или шаг цены некорректен - выход
            if (Asks.empty() && Bids.empty()) return snap;
            if (priceStep <= 0.00000001) return snap;

            std::map<double, double> aggBids;
            std::map<double, double> aggAsks;

            // Агрегация данных под текущий масштаб
            for (auto const& [price, qty] : Asks) {
                double key = std::ceil(price / priceStep - 0.000001) * priceStep;
                if (key == -0.0) key = 0.0;
                aggAsks[key] += qty;
            }
            for (auto const& [price, qty] : Bids) {
                double key = std::floor(price / priceStep + 0.000001) * priceStep;
                aggBids[key] += qty;
            }

            double bestAsk = Asks.empty() ? 0 : Asks.begin()->first;
            double bestBid = Bids.empty() ? 0 : Bids.rbegin()->first;

            if (bestAsk <= 0 || bestBid <= 0) return snap;

            double gridAsk = std::ceil(bestAsk / priceStep - 0.000001) * priceStep;
            double gridBid = std::floor(bestBid / priceStep + 0.000001) * priceStep;

            // Защита от перекрытия спреда
            if (gridAsk <= gridBid) gridAsk = gridBid + priceStep;

            for (int i = 0; i < depth; i++) {
                double price = gridAsk + (i * priceStep);
                double vol = 0;
                auto it = aggAsks.lower_bound(price - 0.00001);
                if (it != aggAsks.end() && std::abs(it->first - price) < 0.00001) vol = it->second;
                snap.Asks.push_back({ price, vol });
            }

            for (int i = 0; i < depth; i++) {
                double price = gridBid - (i * priceStep);
                double vol = 0;
                auto it = aggBids.lower_bound(price - 0.00001);
                if (it != aggBids.end() && std::abs(it->first - price) < 0.00001) vol = it->second;
                snap.Bids.push_back({ price, vol });
            }

            snap.RecentTrades.assign(trades_.begin(), trades_.end());
            return snap;
        }

    private:
        std::mutex mutex_;
        std::map<double, double> Bids;
        std::map<double, double> Asks;
        std::deque<Trade> trades_;
    };
}