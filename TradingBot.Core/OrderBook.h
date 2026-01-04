#pragma once
#include <vector>
#include <algorithm>
#include <cstdint>

namespace TradingBot::Core::Models {

    // ═══════════════════════════════════════════════════════════════
    // Pre-allocated OrderBook с эффективным обновлением
    // ═══════════════════════════════════════════════════════════════

    struct PriceLevel {
        double price{ 0.0 };
        double quantity{ 0.0 };

        // Для binary search и сортировки
        bool operator<(const PriceLevel& other) const {
            return price < other.price;
        }
    };

    class OrderBook {
    public:
        // PRE-ALLOCATION: Резервируем память при создании
        OrderBook() {
            bids_.reserve(10000);  // Worst case: 10k уровней
            asks_.reserve(10000);
        }

        // ═══════════════════════════════════════════════════════════════
        // Применение снэпшота (snapshot from REST API)
        // ═══════════════════════════════════════════════════════════════
        void ApplySnapshot(const std::vector<PriceLevel>& bids,
                          const std::vector<PriceLevel>& asks) {
            bids_.clear();
            asks_.clear();

            bids_.insert(bids_.end(), bids.begin(), bids.end());
            asks_.insert(asks_.end(), asks.begin(), asks.end());

            // Сортировка: bids DESC, asks ASC
            std::sort(bids_.begin(), bids_.end(), 
                [](const PriceLevel& a, const PriceLevel& b) {
                    return a.price > b.price; // DESC для bids
                });

            std::sort(asks_.begin(), asks_.end()); // ASC для asks
        }

        // ═══════════════════════════════════════════════════════════════
        // Применение diff-обновления (WebSocket updates)
        // Алгоритм: Binary Search + In-place Update (Zero-Allocation)
        // ═══════════════════════════════════════════════════════════════
        void ApplyUpdate(const std::vector<PriceLevel>& bidUpdates,
                        const std::vector<PriceLevel>& askUpdates) {
            
            // Обновляем Bids (DESC сортировка)
            for (const auto& update : bidUpdates) {
                if (update.quantity < 1e-8) {
                    // Удаление уровня
                    RemoveBid(update.price);
                } else {
                    // Обновление или вставка
                    UpsertBid(update);
                }
            }

            // Обновляем Asks (ASC сортировка)
            for (const auto& update : askUpdates) {
                if (update.quantity < 1e-8) {
                    RemoveAsk(update.price);
                } else {
                    UpsertAsk(update);
                }
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // Доступ к данным (Read-only, lock-free для читателей)
        // ═══════════════════════════════════════════════════════════════
        const std::vector<PriceLevel>& GetBids() const { return bids_; }
        const std::vector<PriceLevel>& GetAsks() const { return asks_; }

        // Получение лучших цен
        double GetBestBid() const {
            return bids_.empty() ? 0.0 : bids_.front().price;
        }

        double GetBestAsk() const {
            return asks_.empty() ? 0.0 : asks_.front().price;
        }

    private:
        // ═══════════════════════════════════════════════════════════════
        // Internal Helpers: Binary Search + In-place Modification
        // ═══════════════════════════════════════════════════════════════

        void UpsertBid(const PriceLevel& level) {
            // Binary search (DESC sorted)
            auto it = std::lower_bound(bids_.begin(), bids_.end(), level,
                [](const PriceLevel& a, const PriceLevel& b) {
                    return a.price > b.price; // DESC
                });

            if (it != bids_.end() && std::abs(it->price - level.price) < 1e-8) {
                // Обновление существующего уровня
                it->quantity = level.quantity;
            } else {
                // Вставка нового уровня (может вызвать reallocation, но редко)
                bids_.insert(it, level);
            }
        }

        void RemoveBid(double price) {
            auto it = std::lower_bound(bids_.begin(), bids_.end(), price,
                [](const PriceLevel& a, double p) {
                    return a.price > p;
                });

            if (it != bids_.end() && std::abs(it->price - price) < 1e-8) {
                bids_.erase(it);
            }
        }

        void UpsertAsk(const PriceLevel& level) {
            // Binary search (ASC sorted)
            auto it = std::lower_bound(asks_.begin(), asks_.end(), level);

            if (it != asks_.end() && std::abs(it->price - level.price) < 1e-8) {
                it->quantity = level.quantity;
            } else {
                asks_.insert(it, level);
            }
        }

        void RemoveAsk(double price) {
            PriceLevel temp{ price, 0.0 };
            auto it = std::lower_bound(asks_.begin(), asks_.end(), temp);

            if (it != asks_.end() && std::abs(it->price - price) < 1e-8) {
                asks_.erase(it);
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // Data Members
        // ═══════════════════════════════════════════════════════════════
        std::vector<PriceLevel> bids_; // DESC сортировка (лучшая цена первая)
        std::vector<PriceLevel> asks_; // ASC сортировка (лучшая цена первая)
    };

} // namespace TradingBot::Core::Models