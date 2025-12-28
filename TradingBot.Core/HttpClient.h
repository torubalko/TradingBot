#pragma once

#include <string>
#include <boost/beast/core.hpp>
#include <boost/beast/http.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/version.hpp>
#include <boost/asio/connect.hpp>
#include <boost/asio/ip/tcp.hpp>
#include <boost/asio/ssl/error.hpp>
#include <boost/asio/ssl/stream.hpp>
#include <iostream>

namespace beast = boost::beast;
namespace http = beast::http;
namespace net = boost::asio;
namespace ssl = net::ssl;
using tcp = net::ip::tcp;

namespace TradingBot::Core::Network {

    class HttpClient {
    public:
        // ����� ��� ��������� ������� JSON ������ �� URL
        // target, ��������: "/fapi/v1/depth?symbol=BTCUSDT&limit=1000"
        static std::string Get(const std::string& host, const std::string& target) {
            try {
                net::io_context ioc;
                ssl::context ctx(ssl::context::tlsv12_client);
                ctx.set_default_verify_paths();

                tcp::resolver resolver(ioc);
                beast::ssl_stream<tcp::socket> stream(ioc, ctx);

                // ��������� SNI (����� ��� Binance)
                if (!SSL_set_tlsext_host_name(stream.native_handle(), host.c_str())) {
                    throw beast::system_error(
                        beast::error_code(static_cast<int>(::ERR_get_error()),
                            net::error::get_ssl_category()),
                        "Failed to set SNI Hostname");
                }

                // �������� IP � �����������
                auto const results = resolver.resolve(host, "443");
                net::connect(beast::get_lowest_layer(stream), results);
                stream.handshake(ssl::stream_base::client);

                // ��������� HTTP GET ������
                http::request<http::string_body> req{ http::verb::get, target, 11 };
                req.set(http::field::host, host);
                req.set(http::field::user_agent, BOOST_BEAST_VERSION_STRING);

                // ����������
                http::write(stream, req);

                // ������ �����
                beast::flat_buffer buffer;
                http::response<http::dynamic_body> res;
                http::read(stream, buffer, res);

                // ��������� SSL ���������
                beast::error_code ec;
                stream.shutdown(ec);
                if (ec == net::error::eof) ec = {}; // ���������� ������� ��������

                // ���������� ���� ������ (JSON)
                return beast::buffers_to_string(res.body().data());
            }
            catch (std::exception const& e) {
                std::cerr << "[HTTP ERROR] " << e.what() << std::endl;
                return "";
            }
        }
    };
}