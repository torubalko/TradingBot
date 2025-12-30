#pragma once
#include <string>
#include <vector>

namespace TradingBot::Core {

    // Режим торговли: Спот или Фьючерсы
    enum class MarketMode {
        SPOT,
        FUTURES
    };

    // Данные о торговой паре (из ExchangeInfo)
    struct SymbolInfo {
        std::string symbol;      // BTCUSDT
        double tickSize;         // 0.01
        int pricePrecision;      // 2 (кол-во знаков)
        double stepSize;         // 0.001 (шаг объема)
        std::string quoteAsset;  // USDT
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