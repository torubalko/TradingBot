#include "BinanceConnection.h"
#include "JsonParser.h"
#include "Types.h"
#include <iostream>
#include <algorithm>
#include <cctype>
#include <nlohmann/json.hpp>
#include <chrono>
#include <thread>
// --- �������������� �������� ---
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
        : sharedState_(state),
          reconnectStrategy_(1000, 60000, 2.0, -1),
          connectionMonitor_(30000, 60000) {
    }
    BinanceConnection::~BinanceConnection() {
        Disconnect();
    }
    void BinanceConnection::Disconnect() {
        running_ = false;
        SetState(ConnectionState::DISCONNECTED);
        if (wsThread_.joinable()) wsThread_.join();
    }
    void BinanceConnection::Connect(const std::string& symbol, MarketMode mode) {
        Disconnect();
        running_ = true;
        SetState(ConnectionState::CONNECTING);
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
            sharedState_->SetSnapshot(snapshot);
        }
    }
    std::vector<SymbolInfo> BinanceConnection::GetExchangeInfo(MarketMode mode) {
        std::string host = (mode == MarketMode::FUTURES) ? "fapi.binance.com" : "api.binance.com";
        std::string path = (mode == MarketMode::FUTURES) ? "/fapi/v1/exchangeInfo" : "/api/v3/exchangeInfo";
        std::string json = PerformHttpRequest(host, path);
        return JsonParser::ParseExchangeInfo(json);
    }
    void BinanceConnection::WebSocketThread(const std::string& symbol, MarketMode mode) {
        reconnectStrategy_.Reset();
        
        while (running_) {
            try {
                SetState(ConnectionState::CONNECTING);
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
                
                if (!SSL_set_tlsext_host_name(ws.next_layer().native_handle(), host.c_str())) 
                    throw std::runtime_error("SNI Error");
                
                auto const results = resolver.resolve(host, "443");
                beast::get_lowest_layer(ws).connect(results);
                ws.next_layer().handshake(ssl::stream_base::client);
                ws.handshake(host, path);
                
                SetState(ConnectionState::CONNECTED);
                reconnectStrategy_.RecordSuccess();
                connectionMonitor_.UpdateActivity();
                
                beast::flat_buffer buffer;
                buffer.reserve(8192); // Pre-allocate buffer
                
                while (running_) {
                    // Check for timeout
                    if (connectionMonitor_.IsTimedOut()) {
                        std::cerr << "Connection timeout detected" << std::endl;
                        break;
                    }
                    
                    ws.read(buffer);
                    connectionMonitor_.UpdateActivity();
                    
                    std::string msg = beast::buffers_to_string(buffer.data());
                    buffer.consume(buffer.size());
                    
                    if (msg.find("depthUpdate") != std::string::npos) {
                        auto update = JsonParser::ParseDepthUpdate(msg);
                        sharedState_->ApplyUpdate(update);
                    }
                    else if (msg.find("aggTrade") != std::string::npos) {
                        auto trade = JsonParser::ParseAggTrade(msg);
                        sharedState_->AddTrade(trade);
                    }
                }
                
                // Clean shutdown
                beast::error_code ec;
                ws.close(websocket::close_code::normal, ec);
            }
            catch (const std::exception& e) {
                reconnectStrategy_.RecordFailure();
                SetState(ConnectionState::RECONNECTING);
                
                int delay = reconnectStrategy_.GetNextDelay();
                if (delay < 0) {
                    std::cerr << "Max reconnect attempts reached" << std::endl;
                    SetState(ConnectionState::FAILED);
                    break;
                }
                
                std::cerr << "WS Error: " << e.what() 
                         << ". Reconnecting in " << delay << "ms (attempt " 
                         << reconnectStrategy_.GetAttempts() << ")..." << std::endl;
                std::this_thread::sleep_for(std::chrono::milliseconds(delay));
            }
        }
        
        SetState(ConnectionState::DISCONNECTED);
    }
}