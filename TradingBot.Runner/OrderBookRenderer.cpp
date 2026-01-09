#include "OrderBookRenderer.h"
#include <algorithm>
#include <sstream>
#include <iomanip>
#include <cmath>
#include <limits>
#include <unordered_map>

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
    if (!sharedState_) return;

    auto snapshot = sharedState_->GetSnapshotForRender(visibleLevels_, 0.1);
    
    if (snapshot.Bids.empty() || snapshot.Asks.empty()) {
        graphics_->DrawTextPixels(L"Waiting for Order Book synchronization...", 
                                 x + 10, y + 10, width - 20, 20, 12, 
                                 0.7f, 0.7f, 0.7f, 1.0f);
        return;
    }

    cachedBids_.clear();
    cachedAsks_.clear();
    filledBids_.clear();
    filledAsks_.clear();
    
    int bidsToShow = (std::min)((int)snapshot.Bids.size(), visibleLevels_);
    int asksToShow = (std::min)((int)snapshot.Asks.size(), visibleLevels_);
    
    for (int i = 0; i < bidsToShow; ++i) {
        cachedBids_.push_back(snapshot.Bids[i]);
    }
    
    for (int i = 0; i < asksToShow; ++i) {
        cachedAsks_.push_back(snapshot.Asks[i]);
    }

    filledBids_ = FillSide(cachedBids_, true);
    filledAsks_ = FillSide(cachedAsks_, false);

    double stepCommon = DetectCommonStep(cachedBids_, cachedAsks_);
    if (stepCommon <= 0.0) stepCommon = 0.1;

    double bestBid = filledBids_.empty() ? 0.0 : filledBids_[0].first;
    double bestAsk = filledAsks_.empty() ? 0.0 : filledAsks_[0].first;

    if (bestAsk <= bestBid) {
        // realign asks above bids with common step
        filledAsks_ = FillSide(cachedAsks_, false, bestBid + stepCommon);
        bestAsk = filledAsks_.empty() ? 0.0 : filledAsks_[0].first;
    }

    double maxVolume = CalculateMaxVolume(filledBids_, filledAsks_);
    if (maxVolume < 0.001) maxVolume = 1.0;

    float halfHeight = height * 0.5f;
    float asksY = y;
    float bidsY = y + halfHeight;

    // ASKS (top half, best ask adjacent to spread line)
    RenderAsks(x, asksY, width, halfHeight, filledAsks_, maxVolume);
    
    // Spread line between halves
    RenderSpreadLine(x, y + halfHeight, width, bestBid, bestAsk);
    
    // BIDS (bottom half, best bid adjacent to spread line)
    RenderBids(x, bidsY, width, halfHeight, filledBids_, maxVolume);
}

void OrderBookRenderer::RenderAsks(float x, float y, float width, float height,
                                   const std::vector<std::pair<double, double>>& asks,
                                   double maxVolume) {
    if (asks.empty()) return;
    
    float levelHeight = height / visibleLevels_;
    float currentY = y + height - levelHeight; // Снизу вверх (best ask внизу)
    
    // ???????????????????????????????????????????????????????????????
    // GPU BATCH RENDERING: Все бары в одном проходе
    // ???????????????????????????????????????????????????????????????
    
    for (size_t i = 0; i < asks.size() && i < (size_t)visibleLevels_; ++i) {
        double price = asks[i].first;
        double volume = asks[i].second;
        
        // Нормализованная ширина бара
        float barWidth = (float)(volume / maxVolume) * maxBarWidth_;
        
        // Background
        graphics_->DrawRectPixels(x, currentY, width, levelHeight, 
                                 0.15f, 0.12f, 0.12f, 1.0f);
        
        // Volume bar (красный для asks)
        float barX = x + width - barWidth - 100; // Справа налево
        graphics_->DrawRectPixels(barX, currentY + 2, barWidth, levelHeight - 4,
                                 0.8f, 0.2f, 0.2f, 0.3f); // Полупрозрачный красный
        
        // Price text
        std::wstringstream priceStr;
        priceStr << std::fixed << std::setprecision(1) << price;
        graphics_->DrawTextPixels(priceStr.str(), x + 10, currentY + 2, 100, levelHeight - 4, 11,
                                 1.0f, 0.5f, 0.5f, 1.0f); // Светло-красный текст
        
        // Volume text
        std::wstringstream volumeStr;
        if (volume >= 1.0) {
            volumeStr << std::fixed << std::setprecision(3) << volume;
        } else {
            volumeStr << std::fixed << std::setprecision(4) << volume;
        }
        graphics_->DrawTextPixels(volumeStr.str(), x + width - 90, currentY + 2, 80, levelHeight - 4, 11,
                                 0.8f, 0.8f, 0.8f, 1.0f);
        
        currentY -= levelHeight;
    }
}

void OrderBookRenderer::RenderBids(float x, float y, float width, float height,
                                   const std::vector<std::pair<double, double>>& bids,
                                   double maxVolume) {
    if (bids.empty()) return;
    
    float levelHeight = height / visibleLevels_;
    float currentY = y;
    
    // ???????????????????????????????????????????????????????????????
    // GPU BATCH RENDERING: Все бары в одном проходе
    // ???????????????????????????????????????????????????????????????
    
    for (size_t i = 0; i < bids.size() && i < (size_t)visibleLevels_; ++i) {
        double price = bids[i].first;
        double volume = bids[i].second;
        
        // Нормализованная ширина бара
        float barWidth = (float)(volume / maxVolume) * maxBarWidth_;
        
        // Background
        graphics_->DrawRectPixels(x, currentY, width, levelHeight,
                                 0.12f, 0.15f, 0.12f, 1.0f);
        
        // Volume bar (зелёный для bids)
        float barX = x + width - barWidth - 100; // Справа налево
        graphics_->DrawRectPixels(barX, currentY + 2, barWidth, levelHeight - 4,
                                 0.2f, 0.8f, 0.2f, 0.3f); // Полупрозрачный зелёный
        
        // Price text
        std::wstringstream priceStr;
        priceStr << std::fixed << std::setprecision(1) << price;
        graphics_->DrawTextPixels(priceStr.str(), x + 10, currentY + 2, 100, levelHeight - 4, 11,
                                 0.5f, 1.0f, 0.5f, 1.0f); // Светло-зелёный текст
        
        // Volume text
        std::wstringstream volumeStr;
        if (volume >= 1.0) {
            volumeStr << std::fixed << std::setprecision(3) << volume;
        } else {
            volumeStr << std::fixed << std::setprecision(4) << volume;
        }
        graphics_->DrawTextPixels(volumeStr.str(), x + width - 90, currentY + 2, 80, levelHeight - 4, 11,
                                 0.8f, 0.8f, 0.8f, 1.0f);
        
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

std::vector<std::pair<double, double>> OrderBookRenderer::FillSide(
    const std::vector<std::pair<double, double>>& src,
    bool descending,
    double startPriceOverride) const {
    std::vector<std::pair<double, double>> out;
    if (src.empty()) return out;

    double step = DetectPriceStep(src);
    if (step <= 0.0) step = 0.1; // fallback

    // Map price key to volume using step-based rounding
    std::unordered_map<long long, double> volumeByKey;
    auto keyFn = [&](double price) {
        return static_cast<long long>(std::llround(price / step));
    };

    for (const auto& p : src) {
        volumeByKey[keyFn(p.first)] = p.second;
    }

    double price = std::isnan(startPriceOverride) ? src.front().first : startPriceOverride;
    for (int i = 0; i < visibleLevels_; ++i) {
        long long k = keyFn(price);
        auto it = volumeByKey.find(k);
        double vol = (it != volumeByKey.end()) ? it->second : 0.0;
        out.emplace_back(price, vol);
        price += descending ? -step : step;
    }
    return out;
}

double OrderBookRenderer::DetectPriceStep(const std::vector<std::pair<double, double>>& src) const {
    if (src.size() < 2) return 0.0;
    double minDiff = 0.0;
    for (size_t i = 1; i < src.size(); ++i) {
        double d = std::fabs(src[i - 1].first - src[i].first);
        if (d > 1e-9 && (minDiff == 0.0 || d < minDiff)) {
            minDiff = d;
        }
    }
    return minDiff;
}

double OrderBookRenderer::DetectCommonStep(const std::vector<std::pair<double, double>>& bids,
                            const std::vector<std::pair<double, double>>& asks) const {
    double sb = DetectPriceStep(bids);
    double sa = DetectPriceStep(asks);
    if (sb > 0.0 && sa > 0.0) return (sb < sa) ? sb : sa;
    if (sb > 0.0) return sb;
    if (sa > 0.0) return sa;
    return 0.0;
}
