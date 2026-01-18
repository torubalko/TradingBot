#pragma once

#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>
#include <winhttp.h>
#pragma comment(lib, "winhttp.lib")
#endif

#include <string>
#include <vector>

namespace hft {

// Simple HTTP GET client using WinHTTP
class SimpleHttpClient {
public:
    static std::string HttpGet(const std::string& url) {
#ifdef _WIN32
        // Parse URL
        std::wstring wUrl(url.begin(), url.end());
        URL_COMPONENTS urlComp = {};
        urlComp.dwStructSize = sizeof(urlComp);
        
        wchar_t host[256] = {};
        wchar_t path[1024] = {};
        urlComp.lpszHostName = host;
        urlComp.dwHostNameLength = sizeof(host) / sizeof(host[0]);
        urlComp.lpszUrlPath = path;
        urlComp.dwUrlPathLength = sizeof(path) / sizeof(path[0]);
        
        if (!WinHttpCrackUrl(wUrl.c_str(), 0, 0, &urlComp)) {
            return "";
        }
        
        // Open session
        HINTERNET hSession = WinHttpOpen(
            L"BinanceDataFeed/1.0",
            WINHTTP_ACCESS_TYPE_DEFAULT_PROXY,
            WINHTTP_NO_PROXY_NAME,
            WINHTTP_NO_PROXY_BYPASS,
            0
        );
        
        if (!hSession) return "";
        
        // Connect
        HINTERNET hConnect = WinHttpConnect(
            hSession,
            urlComp.lpszHostName,
            urlComp.nPort,
            0
        );
        
        if (!hConnect) {
            WinHttpCloseHandle(hSession);
            return "";
        }
        
        // Open request
        DWORD flags = (urlComp.nScheme == INTERNET_SCHEME_HTTPS) ? WINHTTP_FLAG_SECURE : 0;
        HINTERNET hRequest = WinHttpOpenRequest(
            hConnect,
            L"GET",
            urlComp.lpszUrlPath,
            NULL,
            WINHTTP_NO_REFERER,
            WINHTTP_DEFAULT_ACCEPT_TYPES,
            flags
        );
        
        if (!hRequest) {
            WinHttpCloseHandle(hConnect);
            WinHttpCloseHandle(hSession);
            return "";
        }
        
        // Set timeout (5 seconds)
        DWORD timeout = 5000;
        WinHttpSetOption(hRequest, WINHTTP_OPTION_CONNECT_TIMEOUT, &timeout, sizeof(timeout));
        WinHttpSetOption(hRequest, WINHTTP_OPTION_RECEIVE_TIMEOUT, &timeout, sizeof(timeout));
        
        // Enable automatic decompression (gzip/deflate)
        DWORD decompression = WINHTTP_DECOMPRESSION_FLAG_ALL;
        WinHttpSetOption(hRequest, WINHTTP_OPTION_DECOMPRESSION, &decompression, sizeof(decompression));
        
        // Send request
        if (!WinHttpSendRequest(hRequest, WINHTTP_NO_ADDITIONAL_HEADERS, 0, WINHTTP_NO_REQUEST_DATA, 0, 0, 0)) {
            WinHttpCloseHandle(hRequest);
            WinHttpCloseHandle(hConnect);
            WinHttpCloseHandle(hSession);
            return "";
        }
        
        // Receive response
        if (!WinHttpReceiveResponse(hRequest, NULL)) {
            WinHttpCloseHandle(hRequest);
            WinHttpCloseHandle(hConnect);
            WinHttpCloseHandle(hSession);
            return "";
        }
        
        // Read data
        std::string result;
        DWORD bytesAvailable = 0;
        DWORD bytesRead = 0;
        std::vector<char> buffer(8192);
        
        do {
            bytesAvailable = 0;
            if (!WinHttpQueryDataAvailable(hRequest, &bytesAvailable)) {
                break;
            }
            
            if (bytesAvailable == 0) break;
            
            DWORD toRead = (bytesAvailable > buffer.size()) ? buffer.size() : bytesAvailable;
            if (!WinHttpReadData(hRequest, buffer.data(), toRead, &bytesRead)) {
                break;
            }
            
            result.append(buffer.data(), bytesRead);
        } while (bytesAvailable > 0);
        
        // Cleanup
        WinHttpCloseHandle(hRequest);
        WinHttpCloseHandle(hConnect);
        WinHttpCloseHandle(hSession);
        
        return result;
#else
        // TODO: Linux implementation using libcurl
        return "";
#endif
    }
};

} // namespace hft
