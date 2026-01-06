#pragma once
#include <deque>
#include <vector>
#include <numeric>
#include <algorithm>
#include "Types.h"

namespace TradingBot::Core::Strategy {
    // Flow statistics for a time window
    struct FlowStats {
        double buyVolume = 0;
        double sellVolume = 0;
        double buyQuoteVolume = 0;
        double sellQuoteVolume = 0;
        int buyCount = 0;
        int sellCount = 0;
        
        double GetNetFlow() const { return buyVolume - sellVolume; }
        double GetNetQuoteFlow() const { return buyQuoteVolume - sellQuoteVolume; }
        double GetBuyPressure() const {
            double total = buyVolume + sellVolume;
            return total > 0 ? buyVolume / total : 0.5;
        }
    };

    // Analyzer for aggressive taker flow (market orders)
    class TakerFlowAnalyzer {
    public:
        explicit TakerFlowAnalyzer(size_t windowSize = 100, long long timeWindowMs = 10000)
            : maxWindowSize_(windowSize), timeWindowMs_(timeWindowMs) {
            trades_.reserve(windowSize);
        }

        // Process incoming aggTrade
        void ProcessTrade(const Trade& trade) {
            trades_.push_back(trade);
            
            // Remove old trades beyond window size
            if (trades_.size() > maxWindowSize_) {
                trades_.pop_front();
            }
            
            // Remove trades outside time window
            long long cutoffTime = trade.timestamp - timeWindowMs_;
            while (!trades_.empty() && trades_.front().timestamp < cutoffTime) {
                trades_.pop_front();
            }
        }

        // Get flow statistics for the current window
        FlowStats GetFlowStats() const {
            FlowStats stats;
            
            for (const auto& trade : trades_) {
                double quoteVolume = trade.price * trade.quantity;
                
                if (trade.isBuyerMaker) {
                    // Buyer is maker = aggressive sell
                    stats.sellVolume += trade.quantity;
                    stats.sellQuoteVolume += quoteVolume;
                    ++stats.sellCount;
                } else {
                    // Seller is maker = aggressive buy
                    stats.buyVolume += trade.quantity;
                    stats.buyQuoteVolume += quoteVolume;
                    ++stats.buyCount;
                }
            }
            
            return stats;
        }

        // Get flow stats for a specific time period
        FlowStats GetFlowStats(long long startTime, long long endTime) const {
            FlowStats stats;
            
            for (const auto& trade : trades_) {
                if (trade.timestamp < startTime || trade.timestamp > endTime) {
                    continue;
                }
                
                double quoteVolume = trade.price * trade.quantity;
                
                if (trade.isBuyerMaker) {
                    stats.sellVolume += trade.quantity;
                    stats.sellQuoteVolume += quoteVolume;
                    ++stats.sellCount;
                } else {
                    stats.buyVolume += trade.quantity;
                    stats.buyQuoteVolume += quoteVolume;
                    ++stats.buyCount;
                }
            }
            
            return stats;
        }

        // Detect strong directional flow
        bool HasStrongBuyPressure(double threshold = 0.7) const {
            auto stats = GetFlowStats();
            return stats.GetBuyPressure() >= threshold && (stats.buyCount + stats.sellCount) >= 10;
        }

        bool HasStrongSellPressure(double threshold = 0.7) const {
            auto stats = GetFlowStats();
            return stats.GetBuyPressure() <= (1.0 - threshold) && (stats.buyCount + stats.sellCount) >= 10;
        }

        // Get volume-weighted average price
        double GetVWAP() const {
            if (trades_.empty()) return 0;
            
            double totalQuoteVolume = 0;
            double totalVolume = 0;
            
            for (const auto& trade : trades_) {
                totalQuoteVolume += trade.price * trade.quantity;
                totalVolume += trade.quantity;
            }
            
            return totalVolume > 0 ? totalQuoteVolume / totalVolume : 0;
        }

        size_t GetTradeCount() const { return trades_.size(); }
        const std::deque<Trade>& GetTrades() const { return trades_; }

    private:
        std::deque<Trade> trades_;
        size_t maxWindowSize_;
        long long timeWindowMs_;
    };
}
