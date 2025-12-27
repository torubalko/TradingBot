#include <iostream>
#include <string>

// Подключаем наш новый сетевой класс
#include "BinanceConnection.h"

int main() {
    setlocale(LC_ALL, "ru_RU.UTF-8");

    std::cout << "=== HIGH FREQUENCY TRADING BOT ===" << std::endl;
    std::cout << "Запуск подключения к Binance Futures..." << std::endl;

    // 1. Создаем экземпляр подключения
    TradingBot::Core::Network::BinanceConnection client;

    // 2. Говорим, что делать с данными (используем лямбда-функцию)
    client.OnMessage = [](const std::string& data) {
        // Выводим только начало строки, чтобы не засорять консоль
        // (Реальные данные очень длинные)
        std::cout << "[DATA]: " << data.substr(0, 100) << "..." << std::endl;
        };

    // 3. Запускаем на паре BTCUSDT (биткоин)
    // Внимание: Этот метод "захватит" поток и не отпустит его (бесконечный цикл)
    client.Connect("btcusdt");

    return 0;
}