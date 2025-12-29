#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <algorithm>
#include "Types.h" // Подключаем наши структуры

namespace TradingBot::Core {

    struct RenderSnapshot {
        std::vector<std::pair<double, double>> Bids;
        std::vector<std::pair<double, double>> Asks;
    };

    class SharedState {
    public:
        // Теперь принимаем векторы OrderBookLevel (как в Types.h)
        void ApplyUpdate(const std::vector<OrderBookLevel>& bids,
            const std::vector<OrderBookLevel>& asks) {
            std::lock_guard<std::mutex> lock(mutex_);

            for (const auto& level : bids) {
                if (level.quantity == 0) Bids.erase(level.price);
                else Bids[level.price] = level.quantity;
            }

            for (const auto& level : asks) {
                if (level.quantity == 0) Asks.erase(level.price);
                else Asks[level.price] = level.quantity;
            }
        }

        RenderSnapshot GetSnapshotForRender(int depth) {
            std::lock_guard<std::mutex> lock(mutex_);
            RenderSnapshot snap;

            // ASKS: Дешевые -> Дорогие (ВВЕРХ)
            int count = 0;
            for (auto it = Asks.begin(); it != Asks.end() && count < depth; ++it) {
                snap.Asks.push_back({ it->first, it->second });
                count++;
            }

            // BIDS: Дорогие -> Дешевые (ВНИЗ)
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