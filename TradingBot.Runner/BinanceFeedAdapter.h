#pragma once
#include <memory>
#include <sstream>
#ifdef _WIN32
#include <windows.h>
#endif
#include "../BinanceDataFeed/HighSpeedDataFeed.h"
#include "../BinanceDataFeed/DepthDelta.h"
#include "../TradingBot.Core/SharedState.h"
#include "../TradingBot.Core/RawOrderBook.h"

// ???????????????????????????????????????????????????????????????????????????????
// ULTRA LOW LATENCY ADAPTER - Zero-Copy Design
// ???????????????????????????????????????????????????????????????????????????????
class BinanceFeedAdapter {
public:
    BinanceFeedAdapter(std::shared_ptr<TradingBot::Core::SharedState> state)
        : state_(std::move(state)) {
        // Pre-allocate conversion buffers
        bidBuffer_.reserve(256);
        askBuffer_.reserve(256);
    }

    // ???????????????????????????????????????????????????????????????????????????????
    // CRITICAL HOT PATH - Every microsecond counts!
    // ???????????????????????????????????????????????????????????????????????????????
    void OnDepth(const std::string& symbol, const hft::ParsedDepthUpdate& upd) {
        if (!state_) [[unlikely]] return;
        
        // REUSE pre-allocated buffers (no allocation!)
        bidBuffer_.clear();
        askBuffer_.clear();
        
        // Direct conversion without intermediate allocations
        for (const auto& [price, qty] : upd.bids) {
            bidBuffer_.push_back({price, qty});
        }
        for (const auto& [price, qty] : upd.asks) {
            askBuffer_.push_back({price, qty});
        }
        
        // DIRECT UPDATE - No batching, no sorting (data is already sorted from Binance!)
        state_->ApplyUpdateDirect(bidBuffer_, askBuffer_);

        // Latency calculation (cheap)
        int64_t nowMs = hft::HighResTimer::UnixMs();
        int64_t latMs = nowMs - upd.transactionTime;
        if (latMs < 0) latMs = -latMs;
        state_->UpdateLatency(latMs);
    }

    // Tiger RAW snapshot handler
    void OnRawSnapshot(const std::string& symbol, int64_t lastUpdateId,
                       const std::vector<hft::DepthLevel>& bids,
                       const std::vector<hft::DepthLevel>& asks) {
        if (!state_) return;
        const int bcnt = static_cast<int>(std::min<size_t>(bids.size(), TradingBot::Core::Raw::MAX_LEVELS));
        const int acnt = static_cast<int>(std::min<size_t>(asks.size(), TradingBot::Core::Raw::MAX_LEVELS));
        for (int i = 0; i < bcnt; ++i) {
            rawBids_[i].price = bids[i].price;
            rawBids_[i].qty = bids[i].qty;
        }
        for (int i = 0; i < acnt; ++i) {
            rawAsks_[i].price = asks[i].price;
            rawAsks_[i].qty = asks[i].qty;
        }
        state_->ApplyRawSnapshot(lastUpdateId, rawBids_, bcnt, rawAsks_, acnt);
    }

    // Tiger RAW delta handler (OrderBook thread)
    void OnRawDelta(const hft::DepthDelta& d) {
        if (!state_) return;
        const int bcnt = (d.bidCount > TradingBot::Core::Raw::MAX_LEVELS) ? TradingBot::Core::Raw::MAX_LEVELS : d.bidCount;
        const int acnt = (d.askCount > TradingBot::Core::Raw::MAX_LEVELS) ? TradingBot::Core::Raw::MAX_LEVELS : d.askCount;
        for (int i = 0; i < bcnt; ++i) {
            rawBids_[i].price = d.bids[i].price;
            rawBids_[i].qty = d.bids[i].qty;
        }
        for (int i = 0; i < acnt; ++i) {
            rawAsks_[i].price = d.asks[i].price;
            rawAsks_[i].qty = d.asks[i].qty;
        }
        bool ok = state_->ApplyRawDelta(d.firstUpdateId, d.lastUpdateId, rawBids_, bcnt, rawAsks_, acnt);
        if (!ok) {
            // Force resync: consumer should trigger snapshot fetch
            state_->ResetOrderBook();
        }
    }

    void OnBookTicker(const std::string& symbol, const hft::ParsedBookTicker& bt) {
        if (!state_) [[unlikely]] return;
        
        // CRITICAL: Update best prices immediately - this is the fastest price source!
        state_->UpdateBestPrices(bt.bestBidPrice, bt.bestBidQty, bt.bestAskPrice, bt.bestAskQty);
        
        int64_t nowMs = hft::HighResTimer::UnixMs();
        int64_t latMs = nowMs - bt.transactionTime;
        if (latMs < 0) latMs = -latMs;
        state_->UpdateLatency(latMs);
    }

    void OnAggTrade(const std::string& symbol, const hft::ParsedAggTrade& trade) {
        (void)symbol; (void)trade;
        if (!state_) [[unlikely]] return;
        int64_t nowMs = hft::HighResTimer::UnixMs();
        int64_t latMs = nowMs - static_cast<int64_t>(trade.tradeTime);
        if (latMs < 0) latMs = -latMs;
        state_->UpdateLatency(latMs);
    }

    // ???????????????????????????????????????????????????????????????????????????????
    // Snapshot handler (not hot path)
    // ???????????????????????????????????????????????????????????????????????????????
    void OnSnapshot(const std::string& symbol, 
                    const std::vector<std::pair<double, double>>& bids,
                    const std::vector<std::pair<double, double>>& asks) {
        if (!state_) return;
        
        std::vector<TradingBot::Core::OrderBookLevel> bidLevels;
        std::vector<TradingBot::Core::OrderBookLevel> askLevels;
        bidLevels.reserve(bids.size());
        askLevels.reserve(asks.size());
        
        for (const auto& [price, qty] : bids) {
            bidLevels.push_back({price, qty});
        }
        for (const auto& [price, qty] : asks) {
            askLevels.push_back({price, qty});
        }
        
        state_->ApplySnapshot(bidLevels, askLevels);
        
#ifdef _WIN32
        std::ostringstream oss;
        oss << "[Adapter] Snapshot applied: " << symbol 
            << " bids=" << bids.size() << " asks=" << asks.size() << "\n";
        OutputDebugStringA(oss.str().c_str());
#endif
    }

    std::shared_ptr<TradingBot::Core::SharedState> GetState() const { return state_; }

private:
    std::shared_ptr<TradingBot::Core::SharedState> state_;
    
    // PRE-ALLOCATED buffers for zero-allocation in hot path
    std::vector<TradingBot::Core::OrderBookLevel> bidBuffer_;
    std::vector<TradingBot::Core::OrderBookLevel> askBuffer_;

    TradingBot::Core::Raw::Level rawBids_[TradingBot::Core::Raw::MAX_LEVELS];
    TradingBot::Core::Raw::Level rawAsks_[TradingBot::Core::Raw::MAX_LEVELS];
};
