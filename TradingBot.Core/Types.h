#pragma once
#include <vector>
#include <string>

namespace TradingBot::Core {

    // ═══════════════════════════════════════════════════════════════
    // Базовая структура для price level
    // ═══════════════════════════════════════════════════════════════
    struct OrderBookLevel {
        double price{ 0.0 };
        double quantity{ 0.0 };
    };

    // ═══════════════════════════════════════════════════════════════
    // WebSocket Update Structure
    // ═══════════════════════════════════════════════════════════════
    struct OrderBookUpdate {
        long long u{ 0 };  // Final update ID
        long long U{ 0 };  // First update ID
        long long pu{ 0 }; // Previous final update ID (Futures)
        long long E{ 0 };  // Event time

        std::vector<OrderBookLevel> bids;
        std::vector<OrderBookLevel> asks;

        // PRE-ALLOCATION в конструкторе
        OrderBookUpdate() {
            bids.reserve(100);
            asks.reserve(100);
        }
    };

    // ═══════════════════════════════════════════════════════════════
    // REST Snapshot Structure
    // ═══════════════════════════════════════════════════════════════
    struct OrderBookSnapshot {
        long long lastUpdateId{ 0 };
        std::vector<OrderBookLevel> bids;
        std::vector<OrderBookLevel> asks;

        OrderBookSnapshot() {
            bids.reserve(1000);
            asks.reserve(1000);
        }
    };

    // ═══════════════════════════════════════════════════════════════
    // Trade Structure (для aggTrade стрима)
    // ═══════════════════════════════════════════════════════════════
    struct Trade {
        double price{ 0.0 };
        double quantity{ 0.0 };
        bool isBuyerMaker{ false };
        long long timestamp{ 0 };
    };

} // namespace TradingBot::Core