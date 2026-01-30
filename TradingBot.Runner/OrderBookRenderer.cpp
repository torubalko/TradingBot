#include "OrderBookRenderer.h"
#include <algorithm>
#include <sstream>
#include <iomanip>
#include <cmath>
#include <mutex>
#include "../TradingBot.Core/RawOrderBook.h"
#include <limits>
#include <iostream>

namespace {
    std::wstring FormatPriceDynamic(double price) {
        double absP = std::fabs(price);
        if (absP < 1e-12) return L"0";
        int exp10 = static_cast<int>(std::floor(std::log10(absP)));
        int decimals = 6 - exp10 - 1; // keep ~6 significant digits
        if (decimals < 0) decimals = 0;
        if (decimals > 8) decimals = 8;
        std::wstringstream ss;
        ss << std::fixed << std::setprecision(decimals) << price;
        auto s = ss.str();
        if (s.find(L'.') != std::wstring::npos) {
            while (!s.empty() && s.back() == L'0') s.pop_back();
            if (!s.empty() && s.back() == L'.') s.pop_back();
        }
        return s.empty() ? L"0" : s;
    }

    std::wstring FormatVolumeDynamic(double vol) {
        double absV = std::fabs(vol);
        wchar_t suffix = L'\0';
        double scaled = vol;
        if (absV >= 1'000'000'000.0) { suffix = L'B'; scaled = vol / 1'000'000'000.0; }
        else if (absV >= 1'000'000.0) { suffix = L'M'; scaled = vol / 1'000'000.0; }
        else if (absV >= 1'000.0) { suffix = L'K'; scaled = vol / 1'000.0; }

        int prec = 2;
        double absScaled = std::fabs(scaled);
        if (absScaled >= 100.0) prec = 0;
        else if (absScaled >= 10.0) prec = 1;
        else if (absScaled >= 1.0) prec = 2;
        else if (absScaled >= 0.1) prec = 3;
        else prec = 4;
        std::wstringstream ss;
        ss << std::fixed << std::setprecision(prec) << scaled;
        auto s = ss.str();
        if (s.find(L'.') != std::wstring::npos) {
            while (!s.empty() && s.back() == L'0') s.pop_back();
            if (!s.empty() && s.back() == L'.') s.pop_back();
        }
        if (suffix != L'\0') s.push_back(suffix);
        return s.empty() ? L"0" : s;
    }

    std::wstring FormatPercentShort(double pct) {
        std::wstringstream ss;
        ss << std::fixed << std::setprecision(4);
        if (pct > 0) ss << L"+";
        ss << pct << L"%";
        return ss.str();
    }
}

// ???????????????????????????????????????????????????????????????
// OrderBookRenderer Implementation
// ???????????????????????????????????????????????????????????????

OrderBookRenderer::OrderBookRenderer(Graphics* graphics, 
                                     std::shared_ptr<TradingBot::Core::SharedState> sharedState)
    : graphics_(graphics)
    , sharedState_(sharedState)
{
    // PRE-ALLOCATION: Резервируем память для буферов
    cachedBids_.reserve(100);
    cachedAsks_.reserve(100);
}

OrderBookRenderer::~OrderBookRenderer() {
    // Cleanup
}

void OrderBookRenderer::Render(float x, float y, float width, float height) {
auto renderStart = std::chrono::steady_clock::now();
if (!sharedState_) return;
const auto now = std::chrono::steady_clock::now();
    
// REDUCED THROTTLE: 8ms (~120 FPS) for faster price updates
// Real-time trading needs faster refresh than typical UI
const auto throttle = std::chrono::milliseconds(8);

const TradingBot::Core::RenderSnapshot* snapshotPtr = nullptr;
    
// Always fetch fresh snapshot - price accuracy is critical
// The GetSnapshotForRender already has version check optimization
int requestedDepth = visibleLevels_ * (compressionStep_ > 0 ? compressionStep_ : 1);
auto snap = sharedState_->GetSnapshotForRender(requestedDepth, 0.1);
if (snap.Version >= 0) {
    cachedSnapshot_ = std::move(snap);
    lastSnapshotFetch_ = now;
    snapshotPtr = &cachedSnapshot_;
} else if (cachedSnapshot_.Version >= 0) {
    // Fallback to cached if new fetch failed
    snapshotPtr = &cachedSnapshot_;
}

if (!snapshotPtr) {
    graphics_->DrawTextPixels(L"Waiting for Order Book synchronization...",
                             x + 10, y + 10, width - 20, 20, 12,
                             0.7f, 0.7f, 0.7f, 1.0f);
    return;
}

    const auto& snapshot = *snapshotPtr;
    const auto& bidsSrc = (volumeMode_ == VolumeMode::Quote && !snapshot.BidsQuote.empty()) ? snapshot.BidsQuote : snapshot.Bids;
    const auto& asksSrc = (volumeMode_ == VolumeMode::Quote && !snapshot.AsksQuote.empty()) ? snapshot.AsksQuote : snapshot.Asks;

    // Prefer RAW snapshot even if legacy vectors are empty
    auto rawSnap = sharedState_->GetRawSnapshot();
    const TradingBot::Core::Raw::SideBook* rawBids = rawSnap.bids;
    const TradingBot::Core::Raw::SideBook* rawAsks = rawSnap.asks;

#ifdef _WIN32
    // Debug: Log level counts periodically
    static auto lastLog = std::chrono::steady_clock::now();
    auto logNow = std::chrono::steady_clock::now();
    if (std::chrono::duration_cast<std::chrono::seconds>(logNow - lastLog).count() >= 5) {
        std::wstringstream dbg;
        size_t dbgBids = bidsSrc.size();
        size_t dbgAsks = asksSrc.size();
        if (rawBids) dbgBids = rawBids->size;
        if (rawAsks) dbgAsks = rawAsks->size;
        dbg << L"[OrderBook] Snapshot levels: bids=" << dbgBids 
            << L" asks=" << dbgAsks
            << L" compression=" << compressionStep_
            << L" visible=" << visibleLevels_ << L"\n";
        OutputDebugStringW(dbg.str().c_str());
        lastLog = logNow;
    }
#endif

    if ((bidsSrc.empty() || asksSrc.empty()) && (!rawBids || !rawAsks || rawBids->size == 0 || rawAsks->size == 0)) {
        graphics_->DrawTextPixels(L"Waiting for Order Book synchronization...", 
                                 x + 10, y + 10, width - 20, 20, 12, 
                                 0.7f, 0.7f, 0.7f, 1.0f);
        return;
    }

    cachedBids_.clear();
    cachedAsks_.clear();

    // Determine tick size from market metadata; fallback to deduced tick
    auto getMarketTick = [&]() {
        double tick = 0.0;
        std::string symbol = sharedState_->GetSymbol();
        if (!symbol.empty()) {
            std::lock_guard<std::mutex> lock(sharedState_->instrumentsMutex);
            const auto& pairs = sharedState_->marketData.futuresPairs.empty() ? sharedState_->marketData.spotPairs : sharedState_->marketData.futuresPairs;
            for (const auto& p : pairs) {
                if (p.symbol == symbol) { tick = p.tickSize; break; }
            }
        }
        if (tick > 0.0) return tick;

        // Fallback: detect minimal price increment from incoming levels
        auto deduceTick = [&](const std::vector<std::pair<double, double>>& a,
                             const std::vector<std::pair<double, double>>& b) {
            double t = 0.0;
            auto consider = [&](const std::vector<std::pair<double, double>>& src, bool descending) {
                if (src.size() < 2) return;
                for (size_t i = 0; i + 1 < src.size(); ++i) {
                    double diff = descending ? src[i].first - src[i + 1].first : src[i + 1].first - src[i].first;
                    if (diff > 1e-12) {
                        t = (t == 0.0) ? diff : (std::min)(t, diff);
                    }
                }
            };
            consider(a, true);
            consider(b, false);
            return t;
        };
        tick = deduceTick(bidsSrc, asksSrc);
        if (tick <= 0.0) tick = 0.1; // fallback
        return tick;
    };

    double tickSize = getMarketTick();
    if ((tickSize <= 0.0 || std::isnan(tickSize)) && rawBids && rawAsks) {
        // Fallback: deduce from RAW
        auto deduceTickRaw = [&](const TradingBot::Core::Raw::SideBook* side, bool descending){
            double t = 0.0;
            if (!side || side->size < 2) return t;
            for (int i = 0; i + 1 < side->size; ++i) {
                double d = descending ? (side->levels[i].price - side->levels[i+1].price)
                                      : (side->levels[i+1].price - side->levels[i].price);
                if (d > 1e-12) t = (t == 0.0) ? d : (std::min)(t, d);
            }
            return t;
        };
        double tb = deduceTickRaw(rawBids, true);
        double ta = deduceTickRaw(rawAsks, false);
        double t = 0.0;
        if (tb > 0.0 && ta > 0.0) t = (tb < ta) ? tb : ta;
        else t = (tb > 0.0) ? tb : ta;
        if (t > 0.0) tickSize = t;
    }
    double bucketWidth = tickSize * (compressionStep_ > 0 ? compressionStep_ : 1);
    if (bucketWidth <= 0.0) bucketWidth = 0.1;

    // CRITICAL: Use bookTicker prices for mid-anchor (REAL-TIME!)
    // BookTicker updates instantly when best price changes
    // Depth snapshot is delayed by 100ms
    double tickerBid = sharedState_->GetTickerBestBid();
    double tickerAsk = sharedState_->GetTickerBestAsk();
    
    // Fallback to depth snapshot if bookTicker not available yet
    double bestBidSrc = (tickerBid > 0.0) ? tickerBid : (bidsSrc.empty() ? 0.0 : bidsSrc[0].first);
    double bestAskSrc = (tickerAsk > 0.0) ? tickerAsk : (asksSrc.empty() ? 0.0 : asksSrc[0].first);
    if (bestBidSrc <= 0.0 && rawBids && rawBids->size > 0) bestBidSrc = rawBids->levels[0].price;
    if (bestAskSrc <= 0.0 && rawAsks && rawAsks->size > 0) bestAskSrc = rawAsks->levels[0].price;
    
    double midAnchor = 0.0;
    if (bestBidSrc > 0.0 && bestAskSrc > 0.0) midAnchor = (bestBidSrc + bestAskSrc) * 0.5;
    else if (bestBidSrc > 0.0) midAnchor = bestBidSrc;
    else if (bestAskSrc > 0.0) midAnchor = bestAskSrc;

    const int MAX_VIS = 2048;
    int vis = (visibleLevels_ > 0) ? visibleLevels_ : 1;
    if (vis > MAX_VIS) vis = MAX_VIS;
    double bidBuckets[2048] = {};
    double askBuckets[2048] = {};
    double bidsAnchor = (bestBidSrc > 0.0) ? std::floor(bestBidSrc / bucketWidth) * bucketWidth
                                           : std::floor(midAnchor / bucketWidth) * bucketWidth;
    // Align ask bucket 0 exactly to best ask so first visible level is best ask
    double asksAnchor = (bestAskSrc > 0.0) ? std::floor(bestAskSrc / bucketWidth) * bucketWidth
                                           : std::floor(midAnchor / bucketWidth) * bucketWidth;

    auto compressSide = [&](const TradingBot::Core::Raw::SideBook* side, bool isBid, double anchor, double* buckets){
        if (!side) return;
        for (int i = 0; i < side->size; ++i) {
            double price = side->levels[i].price;
            double qty = side->levels[i].qty;
            double bucket = std::floor(price / bucketWidth) * bucketWidth;
            double offset = isBid ? ((anchor - bucket) / bucketWidth) : ((bucket - anchor) / bucketWidth);
            int idx = static_cast<int>(offset + 0.5);
            if (idx >= 0 && idx < vis && idx < MAX_VIS) {
                buckets[idx] += qty;
            }
        }
    };

    // Prefer RAW snapshot when available
    if (rawBids && rawAsks) {
        compressSide(rawBids, true, bidsAnchor, bidBuckets);
        compressSide(rawAsks, false, asksAnchor, askBuckets);

        cachedBids_.clear();
        cachedAsks_.clear();
        cachedBids_.reserve(vis);
        cachedAsks_.reserve(vis);
        for (int i = 0; i < vis; ++i) {
            cachedBids_.emplace_back(bidsAnchor - static_cast<double>(i) * bucketWidth, bidBuckets[i]);
            cachedAsks_.emplace_back(asksAnchor + static_cast<double>(i) * bucketWidth, askBuckets[i]);
        }
    } else {
        // Fallback to existing compressed vectors if raw not ready
        cachedBids_.clear();
        cachedAsks_.clear();
        cachedBids_.reserve(bidsSrc.size());
        cachedAsks_.reserve(asksSrc.size());
        cachedBids_.insert(cachedBids_.end(), bidsSrc.begin(), bidsSrc.end());
        cachedAsks_.insert(cachedAsks_.end(), asksSrc.begin(), asksSrc.end());
    }

    // If quote data is not precomputed, derive from price*base
    if (volumeMode_ == VolumeMode::Quote) {
        if (snapshot.BidsQuote.empty()) {
            for (auto& p : cachedBids_) p.second = p.first * p.second;
        }
        if (snapshot.AsksQuote.empty()) {
            for (auto& p : cachedAsks_) p.second = p.first * p.second;
        }
    }

    double maxVolume = CalculateMaxVolume(cachedBids_, cachedAsks_);
    if (maxVolume < 0.001) maxVolume = 1.0;

    float halfHeight = height * 0.5f;
    float asksY = y;
    float bidsY = y + halfHeight;

    // ASKS (top half, best ask adjacent to spread line)
    // mid-price for percent labels
    double bestBid = cachedBids_.empty() ? 0.0 : cachedBids_[0].first;
    double bestAsk = cachedAsks_.empty() ? 0.0 : cachedAsks_[0].first;
    double midPrice = (bestBid > 0.0 && bestAsk > 0.0) ? (bestBid + bestAsk) * 0.5 : (bestBid > 0.0 ? bestBid : bestAsk);
    double midForChart = (midAnchor > 0.0) ? midAnchor : midPrice;

    // Update mid-price history for mini chart (use unbucketed mid)
    if (midForChart > 0.0 && (midHistory_.empty() || std::fabs(midForChart - lastMid_) > 1e-9)) {
        midHistory_.push_back(midForChart);
        lastMid_ = midForChart;
        flashUntil_ = now + std::chrono::milliseconds(5);
    }

    RenderAsks(x, asksY, width, halfHeight, cachedAsks_, maxVolume, midPrice);
    
    // Spread line between halves
    RenderSpreadLine(x, y + halfHeight, width, bestBid, bestAsk);
    
    // BIDS (bottom half, best bid adjacent to spread line)
    RenderBids(x, bidsY, width, halfHeight, cachedBids_, maxVolume, midPrice);

    // Mini mid-price chart across the book width, scaled to current price span
    if (midHistory_.size() >= 2) {
        float chartWidth = width * 0.5f;
        float chartHeight = height;
        float chartX = x + width * 0.1f;
        float chartY = y;

        // fixed step for discrete shift
        float sampleStep = 4.0f;
        size_t maxSamples = static_cast<size_t>(chartWidth / sampleStep) + 1;
        while (midHistory_.size() > maxSamples) {
            midHistory_.pop_front();
        }

        double priceMin = midForChart - bucketWidth * static_cast<double>(visibleLevels_ - 1);
        double priceMax = midForChart + bucketWidth * static_cast<double>(visibleLevels_ - 1);
        double priceSpan = priceMax - priceMin;
        if (priceSpan < 1e-9) priceSpan = bucketWidth;

        size_t count = midHistory_.size();
        float startX = chartX + chartWidth - sampleStep * static_cast<float>(count - 1);
        auto priceToY = [&](double p) -> float {
            double clamped = (p < priceMin) ? priceMin : (p > priceMax ? priceMax : p);
            double norm = (clamped - priceMin) / priceSpan;
            return chartY + chartHeight - static_cast<float>(norm) * chartHeight;
        };
        float prevX = startX;
        float prevY = priceToY(midHistory_[0]);

        for (size_t i = 1; i < count; ++i) {
            float currX = startX + sampleStep * static_cast<float>(i);
            float currY = priceToY(midHistory_[i]);
            // draw thin segment as rect
            float segX = (prevX < currX) ? prevX : currX;
            float segY = (prevY < currY) ? prevY : currY;
            float segW = std::fabs(currX - prevX);
            float segH = std::fabs(currY - prevY);
            if (segW < 2.0f) segW = 2.0f;
            if (segH < 2.0f) segH = 2.0f;
            graphics_->DrawRectPixels(segX, segY, segW, segH, 0.2f, 0.7f, 1.0f, 1.0f);
            prevX = currX;
            prevY = currY;
        }
    }

    // Price-change flash indicator (top-left corner of book)
    if (flashUntil_.time_since_epoch().count() > 0 && now < flashUntil_) {
        float flashSize = 14.0f;
        graphics_->DrawRectPixels(x + 6.0f, y + 6.0f, flashSize, flashSize, 0.2f, 0.8f, 1.0f, 1.0f);
    }

#ifdef _DEBUG
    auto renderEnd = std::chrono::steady_clock::now();
    auto durMs = std::chrono::duration_cast<std::chrono::milliseconds>(renderEnd - renderStart).count();
    if (durMs > 10) {
        std::cout << "[RenderProfile] OrderBookRenderer::Render took " << durMs << " ms\n";
    }
#endif
}

void OrderBookRenderer::RenderAsks(float x, float y, float width, float height,
                                   const std::vector<std::pair<double, double>>& asks,
                                   double maxVolume,
                                   double midPrice) {
    if (asks.empty()) return;
    
    float levelHeight = height / visibleLevels_;
    float currentY = y + height - levelHeight; // Снизу вверх (best ask внизу)
    
    // ???????????????????????????????????????????????????????????????
    // GPU BATCH RENDERING: Все бары в одном проходе
    // ???????????????????????????????????????????????????????????????
    
    for (size_t i = 0; i < asks.size() && i < (size_t)visibleLevels_; ++i) {
        double price = asks[i].first;
        double volume = asks[i].second;
        
        bool hasVolume = volume > 1e-12;
        float ratio = hasVolume && domQuoteMaxSize_ > 0.0
            ? static_cast<float>(volume / domQuoteMaxSize_)
            : 0.0f;
        ratio = std::clamp(ratio, 0.0f, 1.0f);

        const bool isBest = (i == 0);

        // Density background (full width)
        if (hasVolume) {
            const float baseR = isBest ? 0.65f : 0.45f;
            const float baseG = 0.10f;
            const float baseB = 0.10f;
            const float alpha = isBest ? 0.50f : 0.35f;
            graphics_->DrawRectPixels(x, currentY, width, levelHeight,
                                     baseR, baseG, baseB, alpha);
        }

        // Volume bar (asks)
        float availableWidth = width - 180.0f;
        if (availableWidth < 1.0f) availableWidth = 0.0f;
        float barWidth = hasVolume ? (std::min)(availableWidth, (std::max)(availableWidth * ratio, 1.0f)) : 0.0f;
        if (hasVolume && barWidth > 0.0f) {
            float barX = x + availableWidth - barWidth;
            graphics_->DrawRectPixels(barX, currentY + 1, barWidth, levelHeight - 2,
                                     0.95f, 0.12f, 0.12f, 0.80f);
        }
        
        // Price text
        std::wstring priceStr = FormatPriceDynamic(price);
        graphics_->DrawTextPixels(priceStr, x + 10, currentY + 2, 120, levelHeight - 4, 11,
                                 1.0f, 0.5f, 0.5f, 1.0f); // красно-розовый текст
        
        // Volume text
        std::wstring volumeStr = FormatVolumeDynamic(volume);
        graphics_->DrawTextPixels(volumeStr, x + width - 170, currentY + 2, 80, levelHeight - 4, 11,
                                 0.8f, 0.8f, 0.8f, 1.0f);
 
         // Percent text (relative to mid)
         double pct = (midPrice > 0.0) ? ((price - midPrice) / midPrice) * 100.0 : 0.0;
         std::wstring pctStr = FormatPercentShort(pct);
        graphics_->DrawTextPixels(pctStr, x + width - 80, currentY + 2, 70, levelHeight - 4, 11,
                                 0.8f, 0.9f, 1.0f, 1.0f);
        
        currentY -= levelHeight;
    }
}

void OrderBookRenderer::RenderBids(float x, float y, float width, float height,
                                   const std::vector<std::pair<double, double>>& bids,
                                   double maxVolume,
                                   double midPrice) {
    if (bids.empty()) return;
    
    float levelHeight = height / visibleLevels_;
    float currentY = y;
    
    // ???????????????????????????????????????????????????????????????
    // GPU BATCH RENDERING: Все бары в одном проходе
    // ???????????????????????????????????????????????????????????????
    
    for (size_t i = 0; i < bids.size() && i < (size_t)visibleLevels_; ++i) {
        double price = bids[i].first;
        double volume = bids[i].second;
        
        bool hasVolume = volume > 1e-12;
        float ratio = hasVolume && domQuoteMaxSize_ > 0.0
            ? static_cast<float>(volume / domQuoteMaxSize_)
            : 0.0f;
        ratio = std::clamp(ratio, 0.0f, 1.0f);

        const bool isBest = (i == 0);

        // Density background (full width)
        if (hasVolume) {
            const float baseR = 0.10f;
            const float baseG = isBest ? 0.65f : 0.45f;
            const float baseB = 0.10f;
            const float alpha = isBest ? 0.50f : 0.35f;
            graphics_->DrawRectPixels(x, currentY, width, levelHeight,
                                     baseR, baseG, baseB, alpha);
        }

        // Volume bar (bids)
        float availableWidth = width - 180.0f;
        if (availableWidth < 1.0f) availableWidth = 0.0f;
        float barWidth = hasVolume ? (std::min)(availableWidth, (std::max)(availableWidth * ratio, 1.0f)) : 0.0f;
        if (hasVolume && barWidth > 0.0f) {
            float barX = x + availableWidth - barWidth;
            graphics_->DrawRectPixels(barX, currentY + 1, barWidth, levelHeight - 2,
                                     0.12f, 0.95f, 0.12f, 0.80f);
        }

        // Price text
        std::wstring priceStr = FormatPriceDynamic(price);
        graphics_->DrawTextPixels(priceStr, x + 10, currentY + 2, 120, levelHeight - 4, 11,
                                 0.5f, 1.0f, 0.5f, 1.0f); // зелено-белый текст
        
        // Volume text
        std::wstring volumeStr = FormatVolumeDynamic(volume);
        graphics_->DrawTextPixels(volumeStr, x + width - 170, currentY + 2, 80, levelHeight - 4, 11,
                                 0.8f, 0.8f, 0.8f, 1.0f);
 
         // Percent text (relative to mid)
         double pct = (midPrice > 0.0) ? ((price - midPrice) / midPrice) * 100.0 : 0.0;
         std::wstring pctStr = FormatPercentShort(pct);
        graphics_->DrawTextPixels(pctStr, x + width - 80, currentY + 2, 70, levelHeight - 4, 11,
                                 0.8f, 0.9f, 1.0f, 1.0f);
        
        currentY += levelHeight;
    }
}

void OrderBookRenderer::RenderSpreadLine(float x, float y, float width, double bidPrice, double askPrice) {
    // Thin separator line at spread level
    graphics_->DrawRectPixels(x, y - 1.0f, width, 2.0f, 0.95f, 0.85f, 0.1f, 1.0f);
}

double OrderBookRenderer::CalculateMaxVolume(const std::vector<std::pair<double, double>>& bids,
                                            const std::vector<std::pair<double, double>>& asks) {
    double maxVol = 0.0;
    
    for (const auto& bid : bids) {
        if (bid.second > maxVol) maxVol = bid.second;
    }
    
    for (const auto& ask : asks) {
        if (ask.second > maxVol) maxVol = ask.second;
    }
    
    return maxVol;
}


