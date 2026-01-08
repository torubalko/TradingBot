#include <iostream>
#include <string>
#include <chrono>
#include <thread>
#include <memory>

#include <boost/beast/core.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/websocket.hpp>
#include <boost/asio/ip/tcp.hpp>
#include <boost/asio/ssl/stream.hpp>

namespace beast = boost::beast;
namespace websocket = beast::websocket;
namespace net = boost::asio;
namespace ssl = boost::asio::ssl;
using tcp = boost::asio::ip::tcp;

// ???????????????????????????????????????????????????????????????
// Минимальный тест WebSocket подключения к Binance
// ???????????????????????????????????????????????????????????????

int main() {
    std::cout << "=== Binance WebSocket Test ===" << std::endl;
    std::cout << std::endl;

    try {
        // 1. Настройка
        net::io_context ioc;
        ssl::context sslCtx{ssl::context::tlsv12_client};
        sslCtx.set_default_verify_paths();
        sslCtx.set_verify_mode(ssl::verify_none);

        tcp::resolver resolver(ioc);

        // 2. Подключение
        std::string host = "fstream.binance.com";
        std::string port = "443";
        std::string path = "/ws/btcusdt@depth";

        std::cout << "[1] Resolving DNS: " << host << std::endl;
        auto const results = resolver.resolve(host, port);
        std::cout << "    OK" << std::endl;

        // 3. Create WebSocket
        std::cout << "[2] Creating SSL WebSocket..." << std::endl;
        websocket::stream<beast::ssl_stream<tcp::socket>> ws(ioc, sslCtx);
        
        // SNI
        if (!SSL_set_tlsext_host_name(ws.next_layer().native_handle(), host.c_str())) {
            throw beast::system_error(
                beast::error_code(
                    static_cast<int>(::ERR_get_error()),
                    net::error::get_ssl_category()),
                "Failed to set SNI");
        }
        std::cout << "    OK" << std::endl;

        // 4. TCP Connect
        std::cout << "[3] Connecting TCP..." << std::endl;
        net::connect(beast::get_lowest_layer(ws), results);
        std::cout << "    OK" << std::endl;

        // 5. SSL Handshake
        std::cout << "[4] SSL Handshake..." << std::endl;
        ws.next_layer().handshake(ssl::stream_base::client);
        std::cout << "    OK" << std::endl;

        // 6. WebSocket Handshake
        std::cout << "[5] WebSocket Handshake: " << path << std::endl;
        ws.handshake(host, path);
        std::cout << "    OK - Connected!" << std::endl;
        std::cout << std::endl;

        // 7. Read messages
        std::cout << "[6] Reading messages..." << std::endl;
        std::cout << std::endl;

        for (int i = 0; i < 10; ++i) {
            beast::flat_buffer buffer;
            ws.read(buffer);

            std::string message(
                static_cast<const char*>(buffer.data().data()),
                buffer.size()
            );

            std::cout << "Message #" << (i + 1) << " (" << message.size() << " bytes):" << std::endl;
            
            // Показываем первые 200 символов
            if (message.size() > 200) {
                std::cout << message.substr(0, 200) << "..." << std::endl;
            } else {
                std::cout << message << std::endl;
            }
            std::cout << std::endl;
        }

        // 8. Close
        std::cout << "[7] Closing connection..." << std::endl;
        beast::error_code ec;
        ws.close(websocket::close_code::normal, ec);
        std::cout << "    OK" << std::endl;

        std::cout << std::endl;
        std::cout << "=== Test PASSED ===" << std::endl;

    } catch (const std::exception& e) {
        std::cerr << std::endl;
        std::cerr << "ERROR: " << e.what() << std::endl;
        std::cerr << std::endl;
        std::cerr << "=== Test FAILED ===" << std::endl;
        return 1;
    }

    return 0;
}
