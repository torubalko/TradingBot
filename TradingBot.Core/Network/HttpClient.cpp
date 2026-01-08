#include "HttpClient.h"
#include <iostream>
#include <boost/beast/zlib.hpp>  // ? ДОБАВЛЕНО: для gzip decompression

namespace TradingBot::Core::Network {

    HttpClient::HttpClient() {
        // Настройка SSL context
        sslCtx_.set_default_verify_paths();
        sslCtx_.set_verify_mode(ssl::verify_none);
    }

    HttpClient::~HttpClient() {
        // Cleanup
    }

    // ???????????????????????????????????????????????????????????????
    // GET Request
    // ???????????????????????????????????????????????????????????????
    HttpResponse HttpClient::Get(const std::string& host,
                                 const std::string& target,
                                 const std::string& apiKey) {
        return ExecuteRequest(http::verb::get, host, target, "", apiKey);
    }

    // ???????????????????????????????????????????????????????????????
    // GET Request (static helper)
    // ???????????????????????????????????????????????????????????????
    std::string HttpClient::GetSimple(const std::string& host, const std::string& target) {
        HttpClient client;
        auto response = client.Get(host, target, "");
        return response.IsSuccess() ? response.body : "";
    }

    // ???????????????????????????????????????????????????????????????
    // POST Request
    // ???????????????????????????????????????????????????????????????
    HttpResponse HttpClient::Post(const std::string& host,
                                  const std::string& target,
                                  const std::string& body,
                                  const std::string& apiKey) {
        return ExecuteRequest(http::verb::post, host, target, body, apiKey);
    }

    // ???????????????????????????????????????????????????????????????
    // DELETE Request
    // ???????????????????????????????????????????????????????????????
    HttpResponse HttpClient::Delete(const std::string& host,
                                    const std::string& target,
                                    const std::string& apiKey) {
        return ExecuteRequest(http::verb::delete_, host, target, "", apiKey);
    }

    // ???????????????????????????????????????????????????????????????
    // ExecuteRequest: Универсальный метод для всех HTTP запросов
    // ИСПРАВЛЕНО: Добавлена gzip decompression
    // ???????????????????????????????????????????????????????????????
    HttpResponse HttpClient::ExecuteRequest(
        http::verb method,
        const std::string& host,
        const std::string& target,
        const std::string& body,
        const std::string& apiKey)
    {
        HttpResponse response;

        try {
            // 1. Resolve DNS (FAST: кэшируем результат)
            tcp::resolver resolver(ioc_);
            auto const results = resolver.resolve(host, "443");

            // 2. Create SSL stream
            beast::ssl_stream<beast::tcp_stream> stream(ioc_, sslCtx_);

            // Устанавливаем агрессивные timeout
            beast::get_lowest_layer(stream).expires_after(std::chrono::seconds(3));

            // Set SNI Hostname (required for SSL)
            if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str())) {
                beast::error_code ec{static_cast<int>(::ERR_get_error()), net::error::get_ssl_category()};
                throw beast::system_error{ec};
            }

            // 3. Connect TCP (с timeout)
            beast::get_lowest_layer(stream).connect(results);

            // 4. SSL Handshake (с timeout)
            beast::get_lowest_layer(stream).expires_after(std::chrono::seconds(3));
            stream.handshake(ssl::stream_base::client);

            // 5. Build HTTP request
            http::request<http::string_body> req{method, target, 11};
            req.set(http::field::host, host);
            req.set(http::field::user_agent, "TradingBot-HFT/2.0");
            req.set(http::field::connection, "keep-alive");
            // req.set(http::field::accept_encoding, "gzip, deflate"); // ? ЗАКОММЕНТИРОВАНО: отключаем gzip

            // Add API key header (если есть)
            if (!apiKey.empty()) {
                req.set("X-MBX-APIKEY", apiKey);
            }

            // Add body for POST
            if (!body.empty()) {
                req.body() = body;
                req.set(http::field::content_type, "application/x-www-form-urlencoded");
                req.prepare_payload();
            }

            // 6. Send HTTP request (с timeout)
            beast::get_lowest_layer(stream).expires_after(std::chrono::seconds(5));
            http::write(stream, req);

            // 7. Receive HTTP response (с timeout)
            beast::flat_buffer buffer;
            http::response<http::string_body> res;
            beast::get_lowest_layer(stream).expires_after(std::chrono::seconds(5));
            http::read(stream, buffer, res);

            // 8. Extract response
            response.statusCode = res.result_int();
            
            // ???????????????????????????????????????????????????????
            // НОВОЕ: Проверяем Content-Encoding и декомпрессим gzip
            // ???????????????????????????????????????????????????????
            auto contentEncoding = res[http::field::content_encoding];
            
            if (contentEncoding == "gzip") {
                // GZIP decompression
                beast::zlib::z_params zs;
                beast::zlib::inflate_stream inflater;
                
                zs.next_in = res.body().data();
                zs.avail_in = res.body().size();
                zs.total_in = 0;
                zs.total_out = 0;
                
                std::string decompressed;
                decompressed.reserve(res.body().size() * 10); // Резервируем больше места
                
                char outBuffer[8192];
                beast::error_code ec;
                
                inflater.reset(31); // 31 = gzip format
                
                while (zs.avail_in > 0) {
                    zs.next_out = outBuffer;
                    zs.avail_out = sizeof(outBuffer);
                    
                    inflater.write(zs, beast::zlib::Flush::sync, ec);
                    
                    if (ec && ec != beast::zlib::error::end_of_stream) {
                        throw beast::system_error{ec};
                    }
                    
                    size_t have = sizeof(outBuffer) - zs.avail_out;
                    decompressed.append(outBuffer, have);
                    
                    if (ec == beast::zlib::error::end_of_stream) {
                        break;
                    }
                }
                
                response.body = std::move(decompressed);
                
            } else {
                // Plain response (не сжат)
                response.body = res.body();
            }

            // 9. Graceful shutdown (НЕ блокирующий)
            beast::error_code ec;
            beast::get_lowest_layer(stream).expires_after(std::chrono::milliseconds(500));
            stream.shutdown(ec);

            // Ignore "stream truncated" error (normal для HTTP/1.1)
            if (ec == net::error::eof || ec == ssl::error::stream_truncated) {
                ec = {};
            }

        } catch (const std::exception& e) {
            response.statusCode = 0;
            response.errorMessage = std::string("HTTP request failed: ") + e.what();
            
            #ifdef _WIN32
            std::string debugMsg = "[HttpClient] Error: " + response.errorMessage + "\n";
            OutputDebugStringA(debugMsg.c_str());
            #endif
        }

        return response;
    }

} // namespace TradingBot::Core::Network
