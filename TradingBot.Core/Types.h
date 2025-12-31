#pragma once
#include <string>
#include <vector>

namespace TradingBot::Core {

    // Режим рынка
    enum class MarketMode {
        SPOT,
        FUTURES
    };

    struct SymbolInfo {
        std::string symbol;
        double tickSize;
        int pricePrecision;
        double stepSize;
        std::string quoteAsset;
    };

    struct Trade {
        long id;
        double price;
        double quantity;
        bool isBuyerMaker;
        long long timestamp;
    };

    struct OrderBookLevel {
        double price;
        double quantity;
    };

    // Полный снимок стакана (Snapshot)
    struct OrderBook {
        long long lastUpdateId;
        std::vector<OrderBookLevel> bids;
        std::vector<OrderBookLevel> asks;
    };

    // Обновление стакана (Delta)
    struct OrderBookUpdate {
        long long U; // First update ID
        long long u; // Final update ID
        long long pu; // Previous final update ID (важно для синхронизации)
        std::vector<OrderBookLevel> bids;
        std::vector<OrderBookLevel> asks;
    };
}