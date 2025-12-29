#include "BinanceConnection.h"
#include <iostream>

namespace TradingBot::Core::Network {

    BinanceConnection::BinanceConnection() {
        ctx_.set_default_verify_paths();
    }

    BinanceConnection::~BinanceConnection() {
    }

    void BinanceConnection::Connect(const std::string& symbol, bool useTestnet) {
        try {
            std::string host;
            if (useTestnet) {
                host = "stream.binancefuture.com";
            }
            else {
                host = "fstream.binance.com";
            }

            // САМЫЙ СЫРОЙ ПОТОК: diff-depth (все изменения стакана)
            // Он не вешает сеть как depth500, но дает данные по всей глубине.
            std::string target = "/stream?streams=" + symbol + "@depth@100ms";

            auto const port = "443";
            tcp::resolver resolver(ioc_);
            auto const results = resolver.resolve(host, port);

            websocket::stream<beast::ssl_stream<tcp::socket>> ws(ioc_, ctx_);
            auto ep = net::connect(get_lowest_layer(ws), results);

            // Тюнинг буфера (оставляем 1МБ, чтобы наверняка)
            net::socket_base::receive_buffer_size option(1024 * 1024);
            get_lowest_layer(ws).set_option(option);

            if (!SSL_set_tlsext_host_name(ws.next_layer().native_handle(), host.c_str()))
                throw beast::system_error(beast::error_code(static_cast<int>(::ERR_get_error()), net::error::get_ssl_category()), "Failed to set SNI");

            ws.next_layer().handshake(ssl::stream_base::client);

            std::string host_header = host + ":" + std::to_string(ep.port());

            std::cout << "Connecting to: " << host << std::endl;
            std::cout << "Target: " << target << std::endl;

            ws.handshake(host_header, target);

            std::cout << ">>> CONNECTED. RAW DATA STREAM STARTED.\n" << std::endl;

            beast::flat_buffer buffer;
            while (true) {
                ws.read(buffer);
                std::string msg = beast::buffers_to_string(buffer.data());

                if (OnMessage) OnMessage(msg);

                buffer.consume(buffer.size());
            }
        }
        catch (std::exception const& e) {
            std::cerr << "Error: " << e.what() << std::endl;
        }
    }
}