#include "JsonParser.h"
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>
#include <iostream>

namespace TradingBot::Core::Utils {

    using namespace boost::property_tree;

    // Вспомогательная функция для парсинга массива уровней [[price, qty], ...]
    std::vector<OrderBookLevel> ParseLevels(const ptree& node) {
        std::vector<OrderBookLevel> levels;
        for (const auto& item : node) {
            // item.second - это массив ["price", "qty"]
            auto it = item.second.begin();
            if (it != item.second.end()) {
                double price = std::stod(it->second.data());
                ++it;
                if (it != item.second.end()) {
                    double qty = std::stod(it->second.data());
                    levels.push_back({ price, qty });
                }
            }
        }
        return levels;
    }

    OrderBookSnapshot JsonParser::ParseSnapshot(const std::string& json) {
        OrderBookSnapshot snapshot;
        try {
            ptree pt;
            std::stringstream ss(json);
            read_json(ss, pt);

            snapshot.lastUpdateId = pt.get<long long>("lastUpdateId");
            snapshot.bids = ParseLevels(pt.get_child("bids"));
            snapshot.asks = ParseLevels(pt.get_child("asks"));
        }
        catch (const std::exception& e) {
            std::cerr << "[JsonParser] Snapshot error: " << e.what() << std::endl;
        }
        return snapshot;
    }

    OrderBookUpdate JsonParser::ParseDepthUpdate(const std::string& json) {
        OrderBookUpdate update;
        try {
            ptree pt;
            std::stringstream ss(json);
            read_json(ss, pt);

            // В WebSocket данные лежат внутри объекта "data" (если поток комбинированный)
            // Но в нашем случае (прямой поток) поля могут быть в корне.
            // Проверим наличие поля "data", если нет - читаем из корня.
            const ptree* root = &pt;
            if (pt.count("data")) {
                root = &pt.get_child("data");
            }

            update.u = root->get<long long>("u"); // Final update ID
            update.U = root->get<long long>("U"); // First update ID

            // "b" - bids, "a" - asks
            if (root->count("b")) update.bids = ParseLevels(root->get_child("b"));
            if (root->count("a")) update.asks = ParseLevels(root->get_child("a"));
        }
        catch (const std::exception& e) {
            // Иногда приходят сообщения другого типа (ping/pong), это не страшно
            // std::cerr << "[JsonParser] Update error: " << e.what() << std::endl;
        }
        return update;
    }
}