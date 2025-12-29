#pragma once

#include <string>
#include <functional>
#include <memory>
#include <boost/beast/core.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/websocket.hpp>
#include <boost/beast/websocket/ssl.hpp>
#include <boost/asio/strand.hpp>

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

        // useTestnet = true  -> Подключение к тестовой сети (деньги ненастоящие)
        // useTestnet = false -> Подключение к реальной бирже (по умолчанию)
        void Connect(const std::string& symbol, bool useTestnet = false);

        std::function<void(const std::string&)> OnMessage;

    private:
        net::io_context ioc_;
        ssl::context ctx_{ ssl::context::tlsv12_client };
    };
}