#pragma once
#include <string>
#include <vector>

// Тип рынка: Спот или Фьючерсы
enum class MarketType {
    Spot,
    Futures
};

// Полное описание торговой пары (как в Tiger Trade)
struct TradingPair {
    // Основные идентификаторы
    std::string symbol;      // Например: "BTCUSDT"
    std::string baseAsset;   // "BTC"
    std::string quoteAsset;  // "USDT"

    // Параметры для математики и сетки (Grid)
    double tickSize;         // Шаг цены (0.1, 0.01, 0.00001). Критично для визуализатора!
    double stepSize;         // Шаг объема (лотность)
    double minQty;           // Минимальный объем ордера

    // Точность для отображения в UI (кол-во знаков)
    int pricePrecision;
    int quantityPrecision;

    // Статус
    bool isTrading;          // Торгуется ли сейчас
    MarketType type;         // SPOT или FUTURES
};

// Структура для хранения всех пар в SharedState
struct MarketCache {
    std::vector<TradingPair> spotPairs;
    std::vector<TradingPair> futuresPairs;
    bool isLoaded = false;   // Флаг, что данные получены
};