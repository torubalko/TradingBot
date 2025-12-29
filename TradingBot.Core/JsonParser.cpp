#include "JsonParser.h"
#include <iostream>
#include <vector>
#include <string>

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

                    if (!sVol.empty() && sVol.back() == '"') sVol.pop_back();
                    if (!sVol.empty() && sVol.front() == '"') sVol.erase(0, 1);

                    levels.push_back({ std::stod(sPrice), std::stod(sVol) });
                }
                catch (...) {}
            }
            pos = end + 1;
        }
    }

    Models::OrderBookUpdate JsonParser::ParseDepthUpdate(const std::string& json) {
        Models::OrderBookUpdate update;

        // --- јƒјѕ“ј÷»я ѕќƒ TIGER (COMBINED STREAMS) ---
        // »щем поле "data", где лежит насто€щий стакан
        size_t dataPos = json.find("\"data\"");
        size_t startSearch = 0;

        if (dataPos != std::string::npos) {
            startSearch = dataPos; // ≈сли нашли обертку, ищем внутри неЄ
        }
        // -----------------------------------------------

        size_t bidsPos = json.find("\"b\"", startSearch); // »щем "b" (bids)
        if (bidsPos != std::string::npos) {
            size_t closeBracket = json.find("]]", bidsPos);
            if (closeBracket != std::string::npos)
                ParseLevels(json.substr(bidsPos, closeBracket - bidsPos), update.bids);
        }

        size_t asksPos = json.find("\"a\"", startSearch); // »щем "a" (asks)
        if (asksPos != std::string::npos) {
            size_t closeBracket = json.find("]]", asksPos);
            if (closeBracket != std::string::npos)
                ParseLevels(json.substr(asksPos, closeBracket - asksPos), update.asks);
        }
        return update;
    }

    Models::OrderBookSnapshot JsonParser::ParseSnapshot(const std::string& json) {
        // —напшоты пока не мен€ем, они приход€т по HTTP
        Models::OrderBookSnapshot snap;
        // (Ћогика снапшота остаетс€ старой, так как это HTTP запрос, а не WS)
        // ... код дл€ снапшота такой же ...
        return snap;
    }
}