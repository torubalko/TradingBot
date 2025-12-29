#pragma once
#include <vector>
#include <mutex>
#include <map>
#include <iostream>
#include "OrderBook.h" // Убедитесь, что этот файл существует и там есть Models::OrderBookLevel

namespace TradingBot::Core {

    // Структура для отрисовки (готовый кадр)
    struct RenderSnapshot {
        std::vector<std::pair<double, double>> Bids;
        std::vector<std::pair<double, double>> Asks;
    };

    class SharedState {
    private:
        // Используем map для авто-сортировки
        std::map<double, double, std::greater<double>> bidsMap; // Покупатели (дорого -> дешево)
        std::map<double, double, std::less<double>> asksMap;    // Продавцы (дешево -> дорого)
        std::mutex dataMutex;

    public:
        SharedState() {}

        // Метод обновления (вызывается из Сети)
        void ApplyUpdate(const std::vector<Models::OrderBookLevel>& bids, const std::vector<Models::OrderBookLevel>& asks) {
            std::lock_guard<std::mutex> lock(dataMutex);

            for (const auto& level : bids) {
                if (level.quantity == 0) bidsMap.erase(level.price);
                else bidsMap[level.price] = level.quantity;
            }

            for (const auto& level : asks) {
                if (level.quantity == 0) asksMap.erase(level.price);
                else asksMap[level.price] = level.quantity;
            }
        }

        // Метод для Рендера (подготовка кадра)
        RenderSnapshot GetSnapshotForRender(int depth = 100) {
            std::lock_guard<std::mutex> lock(dataMutex);
            RenderSnapshot snap;

            int count = 0;
            for (auto it = bidsMap.begin(); it != bidsMap.end() && count < depth; ++it, ++count) {
                snap.Bids.push_back(*it);
            }

            count = 0;
            for (auto it = asksMap.begin(); it != asksMap.end() && count < depth; ++it, ++count) {
                snap.Asks.push_back(*it);
            }
            return snap;
        }
    };
}