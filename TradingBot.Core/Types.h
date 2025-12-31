#pragma once
#include <string>
#include <vector>
namespace TradingBot::Core {
    enum class MarketMode { SPOT, FUTURES };
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
    struct OrderBook {
        long long lastUpdateId;
        std::vector<OrderBookLevel> bids;
        std::vector<OrderBookLevel> asks;
    };
}