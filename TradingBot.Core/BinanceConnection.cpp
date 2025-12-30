#include "BinanceConnection.h"
#include "JsonParser.h"
#include "Types.h"
#include <iostream>
#include <algorithm> 
#include <cctype>    
#include <boost/beast/http.hpp>
#include <boost/beast/version.hpp> // ИСПРАВЛЕНИЕ E0020
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>

// Подключаем JSON библиотеку (предполагаем наличие nlohmann или используем Boost PropertyTree для простоты,
// но лучше nlohmann, как в JsonParser.cpp. Здесь использую существующий JsonParser.h)

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

    // Реализация GetExchangeInfo (Синхронный запрос)
    std::vector<SymbolInfo> BinanceConnection::GetExchangeInfo(MarketMode mode) {
        std::vector<SymbolInfo> result;
        try {
            bool isFutures = (mode == MarketMode::FUTURES);
            std::string host = isFutures ? "fapi.binance.com" : "api.binance.com";
            std::string target = isFutures ? "/fapi/v1/exchangeInfo" : "/api/v3/exchangeInfo";

            net::io_context ioc;
            ssl::context ctx(ssl::context::tlsv12_client);
            ctx.set_default_verify_paths();

            tcp::resolver resolver(ioc);
            beast::ssl_stream<beast::tcp_stream> stream(ioc, ctx);

            if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str())) {
                return {};
            }

            auto const results = resolver.resolve(host, "443");
            beast::get_lowest_layer(stream).connect(results);
            stream.handshake(ssl::stream_base::client);

            http::request<http::string_body> req{ http::verb::get, target, 11 };
            req.set(http::field::host, host);
            req.set(http::field::user_agent, BOOST_BEAST_VERSION_STRING);

            http::write(stream, req);

            beast::flat_buffer buffer;
            http::response<http::string_body> res;
            http::read(stream, buffer, res);

            // Используем JsonParser для разбора (нужно добавить метод в JsonParser, 
            // либо разобрать тут. Для скорости используем JsonParser::ParseExchangeInfo, 
            // который я давал в предыдущем ответе. Если его нет, используем заглушку пока).
            // В идеале: return Utils::JsonParser::ParseExchangeInfo(res.body());

            // Временная реализация через PropertyTree (чтобы скомпилировалось прямо сейчас)
            namespace pt = boost::property_tree;
            pt::ptree root;
            std::stringstream ss; ss << res.body();
            pt::read_json(ss, root);

            for (const auto& item : root.get_child("symbols")) {
                SymbolInfo info;
                info.symbol = item.second.get<std::string>("symbol");
                info.quoteAsset = item.second.get<std::string>("quoteAsset");

                if (item.second.get<std::string>("status") != "TRADING") continue;
                if (info.quoteAsset != "USDT" && info.quoteAsset != "BUSD") continue;

                for (const auto& filter : item.second.get_child("filters")) {
                    std::string fType = filter.second.get<std::string>("filterType");
                    if (fType == "PRICE_FILTER") {
                        info.tickSize = std::stod(filter.second.get<std::string>("tickSize"));
                    }
                    else if (fType == "LOT_SIZE") {
                        info.stepSize = std::stod(filter.second.get<std::string>("stepSize"));
                    }
                }

                if (info.tickSize > 0)
                    info.pricePrecision = (int)std::round(-std::log10(info.tickSize));

                result.push_back(info);
            }

            beast::error_code ec;
            stream.shutdown(ec);
        }
        catch (...) {}
        return result;
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

            // Используем Utils::JsonParser, убедитесь, что в файле JsonParser.h есть namespace Utils
            // Если нет, исправьте на TradingBot::Core::JsonParser
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

                        if (streamName.find("@depth") != std::string::npos) {
                            auto update = Utils::JsonParser::ParseDepthUpdate(msg);
                            state_->ApplyUpdate(update.bids, update.asks);
                        }
                        else if (streamName.find("@trade") != std::string::npos) {
                            pt::ptree data = root.get_child("data");
                            Trade trade;
                            trade.price = std::stod(data.get<std::string>("p"));
                            trade.quantity = std::stod(data.get<std::string>("q"));
                            trade.isBuyerMaker = data.get<bool>("m");
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