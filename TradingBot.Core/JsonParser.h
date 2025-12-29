#pragma once
#include <string>
#include <vector>
#include "Types.h" // Подключаем, чтобы видеть OrderBookSnapshot и OrderBookUpdate

namespace TradingBot::Core::Utils {

    class JsonParser {
    public:
        // Возвращаем типы напрямую из Core (без Models)
        static OrderBookSnapshot ParseSnapshot(const std::string& json);
        static OrderBookUpdate ParseDepthUpdate(const std::string& json);
    };
}