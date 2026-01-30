#pragma once
#include <cstdint>

// POD delta message for SPSC ring between WS thread and OrderBook thread
namespace hft {

constexpr int MAX_DELTA_LEVELS = 64; // per depth event

struct DepthLevel {
    double price;
    double qty;
};

struct DepthDelta {
    int64_t eventTime;
    int64_t transactionTime;
    int64_t firstUpdateId; // U
    int64_t lastUpdateId;  // u
    char symbol[16];
    int bidCount;
    int askCount;
    DepthLevel bids[MAX_DELTA_LEVELS];
    DepthLevel asks[MAX_DELTA_LEVELS];
};

} // namespace hft
