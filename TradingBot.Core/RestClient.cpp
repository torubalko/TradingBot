#include "RestClient.h"
#include <iostream>
#include <boost/asio/connect.hpp>
#include <boost/asio/ip/tcp.hpp>
#include <nlohmann/json.hpp>
#include <wincrypt.h>
#pragma comment(lib, "crypt32.lib") 
#include <openssl/x509.h>
#include <openssl/pem.h>
#include <string>
#include <cmath>

using json = nlohmann::json;

RestClient::RestClient() {
    ctx_.set_verify_mode(ssl::verify_peer);
    LoadRootCertificates();
}

RestClient::~RestClient() {
}

void RestClient::LoadRootCertificates() {
    HCERTSTORE hStore = CertOpenSystemStore(0, L"ROOT");
    if (!hStore) return;

    X509_STORE* store = SSL_CTX_get_cert_store(ctx_.native_handle());
    PCCERT_CONTEXT pContext = NULL;

    while ((pContext = CertEnumCertificatesInStore(hStore, pContext))) {
        const unsigned char* p = pContext->pbCertEncoded;
        X509* x509 = d2i_X509(NULL, &p, pContext->cbCertEncoded);
        if (x509) {
            X509_STORE_add_cert(store, x509);
            X509_free(x509);
        }
    }
    CertCloseStore(hStore, 0);
}

void RestClient::LoadExchangeInfo(MarketCache& cache) {
    // Spot
    std::string spotJson = HttpsGet("api.binance.com", "/api/v3/exchangeInfo");
    if (!spotJson.empty()) {
        cache.spotPairs = ParseExchangeInfo(spotJson, MarketType::Spot);
    }

    // Futures
    std::string futJson = HttpsGet("fapi.binance.com", "/fapi/v1/exchangeInfo");
    if (!futJson.empty()) {
        cache.futuresPairs = ParseExchangeInfo(futJson, MarketType::Futures);
    }

    if (!cache.spotPairs.empty() || !cache.futuresPairs.empty()) {
        cache.isLoaded = true;
        char msg[128];
        sprintf_s(msg, "[TigerBot] REST Loaded: %zu Spot, %zu Futures.\n", cache.spotPairs.size(), cache.futuresPairs.size());
        OutputDebugStringA(msg);
    }
}

std::string RestClient::HttpsGet(const std::string& host, const std::string& target) {
    try {
        net::io_context ioc;
        tcp::resolver resolver(ioc);
        beast::ssl_stream<beast::tcp_stream> stream(ioc, ctx_);

        if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str())) return "";

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
    catch (const std::exception& e) {
        std::cerr << "[RestClient] HTTPS GET failed: " << e.what() << std::endl;
        return "";
    }
    catch (...) {
        std::cerr << "[RestClient] HTTPS GET failed with unknown error" << std::endl;
        return "";
    }
}

std::vector<TradingPair> RestClient::ParseExchangeInfo(const std::string& jsonResponse, MarketType type) {
    std::vector<TradingPair> pairs;
    try {
        auto j = json::parse(jsonResponse);
        for (const auto& item : j["symbols"]) {
            if (item["status"] != "TRADING") continue;

            TradingPair p;
            p.symbol = item["symbol"].get<std::string>();
            p.baseAsset = item["baseAsset"].get<std::string>();
            p.quoteAsset = item["quoteAsset"].get<std::string>();
            p.type = type;
            p.isTrading = true;

            p.tickSize = 0.0;
            p.stepSize = 0.0;
            p.minQty = 0.0;
            p.pricePrecision = 2; // ������, ���� �� ������ ���������

            for (const auto& filter : item["filters"]) {
                std::string fType = filter["filterType"];
                if (fType == "PRICE_FILTER") {
                    std::string tickStr = filter["tickSize"].get<std::string>();
                    p.tickSize = std::stod(tickStr);

                    // <--- ������ �������� �� TICK SIZE (������� ������ ����) --->
                    // ������: "0.001000" -> ������� ���� -> "0.001" -> 3 �����
                    size_t decimalPos = tickStr.find('.');
                    if (decimalPos != std::string::npos) {
                        // ������� ��������� ����
                        tickStr.erase(tickStr.find_last_not_of('0') + 1, std::string::npos);
                        // ���� ����� �������� ��������� (1.), ������� � �
                        if (tickStr.back() == '.') tickStr.pop_back();

                        // ������������� ������� �����
                        decimalPos = tickStr.find('.');
                        if (decimalPos != std::string::npos) {
                            p.pricePrecision = (int)(tickStr.length() - decimalPos - 1);
                        }
                        else {
                            p.pricePrecision = 0; // ����� �����
                        }
                    }
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
        std::cerr << "[RestClient] Failed to parse ExchangeInfo: " << e.what() << std::endl;
    }
    catch (...) {
        std::cerr << "[RestClient] Failed to parse ExchangeInfo with unknown error" << std::endl;
    }
    return pairs;
}