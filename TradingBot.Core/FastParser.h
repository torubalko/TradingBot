#pragma once
#include <string_view>
#include <charconv>
#include <optional>

namespace TradingBot::Core::Utils {
    // Fast parsing utilities using std::from_chars for minimal allocations
    class FastParser {
    public:
        // Parse double from string_view using std::from_chars
        static std::optional<double> ParseDouble(std::string_view str) {
            double value;
            auto [ptr, ec] = std::from_chars(str.data(), str.data() + str.size(), value);
            if (ec == std::errc()) {
                return value;
            }
            return std::nullopt;
        }

        // Parse long long from string_view
        static std::optional<long long> ParseInt64(std::string_view str) {
            long long value;
            auto [ptr, ec] = std::from_chars(str.data(), str.data() + str.size(), value);
            if (ec == std::errc()) {
                return value;
            }
            return std::nullopt;
        }

        // Parse bool from string_view
        static bool ParseBool(std::string_view str) {
            if (str.empty()) return false;
            return str == "true" || str == "1" || str == "True";
        }

        // Extract string_view from quoted JSON string
        static std::string_view ExtractString(std::string_view str) {
            if (str.size() >= 2 && str.front() == '"' && str.back() == '"') {
                return str.substr(1, str.size() - 2);
            }
            return str;
        }
    };
}
