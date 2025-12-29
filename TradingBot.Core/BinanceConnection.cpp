#include "BinanceConnection.h"
#include "JsonParser.h"
#include <iostream>
#include <algorithm> // Для std::transform (toupper)

// Подключаем HTTP библиотеки для скачивания снимка
#include <boost/beast/http.hpp>

namespace TradingBot::Core::Network {

    BinanceConnection::BinanceConnection(std::shared_ptr<SharedState> state)
        : state_(state) {
        ctx_.set_default_verify_paths();
    }

    BinanceConnection::~BinanceConnection() {
    }

    void BinanceConnection::Stop() {
        running_ = false;
        ioc_.stop();
    }

    // Вспомогательная функция (Статическая, чтобы не засорять класс)
    static void DownloadSnapshot(net::io_context& ioc, ssl::context& ctx, std::shared_ptr<SharedState> state, const std::string& symbol, bool useTestnet) {
        try {
            std::cout << "[Snapshot] Downloading OrderBook for " << symbol << "..." << std::endl;

            std::string host = useTestnet ? "testnet.binancefuture.com" : "fapi.binance.com";
            std::string target = "/fapi/v1/depth?symbol=" + symbol + "&limit=1000";

            tcp::resolver resolver(ioc);
            beast::ssl_stream<beast::tcp_stream> stream(ioc, ctx);

            if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str()))
                throw beast::system_error(beast::error_code(static_cast<int>(::ERR_get_error()), net::error::get_ssl_category()), "SNI Error");

            auto const results = resolver.resolve(host, "443");
            beast::get_lowest_layer(stream).connect(results);
            stream.handshake(ssl::stream_base::client);

            http::request<http::string_body> req{ http::verb::get, target, 11 };
            req.set(http::field::host, host);
            req.set(http::field::user_agent, "TigerBot/1.0");

            http::write(stream, req);

            beast::flat_buffer buffer;
            http::response<http::string_body> res;
            http::read(stream, buffer, res);

            // Парсим
            auto snap = Utils::JsonParser::ParseSnapshot(res.body());

            if (!snap.bids.empty()) {
                state->ApplyUpdate(snap.bids, snap.asks);
                std::cout << "[Snapshot] Loaded " << snap.bids.size() << " levels." << std::endl;
            }

            beast::error_code ec;
            stream.shutdown(ec);
        }
        catch (std::exception const& e) {
            std::cerr << "[Snapshot Failed] " << e.what() << std::endl;
        }
    }

    void BinanceConnection::Connect(const std::string& symbol, bool useTestnet) {
        // 1. Скачиваем снимок (Uppercase symbol)
        std::string upperSymbol = symbol;
        std::transform(upperSymbol.begin(), upperSymbol.end(), upperSymbol.begin(), ::toupper);

        DownloadSnapshot(ioc_, ctx_, state_, upperSymbol, useTestnet);

        // 2. Запускаем WebSocket
        try {
            std::string host = useTestnet ? "stream.binancefuture.com" : "fstream.binance.com";

            // Инкрементальный поток (самый быстрый)
            std::string target = "/stream?streams=" + symbol + "@depth@100ms";

            auto const port = "443";
            tcp::resolver resolver(ioc_);
            auto const results = resolver.resolve(host, port);

            websocket::stream<beast::ssl_stream<tcp::socket>> ws(ioc_, ctx_);
            auto ep = net::connect(get_lowest_layer(ws), results);

            net::socket_base::receive_buffer_size option(1024 * 1024);
            get_lowest_layer(ws).set_option(option);

            if (!SSL_set_tlsext_host_name(ws.next_layer().native_handle(), host.c_str()))
                throw beast::system_error(beast::error_code(static_cast<int>(::ERR_get_error()), net::error::get_ssl_category()), "SNI Error");

            ws.next_layer().handshake(ssl::stream_base::client);
            std::string host_header = host + ":" + std::to_string(ep.port());

            std::cout << "[Network] Listening to stream: " << target << std::endl;
            ws.handshake(host_header, target);

            beast::flat_buffer buffer;
            while (running_) {
                ws.read(buffer);
                std::string msg = beast::buffers_to_string(buffer.data());

                auto update = Utils::JsonParser::ParseDepthUpdate(msg);
                if (!update.bids.empty() || !update.asks.empty()) {
                    state_->ApplyUpdate(update.bids, update.asks);
                }
                buffer.consume(buffer.size());
            }
        }
        catch (std::exception const& e) {
            std::cerr << "[WS Error] " << e.what() << std::endl;
        }
    }
}