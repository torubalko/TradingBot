#pragma once
#include <string>
#include <memory>
#include <functional>
#include <atomic>
#include <thread>
#include <boost/beast/core.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/websocket.hpp>
#include <boost/asio/strand.hpp>

namespace beast = boost::beast;
namespace websocket = beast::websocket;
namespace net = boost::asio;
namespace ssl = boost::asio::ssl;
using tcp = boost::asio::ip::tcp;

namespace TradingBot::Core::Network {
    using MessageCallback = std::function<void(const std::string&)>;
    using ErrorCallback = std::function<void(const std::string&)>;

    class WebSocketSession {
    public:
        WebSocketSession()
            : running_(false) {}

        ~WebSocketSession() {
            Disconnect();
        }

        void Connect(
            const std::string& host,
            const std::string& path,
            MessageCallback onMessage,
            ErrorCallback onError = nullptr
        ) {
            Disconnect();

            host_ = host;
            path_ = path;
            onMessage_ = onMessage;
            onError_ = onError;
            running_ = true;

            thread_ = std::thread(&WebSocketSession::Run, this);
        }

        void Disconnect() {
            running_ = false;
            if (thread_.joinable()) {
                thread_.join();
            }
        }

        bool IsConnected() const {
            return running_;
        }

    private:
        void Run() {
            while (running_) {
                try {
                    net::io_context ioc;
                    ssl::context ctx(ssl::context::tlsv12_client);
                    ctx.set_verify_mode(ssl::verify_none);

                    tcp::resolver resolver(ioc);
                    websocket::stream<beast::ssl_stream<tcp::socket>> ws(ioc, ctx);

                    // Set SNI hostname
                    if (!SSL_set_tlsext_host_name(ws.next_layer().native_handle(), host_.c_str())) {
                        throw std::runtime_error("Failed to set SNI hostname");
                    }

                    // Resolve and connect
                    auto const results = resolver.resolve(host_, "443");
                    beast::get_lowest_layer(ws).connect(results);

                    // SSL handshake
                    ws.next_layer().handshake(ssl::stream_base::client);

                    // WebSocket handshake
                    ws.handshake(host_, path_);

                    // Set WebSocket options
                    ws.set_option(websocket::stream_base::decorator(
                        [](websocket::request_type& req) {
                            req.set(beast::http::field::user_agent, "TradingBot/1.0");
                        }
                    ));

                    // Read loop
                    beast::flat_buffer buffer;
                    while (running_) {
                        ws.read(buffer);
                        std::string message = beast::buffers_to_string(buffer.data());
                        buffer.consume(buffer.size());

                        if (onMessage_) {
                            onMessage_(message);
                        }
                    }

                    // Graceful close
                    if (ws.is_open()) {
                        ws.close(websocket::close_code::normal);
                    }
                    break;
                }
                catch (const std::exception& e) {
                    if (onError_) {
                        onError_(std::string("WebSocket error: ") + e.what());
                    }

                    if (running_) {
                        // Reconnect after delay
                        std::this_thread::sleep_for(std::chrono::seconds(5));
                    }
                }
            }
        }

        std::string host_;
        std::string path_;
        MessageCallback onMessage_;
        ErrorCallback onError_;
        std::atomic<bool> running_;
        std::thread thread_;
    };
}
