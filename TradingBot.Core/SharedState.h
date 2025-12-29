#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <algorithm>
#include "Types.h" 

namespace TradingBot::Core {

    struct RenderSnapshot {
        std::vector<std::pair<double, double>> Bids;
        std::vector<std::pair<double, double>> Asks;
    };

    class SharedState {
    public:
        void ApplyUpdate(const std::vector<OrderBookLevel>& bids,
            const std::vector<OrderBookLevel>& asks) {
            std::lock_guard<std::mutex> lock(mutex_);

            // "Магическое число" для сравнения с нулем
            double epsilon = 0.0000001;

            // Обновляем Bids
            for (const auto& level : bids) {
                // ИСПРАВЛЕНО: Если объем почти ноль - удаляем
                if (level.quantity < epsilon) Bids.erase(level.price);
                else Bids[level.price] = level.quantity;
            }

            // Обновляем Asks
            for (const auto& level : asks) {
                if (level.quantity < epsilon) Asks.erase(level.price);
                else Asks[level.price] = level.quantity;
            }
        }

        RenderSnapshot GetSnapshotForRender(int depth) {
            std::lock_guard<std::mutex> lock(mutex_);
            RenderSnapshot snap;

            // 1. ASKS (Сортировка 100, 101, 102...)
            int count = 0;
            for (auto it = Asks.begin(); it != Asks.end() && count < depth; ++it) {
                snap.Asks.push_back({ it->first, it->second });
                count++;
            }

            // 2. BIDS (Сортировка 99, 98, 97...)
            count = 0;
            for (auto it = Bids.rbegin(); it != Bids.rend() && count < depth; ++it) {
                snap.Bids.push_back({ it->first, it->second });
                count++;
            }

            return snap;
        }

    private:
        std::mutex mutex_;
        std::map<double, double> Bids;
        std::map<double, double> Asks;
    };
}