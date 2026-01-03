#pragma once
#include <memory>
#include <string>
#include <atomic>
#include <deque>
#include <boost/beast/core.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/websocket.hpp>
#include <boost/asio/ip/tcp.hpp>
#include <boost/asio/ssl/stream.hpp>

#include "SharedState.h"
#include "Types.h"

namespace TradingBot::Core::Network {

    namespace beast = boost::beast;
    namespace http = beast::http;
    namespace websocket = beast::websocket;
    namespace net = boost::asio;
    namespace ssl = boost::asio::ssl;
    using tcp = boost::asio::ip::tcp;

    class BinanceConnection : public std::enable_shared_from_this<BinanceConnection> {
    public:
        BinanceConnection(std::shared_ptr<SharedState> state);
        ~BinanceConnection();

        void Connect(const std::string& symbol, bool useTestnet);
        void Stop();

    private:
        void DownloadSnapshotAsync(const std::string& symbol, bool useTestnet);
        long long DownloadSnapshot(const std::string& symbol, bool useTestnet);

        std::shared_ptr<SharedState> state_;
        net::io_context ioc_;
        ssl::context ctx_{ ssl::context::tlsv12_client };
        std::atomic<bool> running_{ true };
        
        std::atomic<long long> snapshotLastUpdateId_{ 0 };
        std::atomic<bool> isSnapshotDownloading_{ false };
    };
}