#include "JsonParser.h"
#include <iostream>
#include <vector>
#include <string>
#include <charconv>
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>

namespace TradingBot::Core::Utils {

    OrderBookUpdate JsonParser::ParseDepthUpdate(const std::string& json) {
        OrderBookUpdate update;
        update.u = 0;
        update.U = 0;

        try {
            // Robust field finder: looks for "key" then : then value
            auto findField = [&](const std::string& key) -> long long {
                std::string keyPattern = "\"" + key + "\"";
                size_t keyPos = json.find(keyPattern);
                if (keyPos == std::string::npos) return 0;
                
                size_t pos = keyPos + keyPattern.length();
                
                // Skip spaces and find colon
                while (pos < json.length() && isspace(json[pos])) pos++;
                if (pos >= json.length() || json[pos] != ':') return 0;
                pos++; // skip colon

                // Skip spaces
                while (pos < json.length() && isspace(json[pos])) pos++;
                
                size_t end = pos;
                while (end < json.length() && isdigit(json[end])) end++;
                
                if (end > pos) {
                    try {
                        return std::stoll(json.substr(pos, end - pos));
                    } catch(...) { return 0; }
                }
                return 0;
            };

            update.U = findField("U");
            update.u = findField("u");
            update.pu = findField("pu"); // Parse previous update ID
            update.E = findField("E"); // Parse Event Time

            if (update.U == 0 || update.u == 0) return update;

            // 2. Parse bids and asks
            auto parseLevels = [&](const std::string& key, std::vector<OrderBookLevel>& levels) {
                std::string keyPattern = "\"" + key + "\"";
                size_t keyPos = json.find(keyPattern);
                if (keyPos == std::string::npos) return;
                
                size_t pos = keyPos + keyPattern.length();
                while (pos < json.length() && isspace(json[pos])) pos++;
                if (pos >= json.length() || json[pos] != ':') return;
                pos++;
                while (pos < json.length() && isspace(json[pos])) pos++;
                if (pos >= json.length() || json[pos] != '[') return;
                pos++; // Skip '['

                while (pos < json.length()) {
                    while (pos < json.length() && (isspace(json[pos]) || json[pos] == ',')) pos++;
                    if (pos >= json.length() || json[pos] != '[') break;
                    pos++; // Skip '['

                    // Price
                    while (pos < json.length() && (isspace(json[pos]) || json[pos] == '"')) pos++;
                    size_t pStart = pos;
                    while (pos < json.length() && json[pos] != '"') pos++;
                    std::string sPrice = json.substr(pStart, pos - pStart);
                    pos++; // Skip '"'

                    // Comma
                    while (pos < json.length() && (isspace(json[pos]) || json[pos] == ',')) pos++;

                    // Qty
                    while (pos < json.length() && (isspace(json[pos]) || json[pos] == '"')) pos++;
                    size_t qStart = pos;
                    while (pos < json.length() && json[pos] != '"') pos++;
                    std::string sQty = json.substr(qStart, pos - qStart);
                    pos++; // Skip '"'

                    while (pos < json.length() && json[pos] != ']') pos++;
                    pos++; // Skip ']'

                    try {
                        double p = std::stod(sPrice);
                        double q = std::stod(sQty);
                        levels.push_back({ p, q });
                    } catch(...) {}
                }
            };

            parseLevels("b", update.bids);
            parseLevels("a", update.asks);
        }
        catch (...) {
        }
        return update;
    }

    // Keep Snapshot parsing robust with property_tree as it happens only once
    std::vector<OrderBookLevel> ParseLevelsPT(const boost::property_tree::ptree& node) {
        std::vector<OrderBookLevel> levels;
        for (const auto& item : node) {
            auto it = item.second.begin();
            if (it != item.second.end()) {
                try {
                    double price = std::stod(it->second.data());
                    ++it;
                    if (it != item.second.end()) {
                        double qty = std::stod(it->second.data());
                        levels.push_back({ price, qty });
                    }
                } catch(...) {}
            }
        }
        return levels;
    }

    OrderBookSnapshot JsonParser::ParseSnapshot(const std::string& json) {
        OrderBookSnapshot snapshot;
        try {
            boost::property_tree::ptree pt;
            std::stringstream ss(json);
            boost::property_tree::read_json(ss, pt);

            snapshot.lastUpdateId = pt.get<long long>("lastUpdateId");
            snapshot.bids = ParseLevelsPT(pt.get_child("bids"));
            snapshot.asks = ParseLevelsPT(pt.get_child("asks"));
        }
        catch (...) {}
        return snapshot;
    }
}