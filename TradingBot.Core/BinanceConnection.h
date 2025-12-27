#pragma once

#include <string>
#include <functional>
#include <memory>

// Подключаем Boost.Beast и OpenSSL
#include <boost/beast/core.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/websocket.hpp>
#include <boost/beast/websocket/ssl.hpp>
#include <boost/asio/strand.hpp>

// Сокращения для удобства (чтобы не писать длинные имена)
namespace beast = boost::beast;
namespace http = beast::http;
namespace websocket = beast::websocket;
namespace net = boost::asio;
namespace ssl = boost::asio::ssl;
using tcp = boost::asio::ip::tcp;

namespace TradingBot::Core::Network {

    class BinanceConnection {
    public:
        BinanceConnection();
        ~BinanceConnection();

        // Главный метод: подключиться к паре (например, "btcusdt")
        void Connect(const std::string& symbol);

        // Сюда мы "повесим" функцию, которая будет обрабатывать входящие JSON сообщения
        std::function<void(const std::string&)> OnMessage;

    private:
        // Контекст ввода-вывода (сердце Boost.Asio)
        net::io_context ioc_;
        // Контекст SSL (шифрование)
        ssl::context ctx_{ ssl::context::tlsv12_client };
    };
}