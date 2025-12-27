#pragma once
#include "Types.h"
#include <nlohmann/json.hpp>
#include <string>
#include <vector>
#include <iostream>

using json = nlohmann::json;

namespace TradingBot::Core::Utils {

    class JsonParser {
    public:
        // Метод парсит сырую строку от Binance
        static Models::OrderBookUpdate ParseDepthUpdate(const std::string& raw_json) {
            Models::OrderBookUpdate update;

            try {
                // 1. Превращаем строку в JSON-объект
                auto j = json::parse(raw_json);

                // Проверяем, есть ли там поле "e" (event type)
                if (j.contains("e") && j["e"] == "depthUpdate") {
                    update.symbol = j["s"]; // Символ (BTCUSDT)

                    // 2. Парсим Bids (Покупки) - массив массивов [["40000.00", "0.5"], ...]
                    if (j.contains("b")) {
                        for (const auto& item : j["b"]) {
                            // Binance присылает числа в кавычках (строками), нужно конвертировать (stod)
                            double p = std::stod(item[0].get<std::string>());
                            double v = std::stod(item[1].get<std::string>());
                            update.bids.push_back({ p, v });
                        }
                    }

                    // 3. Парсим Asks (Продажи)
                    if (j.contains("a")) {
                        for (const auto& item : j["a"]) {
                            double p = std::stod(item[0].get<std::string>());
                            double v = std::stod(item[1].get<std::string>());
                            update.asks.push_back({ p, v });
                        }
                    }
                }
            }
            catch (const std::exception& e) {
                // Если пришел мусор или ошибка парсинга
                std::cerr << "[PARSER ERROR] " << e.what() << std::endl;
            }

            return update;
        }
    };
}