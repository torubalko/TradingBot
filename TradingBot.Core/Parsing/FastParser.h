#pragma once
#include <string>
#include <string_view>
#include <charconv>
#include <optional>
#include <vector>
#include "../Types.h"
#include "../OrderBook.h"

namespace TradingBot::Core::Parsing {
    class FastParser {
    public:
        // Fast parse double from string using std::from_chars (zero-copy)
        static std::optional<double> ParseDouble(std::string_view str) {
            double value = 0.0;
            auto result = std::from_chars(str.data(), str.data() + str.size(), value);
            if (result.ec == std::errc{}) {
                return value;
            }
            return std::nullopt;
        }

        // Fast parse long long from string using std::from_chars
        static std::optional<long long> ParseLongLong(std::string_view str) {
            long long value = 0;
            auto result = std::from_chars(str.data(), str.data() + str.size(), value);
            if (result.ec == std::errc{}) {
                return value;
            }
            return std::nullopt;
        }

        // Fast parse int from string using std::from_chars
        static std::optional<int> ParseInt(std::string_view str) {
            int value = 0;
            auto result = std::from_chars(str.data(), str.data() + str.size(), value);
            if (result.ec == std::errc{}) {
                return value;
            }
            return std::nullopt;
        }

        // Extract string value between quotes (zero-copy view)
        static std::string_view ExtractQuotedString(std::string_view json, std::string_view key) {
            size_t keyPos = json.find(key);
            if (keyPos == std::string_view::npos) {
                return {};
            }

            size_t colonPos = json.find(':', keyPos);
            if (colonPos == std::string_view::npos) {
                return {};
            }

            size_t startQuote = json.find('"', colonPos);
            if (startQuote == std::string_view::npos) {
                return {};
            }

            size_t endQuote = json.find('"', startQuote + 1);
            if (endQuote == std::string_view::npos) {
                return {};
            }

            return json.substr(startQuote + 1, endQuote - startQuote - 1);
        }

        // Extract numeric value (returns string_view for zero-copy parsing)
        static std::string_view ExtractNumber(std::string_view json, std::string_view key) {
            size_t keyPos = json.find(key);
            if (keyPos == std::string_view::npos) {
                return {};
            }

            size_t colonPos = json.find(':', keyPos);
            if (colonPos == std::string_view::npos) {
                return {};
            }

            // Skip whitespace after colon
            size_t numStart = colonPos + 1;
            while (numStart < json.size() && (json[numStart] == ' ' || json[numStart] == '\t')) {
                numStart++;
            }

            // Find end of number
            size_t numEnd = numStart;
            while (numEnd < json.size() && 
                   (std::isdigit(json[numEnd]) || json[numEnd] == '.' || json[numEnd] == '-' || json[numEnd] == 'e' || json[numEnd] == 'E' || json[numEnd] == '+')) {
                numEnd++;
            }

            if (numEnd == numStart) {
                return {};
            }

            return json.substr(numStart, numEnd - numStart);
        }

        // Extract boolean value
        static std::optional<bool> ExtractBool(std::string_view json, std::string_view key) {
            size_t keyPos = json.find(key);
            if (keyPos == std::string_view::npos) {
                return std::nullopt;
            }

            size_t colonPos = json.find(':', keyPos);
            if (colonPos == std::string_view::npos) {
                return std::nullopt;
            }

            size_t truePos = json.find("true", colonPos);
            size_t falsePos = json.find("false", colonPos);

            if (truePos != std::string_view::npos && (falsePos == std::string_view::npos || truePos < falsePos)) {
                return true;
            }
            if (falsePos != std::string_view::npos) {
                return false;
            }

            return std::nullopt;
        }

        // Fast parse price-quantity pair from JSON array element
        static std::optional<OrderBookLevel> ParsePriceLevel(std::string_view levelStr) {
            // Expected format: ["price", "quantity"]
            size_t firstQuote = levelStr.find('"');
            if (firstQuote == std::string_view::npos) return std::nullopt;

            size_t secondQuote = levelStr.find('"', firstQuote + 1);
            if (secondQuote == std::string_view::npos) return std::nullopt;

            auto priceStr = levelStr.substr(firstQuote + 1, secondQuote - firstQuote - 1);
            auto priceOpt = ParseDouble(priceStr);
            if (!priceOpt) return std::nullopt;

            size_t thirdQuote = levelStr.find('"', secondQuote + 1);
            if (thirdQuote == std::string_view::npos) return std::nullopt;

            size_t fourthQuote = levelStr.find('"', thirdQuote + 1);
            if (fourthQuote == std::string_view::npos) return std::nullopt;

            auto qtyStr = levelStr.substr(thirdQuote + 1, fourthQuote - thirdQuote - 1);
            auto qtyOpt = ParseDouble(qtyStr);
            if (!qtyOpt) return std::nullopt;

            OrderBookLevel level;
            level.price = *priceOpt;
            level.quantity = *qtyOpt;
            return level;
        }

        // Helper to extract nested data object
        static std::string_view ExtractDataObject(std::string_view json) {
            size_t dataPos = json.find("\"data\"");
            if (dataPos == std::string_view::npos) {
                return json; // No data field, return whole json
            }

            size_t openBrace = json.find('{', dataPos);
            if (openBrace == std::string_view::npos) {
                return json;
            }

            // Simple brace matching
            int braceCount = 1;
            size_t pos = openBrace + 1;
            while (pos < json.size() && braceCount > 0) {
                if (json[pos] == '{') braceCount++;
                else if (json[pos] == '}') braceCount--;
                pos++;
            }

            if (braceCount == 0) {
                return json.substr(openBrace, pos - openBrace);
            }

            return json;
        }
    };
}
