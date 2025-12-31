#pragma once
#include <string>
#include <vector>
#include "Types.h" 

namespace TradingBot::Core {

    class JsonParser {
    public:
        // Возвращает полный снимок
        static OrderBook ParseSnapshot(const std::string& json);

        // Возвращает структуру обновления (дельта)
        static OrderBookUpdate ParseDepthUpdate(const std::string& json);

        static std::vector<SymbolInfo> ParseExchangeInfo(const std::string& json);
    };
}