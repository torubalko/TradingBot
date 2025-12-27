#include "BinanceConnection.h"
#include <iostream>

namespace TradingBot::Core::Network {

    BinanceConnection::BinanceConnection() {
        // Загружаем сертификаты по умолчанию, чтобы доверять серверу Binance
        ctx_.set_default_verify_paths();
    }

    BinanceConnection::~BinanceConnection() {
        // Деструктор
    }

    void BinanceConnection::Connect(const std::string& symbol) {
        try {
            // Адрес Binance Futures
            auto const host = "fstream.binance.com";
            auto const port = "443";

            // Формируем запрос: подписка на стакан (Depth)
            // @depth20@100ms = топ 20 цен, обновление 10 раз в секунду
            std::string target = "/ws/" + symbol + "@depth20@100ms";

            // 1. Находим IP адрес сервера
            tcp::resolver resolver(ioc_);
            auto const results = resolver.resolve(host, port);

            // 2. Создаем защищенный WebSocket поток
            websocket::stream<beast::ssl_stream<tcp::socket>> ws(ioc_, ctx_);

            // 3. Подключаемся по TCP (физическое соединение)
            auto ep = net::connect(get_lowest_layer(ws), results);

            // 4. Настраиваем SSL (обязательно указываем имя хоста - SNI)
            if (!SSL_set_tlsext_host_name(ws.next_layer().native_handle(), host))
                throw beast::system_error(
                    beast::error_code(static_cast<int>(::ERR_get_error()),
                        net::error::get_ssl_category()),
                    "Failed to set SNI Hostname");

            // Выполняем SSL рукопожатие (шифрование включено)
            ws.next_layer().handshake(ssl::stream_base::client);

            // 5. Выполняем WebSocket рукопожатие (протокол обновлен)
            std::string host_header = std::string(host) + ":" + std::to_string(ep.port());
            ws.handshake(host_header, target);

            std::cout << "[Network] CONNECTED to Binance Futures: " << symbol << std::endl;

            // 6. Бесконечный цикл чтения данных
            beast::flat_buffer buffer;
            while (true) {
                // Ждем и читаем сообщение
                ws.read(buffer);

                // Превращаем в строку
                std::string msg = beast::buffers_to_string(buffer.data());

                // Если кто-то подписался на сообщения - передаем ему
                if (OnMessage) {
                    OnMessage(msg);
                }

                // Очищаем буфер перед следующим сообщением
                buffer.consume(buffer.size());
            }
        }
        catch (std::exception const& e) {
            std::cerr << "[ERROR] Network error: " << e.what() << std::endl;
        }
    }
}