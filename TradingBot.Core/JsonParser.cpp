#include "JsonParser.h"
#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

namespace TradingBot::Core::Utils {

    void ParseLevels(const std::string& json, std::vector<Models::OrderBookLevel>& levels) {
        size_t pos = 0;
        while ((pos = json.find('[', pos)) != std::string::npos) {
            size_t end = json.find(']', pos);
            if (end == std::string::npos) break;

            std::string pairStr = json.substr(pos + 1, end - pos - 1);
            size_t comma = pairStr.find(',');

            if (comma != std::string::npos) {
                try {
                    std::string sPrice = pairStr.substr(1, comma - 2);
                    std::string sVol = pairStr.substr(comma + 2);

                    // Чистим кавычки (они есть в стриме, но могут отсутствовать в числах REST API)
                    sPrice.erase(remove(sPrice.begin(), sPrice.end(), '\"'), sPrice.end());
                    sVol.erase(remove(sVol.begin(), sVol.end(), '\"'), sVol.end());

                    levels.push_back({ std::stod(sPrice), std::stod(sVol) });
                }
                catch (...) {}
            }
            pos = end + 1;
        }
    }

    Models::OrderBookUpdate JsonParser::ParseDepthUpdate(const std::string& json) {
        Models::OrderBookUpdate update;

        // 1. Пробуем найти короткие ключи (WebSocket)
        size_t bidsPos = json.find("\"b\":[");
        if (bidsPos == std::string::npos) bidsPos = json.find("\"bids\":["); // Пробуем длинные (REST)

        if (bidsPos != std::string::npos) {
            size_t closeBracket = json.find("]]", bidsPos);
            if (closeBracket != std::string::npos)
                ParseLevels(json.substr(bidsPos, closeBracket - bidsPos), update.bids);
        }

        // 2. Пробуем найти аски
        size_t asksPos = json.find("\"a\":[");
        if (asksPos == std::string::npos) asksPos = json.find("\"asks\":["); // Пробуем длинные (REST)

        if (asksPos != std::string::npos) {
            size_t closeBracket = json.find("]]", asksPos);
            if (closeBracket != std::string::npos)
                ParseLevels(json.substr(asksPos, closeBracket - asksPos), update.asks);
        }
        return update;
    }

    // Для снимка используем ту же логику, так как структура похожа
    Models::OrderBookSnapshot JsonParser::ParseSnapshot(const std::string& json) {
        Models::OrderBookSnapshot snap;
        auto update = ParseDepthUpdate(json);
        snap.bids = update.bids;
        snap.asks = update.asks;
        return snap;
    }
}