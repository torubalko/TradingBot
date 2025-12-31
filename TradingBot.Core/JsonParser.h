#pragma once
#include <string>
#include <vector>
#include "Types.h"
#include "OrderBook.h"
namespace TradingBot::Core {
    class JsonParser {
    public:
        static Models::OrderBookSnapshot ParseSnapshot(const std::string& json);
        static Models::OrderBookUpdate ParseDepthUpdate(const std::string& json);
        static Trade ParseAggTrade(const std::string& json);
        static std::vector<SymbolInfo> ParseExchangeInfo(const std::string& json);
    };
}