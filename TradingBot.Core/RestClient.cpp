#include "RestClient.h"
#include <iostream>
#include <boost/asio/connect.hpp>
#include <boost/asio/ip/tcp.hpp>
#include <nlohmann/json.hpp> // Убедись, что библиотека подключена

using json = nlohmann::json;

RestClient::RestClient() {
    // Загружаем корневые сертификаты для SSL (как в браузере)
    ctx_.set_default_verify_paths();
    ctx_.set_verify_mode(ssl::verify_peer);
}

RestClient::~RestClient() {
    // Деструктор (здесь будет очистка ресурсов)
}

void RestClient::LoadExchangeInfo(MarketCache& cache) {
    // 1. Загружаем SPOT
    std::string spotJson = HttpsGet("api.binance.com", "/api/v3/exchangeInfo");
    if (!spotJson.empty()) {
        cache.spotPairs = ParseExchangeInfo(spotJson, MarketType::Spot);
    }

    // 2. Загружаем FUTURES
    std::string futJson = HttpsGet("fapi.binance.com", "/fapi/v1/exchangeInfo");
    if (!futJson.empty()) {
        cache.futuresPairs = ParseExchangeInfo(futJson, MarketType::Futures);
    }

    if (!cache.spotPairs.empty() || !cache.futuresPairs.empty()) {
        cache.isLoaded = true;
        std::cout << "[TigerBot] Loaded " << cache.spotPairs.size() << " Spot pairs, "
            << cache.futuresPairs.size() << " Futures pairs." << std::endl;
    }
}

std::string RestClient::HttpsGet(const std::string& host, const std::string& target) {
    try {
        net::io_context ioc;
        tcp::resolver resolver(ioc);
        beast::ssl_stream<beast::tcp_stream> stream(ioc, ctx_);

        // SNI (Server Name Indication) обязателен для Binance API
        if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str())) {
            throw beast::system_error(
                beast::error_code(static_cast<int>(::ERR_get_error()), net::error::get_ssl_category()));
        }

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

        beast::error_code ec;
        stream.shutdown(ec);

        return res.body();
    }
    catch (std::exception const& e) {
        std::cerr << "Network Error (" << host << "): " << e.what() << std::endl;
        return "";
    }
}

std::vector<TradingPair> RestClient::ParseExchangeInfo(const std::string& jsonResponse, MarketType type) {
    std::vector<TradingPair> pairs;
    try {
        auto j = json::parse(jsonResponse);

        // В Tiger Trade фильтруют пары, которые не торгуются
        for (const auto& item : j["symbols"]) {
            if (item["status"] != "TRADING") continue;

            TradingPair p;
            p.symbol = item["symbol"].get<std::string>();
            p.baseAsset = item["baseAsset"].get<std::string>();
            p.quoteAsset = item["quoteAsset"].get<std::string>();
            p.type = type;
            p.isTrading = true;
            p.pricePrecision = item["baseAssetPrecision"].get<int>();

            // ВАЖНО: Парсинг фильтров. Без этого сетка цены будет кривой.
            for (const auto& filter : item["filters"]) {
                std::string fType = filter["filterType"];

                if (fType == "PRICE_FILTER") {
                    p.tickSize = std::stod(filter["tickSize"].get<std::string>());
                }
                else if (fType == "LOT_SIZE") {
                    p.stepSize = std::stod(filter["stepSize"].get<std::string>());
                    p.minQty = std::stod(filter["minQty"].get<std::string>());
                }
            }
            pairs.push_back(p);
        }
    }
    catch (const std::exception& e) {
        std::cerr << "Parsing Error: " << e.what() << std::endl;
    }
    return pairs;
}