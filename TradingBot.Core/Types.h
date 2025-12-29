#pragma once
#include <vector>
#include <string>

namespace TradingBot::Core {

    // Базовая структура уровня цены
    struct OrderBookLevel {
        double price;
        double quantity;
    };

    // Структура для Снапшота (REST)
    struct OrderBookSnapshot {
        long long lastUpdateId;
        std::vector<OrderBookLevel> bids;
        std::vector<OrderBookLevel> asks;
    };

    // Структура для Обновления (WebSocket)
    // Именно на неё ругался компилятор (C2027), так как не видел её определения
    struct OrderBookUpdate {
        long long u; // Final update ID
        long long U; // First update ID
        std::vector<OrderBookLevel> bids;
        std::vector<OrderBookLevel> asks;
    };
}