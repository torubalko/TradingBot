#pragma once
#include <string>
#include <vector>
#include "Types.h"
#include "OrderBook.h"

class JsonParser {
public:
    static OrderBook ParseOrderBook(const std::string& json);
    static Trade ParseTrade(const std::string& json);
    static std::vector<Trade> ParseAggTrades(const std::string& json);

    // НОВОЕ: Парсинг списка монет
    static std::vector<SymbolInfo> ParseExchangeInfo(const std::string& json);
};