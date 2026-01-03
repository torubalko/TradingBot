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
    struct OrderBookUpdate {
        long long u; // Final update ID
        long long U; // First update ID
        long long pu; // Previous final update ID (Binance futures depth)
        long long E; // Event time
        std::vector<OrderBookLevel> bids;
        std::vector<OrderBookLevel> asks;
    };

    // --- НОВОЕ: Структура для сделки (Bubbles) ---
    struct Trade {
        double price;
        double quantity;
        bool isBuyerMaker;   // true = продажа (красный), false = покупка (зеленый)
        long long timestamp; // Время сделки
    };
}