#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <WinSock2.h>
#include <ws2tcpip.h>
#include <windows.h>
#include <shlwapi.h>
#include <winhttp.h>
#include <windowsx.h>
#ifndef WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_2
#define WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_2 0x00000800
#endif
#pragma comment(lib, "Ws2_32.lib")
#pragma comment(lib, "Shlwapi.lib")
#pragma comment(lib, "winhttp.lib")

// standard includes
#include <atomic>
#include <thread>
#include <memory>
#include <string>
#include <iostream>
#include <sstream>
#include <iomanip>
#include <mutex>
#include <algorithm>

#include "Graphics.h"
#include "OrderBookRenderer.h"
#include "BinanceFeedAdapter.h"
#include "../BinanceDataFeed/HighSpeedDataFeed.h"

using TradingBot::Core::SharedState;
using TradingBot::Core::ExternalMetricsSnapshot;

std::unique_ptr<Graphics> g_Graphics;
std::unique_ptr<OrderBookRenderer> g_OrderBookRenderer;
std::shared_ptr<SharedState> g_SharedState;
std::atomic<bool> g_Running(true);

std::unique_ptr<hft::BinanceDataFeed> g_Feed;
std::unique_ptr<BinanceFeedAdapter> g_FeedAdapter;

std::vector<int> g_Scales = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000 };
int g_ScaleIndex = 0;

enum class VolumeDisplayMode { Base = 0, Quote = 1 };
std::atomic<int> g_VolumeMode{ 0 }; // 0-base, 1-quote
struct VolumeToggleUIState { float x = 0, y = 0, w = 0, h = 0; };
VolumeToggleUIState g_VolToggleUI;

struct SymbolUIState {
    std::vector<std::string> allSymbols;
    std::vector<std::string> filteredSymbols;
    std::wstring search;
    bool dropdownOpen = false;
    int highlightedIndex = 0;
    int listOffset = 0;
    std::string currentSymbol = "BTCUSDT";
    float buttonX = 240.0f;
    float buttonY = 10.0f;
    float buttonW = 160.0f;
    float buttonH = 30.0f;
    float dropdownX = 240.0f;
    float dropdownY = 50.0f;
    float dropdownW = 220.0f;
};

SymbolUIState g_SymbolUI;
std::mutex g_SymbolMutex;
std::mutex g_SymbolSwitchMutex;
std::string g_PendingSymbol;
std::atomic<bool> g_SymbolChangeRequested{ false };
const float HEADER_HEIGHT = 50.0f;
const float DROPDOWN_SEARCH_H = 26.0f;
const float DROPDOWN_ITEM_H = 20.0f;
const int DROPDOWN_MAX_ITEMS = 12;

// Forward declarations
std::string ToUpper(const std::string& s);
std::wstring ToWString(const std::string& s);
std::string HttpGetWinHttp(const wchar_t* host, const wchar_t* path);
std::vector<std::string> ParseFuturesSymbols(const std::string& json);
std::vector<std::string> FetchFuturesSymbols();
void UpdateFilteredSymbolsLocked();
void InitializeSymbols();
void StartFeedForSymbol(const std::string& sym);
void ApplyPendingSymbolChange();
void SelectSymbol(const std::string& sym);
void HandleMouseClick(int x, int y);
void HandleCharInput(WPARAM wParam);
void HandleKeyDown(WPARAM wParam);

// helper definitions
std::string ToUpper(const std::string& s) {
    std::string out = s;
    std::transform(out.begin(), out.end(), out.begin(), [](unsigned char c) { return static_cast<char>(::toupper(c)); });
    return out;
}

std::wstring ToWString(const std::string& s) {
    return std::wstring(s.begin(), s.end());
}

std::string HttpGetWinHttp(const wchar_t* host, const wchar_t* path) {
    std::string result;
    HINTERNET hSession = WinHttpOpen(L"TradingBot/1.0", WINHTTP_ACCESS_TYPE_DEFAULT_PROXY, WINHTTP_NO_PROXY_NAME, WINHTTP_NO_PROXY_BYPASS, 0);
    if (!hSession) return result;

    DWORD protocols = WINHTTP_FLAG_SECURE_PROTOCOL_TLS1_2;
    WinHttpSetOption(hSession, WINHTTP_OPTION_SECURE_PROTOCOLS, &protocols, sizeof(protocols));
    WinHttpSetTimeouts(hSession, 5000, 5000, 5000, 5000);

    HINTERNET hConnect = WinHttpConnect(hSession, host, INTERNET_DEFAULT_HTTPS_PORT, 0);
    if (!hConnect) { WinHttpCloseHandle(hSession); return result; }
    HINTERNET hRequest = WinHttpOpenRequest(hConnect, L"GET", path, NULL, WINHTTP_NO_REFERER, WINHTTP_DEFAULT_ACCEPT_TYPES, WINHTTP_FLAG_SECURE);
    if (!hRequest) { WinHttpCloseHandle(hConnect); WinHttpCloseHandle(hSession); return result; }

    DWORD decompression = WINHTTP_DECOMPRESSION_FLAG_GZIP | WINHTTP_DECOMPRESSION_FLAG_DEFLATE;
    WinHttpSetOption(hRequest, WINHTTP_OPTION_DECOMPRESSION, &decompression, sizeof(decompression));

    static const wchar_t* kHeaders = L"Accept: application/json\r\nAccept-Encoding: identity\r\n";
    WinHttpAddRequestHeaders(hRequest, kHeaders, (ULONG)-1L, WINHTTP_ADDREQ_FLAG_ADD | WINHTTP_ADDREQ_FLAG_REPLACE);

    BOOL bResults = WinHttpSendRequest(hRequest, WINHTTP_NO_ADDITIONAL_HEADERS, 0, WINHTTP_NO_REQUEST_DATA, 0, 0, 0);
    if (bResults) bResults = WinHttpReceiveResponse(hRequest, NULL);

    if (bResults) {
        DWORD dwDownloaded = 0;
        char buffer[8192];
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

std::vector<std::string> ParseFuturesSymbols(const std::string& json) {
    std::vector<std::string> out;

    const std::string key = "\"symbols\":";
    size_t startPos = json.find(key);
    if (startPos == std::string::npos) return out;
    startPos = json.find('[', startPos);
    if (startPos == std::string::npos) return out;

    size_t currentPos = startPos + 1;
    while (true) {
        size_t objStart = json.find('{', currentPos);
        if (objStart == std::string::npos) break;
        size_t objEnd = json.find('}', objStart);
        if (objEnd == std::string::npos) break;

        std::string obj = json.substr(objStart, objEnd - objStart);

        auto extractValue = [&](const std::string& field) -> std::string {
            std::string searchKey = "\"" + field + "\":\"";
            size_t kPos = obj.find(searchKey);
            if (kPos == std::string::npos) return "";
            size_t vStart = kPos + searchKey.length();
            size_t vEnd = obj.find('"', vStart);
            if (vEnd == std::string::npos) return "";
            return obj.substr(vStart, vEnd - vStart);
        };

        std::string sym = extractValue("symbol");
        std::string status = extractValue("status");
        std::string contractType = extractValue("contractType");

        if (!sym.empty() && status == "TRADING" && contractType == "PERPETUAL") {
            out.push_back(ToUpper(sym));
        }

        currentPos = objEnd + 1;
    }

    std::sort(out.begin(), out.end());
    out.erase(std::unique(out.begin(), out.end()), out.end());
    return out;
}

std::vector<std::string> FetchFuturesSymbols() {
    auto body = HttpGetWinHttp(L"fapi.binance.com", L"/fapi/v1/exchangeInfo");
    if (body.empty()) return {};
    return ParseFuturesSymbols(body);
}

// ═══════════════════════════════════════════════════════════════
// Trading Bot Thread: Запуск основной логики бота
// ═══════════════════════════════════════════════════════════════

void TradingBotThreadFunc() {
    try {
        OutputDebugStringA("[TradingBot] Initializing BinanceDataFeed...\n");

        g_SharedState = std::make_shared<SharedState>();
        g_FeedAdapter = std::make_unique<BinanceFeedAdapter>(g_SharedState);

        InitializeSymbols();
        std::string startSymbol;
        {
            std::lock_guard<std::mutex> lock(g_SymbolMutex);
            startSymbol = g_SymbolUI.currentSymbol;
        }

        StartFeedForSymbol(startSymbol);

        // Metrics pump: update external metrics every 200 ms
        while (g_Running) {
            ApplyPendingSymbolChange();

            if (g_Feed) {
                ExternalMetricsSnapshot snap{};
                auto& lt = g_Feed->GetLatencyTracker();
                snap.exchLatencyNs = lt.GetExchangeAvgNs();
                snap.netLatencyNs = lt.GetNetworkAvgNs();
                snap.enqueueLatencyNs = lt.GetEnqueueAvgNs();
                snap.parseLatencyNs = lt.GetParseAvgNs();
                snap.processLatencyNs = lt.GetProcessAvgNs();
                snap.callbackLatencyNs = lt.GetCallbackAvgNs();
                snap.procChainLatencyNs = snap.enqueueLatencyNs + snap.parseLatencyNs + snap.processLatencyNs + snap.callbackLatencyNs;
                snap.endToEndP99Ns = lt.GetEndToEndP99Ms() * 1'000'000; // ms->ns
                snap.messagesPerSecond = lt.GetMessagesPerSecond();
                snap.droppedMessages = g_Feed->GetDroppedMessages();
                snap.queueHighWater = g_Feed->GetQueueHighWaterMark();
                g_SharedState->UpdateExternalMetrics(snap);
            }

            std::this_thread::sleep_for(std::chrono::milliseconds(200));
        }

        if (g_Feed) g_Feed->Stop();
    }
    catch (const std::exception& e) {
        OutputDebugStringA("[TradingBot] FATAL ERROR: ");
        OutputDebugStringA(e.what());
        OutputDebugStringA("\n");
        g_Running = false;
    }
}

// ═══════════════════════════════════════════════════════════════
// Helper Functions (для визуализации)
// ═══════════════════════════════════════════════════════════════

std::wstring FormatPrice(double price) {
    std::wstringstream ss;
    ss << std::fixed;
    if (price >= 1000.0) ss << std::setprecision(1) << price;
    else if (price >= 10.0) ss << std::setprecision(2) << price;
    else ss << std::setprecision(4) << price;
    return ss.str();
}

std::wstring FormatQuoteVolume(double vol) {
    std::wstringstream ss;
    ss << std::fixed;
    if (vol >= 1000000.0) {
        double val = vol / 1000000.0;
        ss << std::setprecision(1) << val << L"M";
    }
    else if (vol >= 1000.0) {
        double val = vol / 1000.0;
        if (val >= 100.0) ss << std::setprecision(0) << val << L"k";
        else ss << std::setprecision(1) << val << L"k";
    }
    else {
        ss << std::setprecision(0) << vol;
    }
    return ss.str();
}

std::wstring FormatPercent(double pct) {
    std::wstringstream ss;
    ss << std::fixed << std::setprecision(2);
    if (pct > 0) ss << L"+";
    ss << pct << L"%";
    return ss.str();
}

// ═══════════════════════════════════════════════════════════════
// Window Procedure
// ═══════════════════════════════════════════════════════════════

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {
    case WM_MOUSEWHEEL: {
        short zDelta = GET_WHEEL_DELTA_WPARAM(wParam);
        bool handled = false;
        {
            std::lock_guard<std::mutex> lock(g_SymbolMutex);
            if (g_SymbolUI.dropdownOpen && !g_SymbolUI.filteredSymbols.empty()) {
                int total = static_cast<int>(g_SymbolUI.filteredSymbols.size());
                int step = (zDelta > 0) ? -1 : 1;
                int newHighlight = g_SymbolUI.highlightedIndex + step;
                newHighlight = (std::max)(0, (std::min)(newHighlight, total - 1));
                g_SymbolUI.highlightedIndex = newHighlight;
                if (g_SymbolUI.highlightedIndex < g_SymbolUI.listOffset) {
                    g_SymbolUI.listOffset = g_SymbolUI.highlightedIndex;
                }
                int windowEnd = g_SymbolUI.listOffset + DROPDOWN_MAX_ITEMS;
                if (g_SymbolUI.highlightedIndex >= windowEnd) {
                    g_SymbolUI.listOffset = g_SymbolUI.highlightedIndex - DROPDOWN_MAX_ITEMS + 1;
                }
                handled = true;
            }
        }
        if (!handled) {
            if (zDelta > 0) { if (g_ScaleIndex < g_Scales.size() - 1) g_ScaleIndex++; }
            else { if (g_ScaleIndex > 0) g_ScaleIndex--; }
        }
    } return 0;

    case WM_LBUTTONDOWN: {
        SetFocus(hWnd);
        int x = GET_X_LPARAM(lParam);
        int y = GET_Y_LPARAM(lParam);
        HandleMouseClick(x, y);
    } return 0;

    case WM_CHAR:
        HandleCharInput(wParam);
        return 0;

    case WM_KEYDOWN:
        HandleKeyDown(wParam);
        return 0;
    
    case WM_SIZE:
        if (g_Graphics) {
            g_Graphics->Resize(hWnd);
        }
        return 0;
    
    case WM_DESTROY:
        OutputDebugStringA("[TradingBot] Window closing, shutting down...\n");
        g_Running = false;
        if (g_Feed) g_Feed->Stop();
        PostQuitMessage(0);
        return 0;
    }
    return DefWindowProc(hWnd, message, wParam, lParam);
}

// ═══════════════════════════════════════════════════════════════
// WinMain: Entry Point
// ═══════════════════════════════════════════════════════════════

HICON LoadTorBotIcon() {
    wchar_t exePath[MAX_PATH] = {0};
    if (GetModuleFileNameW(NULL, exePath, MAX_PATH)) {
        PathRemoveFileSpecW(exePath);
        wcscat_s(exePath, L"\\TorBot.ico");
        HICON hIcon = (HICON)LoadImageW(NULL, exePath, IMAGE_ICON, 0, 0, LR_LOADFROMFILE | LR_DEFAULTSIZE);
        if (hIcon) return hIcon;
    }
    // fallback current dir
    HICON hIcon = (HICON)LoadImageW(NULL, L"TorBot.ico", IMAGE_ICON, 0, 0, LR_LOADFROMFILE | LR_DEFAULTSIZE);
    if (hIcon) return hIcon;
    return LoadIcon(NULL, IDI_APPLICATION);
}


int APIENTRY WinMain(_In_ HINSTANCE hInstance, 
                     _In_opt_ HINSTANCE hPrevInstance, 
                     _In_ LPSTR lpCmdLine, 
                     _In_ int nCmdShow) 
{
    // Detach console to keep only the graphics window
    FreeConsole();

    // Запускаем Trading Bot в отдельном потоке
    std::thread tradingBotThread(TradingBotThreadFunc);

    // Создаём окно для визуализации
    // Create window class
    HICON hIcon = LoadTorBotIcon();

    WNDCLASSEXW wc = {
        sizeof(WNDCLASSEXW),
        CS_CLASSDC,
        WndProc,
        0L, 0L,
        GetModuleHandle(NULL),
        hIcon,
        NULL,
        NULL,
        NULL,
        L"TorBotWindow",
        hIcon
    };
    RegisterClassExW(&wc);

    HWND hWnd = CreateWindowW(
        L"TorBotWindow",
        L"TorBot HFT v2.0",
        WS_OVERLAPPEDWINDOW,
        100, 100, 1200, 1200,
        NULL, NULL,
        wc.hInstance,
        NULL
    );

    SendMessageW(hWnd, WM_SETICON, ICON_BIG,   (LPARAM)hIcon);
    SendMessageW(hWnd, WM_SETICON, ICON_SMALL, (LPARAM)hIcon);

    // Инициализируем графику
    g_Graphics = std::make_unique<Graphics>();
    if (!g_Graphics->Initialize(hWnd)) {
        OutputDebugStringA("[Graphics] Failed to initialize\n");
        return 1;
    }

    ShowWindow(hWnd, nCmdShow);
    UpdateWindow(hWnd);

    // ═══════════════════════════════════════════════════════════════
    // НОВОЕ: Ждём пока TradingBot инициализируется
    // ═══════════════════════════════════════════════════════════════
    std::this_thread::sleep_for(std::chrono::milliseconds(100));
    
    // Создаём OrderBookRenderer после инициализации бота
    if (g_SharedState) {
        g_OrderBookRenderer = std::make_unique<OrderBookRenderer>(
            g_Graphics.get(),
            g_SharedState
        );
    }

    // ═══════════════════════════════════════════════════════════════
    // Main Render Loop
    // ═══════════════════════════════════════════════════════════════
    MSG msg = { 0 };
    while (msg.message != WM_QUIT && g_Running) {
        if (PeekMessage(&msg, NULL, 0U, 0U, PM_REMOVE)) {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
        else {
            // Render frame
            g_Graphics->BeginFrame(0.12f, 0.12f, 0.14f);

            float screenWidth = g_Graphics->GetWidth();
            float screenHeight = g_Graphics->GetHeight();

            // Header
            g_Graphics->DrawRectPixels(0, 0, screenWidth, HEADER_HEIGHT, 0.1f, 0.1f, 0.12f, 1.0f);
            g_Graphics->DrawRectPixels(0, HEADER_HEIGHT - 1.0f, screenWidth, 1.0f, 0.3f, 0.3f, 0.3f, 1.0f);

            g_Graphics->DrawTextPixels(L"TORBOT", 20, 15, 200, 20, 14, 1.0f, 1.0f, 1.0f, 1.0f);

            std::string currentSymbol;
            std::vector<std::string> filtered;
            std::wstring search;
            bool dropdownOpen = false;
            int highlighted = 0;
            int listOffset = 0;
            {
                std::lock_guard<std::mutex> lock(g_SymbolMutex);
                g_SymbolUI.buttonX = screenWidth * 0.5f - 110.0f;
                g_SymbolUI.buttonY = 10.0f;
                g_SymbolUI.buttonW = 220.0f;
                g_SymbolUI.buttonH = 30.0f;
                g_SymbolUI.dropdownX = g_SymbolUI.buttonX;
                g_SymbolUI.dropdownY = HEADER_HEIGHT;
                g_SymbolUI.dropdownW = 260.0f;
                currentSymbol = g_SymbolUI.currentSymbol;
                filtered = g_SymbolUI.filteredSymbols;
                search = g_SymbolUI.search;
                dropdownOpen = g_SymbolUI.dropdownOpen;
                highlighted = g_SymbolUI.highlightedIndex;
                listOffset = g_SymbolUI.listOffset;
            }

            // Volume toggle in header (iOS-like)
            float toggleW = 120.0f;
            float toggleH = 24.0f;
            g_VolToggleUI.w = toggleW;
            g_VolToggleUI.h = toggleH;
            g_VolToggleUI.x = screenWidth - toggleW - 20.0f;
            g_VolToggleUI.y = (HEADER_HEIGHT - toggleH) * 0.5f;
 
            bool showQuote = g_VolumeMode.load(std::memory_order_relaxed) == 1;
            float tx = g_VolToggleUI.x;
            float ty = g_VolToggleUI.y;
            float knobW = toggleH - 6.0f;
            float knobH = toggleH - 6.0f;
            float centerX = tx + toggleW * 0.5f;
            float knobX = showQuote ? (centerX + 6.0f) : (centerX - knobW - 6.0f);
             float knobY = ty + 2.0f;

            // Background pill
            g_Graphics->DrawRectPixels(tx, ty, toggleW, toggleH, showQuote ? 0.22f : 0.16f, showQuote ? 0.35f : 0.22f, 0.32f, 1.0f);
            // Knob
            g_Graphics->DrawRectPixels(knobX, knobY, knobW, knobH, 0.9f, 0.9f, 0.95f, 1.0f);
            // Labels
            g_Graphics->DrawTextPixels(L"BASE", tx + 8, ty + 4, 50, toggleH - 8, 11, showQuote ? 0.6f : 1.0f, showQuote ? 0.7f : 1.0f, 1.0f, 1.0f);
            g_Graphics->DrawTextPixels(L"USDT", tx + toggleW - 44, ty + 4, 40, toggleH - 8, 11, showQuote ? 1.0f : 0.7f, showQuote ? 1.0f : 0.8f, 1.0f, 1.0f);

            float obX = 20;
            float obY = HEADER_HEIGHT + 120;
            float obWidth = screenWidth - 40;
            float obHeight = screenHeight - HEADER_HEIGHT - 140;

            // Status
            bool runningFeed = (g_Feed != nullptr);
            std::wstring status = runningFeed ? L"RUNNING" : L"STOPPED";
            float statusR = runningFeed ? 0.0f : 1.0f;
            float statusG = runningFeed ? 1.0f : 0.0f;
            g_Graphics->DrawTextPixels(status, screenWidth - 250, 15, 100, 20, 14, statusR, statusG, 0.0f, 1.0f);

            // Symbol button (drawn on header)
            g_Graphics->DrawRectPixels(g_SymbolUI.buttonX, g_SymbolUI.buttonY, g_SymbolUI.buttonW, g_SymbolUI.buttonH,
                                       dropdownOpen ? 0.25f : 0.18f, dropdownOpen ? 0.25f : 0.18f, 0.3f, 1.0f);
            g_Graphics->DrawTextCentered(ToWString(currentSymbol), g_SymbolUI.buttonX + g_SymbolUI.buttonW * 0.5f,
                                         g_SymbolUI.buttonY + g_SymbolUI.buttonH * 0.5f - 2.0f, 14,
                                         0.8f, 0.8f, 1.0f, 1.0f);

            // Dropdown with search
            if (dropdownOpen) {
                int toShow = std::min<int>(static_cast<int>(filtered.size()) - listOffset, DROPDOWN_MAX_ITEMS);
                if (toShow < 0) toShow = 0;
                float listHeight = DROPDOWN_ITEM_H * toShow;
                g_Graphics->DrawRectPixels(g_SymbolUI.dropdownX, g_SymbolUI.dropdownY, g_SymbolUI.dropdownW,
                                           DROPDOWN_SEARCH_H + listHeight, 0.08f, 0.08f, 0.1f, 1.0f);
                g_Graphics->DrawRectPixels(g_SymbolUI.dropdownX + 2, g_SymbolUI.dropdownY + 2, g_SymbolUI.dropdownW - 4,
                                           DROPDOWN_SEARCH_H - 4, 0.12f, 0.12f, 0.14f, 1.0f);
                std::wstring searchText = L"Search: " + search;
                g_Graphics->DrawTextPixels(searchText, g_SymbolUI.dropdownX + 8, g_SymbolUI.dropdownY + 4,
                                           g_SymbolUI.dropdownW - 16, DROPDOWN_SEARCH_H - 8, 12,
                                           0.8f, 0.8f, 0.9f, 1.0f);

                for (int i = 0; i < toShow; ++i) {
                    int idxGlobal = listOffset + i;
                    float itemY = g_SymbolUI.dropdownY + DROPDOWN_SEARCH_H + i * DROPDOWN_ITEM_H;
                    bool isSel = (idxGlobal == highlighted);
                    g_Graphics->DrawRectPixels(g_SymbolUI.dropdownX + 2, itemY, g_SymbolUI.dropdownW - 4, DROPDOWN_ITEM_H,
                                               isSel ? 0.30f : 0.20f, isSel ? 0.30f : 0.20f, isSel ? 0.40f : 0.25f, 1.0f);
                    g_Graphics->DrawTextPixels(ToWString(filtered[idxGlobal]), g_SymbolUI.dropdownX + 8, itemY + 2,
                                               g_SymbolUI.dropdownW - 16, DROPDOWN_ITEM_H - 4, 12,
                                               1.0f, 1.0f, 1.0f, 1.0f);
                }
            }

            if (g_SharedState) {
                auto sharedState = g_SharedState;
                auto metrics = sharedState->GetMetrics();
                auto ext = sharedState->GetExternalMetrics();
                float y = HEADER_HEIGHT + 20;
                float x = 20;
                std::wstringstream ss;
                ss << L"Latency: " << metrics.latencyMs << L" ms";
                g_Graphics->DrawTextPixels(ss.str(), x, y, 250, 18, 12, 0.8f, 1.0f, 0.8f, 1.0f);
                ss.str(L""); ss.clear();
                ss << L"Staleness: " << metrics.stalenessMs << L" ms";
                g_Graphics->DrawTextPixels(ss.str(), x, y + 18, 250, 18, 12, 0.8f, 1.0f, 0.8f, 1.0f);

                auto toMs = [](long long ns) { return ns / 1'000'000.0; };
                float yExt = y + 40;
                ss.str(L""); ss.clear();
                ss << L"Net " << std::fixed << std::setprecision(3) << toMs(ext.netLatencyNs) << L" ms"
                   << L" | Proc " << toMs(ext.procChainLatencyNs) << L" ms";
                g_Graphics->DrawTextPixels(ss.str(), x, yExt, 400, 18, 12, 0.8f, 0.9f, 1.0f, 1.0f);

                ss.str(L""); ss.clear();
                ss << L"E2E P99 " << toMs(ext.endToEndP99Ns) << L" ms"
                   << L" | Drops " << ext.droppedMessages
                   << L" | Qmax " << ext.queueHighWater
                   << L" | " << ext.messagesPerSecond << L" msg/s";
                g_Graphics->DrawTextPixels(ss.str(), x, yExt + 18, 520, 18, 12, 0.8f, 0.9f, 1.0f, 1.0f);
            }

            if (g_OrderBookRenderer) {
                g_OrderBookRenderer->SetVolumeMode(showQuote ? OrderBookRenderer::VolumeMode::Quote
                                                            : OrderBookRenderer::VolumeMode::Base);
                g_OrderBookRenderer->Render(obX, obY, obWidth, obHeight);
            }

            g_Graphics->EndFrame();
            std::this_thread::sleep_for(std::chrono::milliseconds(1));
        }
    }

    OutputDebugStringA("[TradingBot] Shutting down...\n");
    g_Running = false;
    if (g_Feed) g_Feed->Stop();
    if (tradingBotThread.joinable()) tradingBotThread.join();
    OutputDebugStringA("[TradingBot] Shutdown complete\n");

    return (int)msg.wParam;
}

void UpdateFilteredSymbolsLocked() {
    std::wstring query = g_SymbolUI.search;
    std::wstring queryUpper(query);
    std::transform(queryUpper.begin(), queryUpper.end(), queryUpper.begin(), ::towupper);
    g_SymbolUI.filteredSymbols.clear();
    for (const auto& sym : g_SymbolUI.allSymbols) {
        std::wstring w = ToWString(sym);
        std::wstring wUpper(w);
        std::transform(wUpper.begin(), wUpper.end(), wUpper.begin(), ::towupper);
        if (queryUpper.empty() || wUpper.find(queryUpper) != std::wstring::npos) {
            g_SymbolUI.filteredSymbols.push_back(sym);
        }
    }
    g_SymbolUI.listOffset = 0;
    if (g_SymbolUI.highlightedIndex >= static_cast<int>(g_SymbolUI.filteredSymbols.size())) {
        g_SymbolUI.highlightedIndex = 0;
    }
}

void RequestSymbolChange(const std::string& sym) {
    std::lock_guard<std::mutex> lock(g_SymbolSwitchMutex);
    g_PendingSymbol = sym;
    g_SymbolChangeRequested.store(true, std::memory_order_relaxed);
}

void StartFeedForSymbol(const std::string& sym) {
    std::string upperSym = ToUpper(sym);
    if (g_Feed) {
        g_Feed->Stop();
        g_Feed.reset();
    }

    hft::DataFeedConfig cfg;
    cfg.subscribeDepth = true;
    cfg.subscribeBookTicker = true;
    cfg.subscribeAggTrade = true;
    cfg.depthSpeed = "@100ms";
    cfg.numParserThreads = std::max<int>(4, static_cast<int>(std::thread::hardware_concurrency()));
    cfg.messageQueueSize = 32768;
    cfg.enableLatencyTracking = true;
    cfg.enableDetailedLogging = false;
    cfg.symbols = { upperSym };

    g_Feed = std::make_unique<hft::BinanceDataFeed>(cfg);

    g_Feed->SetDepthUpdateCallback([adapter = g_FeedAdapter.get()](const std::string& symbol, const hft::ParsedDepthUpdate& upd) {
        if (adapter) adapter->OnDepth(symbol, upd);
    });
    g_Feed->SetBookTickerCallback([adapter = g_FeedAdapter.get()](const std::string& symbol, const hft::ParsedBookTicker& bt) {
        if (adapter) adapter->OnBookTicker(symbol, bt);
    });
    g_Feed->SetAggTradeCallback([adapter = g_FeedAdapter.get()](const std::string& symbol, const hft::ParsedAggTrade& tr) {
        if (adapter) adapter->OnAggTrade(symbol, tr);
    });

    if (g_SharedState) {
        g_SharedState->ResetOrderBook();
        g_SharedState->SetSymbol(upperSym);
    }

    g_Feed->Start();
}

void ApplyPendingSymbolChange() {
    if (!g_SymbolChangeRequested.load(std::memory_order_relaxed)) return;
    std::string sym;
    {
        std::lock_guard<std::mutex> lock(g_SymbolSwitchMutex);
        sym = g_PendingSymbol;
        g_PendingSymbol.clear();
        g_SymbolChangeRequested.store(false, std::memory_order_relaxed);
    }
    if (!sym.empty()) {
        StartFeedForSymbol(sym);
    }
}

void SelectSymbol(const std::string& sym) {
    RequestSymbolChange(sym);
    std::lock_guard<std::mutex> lock(g_SymbolMutex);
    g_SymbolUI.currentSymbol = ToUpper(sym);
    g_SymbolUI.dropdownOpen = false;
    g_SymbolUI.search.clear();
    g_SymbolUI.highlightedIndex = 0;
    g_SymbolUI.listOffset = 0;
    UpdateFilteredSymbolsLocked();
}

void HandleMouseClick(int x, int y) {
    std::string chosen;
    {
        std::lock_guard<std::mutex> lock(g_SymbolMutex);
        float fx = static_cast<float>(x);
        float fy = static_cast<float>(y);
        // Toggle dropdown on button click
        if (fx >= g_SymbolUI.buttonX && fx <= g_SymbolUI.buttonX + g_SymbolUI.buttonW &&
            fy >= g_SymbolUI.buttonY && fy <= g_SymbolUI.buttonY + g_SymbolUI.buttonH) {
            g_SymbolUI.dropdownOpen = !g_SymbolUI.dropdownOpen;
            return;
        }

        // Volume mode toggle click
        if (fx >= g_VolToggleUI.x && fx <= g_VolToggleUI.x + g_VolToggleUI.w &&
            fy >= g_VolToggleUI.y && fy <= g_VolToggleUI.y + g_VolToggleUI.h) {
            int mode = g_VolumeMode.load(std::memory_order_relaxed);
            g_VolumeMode.store(mode == 0 ? 1 : 0, std::memory_order_relaxed);
            return;
        }

        if (g_SymbolUI.dropdownOpen) {
            float dropHItems = DROPDOWN_ITEM_H * std::min<int>(static_cast<int>(g_SymbolUI.filteredSymbols.size()) - g_SymbolUI.listOffset, DROPDOWN_MAX_ITEMS);
            if (dropHItems < 0) dropHItems = 0;
            float dropH = DROPDOWN_SEARCH_H + dropHItems;
            if (fx >= g_SymbolUI.dropdownX && fx <= g_SymbolUI.dropdownX + g_SymbolUI.dropdownW &&
                fy >= g_SymbolUI.dropdownY && fy <= g_SymbolUI.dropdownY + dropH) {
                if (fy > g_SymbolUI.dropdownY + DROPDOWN_SEARCH_H) {
                    int idx = static_cast<int>((fy - g_SymbolUI.dropdownY - DROPDOWN_SEARCH_H) / DROPDOWN_ITEM_H);
                    int globalIdx = g_SymbolUI.listOffset + idx;
                    if (idx >= 0 && globalIdx < static_cast<int>(g_SymbolUI.filteredSymbols.size()) && idx < DROPDOWN_MAX_ITEMS) {
                        chosen = g_SymbolUI.filteredSymbols[globalIdx];
                    }
                }
            } else {
                g_SymbolUI.dropdownOpen = false;
            }
        }
    }
    if (!chosen.empty()) {
        SelectSymbol(chosen);
    }
}

void HandleCharInput(WPARAM wParam) {
    std::lock_guard<std::mutex> lock(g_SymbolMutex);
    if (!g_SymbolUI.dropdownOpen) return;
    wchar_t ch = static_cast<wchar_t>(wParam);
    if (ch >= 32 && ch < 127) {
        g_SymbolUI.search.push_back(ch);
        UpdateFilteredSymbolsLocked();
    }
}

void HandleKeyDown(WPARAM wParam) {
    std::string chosen;
    {
        std::lock_guard<std::mutex> lock(g_SymbolMutex);
        if (!g_SymbolUI.dropdownOpen) return;
        int total = static_cast<int>(g_SymbolUI.filteredSymbols.size());
        if (wParam == VK_BACK) {
            if (!g_SymbolUI.search.empty()) {
                g_SymbolUI.search.pop_back();
                UpdateFilteredSymbolsLocked();
            }
        } else if (wParam == VK_ESCAPE) {
            g_SymbolUI.dropdownOpen = false;
        } else if (wParam == VK_UP) {
            if (g_SymbolUI.highlightedIndex > 0) {
                --g_SymbolUI.highlightedIndex;
                if (g_SymbolUI.highlightedIndex < g_SymbolUI.listOffset) {
                    g_SymbolUI.listOffset = g_SymbolUI.highlightedIndex;
                }
            }
        } else if (wParam == VK_DOWN) {
            if (g_SymbolUI.highlightedIndex + 1 < total) {
                ++g_SymbolUI.highlightedIndex;
                int windowEnd = g_SymbolUI.listOffset + DROPDOWN_MAX_ITEMS;
                if (g_SymbolUI.highlightedIndex >= windowEnd) {
                    g_SymbolUI.listOffset = g_SymbolUI.highlightedIndex - DROPDOWN_MAX_ITEMS + 1;
                }
            }
        } else if (wParam == VK_RETURN) {
            if (!g_SymbolUI.filteredSymbols.empty()) {
                chosen = g_SymbolUI.filteredSymbols[g_SymbolUI.highlightedIndex];
            }
        }
    }
    if (!chosen.empty()) {
        SelectSymbol(chosen);
    }
}

void InitializeSymbols() {
    static const std::vector<std::string> kFallbackSymbols = {
        "BTCUSDT","ETHUSDT","BNBUSDT","SOLUSDT","XRPUSDT","ADAUSDT","DOGEUSDT","TRXUSDT","MATICUSDT","DOTUSDT",
        "LTCUSDT","BCHUSDT","LINKUSDT","ATOMUSDT","FILUSDT","AVAXUSDT","ETCUSDT","NEARUSDT","APTUSDT","ARBUSDT",
        "OPUSDT","SUIUSDT","LDOUSDT","INJUSDT","RNDRUSDT","AAVEUSDT","MKRUSDT","COMPUSDT","DYDXUSDT","CRVUSDT",
        "UNIUSDT","SANDUSDT","MANAUSDT","AXSUSDT","GMTUSDT","APEUSDT","FTMUSDT","XLMUSDT","ALGOUSDT","EGLDUSDT",
        "KAVAUSDT","XMRUSDT","ZECUSDT","CELOUSDT","CHZUSDT","ROSEUSDT","CFXUSDT","HBARUSDT","FLOWUSDT","GALAUSDT",
        "IMXUSDT","RUNEUSDT","THETAUSDT","ZILUSDT","LRCUSDT","ENSUSDT","SNXUSDT","1INCHUSDT","HOTUSDT","BLURUSDT",
        "GMXUSDT","MINAUSDT","DASHUSDT","ICPUSDT","ARBUSDT","WOOUSDT","FXSUSDT","PEPEUSDT","TOMOUSDT","BELUSDT",
        "STXUSDT","COTIUSDT","HOOKUSDT","MAGICUSDT","IDUSDT","ALICEUSDT","MASKUSDT","YFIUSDT","SSVUSDT","ANTUSDT"
    };

    auto symbols = FetchFuturesSymbols();
    if (symbols.empty()) {
        symbols = kFallbackSymbols;
        OutputDebugStringA("[Symbols] Using extended fallback symbol list (fetch failed)\n");
    } else {
        std::string msg = "[Symbols] Loaded ";
        msg += std::to_string(symbols.size());
        msg += " futures symbols\n";
        OutputDebugStringA(msg.c_str());
    }
    std::sort(symbols.begin(), symbols.end());
    symbols.erase(std::unique(symbols.begin(), symbols.end()), symbols.end());

    std::lock_guard<std::mutex> lock(g_SymbolMutex);
    g_SymbolUI.allSymbols = symbols;
    if (std::find(symbols.begin(), symbols.end(), g_SymbolUI.currentSymbol) == symbols.end() && !symbols.empty()) {
        g_SymbolUI.currentSymbol = symbols.front();
    }
    g_SymbolUI.search.clear();
    g_SymbolUI.listOffset = 0;
    UpdateFilteredSymbolsLocked();
}