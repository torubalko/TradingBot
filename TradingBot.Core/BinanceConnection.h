#pragma once
#include <string>
#include <memory>
#include <boost/beast/core.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/websocket.hpp>
#include <boost/asio/strand.hpp>
#include "SharedState.h"

namespace beast = boost::beast;
namespace http = beast::http;
namespace websocket = beast::websocket;
namespace net = boost::asio;
namespace ssl = boost::asio::ssl;
using tcp = boost::asio::ip::tcp;

namespace TradingBot::Core::Network {

    class BinanceConnection {
    public:
        // Конструктор принимает указатель на SharedState
        BinanceConnection(std::shared_ptr<SharedState> state);
        ~BinanceConnection();

        void Connect(const std::string& symbol, bool useTestnet = false);
        void Stop();

        // Callback больше не обязателен, так как мы пишем сразу в State, 
        // но оставим для совместимости, если нужен.
        std::function<void(const std::string&)> OnMessage;

    private:
        std::shared_ptr<SharedState> state_;
        net::io_context ioc_;
        ssl::context ctx_{ ssl::context::tlsv12_client };
        bool running_ = true;
    };
}