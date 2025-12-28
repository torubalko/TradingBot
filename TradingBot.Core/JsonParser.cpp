#include "JsonParser.h"
#include <iostream>
#include <vector>
#include <string>

namespace TradingBot::Core::Utils {

    // Вспомогательная функция (скрытая)
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

                    if (!sVol.empty() && sVol.back() == '"') sVol.pop_back();
                    if (!sVol.empty() && sVol.front() == '"') sVol.erase(0, 1);

                    levels.push_back({ std::stod(sPrice), std::stod(sVol) });
                }
                catch (...) {}
            }
            pos = end + 1;
        }
    }

    // Реализация обновления
    Models::OrderBookUpdate JsonParser::ParseDepthUpdate(const std::string& json) {
        Models::OrderBookUpdate update;

        size_t bidsPos = json.find("\"b\"");
        if (bidsPos != std::string::npos) {
            size_t closeBracket = json.find("]]", bidsPos);
            if (closeBracket != std::string::npos)
                ParseLevels(json.substr(bidsPos, closeBracket - bidsPos), update.bids);
        }

        size_t asksPos = json.find("\"a\"");
        if (asksPos != std::string::npos) {
            size_t closeBracket = json.find("]]", asksPos);
            if (closeBracket != std::string::npos)
                ParseLevels(json.substr(asksPos, closeBracket - asksPos), update.asks);
        }
        return update;
    }

    // Реализация снапшота
    Models::OrderBookSnapshot JsonParser::ParseSnapshot(const std::string& json) {
        Models::OrderBookSnapshot snap;

        size_t bidsPos = json.find("\"bids\"");
        if (bidsPos != std::string::npos) {
            size_t openBracket = json.find('[', bidsPos);
            size_t closeBracket = json.find("]]", openBracket);
            if (openBracket != std::string::npos && closeBracket != std::string::npos) {
                ParseLevels(json.substr(openBracket, closeBracket - openBracket + 2), snap.bids);
            }
        }

        size_t asksPos = json.find("\"asks\"");
        if (asksPos != std::string::npos) {
            size_t openBracket = json.find('[', asksPos);
            size_t closeBracket = json.find("]]", openBracket);
            if (openBracket != std::string::npos && closeBracket != std::string::npos) {
                ParseLevels(json.substr(openBracket, closeBracket - openBracket + 2), snap.asks);
            }
        }
        return snap;
    }
}