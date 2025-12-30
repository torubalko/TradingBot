#include "JsonParser.h"
#include <nlohmann/json.hpp>
#include <iostream>
#include <cmath>

using json = nlohmann::json;

OrderBook JsonParser::ParseOrderBook(const std::string& data) {
    OrderBook book;
    try {
        auto j = json::parse(data);
        book.lastUpdateId = j["lastUpdateId"];

        for (const auto& item : j["bids"]) {
            book.bids.push_back({ std::stod(item[0].get<std::string>()), std::stod(item[1].get<std::string>()) });
        }
        for (const auto& item : j["asks"]) {
            book.asks.push_back({ std::stod(item[0].get<std::string>()), std::stod(item[1].get<std::string>()) });
        }
    }
    catch (...) {}
    return book;
}

Trade JsonParser::ParseTrade(const std::string& data) {
    Trade t;
    try {
        auto j = json::parse(data);
        t.id = j["a"];
        t.price = std::stod(j["p"].get<std::string>());
        t.quantity = std::stod(j["q"].get<std::string>());
        t.timestamp = j["T"];
        t.isBuyerMaker = j["m"];
    }
    catch (...) {}
    return t;
}

std::vector<Trade> JsonParser::ParseAggTrades(const std::string& data) {
    std::vector<Trade> trades;
    try {
        auto j = json::parse(data);
        for (const auto& item : j) {
            Trade t;
            t.id = item["a"];
            t.price = std::stod(item["p"].get<std::string>());
            t.quantity = std::stod(item["q"].get<std::string>());
            t.timestamp = item["T"];
            t.isBuyerMaker = item["m"];
            trades.push_back(t);
        }
    }
    catch (...) {}
    return trades;
}

// НОВОЕ: Реализация парсинга ExchangeInfo
std::vector<SymbolInfo> JsonParser::ParseExchangeInfo(const std::string& data) {
    std::vector<SymbolInfo> symbols;
    try {
        auto j = json::parse(data);

        for (const auto& item : j["symbols"]) {
            // Берем только активные пары
            if (item["status"] != "TRADING") continue;

            SymbolInfo info;
            info.symbol = item["symbol"];
            info.quoteAsset = item["quoteAsset"];

            // Фильтруем (можно убрать, если нужны все, но обычно нужны USDT)
            if (info.quoteAsset != "USDT" && info.quoteAsset != "BUSD") continue;

            // Извлекаем tickSize и stepSize из фильтров
            for (const auto& filter : item["filters"]) {
                if (filter["filterType"] == "PRICE_FILTER") {
                    info.tickSize = std::stod(filter["tickSize"].get<std::string>());
                }
                else if (filter["filterType"] == "LOT_SIZE") {
                    info.stepSize = std::stod(filter["stepSize"].get<std::string>());
                }
            }

            // Вычисляем precision
            info.pricePrecision = 0;
            if (info.tickSize > 0) {
                info.pricePrecision = static_cast<int>(std::round(-std::log10(info.tickSize)));
            }

            symbols.push_back(info);
        }
    }
    catch (const std::exception& e) {
        std::cerr << "JSON Error: " << e.what() << std::endl;
    }
    return symbols;
}