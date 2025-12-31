#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <deque>
#include <algorithm>
#include <cmath>
#include "Types.h" 

namespace TradingBot::Core {

    // Снимок данных для отрисовки (готовый к употреблению UI-потоком)
    struct RenderSnapshot {
        std::vector<std::pair<double, double>> Bids;
        std::vector<std::pair<double, double>> Asks;
        std::vector<Trade> RecentTrades;
        SymbolInfo CurrentSymbolInfo;
    };

    class SharedState {
    public:
        // --- Поля для управления символом ---
        std::vector<SymbolInfo> availableSymbols;
        SymbolInfo currentSymbol;
        MarketMode currentMode = MarketMode::FUTURES;

        SharedState() {
            // Дефолтная инициализация, чтобы UI не падал до подключения
            currentSymbol = { "BTCUSDT", 0.1, 1, 0.001, "USDT" };
        }

        // 1. Установка полного снимка (Snapshot) - очищает старые данные
        void SetSnapshot(const OrderBook& snapshot) {
            std::lock_guard<std::mutex> lock(mutex_);
            Bids.clear();
            Asks.clear();

            for (const auto& level : snapshot.bids) {
                Bids[level.price] = level.quantity;
            }
            for (const auto& level : snapshot.asks) {
                Asks[level.price] = level.quantity;
            }
        }

        // 2. Применение изменений (Delta)
        void ApplyUpdate(const OrderBookUpdate& update) {
            std::lock_guard<std::mutex> lock(mutex_);
            double epsilon = 1e-9; // Чуть надежнее, чем 0.0000001

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

            // Агрегация стакана
            std::map<double, double> aggBids;
            std::map<double, double> aggAsks;

            // Округление зависит от точности цены (priceStep)
            // Добавляем epsilon при делении, чтобы избежать float-ошибок на границах
            for (auto const& [price, qty] : Asks) {
                double key = std::ceil(price / priceStep - 1e-9) * priceStep;
                if (key == -0.0) key = 0.0;
                aggAsks[key] += qty;
            }
            for (auto const& [price, qty] : Bids) {
                double key = std::floor(price / priceStep + 1e-9) * priceStep;
                aggBids[key] += qty;
            }

            double bestAsk = Asks.empty() ? 0 : Asks.begin()->first;
            double bestBid = Bids.empty() ? 0 : Bids.rbegin()->first;

            // Если стакан пуст, берем заглушки, чтобы не крашнулось
            if (bestAsk == 0) bestAsk = currentSymbol.tickSize;
            if (bestBid == 0) bestBid = currentSymbol.tickSize;

            double gridAsk = std::ceil(bestAsk / priceStep - 1e-9) * priceStep;
            double gridBid = std::floor(bestBid / priceStep + 1e-9) * priceStep;

            if (gridAsk <= gridBid) gridAsk = gridBid + priceStep;

            // Формируем Asks (цена растет)
            for (int i = 0; i < depth; i++) {
                double price = gridAsk + (i * priceStep);
                double vol = 0;
                auto it = aggAsks.lower_bound(price - 1e-9);
                if (it != aggAsks.end() && std::abs(it->first - price) < 1e-9) vol = it->second;
                snap.Asks.push_back({ price, vol });
            }

            // Формируем Bids (цена падает)
            for (int i = 0; i < depth; i++) {
                double price = gridBid - (i * priceStep);
                double vol = 0;
                auto it = aggBids.lower_bound(price - 1e-9);
                if (it != aggBids.end() && std::abs(it->first - price) < 1e-9) vol = it->second;
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