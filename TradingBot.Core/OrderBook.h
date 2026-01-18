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
        // Batch Update with Sorted Merge - ULTRA LOW LATENCY
        // Pre-sorted updates are merged in O(n) instead of O(n log n)
        // ═══════════════════════════════════════════════════════════════
        void ApplyBatchUpdate(const std::vector<PriceLevel>& bidUpdates,
                             const std::vector<PriceLevel>& askUpdates) {
            // Batch updates are already sorted by caller
            // Use sorted merge for O(n) complexity instead of O(n log n)
            
            if (!bidUpdates.empty()) {
                MergeBidsOptimized(bidUpdates);
            }
            
            if (!askUpdates.empty()) {
                MergeAsksOptimized(askUpdates);
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

        // ═══════════════════════════════════════════════════════════════
        // ULTRA LOW LATENCY: Direct access methods (PUBLIC for SharedState)
        // These use binary search O(log n) - very fast for incremental updates
        // ═══════════════════════════════════════════════════════════════
        
        void UpsertBidDirect(double price, double quantity) {
            // Binary search (DESC sorted)
            auto it = std::lower_bound(bids_.begin(), bids_.end(), price,
                [](const PriceLevel& a, double p) {
                    return a.price > p; // DESC
                });

            if (it != bids_.end() && std::abs(it->price - price) < 1e-8) {
                it->quantity = quantity;  // Update in place - NO ALLOCATION
            } else {
                bids_.insert(it, PriceLevel{price, quantity});
            }
        }
        
        void RemoveBidDirect(double price) {
            auto it = std::lower_bound(bids_.begin(), bids_.end(), price,
                [](const PriceLevel& a, double p) {
                    return a.price > p;
                });

            if (it != bids_.end() && std::abs(it->price - price) < 1e-8) {
                bids_.erase(it);
            }
        }
        
        void UpsertAskDirect(double price, double quantity) {
            PriceLevel temp{price, 0.0};
            auto it = std::lower_bound(asks_.begin(), asks_.end(), temp);

            if (it != asks_.end() && std::abs(it->price - price) < 1e-8) {
                it->quantity = quantity;  // Update in place - NO ALLOCATION
            } else {
                asks_.insert(it, PriceLevel{price, quantity});
            }
        }
        
        void RemoveAskDirect(double price) {
            PriceLevel temp{price, 0.0};
            auto it = std::lower_bound(asks_.begin(), asks_.end(), temp);

            if (it != asks_.end() && std::abs(it->price - price) < 1e-8) {
                asks_.erase(it);
            }
        }

    private:
        // ═══════════════════════════════════════════════════════════════
        // Internal Helpers: Binary Search + In-place Modification
        // ═══════════════════════════════════════════════════════════════

        void UpsertBid(const PriceLevel& level) {
            UpsertBidDirect(level.price, level.quantity);
        }

        void RemoveBid(double price) {
            RemoveBidDirect(price);
        }

        void UpsertAsk(const PriceLevel& level) {
            UpsertAskDirect(level.price, level.quantity);
        }

        void RemoveAsk(double price) {
            RemoveAskDirect(price);
        }

        // ═══════════════════════════════════════════════════════════════
        // Optimized Sorted Merge for Batch Processing - O(n) complexity
        // ═══════════════════════════════════════════════════════════════
        
        void MergeBidsOptimized(const std::vector<PriceLevel>& updates) {
            // Pre-condition: updates are sorted DESC
            std::vector<PriceLevel> merged;
            merged.reserve(bids_.size() + updates.size());
            
            auto it1 = bids_.begin();
            auto it2 = updates.begin();
            
            // Two-pointer merge (DESC order)
            while (it1 != bids_.end() && it2 != updates.end()) {
                if (it1->price > it2->price) {
                    merged.push_back(*it1++);
                } else if (std::abs(it1->price - it2->price) < 1e-8) {
                    // Update existing level or remove if qty is 0
                    if (it2->quantity > 1e-8) {
                        merged.push_back(*it2);
                    }
                    ++it1;
                    ++it2;
                } else {
                    // New level from updates
                    if (it2->quantity > 1e-8) {
                        merged.push_back(*it2);
                    }
                    ++it2;
                }
            }
            
            // Append remaining elements
            while (it1 != bids_.end()) {
                merged.push_back(*it1++);
            }
            while (it2 != updates.end()) {
                if (it2->quantity > 1e-8) {
                    merged.push_back(*it2);
                }
                ++it2;
            }
            
            bids_ = std::move(merged);
        }
        
        void MergeAsksOptimized(const std::vector<PriceLevel>& updates) {
            // Pre-condition: updates are sorted ASC
            std::vector<PriceLevel> merged;
            merged.reserve(asks_.size() + updates.size());
            
            auto it1 = asks_.begin();
            auto it2 = updates.begin();
            
            // Two-pointer merge (ASC order)
            while (it1 != asks_.end() && it2 != updates.end()) {
                if (it1->price < it2->price) {
                    merged.push_back(*it1++);
                } else if (std::abs(it1->price - it2->price) < 1e-8) {
                    // Update existing level or remove if qty is 0
                    if (it2->quantity > 1e-8) {
                        merged.push_back(*it2);
                    }
                    ++it1;
                    ++it2;
                } else {
                    // New level from updates
                    if (it2->quantity > 1e-8) {
                        merged.push_back(*it2);
                    }
                    ++it2;
                }
            }
            
            // Append remaining elements
            while (it1 != asks_.end()) {
                merged.push_back(*it1++);
            }
            while (it2 != updates.end()) {
                if (it2->quantity > 1e-8) {
                    merged.push_back(*it2);
                }
                ++it2;
            }
            
            asks_ = std::move(merged);
        }

        // ═══════════════════════════════════════════════════════════════
        // Data Members
        // ═══════════════════════════════════════════════════════════════
        std::vector<PriceLevel> bids_; // DESC сортировка (лучшая цена первая)
        std::vector<PriceLevel> asks_; // ASC сортировка (лучшая цена первая)
    };

} // namespace TradingBot::Core::Models