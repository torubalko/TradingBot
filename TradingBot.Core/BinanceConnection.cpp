#include "BinanceConnection.h"
#include "JsonParser.h"
#include "Types.h"
#include <iostream>
#include <algorithm>
#include <cctype>
#include <nlohmann/json.hpp>
#include <chrono>
#include <thread>
// --- ¿¬“ŒÃ¿“»◊≈— ¿ﬂ À»Õ Œ¬ ¿ ---
#pragma comment(lib, "ws2_32.lib")
#pragma comment(lib, "crypt32.lib")
namespace beast = boost::beast;
namespace http = beast::http;
namespace websocket = beast::websocket;
namespace net = boost::asio;
namespace ssl = boost::asio::ssl;
using tcp = boost::asio::ip::tcp;
namespace TradingBot::Core::Network {
    BinanceConnection::BinanceConnection(std::shared_ptr<SharedState> state)
        : state_(state) {
    }
    BinanceConnection::~BinanceConnection() {
        Disconnect();
    }
    void BinanceConnection::Disconnect() {
        running_ = false;
        if (wsThread_.joinable()) wsThread_.join();
    }
    void BinanceConnection::Connect(const std::string& symbol, MarketMode mode) {
        Disconnect();
        running_ = true;
        wsThread_ = std::thread(&BinanceConnection::WebSocketThread, this, symbol, mode);
    }
    std::string BinanceConnection::PerformHttpRequest(const std::string& host, const std::string& path) {
        try {
            net::io_context ioc;
            ssl::context ctx(ssl::context::tlsv12_client);
            ctx.set_verify_mode(ssl::verify_none);
            tcp::resolver resolver(ioc);
            beast::ssl_stream<beast::tcp_stream> stream(ioc, ctx);
            if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str())) return "";
            auto const results = resolver.resolve(host, "443");
            beast::get_lowest_layer(stream).connect(results);
            stream.handshake(ssl::stream_base::client);
            http::request<http::string_body> req{ http::verb::get, path, 11 };
            req.set(http::field::host, host);
            req.set(http::field::user_agent, BOOST_BEAST_VERSION_STRING);
            http::write(stream, req);
            beast::flat_buffer buffer;
            http::response<http::string_body> res;
            http::read(stream, buffer, res);
            beast::error_code ec;
            stream.shutdown(ec);
            return res.body();
        }
        catch (const std::exception& e) {
            std::cerr << "HTTP Error: " << e.what() << std::endl;
            return "";
        }
    }
    void BinanceConnection::DownloadSnapshot(const std::string& symbol, MarketMode mode) {
        std::string host = (mode == MarketMode::FUTURES) ? "fapi.binance.com" : "api.binance.com";
        std::string path = (mode == MarketMode::FUTURES) ? "/fapi/v1/depth?symbol=" + symbol + "&limit=1000" : "/api/v3/depth?symbol=" + symbol + "&limit=1000";
        std::string json = PerformHttpRequest(host, path);
        if (!json.empty()) {
            auto snapshot = JsonParser::ParseSnapshot(json);
            state_->SetSnapshot(snapshot);
        }
    }
    std::vector<SymbolInfo> BinanceConnection::GetExchangeInfo(MarketMode mode) {
        std::string host = (mode == MarketMode::FUTURES) ? "fapi.binance.com" : "api.binance.com";
        std::string path = (mode == MarketMode::FUTURES) ? "/fapi/v1/exchangeInfo" : "/api/v3/exchangeInfo";
        std::string json = PerformHttpRequest(host, path);
        return JsonParser::ParseExchangeInfo(json);
    }
    void BinanceConnection::WebSocketThread(const std::string& symbol, MarketMode mode) {
        while (running_) {
            try {
                DownloadSnapshot(symbol, mode);
                std::string host = (mode == MarketMode::FUTURES) ? "fstream.binance.com" : "stream.binance.com";
                std::string lowerSymbol = symbol;
                std::transform(lowerSymbol.begin(), lowerSymbol.end(), lowerSymbol.begin(), ::tolower);
                std::string path = "/stream?streams=" + lowerSymbol + "@depth@100ms/" + lowerSymbol + "@aggTrade";
                net::io_context ioc;
                ssl::context ctx(ssl::context::tlsv12_client);
                ctx.set_verify_mode(ssl::verify_none);
                tcp::resolver resolver(ioc);
                websocket::stream<beast::ssl_stream<tcp::socket>> ws(ioc, ctx);
                if (!SSL_set_tlsext_host_name(ws.next_layer().native_handle(), host.c_str())) throw std::runtime_error("SNI Error");
                auto const results = resolver.resolve(host, "443");
                beast::get_lowest_layer(ws).connect(results);
                ws.next_layer().handshake(ssl::stream_base::client);
                ws.handshake(host, path);
                beast::flat_buffer buffer;
                while (running_) {
                    ws.read(buffer);
                    std::string msg = beast::buffers_to_string(buffer.data());
                    buffer.consume(buffer.size());
                    if (msg.find("depthUpdate") != std::string::npos) {
                        auto update = JsonParser::ParseDepthUpdate(msg);
                        state_->ApplyUpdate(update);
                    }
                    else if (msg.find("aggTrade") != std::string::npos) {
                        auto trade = JsonParser::ParseAggTrade(msg);
                        state_->AddTrade(trade);
                    }
                }
            }
            catch (const std::exception& e) {
                std::cerr << "WS Error: " << e.what() << ". Reconnecting in 5s..." << std::endl;
                std::this_thread::sleep_for(std::chrono::seconds(5));
            }
        }
    }
}