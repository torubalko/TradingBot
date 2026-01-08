#include "DensityDetector.h"
#include <numeric>
#include <cmath>

namespace TradingBot::Core::Strategy {

    DensityDetector::DensityDetector() {
        // Конструктор
    }

    // ???????????????????????????????????????????????????????????????
    // Scan: Главный метод сканирования стакана
    // ???????????????????????????????????????????????????????????????
    void DensityDetector::Scan(const OrderBook::LocalOrderBook& book) {
        // Сброс счётчика плотностей
        densityCount_ = 0;

        // Получаем mid price
        double midPrice = book.GetMidPrice();
        if (midPrice <= 0.0) {
            return; // Нет данных в стакане
        }

        const auto& bids = book.GetBids();
        const auto& asks = book.GetAsks();

        if (bids.empty() || asks.empty()) {
            return;
        }

        // Вычисляем средний объём для каждой стороны
        double avgBidVolume = CalculateAverageVolume(bids, scanDepth_);
        double avgAskVolume = CalculateAverageVolume(asks, scanDepth_);

        // Сканируем bids
        ScanSide(bids, Side::BID, midPrice, avgBidVolume);

        // Сканируем asks
        ScanSide(asks, Side::ASK, midPrice, avgAskVolume);

        // Сортируем плотности по значимости (убывание)
        std::sort(densities_.begin(), densities_.begin() + densityCount_,
            [](const DensityLevel& a, const DensityLevel& b) {
                return a.significance > b.significance;
            });
    }

    // ???????????????????????????????????????????????????????????????
    // CalculateAverageVolume: Средний объём в топ-N уровней
    // ???????????????????????????????????????????????????????????????
    double DensityDetector::CalculateAverageVolume(
        const std::vector<OrderBook::PriceLevel>& levels, 
        int depth) const 
    {
        if (levels.empty()) {
            return 0.0;
        }

        int actualDepth = std::min(depth, static_cast<int>(levels.size()));
        double totalVolume = 0.0;

        for (int i = 0; i < actualDepth; ++i) {
            totalVolume += levels[i].quantity;
        }

        return totalVolume / actualDepth;
    }

    // ???????????????????????????????????????????????????????????????
    // ScanSide: Сканирование одной стороны стакана
    // ???????????????????????????????????????????????????????????????
    void DensityDetector::ScanSide(
        const std::vector<OrderBook::PriceLevel>& levels,
        Side side,
        double midPrice,
        double averageVolume)
    {
        if (averageVolume <= 0.0) {
            return;
        }

        int actualDepth = std::min(scanDepth_, static_cast<int>(levels.size()));
        double threshold = averageVolume * volumeThresholdMultiplier_;

        for (int i = 0; i < actualDepth; ++i) {
            const auto& level = levels[i];

            // Проверяем, превышает ли объём порог
            if (level.quantity < threshold) {
                continue;
            }

            // Вычисляем объём в USDT
            double volumeQuote = level.price * level.quantity;

            // Фильтруем по минимальному объёму в USDT
            if (volumeQuote < minVolumeUsdt_) {
                continue;
            }

            // Вычисляем расстояние от mid price
            double distanceFromMid = std::abs(level.price - midPrice) / midPrice * 100.0;

            // Вычисляем коэффициент значимости (чем больше объём, тем выше)
            double significance = level.quantity / averageVolume;

            // Добавляем плотность
            if (densityCount_ < densities_.size()) {
                DensityLevel& density = densities_[densityCount_];
                density.price = level.price;
                density.volume = level.quantity;
                density.volumeQuote = volumeQuote;
                density.side = side;
                density.distanceFromMid = distanceFromMid;
                density.significance = significance;

                ++densityCount_;
            }
        }
    }

} // namespace TradingBot::Core::Strategy
