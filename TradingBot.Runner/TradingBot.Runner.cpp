#include <iostream>
#include <string>
#include "BinanceConnection.h"

// Убираем лишние инклуды парсера, так как нам нужен только сырой вывод

int main() {
    // Настраиваем консоль (русский язык + точка как разделитель для надежности)
    setlocale(LC_ALL, "ru_RU.UTF-8");
    setlocale(LC_NUMERIC, "C");

    std::cout << "=== РЕЖИМ СЫРОГО ПОТОКА (RAW STREAM) ===" << std::endl;
    std::cout << "Подключение к Binance Futures..." << std::endl;

    TradingBot::Core::Network::BinanceConnection client;

    // В этот раз мы не парсим JSON, а просто выводим строку как есть
    client.OnMessage = [](const std::string& data) {
        std::cout << "[MSG] " << data << std::endl;
        };

    // Запускаем подключение
    client.Connect("btcusdt");

    return 0;
}