#pragma once
#include <string>
#include <memory>
#include <functional> // Grok ������ ��������
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
        BinanceConnection(std::shared_ptr<SharedState> state);
        ~BinanceConnection();

        void Connect(const std::string& symbol, bool isSpot = false);
        void Stop();

    private:
        // ������ ��� ��������� ����� ������, � �� "�������" �������
        void DownloadSnapshot(const std::string& symbol, bool isSpot);
        
        // �������� ��������� ������������ ��� SSL
        void LoadRootCertificates();

    private:
        std::shared_ptr<SharedState> state_;
        net::io_context ioc_;
        ssl::context ctx_{ ssl::context::tlsv12_client };
        bool running_ = true;
    };
}