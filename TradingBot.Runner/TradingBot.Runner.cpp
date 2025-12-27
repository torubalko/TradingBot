#include <iostream>
#include <string>
#include <iomanip> // Для красивого вывода чисел

#include "BinanceConnection.h"
#include "JsonParser.h" // Подключаем наш новый парсер

// Порог "Плотности". Если объем заявки больше этого числа (в монетах BTC), мы будем кричать.
// 5 BTC ~ 200,000$ (для примера)
const double DENSITY_THRESHOLD = 5.0;

int main() {
    setlocale(LC_ALL, "ru_RU.UTF-8");
    std::cout << "=== ПОИСК ПЛОТНОСТЕЙ (СКАЛЬПИНГ) ===" << std::endl;
    std::cout << "Порог плотности: " << DENSITY_THRESHOLD << " BTC" << std::endl;

    TradingBot::Core::Network::BinanceConnection client;

    client.OnMessage = [](const std::string& data) {
        // 1. Парсим сообщение
        auto update = TradingBot::Core::Utils::JsonParser::ParseDepthUpdate(data);

        // Если вектор пустой - значит это было служебное сообщение, пропускаем
        if (update.bids.empty() && update.asks.empty()) return;

        // 2. Анализируем стакан на наличие КРУПНЫХ заявок

        // Проверяем Bids (Покупатели)
        for (const auto& level : update.bids) {
            if (level.quantity >= DENSITY_THRESHOLD) {
                std::cout << "\n[!!!] ПЛОТНОСТЬ НА ПОКУПКУ: "
                    << level.quantity << " BTC по цене " << level.price << std::endl;
            }
        }

        // Проверяем Asks (Продавцы)
        for (const auto& level : update.asks) {
            if (level.quantity >= DENSITY_THRESHOLD) {
                std::cout << "\n[!!!] ПЛОТНОСТЬ НА ПРОДАЖУ: "
                    << level.quantity << " BTC по цене " << level.price << std::endl;
            }
        }

        // Просто чтобы видеть, что бот жив, выводим лучший бид иногда
        // (std::cout работает быстро, но не мгновенно, позже уберем лишний вывод)
        if (!update.bids.empty()) {
            std::cout << "\rBest Bid: " << update.bids[0].price << "   " << std::flush;
        }
        };

    client.Connect("btcusdt");

    return 0;
}