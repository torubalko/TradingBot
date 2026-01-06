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
#include "ConnectionMonitor.h"
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
        ConnectionState GetState() const { return state_.load(); }
    private:
        void DownloadSnapshot(const std::string& symbol, MarketMode mode);
        void WebSocketThread(const std::string& symbol, MarketMode mode);
        std::string PerformHttpRequest(const std::string& host, const std::string& path);
        void SetState(ConnectionState newState) { state_.store(newState); }
        std::shared_ptr<SharedState> sharedState_;
        std::thread wsThread_;
        std::atomic<bool> running_{ false };
        std::atomic<ConnectionState> state_{ ConnectionState::DISCONNECTED };
        ReconnectStrategy reconnectStrategy_;
        ConnectionMonitor connectionMonitor_;
    };
}