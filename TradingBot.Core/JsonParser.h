#pragma once
#include <string>
#include <vector>
#include "OrderBook.h" // Путь настроен через настройки проекта

namespace TradingBot::Core::Utils {
    class JsonParser {
    public:
        // Только объявляем функции, код будет в .cpp
        static Models::OrderBookUpdate ParseDepthUpdate(const std::string& json);
        static Models::OrderBookSnapshot ParseSnapshot(const std::string& json);
    };
}