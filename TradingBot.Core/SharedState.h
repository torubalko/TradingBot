#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <deque>
#include <algorithm>
#include <cmath>
#include "Types.h"
#include "OrderBook.h"
namespace TradingBot::Core {
    struct RenderSnapshot {
        std::vector<std::pair<double, double>> Bids;
        std::vector<std::pair<double, double>> Asks;
        std::vector<Trade> RecentTrades;
        SymbolInfo CurrentSymbolInfo;
    };
    class SharedState {
    public:
        std::vector<SymbolInfo> availableSymbols;
        SymbolInfo currentSymbol;
        MarketMode currentMode = MarketMode::FUTURES;
        SharedState() {
            currentSymbol = { "BTCUSDT", 0.1, 1, 0.001, "USDT" };
        }
        void SetSnapshot(const Models::OrderBookSnapshot& snap) {
            std::lock_guard<std::mutex> lock(mutex_);
            Bids.clear();
            Asks.clear();
            for (const auto& level : snap.bids) Bids[level.price] = level.quantity;
            for (const auto& level : snap.asks) Asks[level.price] = level.quantity;
        }
        void ApplyUpdate(const Models::OrderBookUpdate& update) {
            std::lock_guard<std::mutex> lock(mutex_);
            double epsilon = 0.0000001;
            for (const auto& level : update.bids) {
                if (level.quantity < epsilon) Bids.erase(level.price);
                else Bids[level.price] = level.quantity;
            }
            for (const auto& level : update.asks) {
                if (level.quantity < epsilon) Asks.erase(level.price);
                else Asks[level.price] = level.quantity;
            }
        }
        void AddTrade(const Trade& trade) {
            std::lock_guard<std::mutex> lock(mutex_);
            trades_.push_back(trade);
            if (trades_.size() > 150) trades_.pop_front();
        }
        RenderSnapshot GetSnapshotForRender(int depth, double priceStep) {
            std::lock_guard<std::mutex> lock(mutex_);
            RenderSnapshot snap;
            snap.CurrentSymbolInfo = currentSymbol;
            std::map<double, double> aggBids, aggAsks;
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
            double gridAsk = std::ceil(bestAsk / priceStep - 0.000001) * priceStep;
            double gridBid = std::floor(bestBid / priceStep + 0.000001) * priceStep;
            if (gridAsk <= gridBid) gridAsk = gridBid + priceStep;
            for (int i = 0; i < depth; i++) {
                double price = gridAsk + (i * priceStep);
                double vol = aggAsks.count(price) ? aggAsks[price] : 0;
                snap.Asks.push_back({ price, vol });
            }
            for (int i = 0; i < depth; i++) {
                double price = gridBid - (i * priceStep);
                double vol = aggBids.count(price) ? aggBids[price] : 0;
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