#pragma once
#include <vector>
#include <string>

namespace TradingBot::Core::Models {

    // Используем double для простоты. 
    // В будущем для идеальной точности можно перейти на Decimal, 
    // но для скальпинга double (8 байт) пока хватит.
    using Price = double;
    using Volume = double;

    // Один уровень стакана: Цена + Объем
    struct OrderBookLevel {
        Price price;
        Volume quantity;
    };

    // Весь пакет обновления (snapshot или update)
    struct OrderBookUpdate {
        std::string symbol;
        std::vector<OrderBookLevel> bids; // Покупки (Зеленые)
        std::vector<OrderBookLevel> asks; // Продажи (Красные)
    };
}