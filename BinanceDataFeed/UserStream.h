#pragma once

#include <string>
#include <atomic>
#include <functional>
#include <thread>
#include <vector>

#include <boost/asio.hpp>
#include <boost/asio/ssl.hpp>
#include <boost/beast.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/websocket.hpp>
#include <boost/beast/websocket/ssl.hpp>

#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>
#include <winhttp.h>
#include <wincrypt.h>
#pragma comment(lib, "winhttp.lib")
#pragma comment(lib, "crypt32.lib")
#endif

#include <openssl/x509.h>
#include <openssl/x509v3.h>

namespace hft {

namespace beast = boost::beast;
namespace websocket = beast::websocket;
namespace net = boost::asio;
namespace ssl = boost::asio::ssl;
using tcp = boost::asio::ip::tcp;

class UserStreamClient {
public:
    using MessageCallback = std::function<void(const std::string& payload)>;

    UserStreamClient(std::string apiKey,
        std::string restHost,
        std::string wsHost,
        std::string port,
        int keepAliveSeconds,
        MessageCallback cb)
        : apiKey_(std::move(apiKey))
        , restHost_(std::move(restHost))
        , wsHost_(std::move(wsHost))
        , port_(std::move(port))
        , keepAliveSeconds_(keepAliveSeconds)
        , callback_(std::move(cb))
        , resolver_(net::make_strand(ioc_))
        , ws_(net::make_strand(ioc_), sslCtx_)
    {
        buffer_.reserve(64 * 1024);
        sslCtx_.set_default_verify_paths();
        AddWindowsRootCerts(sslCtx_);
        sslCtx_.set_verify_mode(ssl::verify_peer);
    }

    ~UserStreamClient() {
        Stop();
    }

    bool Start() {
        if (running_.load() || apiKey_.empty()) {
            return false;
        }

        if (!CreateListenKey()) {
            return false;
        }

        running_.store(true);
        ioThread_ = std::thread([this] { RunIo(); });
        keepAliveThread_ = std::thread([this] { KeepAliveLoop(); });

        StartWebSocket();
        return true;
    }

    void Stop() {
        if (!running_.exchange(false)) {
            return;
        }

        beast::error_code ec;
        if (ws_.is_open()) {
            ws_.close(websocket::close_code::normal, ec);
        }
        ioc_.stop();

        if (ioThread_.joinable()) ioThread_.join();
        if (keepAliveThread_.joinable()) keepAliveThread_.join();

        if (!listenKey_.empty()) {
            CloseListenKey();
            listenKey_.clear();
        }
    }

private:
    static void AddWindowsRootCerts(ssl::context& ctx) {
#ifdef _WIN32
        HCERTSTORE storeHandle = CertOpenSystemStoreA(0, "ROOT");
        if (!storeHandle) return;
        X509_STORE* store = SSL_CTX_get_cert_store(ctx.native_handle());
        PCCERT_CONTEXT certCtx = nullptr;
        while ((certCtx = CertEnumCertificatesInStore(storeHandle, certCtx)) != nullptr) {
            const unsigned char* encoded = certCtx->pbCertEncoded;
            X509* cert = d2i_X509(nullptr, &encoded, certCtx->cbCertEncoded);
            if (cert) {
                X509_STORE_add_cert(store, cert);
                X509_free(cert);
            }
        }
        CertCloseStore(storeHandle, 0);
#endif
    }

    static bool VerifyHostName(bool preverified, ssl::verify_context& ctx, const std::string& host) {
        if (!preverified) {
            return false;
        }
        X509* cert = X509_STORE_CTX_get_current_cert(ctx.native_handle());
        if (!cert) {
            return false;
        }
        return X509_check_host(cert, host.c_str(), host.size(), 0, nullptr) == 1;
    }

    static std::string ExtractListenKey(const std::string& body) {
        const std::string key = "\"listenKey\":\"";
        auto pos = body.find(key);
        if (pos == std::string::npos) return "";
        pos += key.size();
        auto end = body.find('"', pos);
        if (end == std::string::npos) return "";
        return body.substr(pos, end - pos);
    }

#ifdef _WIN32
    static std::string HttpRequest(const std::string& method, const std::string& host, const std::string& path, const std::string& apiKey) {
        std::string result;
        std::wstring wHost(host.begin(), host.end());
        std::wstring wPath(path.begin(), path.end());

        HINTERNET hSession = WinHttpOpen(L"BinanceUserStream/1.0",
            WINHTTP_ACCESS_TYPE_DEFAULT_PROXY,
            WINHTTP_NO_PROXY_NAME,
            WINHTTP_NO_PROXY_BYPASS,
            0);
        if (!hSession) return result;

        DWORD protocols = WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_2;
        WinHttpSetOption(hSession, WINHTTP_OPTION_SECURE_PROTOCOLS, &protocols, sizeof(protocols));

        HINTERNET hConnect = WinHttpConnect(hSession, wHost.c_str(), INTERNET_DEFAULT_HTTPS_PORT, 0);
        if (!hConnect) {
            WinHttpCloseHandle(hSession);
            return result;
        }

        HINTERNET hRequest = WinHttpOpenRequest(hConnect, std::wstring(method.begin(), method.end()).c_str(),
            wPath.c_str(), NULL, WINHTTP_NO_REFERER, WINHTTP_DEFAULT_ACCEPT_TYPES, WINHTTP_FLAG_SECURE);
        if (!hRequest) {
            WinHttpCloseHandle(hConnect);
            WinHttpCloseHandle(hSession);
            return result;
        }

        DWORD timeout = 5000;
        WinHttpSetOption(hRequest, WINHTTP_OPTION_CONNECT_TIMEOUT, &timeout, sizeof(timeout));
        WinHttpSetOption(hRequest, WINHTTP_OPTION_RECEIVE_TIMEOUT, &timeout, sizeof(timeout));

        std::wstring headers = L"X-MBX-APIKEY: " + std::wstring(apiKey.begin(), apiKey.end()) + L"\r\n";
        WinHttpAddRequestHeaders(hRequest, headers.c_str(), (ULONG)-1L, WINHTTP_ADDREQ_FLAG_ADD | WINHTTP_ADDREQ_FLAG_REPLACE);

        BOOL bResults = WinHttpSendRequest(hRequest, WINHTTP_NO_ADDITIONAL_HEADERS, 0,
            WINHTTP_NO_REQUEST_DATA, 0, 0, 0);
        if (bResults) bResults = WinHttpReceiveResponse(hRequest, NULL);

        if (bResults) {
            DWORD dwDownloaded = 0;
            char buffer[4096];
            while (WinHttpReadData(hRequest, buffer, sizeof(buffer), &dwDownloaded)) {
                if (dwDownloaded == 0) break;
                result.append(buffer, buffer + dwDownloaded);
            }
        }

        WinHttpCloseHandle(hRequest);
        WinHttpCloseHandle(hConnect);
        WinHttpCloseHandle(hSession);
        return result;
    }
#endif

    bool CreateListenKey() {
#ifdef _WIN32
        std::string body = HttpRequest("POST", restHost_, "/fapi/v1/listenKey", apiKey_);
        listenKey_ = ExtractListenKey(body);
#endif
        return !listenKey_.empty();
    }

    bool KeepAliveListenKey() {
#ifdef _WIN32
        std::string body = HttpRequest("PUT", restHost_, "/fapi/v1/listenKey", apiKey_);
        return !body.empty();
#else
        return false;
#endif
    }

    void CloseListenKey() {
#ifdef _WIN32
        HttpRequest("DELETE", restHost_, "/fapi/v1/listenKey", apiKey_);
#endif
    }

    void RunIo() {
        try {
            ioc_.run();
        } catch (...) {
        }
    }

    void StartWebSocket() {
        resolver_.async_resolve(wsHost_, port_,
            beast::bind_front_handler(&UserStreamClient::OnResolve, this));
    }

    void OnResolve(beast::error_code ec, tcp::resolver::results_type results) {
        if (ec) {
            return Fail(ec, "resolve");
        }

        beast::get_lowest_layer(ws_).async_connect(
            results,
            beast::bind_front_handler(&UserStreamClient::OnConnect, this));
    }

    void OnConnect(beast::error_code ec, tcp::resolver::results_type::endpoint_type) {
        if (ec) {
            return Fail(ec, "connect");
        }

        beast::get_lowest_layer(ws_).socket().set_option(tcp::no_delay(true));

        if (!SSL_set_tlsext_host_name(ws_.next_layer().native_handle(), wsHost_.c_str())) {
            ec = beast::error_code(static_cast<int>(::ERR_get_error()), net::error::get_ssl_category());
            return Fail(ec, "SNI");
        }

        ws_.next_layer().set_verify_mode(ssl::verify_peer);
        ws_.next_layer().set_verify_callback([host = wsHost_](bool preverified, ssl::verify_context& ctx) {
            return VerifyHostName(preverified, ctx, host);
        });

        ws_.next_layer().async_handshake(
            ssl::stream_base::client,
            beast::bind_front_handler(&UserStreamClient::OnSslHandshake, this));
    }

    void OnSslHandshake(beast::error_code ec) {
        if (ec) {
            return Fail(ec, "ssl_handshake");
        }

        beast::get_lowest_layer(ws_).expires_never();

        websocket::stream_base::timeout opt{
            std::chrono::seconds(30),
            std::chrono::seconds(60),
            true
        };
        ws_.set_option(opt);

        ws_.control_callback([this](websocket::frame_type kind, beast::string_view payload) {
            if (kind == websocket::frame_type::ping) {
                websocket::ping_data data;
                data.assign(payload.data(), payload.size());
                beast::error_code pongEc;
                ws_.pong(data, pongEc);
            }
        });

        ws_.set_option(websocket::stream_base::decorator([](websocket::request_type& req) {
            req.set(beast::http::field::user_agent, "TradingBot/1.0");
        }));

        const std::string path = "/ws/" + listenKey_;
        ws_.async_handshake(wsHost_, path,
            beast::bind_front_handler(&UserStreamClient::OnHandshake, this));
    }

    void OnHandshake(beast::error_code ec) {
        if (ec) {
            return Fail(ec, "ws_handshake");
        }

        connected_.store(true);
        DoRead();
    }

    void DoRead() {
        if (!running_.load()) return;
        buffer_.consume(buffer_.size());
        ws_.async_read(buffer_, beast::bind_front_handler(&UserStreamClient::OnRead, this));
    }

    void OnRead(beast::error_code ec, std::size_t bytesTransferred) {
        if (ec) {
            connected_.store(false);
            return Fail(ec, "read");
        }

        const char* data = static_cast<const char*>(buffer_.data().data());
        if (callback_) {
            callback_(std::string(data, data + bytesTransferred));
        }

        DoRead();
    }

    void Fail(beast::error_code, const char*) {
        connected_.store(false);
        if (!running_.load()) return;

        std::this_thread::sleep_for(std::chrono::milliseconds(250));
        if (running_.load()) {
            StartWebSocket();
        }
    }

    void KeepAliveLoop() {
        while (running_.load()) {
            for (int i = 0; i < keepAliveSeconds_ && running_.load(); ++i) {
                std::this_thread::sleep_for(std::chrono::seconds(1));
            }
            if (!running_.load()) break;
            KeepAliveListenKey();
        }
    }

    std::string apiKey_;
    std::string restHost_;
    std::string wsHost_;
    std::string port_;
    int keepAliveSeconds_;

    MessageCallback callback_;

    std::atomic<bool> running_{false};
    std::atomic<bool> connected_{false};

    net::io_context ioc_;
    ssl::context sslCtx_{ssl::context::tlsv12_client};
    tcp::resolver resolver_;
    websocket::stream<beast::ssl_stream<beast::tcp_stream>> ws_;
    beast::flat_buffer buffer_;

    std::string listenKey_;

    std::thread ioThread_;
    std::thread keepAliveThread_;
};

} // namespace hft
