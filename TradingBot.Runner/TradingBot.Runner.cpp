#include <iostream>
#include <string>
#include "BinanceConnection.h"

int main() {
    // Отключаем синхронизацию для скорости вывода в консоль
    std::ios_base::sync_with_stdio(false);
    std::cin.tie(NULL);
    setlocale(LC_ALL, "C");

    std::cout << "=== RAW DATA MONITOR ===" << std::endl;

    TradingBot::Core::Network::BinanceConnection client;

    client.OnMessage = [](const std::string& data) {
        // Просто выводим сырую строку JSON
        std::cout << data << std::endl;
        };

    // false = Реальный Binance
    client.Connect("btcusdt", false);

    return 0;
}