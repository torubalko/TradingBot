#include "BinanceConnection.h"
#include "JsonParser.h"
#include "Types.h"
#include <iostream>
#include <algorithm> 
#include <cctype>    
#include <boost/beast/http.hpp>
// Добавляем для ручного разбора JSON
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>

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

            // ИЗМЕНЕНИЕ: Комбинированный поток (стакан + сделки)
            std::string target = "/stream?streams=" + lowerSymbol + "@depth@100ms/" + lowerSymbol + "@trade";

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
            namespace pt = boost::property_tree;

            while (running_) {
                ws.read(buffer);
                std::string msg = beast::buffers_to_string(buffer.data());

                try {
                    pt::ptree root;
                    std::stringstream ss; ss << msg;
                    pt::read_json(ss, root);

                    if (root.count("stream")) {
                        std::string streamName = root.get<std::string>("stream");

                        // 1. ДАННЫЕ СТАКАНА
                        if (streamName.find("@depth") != std::string::npos) {
                            auto update = Utils::JsonParser::ParseDepthUpdate(msg);
                            state_->ApplyUpdate(update.bids, update.asks);
                        }
                        // 2. ДАННЫЕ СДЕЛОК
                        else if (streamName.find("@trade") != std::string::npos) {
                            pt::ptree data = root.get_child("data");
                            Trade trade;
                            trade.price = std::stod(data.get<std::string>("p"));
                            trade.quantity = std::stod(data.get<std::string>("q"));
                            trade.isBuyerMaker = data.get<bool>("m"); // true = продажа
                            trade.timestamp = data.get<long long>("T");

                            state_->AddTrade(trade);
                        }
                    }
                }
                catch (...) {}

                buffer.consume(buffer.size());
            }
        }
        catch (std::exception const& e) {
            std::cerr << "[WS Error] " << e.what() << std::endl;
            throw;
        }
    }
}