#pragma once
#include <map>
#include <mutex>
#include <vector>
#include <algorithm>
#include <cmath>
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
            double epsilon = 0.0000001;

            // Просто сохраняем сырые данные
            for (const auto& level : bids) {
                if (level.quantity < epsilon) Bids.erase(level.price);
                else Bids[level.price] = level.quantity;
            }
            for (const auto& level : asks) {
                if (level.quantity < epsilon) Asks.erase(level.price);
                else Asks[level.price] = level.quantity;
            }
        }

        // === ГЕНЕРАЦИЯ ЖЕСТКОЙ СЕТКИ ===
        RenderSnapshot GetSnapshotForRender(int depth, double priceStep) {
            std::lock_guard<std::mutex> lock(mutex_);
            RenderSnapshot snap;

            // 1. Сначала агрегируем данные во временные карты
            // Это нужно, чтобы собрать объемы с "мелких" цен в "крупные"
            std::map<double, double> aggBids;
            std::map<double, double> aggAsks;

            // Агрегация ASKS (Округление ВВЕРХ)
            for (auto const& [price, qty] : Asks) {
                double key = std::ceil(price / priceStep - 0.000001) * priceStep;
                if (key == -0.0) key = 0.0;
                aggAsks[key] += qty;
            }

            // Агрегация BIDS (Округление ВНИЗ)
            for (auto const& [price, qty] : Bids) {
                double key = std::floor(price / priceStep + 0.000001) * priceStep;
                aggBids[key] += qty;
            }

            // 2. Определяем "Якорные цены" (Откуда начинать рисовать)
            double bestAsk = Asks.empty() ? 0 : Asks.begin()->first;
            double bestBid = Bids.empty() ? 0 : Bids.rbegin()->first;

            // Привязываем якоря к нашей сетке (шагу цены)
            double gridAsk = std::ceil(bestAsk / priceStep - 0.000001) * priceStep;
            double gridBid = std::floor(bestBid / priceStep + 0.000001) * priceStep;

            // ЗАЩИТА ОТ НАХЛЕСТА:
            // Если из-за округления Bid и Ask встретились на одной цене, раздвигаем их
            if (gridAsk <= gridBid) {
                gridAsk = gridBid + priceStep;
            }

            // 3. ГЕНЕРИРУЕМ ВЕКТОРЫ (МАТЕМАТИЧЕСКИ)
            // Мы идем циклом от 0 до depth и САМИ создаем цены.
            // Это гарантирует, что "пустых" цен не будет - они будут нарисованы с объемом 0.

            // --- ASKS (Вверх) ---
            for (int i = 0; i < depth; i++) {
                double price = gridAsk + (i * priceStep);

                // Ищем объем в агрегированной карте
                // Используем lower_bound для поиска double (из-за погрешностей)
                double vol = 0;
                auto it = aggAsks.lower_bound(price - 0.00001);
                if (it != aggAsks.end() && std::abs(it->first - price) < 0.00001) {
                    vol = it->second;
                }

                snap.Asks.push_back({ price, vol });
            }

            // --- BIDS (Вниз) ---
            for (int i = 0; i < depth; i++) {
                double price = gridBid - (i * priceStep);

                double vol = 0;
                auto it = aggBids.lower_bound(price - 0.00001);
                if (it != aggBids.end() && std::abs(it->first - price) < 0.00001) {
                    vol = it->second;
                }

                snap.Bids.push_back({ price, vol });
            }

            return snap;
        }

    private:
        std::mutex mutex_;
        std::map<double, double> Bids;
        std::map<double, double> Asks;
    };
}