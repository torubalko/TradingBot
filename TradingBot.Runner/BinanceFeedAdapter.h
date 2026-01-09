#pragma once
#include <memory>
#include "../BinanceDataFeed/HighSpeedDataFeed.h"
#include "../TradingBot.Core/SharedState.h"

// Lightweight adapter: pushes depth/book/trade into SharedState without locks on hot path
class BinanceFeedAdapter {
public:
    BinanceFeedAdapter(std::shared_ptr<TradingBot::Core::SharedState> state)
        : state_(std::move(state)) {}

    void OnDepth(const std::string& symbol, const hft::ParsedDepthUpdate& upd) {
        if (!state_) return;
        std::vector<TradingBot::Core::OrderBookLevel> bids;
        std::vector<TradingBot::Core::OrderBookLevel> asks;
        bids.reserve(upd.bids.size());
        asks.reserve(upd.asks.size());
        for (auto& b : upd.bids) bids.push_back({ b.first, b.second });
        for (auto& a : upd.asks) asks.push_back({ a.first, a.second });
        state_->ApplyUpdate(bids, asks);
    }

    void OnBookTicker(const std::string& symbol, const hft::ParsedBookTicker& bt) {
        if (!state_) return;
        // BookTicker can be used to update latency/staleness if needed
        state_->SetAppliedNow();
    }

    void OnAggTrade(const std::string& symbol, const hft::ParsedAggTrade& trade) {
        // TODO: push trades to SharedState if needed (not present yet)
        (void)symbol; (void)trade;
    }

    std::shared_ptr<TradingBot::Core::SharedState> GetState() const { return state_; }

private:
    std::shared_ptr<TradingBot::Core::SharedState> state_;
};
