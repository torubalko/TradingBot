#include "BinanceConnection.h"
#include "JsonParser.h"
#include <iostream>
#include <boost/beast/core.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/websocket.hpp>
#include <boost/beast/http.hpp>
#include <boost/asio/connect.hpp>
#include <boost/asio/ip/tcp.hpp>
#include <boost/asio/ssl/stream.hpp>
#include <nlohmann/json.hpp>

using json = nlohmann::json;

namespace beast = boost::beast;
namespace http = beast::http;
namespace websocket = beast::websocket;
namespace net = boost::asio;
namespace ssl = boost::asio::ssl;
using tcp = net::ip::tcp;

namespace TradingBot::Core::Network {

    BinanceConnection::BinanceConnection(std::shared_ptr<SharedState> state)
        : state_(state), running_(false) {
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
        // Запускаем поток для WebSocket
        wsThread_ = std::thread(&BinanceConnection::WebSocketThread, this, symbol, mode);
    }

    // --- HTTP REQUEST HELPER (Synchronous) ---
    std::string BinanceConnection::PerformHttpRequest(const std::string& host, const std::string& path) {
        try {
            net::io_context ioc;
            ssl::context ctx(ssl::context::tlsv12_client);
            ctx.set_verify_mode(ssl::verify_none); // Для простоты отключаем строгую проверку

            tcp::resolver resolver(ioc);
            beast::ssl_stream<beast::tcp_stream> stream(ioc, ctx);

            if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str())) {
                throw beast::system_error(
                    beast::error_code(static_cast<int>(::ERR_get_error()), net::error::get_ssl_category()),
                    "Failed to set SNI Hostname");
            }

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
            stream.shutdown(ec); // Gracefully close

            return res.body();
        }
        catch (std::exception& e) {
            std::cerr << "HTTP Error: " << e.what() << std::endl;
            return "";
        }
    }

    void BinanceConnection::DownloadSnapshot(const std::string& symbol, MarketMode mode) {
        std::string host = (mode == MarketMode::FUTURES) ? "fapi.binance.com" : "api.binance.com";
        std::string path = (mode == MarketMode::FUTURES) ? "/fapi/v1/depth" : "/api/v3/depth";

        // Загружаем 1000 уровней для точности
        path += "?symbol=" + symbol + "&limit=1000";

        std::string json = PerformHttpRequest(host, path);
        if (!json.empty()) {
            // ИСПОЛЬЗУЕМ НОВЫЙ МЕТОД ПАРСЕРА
            auto snapshot = JsonParser::ParseSnapshot(json);

            // ИСПОЛЬЗУЕМ НОВЫЙ МЕТОД STATE
            state_->SetSnapshot(snapshot);
            std::cout << "Snapshot loaded for " << symbol << std::endl;
        }
    }

    std::vector<SymbolInfo> BinanceConnection::GetExchangeInfo(MarketMode mode) {
        std::string host = (mode == MarketMode::FUTURES) ? "fapi.binance.com" : "api.binance.com";
        std::string path = (mode == MarketMode::FUTURES) ? "/fapi/v1/exchangeInfo" : "/api/v3/exchangeInfo";

        std::string json = PerformHttpRequest(host, path);
        return JsonParser::ParseExchangeInfo(json);
    }

    void BinanceConnection::WebSocketThread(const std::string& symbol, MarketMode mode) {
        // 1. Сначала качаем снимок (Snapshot)
        DownloadSnapshot(symbol, mode);

        // 2. Подключаемся к WebSocket
        try {
            std::string host = (mode == MarketMode::FUTURES) ? "fstream.binance.com" : "stream.binance.com";
            std::string port = "443";

            // Приводим символ к нижнему регистру для стрима (btcusdt)
            std::string lowerSymbol = symbol;
            std::transform(lowerSymbol.begin(), lowerSymbol.end(), lowerSymbol.begin(), ::tolower);

            // Подписываемся на diffDepth (быстрые обновления) и trade (сделки)
            std::string path = "/stream?streams=" + lowerSymbol + "@depth@100ms/" + lowerSymbol + "@aggTrade";

            net::io_context ioc;
            ssl::context ctx(ssl::context::tlsv12_client);
            ctx.set_verify_mode(ssl::verify_none);

            tcp::resolver resolver(ioc);
            websocket::stream<beast::ssl_stream<tcp::socket>> ws(ioc, ctx);

            if (!SSL_set_tlsext_host_name(ws.next_layer().native_handle(), host.c_str())) {
                throw beast::system_error(beast::error_code(static_cast<int>(::ERR_get_error()), net::error::get_ssl_category()));
            }

            auto const results = resolver.resolve(host, port);
            net::connect(beast::get_lowest_layer(ws), results);
            ws.next_layer().handshake(ssl::stream_base::client);

            // Handshake с путем
            ws.handshake(host, path);

            beast::flat_buffer buffer;
            while (running_) {
                ws.read(buffer);
                std::string msg = beast::buffers_to_string(buffer.data());
                buffer.consume(buffer.size()); // Очистка буфера

                // Определяем тип сообщения (простая проверка строки)
                if (msg.find("depthUpdate") != std::string::npos) {
                    // ЭТО И БЫЛО МЕСТО ОШИБКИ C2660
                    // Теперь мы получаем структуру Update и передаем её целиком
                    auto update = JsonParser::ParseDepthUpdate(msg);
                    state_->ApplyUpdate(update);
                }
                else if (msg.find("aggTrade") != std::string::npos) {
                    // Парсинг сделок можно добавить в JsonParser, 
                    // но для краткости пока оставим или добавим по необходимости.
                    // Для примера - простейший ручной парсинг или игнор, 
                    // если в Parser нет метода ParseTrade.
                    // Если нужно добавить пузыри - нужно реализовать ParseTrade.

                    // Пример быстрого парсинга сделки "на лету" (лучше вынести в Parser):
                    try {
                        auto j = nlohmann::json::parse(msg);
                        auto data = j.contains("data") ? j["data"] : j;
                        Trade t;
                        t.id = data["a"];
                        t.price = std::stod(data["p"].get<std::string>());
                        t.quantity = std::stod(data["q"].get<std::string>());
                        t.isBuyerMaker = data["m"];
                        t.timestamp = data["T"];
                        state_->AddTrade(t);
                    }
                    catch (...) {}
                }
            }
            ws.close(websocket::close_code::normal);
        }
        catch (std::exception& e) {
            std::cerr << "WebSocket Error: " << e.what() << std::endl;
        }
    }
}