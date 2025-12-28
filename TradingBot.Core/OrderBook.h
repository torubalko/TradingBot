#pragma once
#include <vector>
#include <map>

namespace TradingBot::Core::Models {

    struct OrderBookLevel {
        double price = 0.0;     // <-- Добавили = 0.0
        double quantity = 0.0;  // <-- Добавили = 0.0
    };

    struct OrderBookUpdate {
        std::vector<OrderBookLevel> bids;
        std::vector<OrderBookLevel> asks;
    };

    struct OrderBookSnapshot {
        long long lastUpdateId = 0; // <-- ИСПРАВЛЕНИЕ: Добавили = 0
        std::vector<OrderBookLevel> bids;
        std::vector<OrderBookLevel> asks;
    };

    class OrderBook {
    public:
        std::map<double, double> bids;
        std::map<double, double> asks;

        void ApplyUpdate(const OrderBookUpdate& update) {
            for (const auto& level : update.bids) {
                if (level.quantity == 0) bids.erase(level.price);
                else bids[level.price] = level.quantity;
            }
            for (const auto& level : update.asks) {
                if (level.quantity == 0) asks.erase(level.price);
                else asks[level.price] = level.quantity;
            }
        }

        void SetSnapshot(const OrderBookSnapshot& snap) {
            bids.clear();
            asks.clear();
            for (const auto& level : snap.bids) bids[level.price] = level.quantity;
            for (const auto& level : snap.asks) asks[level.price] = level.quantity;
        }
    };
}