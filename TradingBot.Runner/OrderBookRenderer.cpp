#include "OrderBookRenderer.h"
#include <algorithm>
#include <sstream>
#include <iomanip>
#include <cmath>

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
        if (std::fabs(scaled) >= 100.0) prec = 0;
        else if (std::fabs(scaled) >= 10.0) prec = 1;
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
    if (!sharedState_) return;
 
    auto snapshot = sharedState_->GetSnapshotForRender(visibleLevels_, 0.1);
    const auto& bidsSrc = (volumeMode_ == VolumeMode::Quote && !snapshot.BidsQuote.empty()) ? snapshot.BidsQuote : snapshot.Bids;
    const auto& asksSrc = (volumeMode_ == VolumeMode::Quote && !snapshot.AsksQuote.empty()) ? snapshot.AsksQuote : snapshot.Asks;

    if (bidsSrc.empty() || asksSrc.empty()) {
        graphics_->DrawTextPixels(L"Waiting for Order Book synchronization...", 
                                 x + 10, y + 10, width - 20, 20, 12, 
                                 0.7f, 0.7f, 0.7f, 1.0f);
        return;
    }

    cachedBids_.clear();
    cachedAsks_.clear();
    
    int bidsToShow = (std::min)((int)bidsSrc.size(), visibleLevels_);
    int asksToShow = (std::min)((int)asksSrc.size(), visibleLevels_);
    
    for (int i = 0; i < bidsToShow; ++i) {
        cachedBids_.push_back(bidsSrc[i]);
    }

    for (int i = 0; i < asksToShow; ++i) {
        cachedAsks_.push_back(asksSrc[i]);
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

    RenderAsks(x, asksY, width, halfHeight, cachedAsks_, maxVolume, midPrice);
    
    // Spread line between halves
    RenderSpreadLine(x, y + halfHeight, width, bestBid, bestAsk);
    
    // BIDS (bottom half, best bid adjacent to spread line)
    RenderBids(x, bidsY, width, halfHeight, cachedBids_, maxVolume, midPrice);
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
        
        // Нормализованная ширина бара
        float barWidth = (float)(volume / maxVolume) * maxBarWidth_;
        
        // Background
        graphics_->DrawRectPixels(x, currentY, width, levelHeight, 
                                 0.15f, 0.12f, 0.12f, 1.0f);
        
        // Volume bar (красный для asks)
        float barX = x + width - barWidth - 180; // Справа налево, больше места справа
        graphics_->DrawRectPixels(barX, currentY + 2, barWidth, levelHeight - 4,
                                 0.8f, 0.2f, 0.2f, 0.3f); // Полупрозрачный красный
        
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
        
        // Нормализованная ширина бара
        float barWidth = (float)(volume / maxVolume) * maxBarWidth_;
        
        // Background
        graphics_->DrawRectPixels(x, currentY, width, levelHeight,
                                 0.12f, 0.15f, 0.12f, 1.0f);
        
        // Volume bar (зелёный для bids)
        float barX = x + width - barWidth - 180; // Справа налево, больше места справа
        graphics_->DrawRectPixels(barX, currentY + 2, barWidth, levelHeight - 4,
                                 0.2f, 0.8f, 0.2f, 0.3f); // Полупрозрачный зелёный
        
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
