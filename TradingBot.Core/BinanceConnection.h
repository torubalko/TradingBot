#pragma once
#include <string>
#include <memory>
#include <functional>
#include <thread>
#include <atomic>
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
        static std::vector<SymbolInfo> GetExchangeInfo(MarketMode mode);
        BinanceConnection(std::shared_ptr<SharedState> state);
        ~BinanceConnection();
        void Connect(const std::string& symbol, MarketMode mode);
        void Disconnect();
    private:
        void DownloadSnapshot(const std::string& symbol, MarketMode mode);
        void WebSocketThread(const std::string& symbol, MarketMode mode);
        std::string PerformHttpRequest(const std::string& host, const std::string& path);
        std::shared_ptr<SharedState> state_;
        std::thread wsThread_;
        std::atomic<bool> running_{ false };
    };
}