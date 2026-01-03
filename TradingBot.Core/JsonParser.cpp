#include "JsonParser.h"
#include <iostream>
#include <vector>
#include <string>
#include <string_view>
#include <charconv>
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>

namespace TradingBot::Core::Utils {

    namespace {
        inline void skipSpaces(std::string_view s, size_t& i) {
            while (i < s.size() && (unsigned char)s[i] <= ' ') ++i;
        }

        inline bool parseInt64(std::string_view s, size_t& i, long long& out) {
            skipSpaces(s, i);
            const char* begin = s.data() + i;
            const char* end = s.data() + s.size();
            auto res = std::from_chars(begin, end, out);
            if (res.ec != std::errc()) return false;
            i = (size_t)(res.ptr - s.data());
            return true;
        }

        inline bool parseQuotedDouble(std::string_view s, size_t& i, double& out) {
            skipSpaces(s, i);
            if (i < s.size() && s[i] == '"') ++i;
            const char* begin = s.data() + i;
            const char* end = s.data() + s.size();
            auto res = std::from_chars(begin, end, out, std::chars_format::general);
            if (res.ec != std::errc()) return false;
            i = (size_t)(res.ptr - s.data());
            if (i < s.size() && s[i] == '"') ++i;
            return true;
        }

        inline bool findKey(std::string_view s, std::string_view key, size_t& pos) {
            pos = s.find(key, pos);
            return pos != std::string_view::npos;
        }

        inline bool findColonAfterKey(std::string_view s, size_t& pos) {
            // pos at beginning of key
            pos = s.find(':', pos);
            if (pos == std::string_view::npos) return false;
            ++pos;
            return true;
        }

        inline long long findIntField(std::string_view s, std::string_view quotedKey) {
            size_t pos = 0;
            if (!findKey(s, quotedKey, pos)) return 0;
            if (!findColonAfterKey(s, pos)) return 0;
            long long v = 0;
            if (!parseInt64(s, pos, v)) return 0;
            return v;
        }

        inline void parseLevels(std::string_view s, std::string_view quotedKey, std::vector<OrderBookLevel>& levels) {
            size_t pos = 0;
            if (!findKey(s, quotedKey, pos)) return;
            if (!findColonAfterKey(s, pos)) return;
            skipSpaces(s, pos);
            if (pos >= s.size() || s[pos] != '[') return;
            ++pos; // after '['

            // Each entry: ["price","qty"]
            while (pos < s.size()) {
                skipSpaces(s, pos);
                if (pos >= s.size()) break;
                if (s[pos] == ']') { ++pos; break; }
                if (s[pos] == ',') { ++pos; continue; }
                if (s[pos] != '[') { ++pos; continue; }
                ++pos; // after '['

                double price = 0.0;
                double qty = 0.0;

                if (!parseQuotedDouble(s, pos, price)) {
                    // skip to end of this element
                    pos = s.find(']', pos);
                    if (pos == std::string_view::npos) return;
                    ++pos;
                    continue;
                }

                // skip comma
                while (pos < s.size() && s[pos] != ',') {
                    if (s[pos] == ']') break;
                    ++pos;
                }
                if (pos < s.size() && s[pos] == ',') ++pos;

                if (!parseQuotedDouble(s, pos, qty)) {
                    pos = s.find(']', pos);
                    if (pos == std::string_view::npos) return;
                    ++pos;
                    continue;
                }

                // skip to end of inner array
                pos = s.find(']', pos);
                if (pos == std::string_view::npos) return;
                ++pos;

                levels.push_back({ price, qty });
            }
        }
    }

    OrderBookUpdate JsonParser::ParseDepthUpdate(const std::string& json) {
        OrderBookUpdate update{};
        update.u = 0;
        update.U = 0;
        update.pu = 0;
        update.E = 0;

        try {
            std::string_view s{ json };

            update.U = findIntField(s, "\"U\"");
            update.u = findIntField(s, "\"u\"");
            update.pu = findIntField(s, "\"pu\"");
            update.E = findIntField(s, "\"E\"");

            if (update.U == 0 || update.u == 0) return update;

            update.bids.clear();
            update.asks.clear();
            update.bids.reserve(128);
            update.asks.reserve(128);

            parseLevels(s, "\"b\"", update.bids);
            parseLevels(s, "\"a\"", update.asks);
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
                }
                catch (...) {}
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