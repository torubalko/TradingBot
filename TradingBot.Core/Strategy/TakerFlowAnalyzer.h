#pragma once
#include <deque>
#include <vector>
#include <mutex>
#include <chrono>
#include "../Types.h"

namespace TradingBot::Core::Strategy {
    struct FlowMetrics {
        double buyerVolume;     // Total volume from buyer-initiated trades
        double sellerVolume;    // Total volume from seller-initiated trades
        double buyerValue;      // Total value (price * quantity) from buyers
        double sellerValue;     // Total value from sellers
        double aggression;      // Ratio: (buyerVolume - sellerVolume) / (buyerVolume + sellerVolume)
        int buyerTradeCount;
        int sellerTradeCount;
        long long timeWindowMs;
    };

    class TakerFlowAnalyzer {
    public:
        TakerFlowAnalyzer(long long timeWindowMs = 60000, size_t maxTrades = 1000)
            : timeWindowMs_(timeWindowMs), maxTrades_(maxTrades) {}

        void AddTrade(const Trade& trade) {
            std::lock_guard<std::mutex> lock(mutex_);
            
            trades_.push_back(trade);
            
            // Keep only recent trades
            if (trades_.size() > maxTrades_) {
                trades_.pop_front();
            }
        }

        FlowMetrics CalculateFlow() const {
            std::lock_guard<std::mutex> lock(mutex_);
            
            FlowMetrics metrics{};
            metrics.timeWindowMs = timeWindowMs_;

            if (trades_.empty()) {
                return metrics;
            }

            long long now = std::chrono::duration_cast<std::chrono::milliseconds>(
                std::chrono::system_clock::now().time_since_epoch()
            ).count();

            long long cutoffTime = now - timeWindowMs_;

            for (const auto& trade : trades_) {
                if (trade.timestamp < cutoffTime) {
                    continue;
                }

                double tradeValue = trade.price * trade.quantity;

                if (trade.isBuyerMaker) {
                    // Seller initiated (taker is selling, hitting bid)
                    metrics.sellerVolume += trade.quantity;
                    metrics.sellerValue += tradeValue;
                    metrics.sellerTradeCount++;
                } else {
                    // Buyer initiated (taker is buying, hitting ask)
                    metrics.buyerVolume += trade.quantity;
                    metrics.buyerValue += tradeValue;
                    metrics.buyerTradeCount++;
                }
            }

            double totalVolume = metrics.buyerVolume + metrics.sellerVolume;
            if (totalVolume > 0.0000001) {
                metrics.aggression = (metrics.buyerVolume - metrics.sellerVolume) / totalVolume;
            }

            return metrics;
        }

        FlowMetrics CalculateFlowCustomWindow(long long customWindowMs) const {
            std::lock_guard<std::mutex> lock(mutex_);
            
            FlowMetrics metrics{};
            metrics.timeWindowMs = customWindowMs;

            if (trades_.empty()) {
                return metrics;
            }

            long long now = std::chrono::duration_cast<std::chrono::milliseconds>(
                std::chrono::system_clock::now().time_since_epoch()
            ).count();

            long long cutoffTime = now - customWindowMs;

            for (const auto& trade : trades_) {
                if (trade.timestamp < cutoffTime) {
                    continue;
                }

                double tradeValue = trade.price * trade.quantity;

                if (trade.isBuyerMaker) {
                    metrics.sellerVolume += trade.quantity;
                    metrics.sellerValue += tradeValue;
                    metrics.sellerTradeCount++;
                } else {
                    metrics.buyerVolume += trade.quantity;
                    metrics.buyerValue += tradeValue;
                    metrics.buyerTradeCount++;
                }
            }

            double totalVolume = metrics.buyerVolume + metrics.sellerVolume;
            if (totalVolume > 0.0000001) {
                metrics.aggression = (metrics.buyerVolume - metrics.sellerVolume) / totalVolume;
            }

            return metrics;
        }

        void SetTimeWindow(long long timeWindowMs) {
            timeWindowMs_ = timeWindowMs;
        }

        void Clear() {
            std::lock_guard<std::mutex> lock(mutex_);
            trades_.clear();
        }

    private:
        mutable std::mutex mutex_;
        std::deque<Trade> trades_;
        long long timeWindowMs_;
        size_t maxTrades_;
    };
}
