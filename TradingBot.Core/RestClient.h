#pragma once

#include "MarketDetails.h"
#include <boost/beast/core.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/http.hpp>
#include <boost/asio/strand.hpp>
#include <string>
#include <vector>
#include <thread>
#include <mutex>

namespace beast = boost::beast;
namespace http = beast::http;
namespace net = boost::asio;
namespace ssl = net::ssl;
using tcp = net::ip::tcp;

class RestClient {
public:
    RestClient();
    ~RestClient();

    // Загрузка данных
    void LoadExchangeInfo(MarketCache& cache);

private:
    // HTTP запрос
    std::string HttpsGet(const std::string& host, const std::string& target);

    // Парсинг
    std::vector<TradingPair> ParseExchangeInfo(const std::string& jsonResponse, MarketType type);

    // <--- ВАЖНОЕ: Метод для интеграции с Windows SSL
    void LoadRootCertificates();

    net::io_context ioc_;
    ssl::context ctx_{ ssl::context::tlsv12_client };
};