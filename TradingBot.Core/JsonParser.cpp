#include "JsonParser.h"
#include <nlohmann/json.hpp>
#include <iostream>
#include <cmath>
using json = nlohmann::json;
namespace TradingBot::Core {
    Models::OrderBookSnapshot JsonParser::ParseSnapshot(const std::string& data) {
        Models::OrderBookSnapshot book;
        try {
            auto j = json::parse(data);
            if (j.contains("lastUpdateId")) book.lastUpdateId = j["lastUpdateId"];
            if (j.contains("bids")) {
                for (const auto& item : j["bids"]) {
                    book.bids.push_back({ std::stod(item[0].get<std::string>()), std::stod(item[1].get<std::string>()) });
                }
            }
            if (j.contains("asks")) {
                for (const auto& item : j["asks"]) {
                    book.asks.push_back({ std::stod(item[0].get<std::string>()), std::stod(item[1].get<std::string>()) });
                }
            }
        }
        catch (...) {}
        return book;
    }
    Models::OrderBookUpdate JsonParser::ParseDepthUpdate(const std::string& data) {
        Models::OrderBookUpdate book;
        try {
            auto j = json::parse(data);
            json payload = j.contains("data") ? j["data"] : j;
            if (payload.contains("b")) {
                for (const auto& item : payload["b"]) {
                    book.bids.push_back({ std::stod(item[0].get<std::string>()), std::stod(item[1].get<std::string>()) });
                }
            }
            if (payload.contains("a")) {
                for (const auto& item : payload["a"]) {
                    book.asks.push_back({ std::stod(item[0].get<std::string>()), std::stod(item[1].get<std::string>()) });
                }
            }
        }
        catch (...) {}
        return book;
    }
    Trade JsonParser::ParseAggTrade(const std::string& data) {
        Trade t;
        try {
            auto j = json::parse(data);
            json payload = j.contains("data") ? j["data"] : j;
            t.id = payload["a"];
            t.price = std::stod(payload["p"].get<std::string>());
            t.quantity = std::stod(payload["q"].get<std::string>());
            t.isBuyerMaker = payload["m"];
            t.timestamp = payload["T"];
        }
        catch (...) {}
        return t;
    }
    std::vector<SymbolInfo> JsonParser::ParseExchangeInfo(const std::string& data) {
        std::vector<SymbolInfo> symbols;
        try {
            auto j = json::parse(data);
            if (!j.contains("symbols")) return symbols;
            for (const auto& item : j["symbols"]) {
                if (item.value("status", "") != "TRADING") continue;
                SymbolInfo info;
                info.symbol = item["symbol"];
                info.quoteAsset = item["quoteAsset"];
                if (info.quoteAsset != "USDT") continue;
                for (const auto& filter : item["filters"]) {
                    std::string fType = filter["filterType"];
                    if (fType == "PRICE_FILTER") {
                        info.tickSize = std::stod(filter["tickSize"].get<std::string>());
                    }
                    else if (fType == "LOT_SIZE") {
                        info.stepSize = std::stod(filter["stepSize"].get<std::string>());
                    }
                }
                info.pricePrecision = info.tickSize > 0 ? static_cast<int>(std::round(-std::log10(info.tickSize))) : 0;
                symbols.push_back(info);
            }
        }
        catch (const std::exception& e) {
            std::cerr << "JSON Parse Error: " << e.what() << std::endl;
        }
        return symbols;
    }
}