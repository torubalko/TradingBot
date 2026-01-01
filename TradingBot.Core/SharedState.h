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

            // Устойчивое «привязывание к сетке»: работаем через целочисленные бакеты,
            // чтобы избежать дрейфа double при маленьком tickSize.
            auto bucketFloor = [priceStep](double price) -> long long {
                return static_cast<long long>(std::floor(price / priceStep + 1e-9));
            };
            auto bucketCeil = [priceStep](double price) -> long long {
                return static_cast<long long>(std::ceil(price / priceStep - 1e-9));
            };
            auto bucketToPrice = [priceStep](long long bucket) -> double {
                return static_cast<double>(bucket) * priceStep;
            };

            std::map<long long, double> aggBids;
            std::map<long long, double> aggAsks;

            for (auto const& [price, qty] : Asks) {
                aggAsks[bucketCeil(price)] += qty;
            }
            for (auto const& [price, qty] : Bids) {
                aggBids[bucketFloor(price)] += qty;
            }

            double bestAsk = Asks.empty() ? 0 : Asks.begin()->first;
            double bestBid = Bids.empty() ? 0 : Bids.rbegin()->first;

            if (bestAsk <= 0 || bestBid <= 0) return snap;

            long long gridAskBucket = bucketCeil(bestAsk);
            long long gridBidBucket = bucketFloor(bestBid);

            // «Разрыв» между сеточными bestBid/bestAsk должен быть минимум 1 шаг
            if (gridAskBucket <= gridBidBucket)
                gridAskBucket = gridBidBucket + 1;

            for (int i = 0; i < depth; i++) {
                long long bucket = gridAskBucket + i;
                double price = bucketToPrice(bucket);
                double vol = 0.0;
                auto it = aggAsks.find(bucket);
                if (it != aggAsks.end()) vol = it->second;
                snap.Asks.push_back({ price, vol });
            }

            for (int i = 0; i < depth; i++) {
                long long bucket = gridBidBucket - i;
                double price = bucketToPrice(bucket);
                double vol = 0.0;
                auto it = aggBids.find(bucket);
                if (it != aggBids.end()) vol = it->second;
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