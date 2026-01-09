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

        int64_t nowMs = hft::HighResTimer::UnixMs();
        int64_t latMs = nowMs - upd.transactionTime;
        if (latMs < 0) latMs = -latMs;
        state_->UpdateLatency(latMs);
    }

    void OnBookTicker(const std::string& symbol, const hft::ParsedBookTicker& bt) {
        if (!state_) return;
        state_->SetAppliedNow();
        int64_t nowMs = hft::HighResTimer::UnixMs();
        int64_t latMs = nowMs - bt.transactionTime;
        if (latMs < 0) latMs = -latMs;
        state_->UpdateLatency(latMs);
    }

    void OnAggTrade(const std::string& symbol, const hft::ParsedAggTrade& trade) {
        (void)symbol; (void)trade;
        if (!state_) return;
        int64_t nowMs = hft::HighResTimer::UnixMs();
        int64_t latMs = nowMs - static_cast<int64_t>(trade.tradeTime);
        if (latMs < 0) latMs = -latMs;
        state_->UpdateLatency(latMs);
    }

    std::shared_ptr<TradingBot::Core::SharedState> GetState() const { return state_; }

private:
    std::shared_ptr<TradingBot::Core::SharedState> state_;
};
