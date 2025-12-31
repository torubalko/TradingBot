#include "JsonParser.h"
#include <nlohmann/json.hpp>
#include <iostream>
#include <cmath>

using json = nlohmann::json;

namespace TradingBot::Core {

    OrderBook JsonParser::ParseSnapshot(const std::string& data) {
        OrderBook book;
        book.lastUpdateId = 0;
        try {
            auto j = json::parse(data);
            if (j.contains("lastUpdateId")) book.lastUpdateId = j["lastUpdateId"];

            // Резервируем память для скорости, если знаем размер
            if (j.contains("bids") && j["bids"].is_array()) {
                book.bids.reserve(j["bids"].size());
                for (const auto& item : j["bids"]) {
                    book.bids.push_back({ std::stod(item[0].get<std::string>()), std::stod(item[1].get<std::string>()) });
                }
            }
            if (j.contains("asks") && j["asks"].is_array()) {
                book.asks.reserve(j["asks"].size());
                for (const auto& item : j["asks"]) {
                    book.asks.push_back({ std::stod(item[0].get<std::string>()), std::stod(item[1].get<std::string>()) });
                }
            }
        }
        catch (...) {}
        return book;
    }

    OrderBookUpdate JsonParser::ParseDepthUpdate(const std::string& data) {
        OrderBookUpdate update;
        update.U = 0; update.u = 0; update.pu = 0;

        try {
            auto j = json::parse(data);

            // Поддержка Combined stream ("data")
            json payload = j;
            if (j.contains("data")) payload = j["data"];

            // Парсим ID обновлений (важно для проверки целостности данных)
            if (payload.contains("U")) update.U = payload["U"];
            if (payload.contains("u")) update.u = payload["u"];
            if (payload.contains("pu")) update.pu = payload["pu"];

            if (payload.contains("b")) {
                for (const auto& item : payload["b"]) {
                    // Важно: здесь мы передаем 0.0, если объем 0. SharedState должен это обработать (удалить уровень)
                    update.bids.push_back({ std::stod(item[0].get<std::string>()), std::stod(item[1].get<std::string>()) });
                }
            }
            if (payload.contains("a")) {
                for (const auto& item : payload["a"]) {
                    update.asks.push_back({ std::stod(item[0].get<std::string>()), std::stod(item[1].get<std::string>()) });
                }
            }
        }
        catch (...) {}
        return update;
    }

    std::vector<SymbolInfo> JsonParser::ParseExchangeInfo(const std::string& data) {
        std::vector<SymbolInfo> symbols;
        try {
            auto j = json::parse(data);

            // Проверка на структуру symbols (иногда бывает в корне, иногда вложенно, если формат сменится)
            if (!j.contains("symbols")) return symbols;

            for (const auto& item : j["symbols"]) {
                if (item.value("status", "") != "TRADING") continue;

                SymbolInfo info;
                info.symbol = item["symbol"];
                info.quoteAsset = item["quoteAsset"];

                // Фильтр USDT
                if (info.quoteAsset != "USDT") continue;

                info.tickSize = 0.0;
                info.stepSize = 0.0;

                for (const auto& filter : item["filters"]) {
                    std::string fType = filter["filterType"];
                    if (fType == "PRICE_FILTER") {
                        info.tickSize = std::stod(filter["tickSize"].get<std::string>());
                    }
                    else if (fType == "LOT_SIZE") {
                        info.stepSize = std::stod(filter["stepSize"].get<std::string>());
                    }
                }

                // Вычисление точности
                info.pricePrecision = 0;
                if (info.tickSize > 0) {
                    info.pricePrecision = static_cast<int>(std::round(-std::log10(info.tickSize)));
                }
                else {
                    // Fallback: иногда tickSize не в фильтрах, пробуем взять общее поле (для фьючерсов бывает)
                    if (item.contains("pricePrecision")) {
                        info.pricePrecision = item["pricePrecision"];
                        info.tickSize = std::pow(10, -info.pricePrecision);
                    }
                }

                symbols.push_back(info);
            }
        }
        catch (const std::exception& e) {
            std::cerr << "JSON Parse Error: " << e.what() << std::endl;
        }
        return symbols;
    }
}