#include "BinanceConnection.h"
#include "JsonParser.h"
#include "Types.h"  // <--- ВАЖНО: Добавили это, чтобы видеть OrderBookUpdate
#include <iostream>
#include <algorithm> 
#include <cctype>    
#include <boost/beast/http.hpp>

namespace TradingBot::Core::Network {

    BinanceConnection::BinanceConnection(std::shared_ptr<SharedState> state)
        : state_(state) {
        ctx_.set_verify_mode(boost::asio::ssl::verify_none);
    }

    BinanceConnection::~BinanceConnection() {
        Stop();
    }

    void BinanceConnection::Stop() {
        running_ = false;
        if (!ioc_.stopped()) ioc_.stop();
    }

    void BinanceConnection::DownloadSnapshot(const std::string& symbol, bool useTestnet) {
        try {
            std::string host = useTestnet ? "testnet.binancefuture.com" : "fapi.binance.com";
            std::string target = "/fapi/v1/depth?symbol=" + symbol + "&limit=1000";

            tcp::resolver resolver(ioc_);
            beast::ssl_stream<beast::tcp_stream> stream(ioc_, ctx_);

            if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str())) return;

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

            // JsonParser теперь должен возвращать Core::OrderBookSnapshot
            auto snap = Utils::JsonParser::ParseSnapshot(res.body());

            if (!snap.bids.empty()) {
                state_->ApplyUpdate(snap.bids, snap.asks);
            }

            beast::error_code ec;
            stream.shutdown(ec);
        }
        catch (std::exception const& e) {
            std::cerr << "[Snapshot Error] " << e.what() << std::endl;
        }
    }

    void BinanceConnection::Connect(const std::string& symbol, bool useTestnet) {
        std::string upperSymbol = symbol;
        std::string lowerSymbol = symbol;
        std::transform(upperSymbol.begin(), upperSymbol.end(), upperSymbol.begin(), ::toupper);
        std::transform(lowerSymbol.begin(), lowerSymbol.end(), lowerSymbol.begin(), ::tolower);

        DownloadSnapshot(upperSymbol, useTestnet);

        try {
            std::string host = useTestnet ? "stream.binancefuture.com" : "fstream.binance.com";
            std::string target = "/stream?streams=" + lowerSymbol + "@depth@100ms";

            tcp::resolver resolver(ioc_);
            auto const results = resolver.resolve(host, "443");

            websocket::stream<beast::ssl_stream<tcp::socket>> ws(ioc_, ctx_);
            auto ep = net::connect(get_lowest_layer(ws), results);
            net::socket_base::receive_buffer_size option(8192 * 8);
            get_lowest_layer(ws).set_option(option);

            if (!SSL_set_tlsext_host_name(ws.next_layer().native_handle(), host.c_str()))
                throw std::runtime_error("SNI Error");

            ws.next_layer().handshake(ssl::stream_base::client);
            std::string host_header = host + ":" + std::to_string(ep.port());
            ws.handshake(host_header, target);

            beast::flat_buffer buffer;
            while (running_) {
                ws.read(buffer);
                std::string msg = beast::buffers_to_string(buffer.data());

                // Здесь возникала ошибка C2027, потому что компилятор не знал структуру update
                // Теперь, благодаря #include "Types.h", он знает поля .bids и .asks
                auto update = Utils::JsonParser::ParseDepthUpdate(msg);
                state_->ApplyUpdate(update.bids, update.asks);

                buffer.consume(buffer.size());
            }
        }
        catch (std::exception const& e) {
            std::cerr << "[WS Error] " << e.what() << std::endl;
            throw;
        }
    }
}