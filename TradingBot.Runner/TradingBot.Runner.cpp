#include <atomic>
#include <thread>
#include <memory>
#include <string>
#include <vector>
#include <list>
#include <algorithm>
#include <iomanip>
#include <sstream>
#include <cmath>
#include <deque>
#include <cstdlib> 
#include <mutex> 
#include <cctype> 

#include <boost/beast/core.hpp>
#include <boost/asio.hpp>
#include <boost/bind/bind.hpp>

#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>
#include <windowsx.h> 

#include "Graphics.h"
#include "../TradingBot.Core/SharedState.h"
#include "../TradingBot.Core/BinanceConnection.h"
#include "../TradingBot.Core/RestClient.h"
#include "../TradingBot.Core/Logging.h"

using namespace TradingBot::Core;
using namespace TradingBot::Core::Network;

std::unique_ptr<Graphics> g_Graphics;
std::shared_ptr<SharedState> g_SharedState;
std::atomic<bool> g_Running(true);

// Параметры
double g_CurrentTickSize = 0.1;
int g_CurrentPrecision = 2;

int g_ScaleIndex = 0;
std::vector<int> g_Scales = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000 };

// Цвета
const float COL_BUY_R = 0.2f, COL_BUY_G = 0.6f, COL_BUY_B = 1.0f;
const float COL_SELL_R = 1.0f, COL_SELL_G = 0.25f, COL_SELL_B = 0.25f;

const float START_X_POS = 310.0f;

// UI
bool g_IsSpotMode = false;
std::string g_CurrentSymbol = "BTCUSDT";
bool g_IsDropdownOpen = false;
std::string g_SearchQuery = "";

// Сеть
std::mutex g_ConnectionMutex;
std::atomic<bool> g_ConnectionDirty(true);
std::shared_ptr<BinanceConnection> g_CurrentConnection = nullptr;

// Connect() blocks on ws.read(), so we run it in a dedicated thread.
std::thread g_ConnectionThread;

std::mutex g_StatusMutex;
std::string g_NetworkStatus = "Initializing...";
bool g_HasNetworkError = false;

// Графика
double g_SmoothCenterPrice = 0.0;
bool g_IsFirstFrame = true;

struct VisualBubble {
    double priceCenter; double priceMin; double priceMax;
    double volumeQuote;
    float currentRadiusX; float targetRadiusX; float velocityRadius;
    float xPosition;
    bool isBuyerMaker;

    // no per-bubble stepping; belt uses global stepping
    float stepAccumulator = 0.0f;
};
std::list<VisualBubble> g_ActiveBubbles;
long long g_LastProcessedTradeTime = 0;

// Bubble movement tuning
// Tiger-like belt: discrete global steps (left-to-right), paused when no trades
static constexpr float BUBBLE_STEP_PIXELS = 9.0f;      // pixels per step
static constexpr float BUBBLE_STEP_INTERVAL = 0.10f;   // seconds per step
static constexpr float BUBBLE_IDLE_TIMEOUT = 0.40f;    // seconds after last trade to freeze belt

// Global accumulator to move all bubbles in sync
static float g_BubbleMoveAccum = 0.0f;
static float g_TimeSinceLastTrade = 999.0f;

// Spacing: overlap (no gaps). Bigger = tighter.
static constexpr float BUBBLE_OVERLAP_PIXELS = 10.0f;

static float EstimateBubbleRadiusFromQuote(double quoteVol) {
    float raw = std::sqrt((float)quoteVol) * 0.7f;
    return std::clamp(raw, 10.0f, 22.0f);
}

// --- ФУНКЦИИ ---

void SetNetworkStatus(const std::string& status, bool isError) {
    std::lock_guard<std::mutex> lock(g_StatusMutex);
    g_NetworkStatus = status;
    g_HasNetworkError = isError;
}

std::string GetNetworkStatus() {
    std::lock_guard<std::mutex> lock(g_StatusMutex);
    return g_NetworkStatus;
}

void UpdateSymbolInfo(const std::string& symbol, bool isSpot) {
    TradingBot::Core::Logging::Info(
        "UI",
        std::string("UpdateSymbolInfo symbol=") + symbol + (isSpot ? " mode=SPOT" : " mode=FUTURES"));
    std::lock_guard<std::mutex> lock(g_SharedState->instrumentsMutex);
    const auto& list = isSpot ? g_SharedState->marketData.spotPairs : g_SharedState->marketData.futuresPairs;

    for (const auto& pair : list) {
        if (pair.symbol == symbol) {
            g_CurrentTickSize = pair.tickSize;
            g_CurrentPrecision = pair.pricePrecision;

            // Сброс камеры и графики
            g_IsFirstFrame = true;
            g_SmoothCenterPrice = 0.0;
            g_ActiveBubbles.clear();
            g_LastProcessedTradeTime = 0;
            return;
        }
    }
    
    TradingBot::Core::Logging::Warn(
        "UI",
        std::string("UpdateSymbolInfo: symbol not found in ") + (isSpot ? "spotPairs" : "futuresPairs") + " -> " + symbol);
}

std::vector<TradingPair> GetFilteredPairs() {
    std::lock_guard<std::mutex> lock(g_SharedState->instrumentsMutex);
    const auto& source = g_IsSpotMode ? g_SharedState->marketData.spotPairs : g_SharedState->marketData.futuresPairs;
    if (g_SearchQuery.empty()) return source;

    std::vector<TradingPair> filtered;
    std::string queryUpper = g_SearchQuery;
    for (auto& c : queryUpper) c = toupper(c);

    for (const auto& p : source) {
        if (p.symbol.find(queryUpper) != std::string::npos) filtered.push_back(p);
    }
    return filtered;
}

std::wstring StringToWString(const std::string& s) {
    if (s.empty()) return L"";
    std::wstring temp(s.length(), L' ');
    std::copy(s.begin(), s.end(), temp.begin());
    return temp;
}

std::wstring FormatPrice(double price) {
    std::wstringstream ss;
    ss << std::fixed << std::setprecision(g_CurrentPrecision) << price;
    return ss.str();
}

std::wstring FormatQuoteVolume(double vol) {
    std::wstringstream ss;
    ss << std::fixed;
    if (vol >= 1000000.0) ss << std::setprecision(1) << (vol / 1000000.0) << L"M";
    else if (vol >= 1000.0) {
        double val = vol / 1000.0;
        ss << (val >= 100.0 ? std::setprecision(0) : std::setprecision(1)) << val << L"k";
    }
    else ss << std::setprecision(0) << vol;
    return ss.str();
}

std::wstring FormatPercent(double pct) {
    std::wstringstream ss;
    ss << std::fixed << std::setprecision(2);
    if (pct > 0) ss << L"+";
    ss << pct << L"%";
    return ss.str();
}

// --- СЕТЕВОЙ ПОТОК ---
void NetworkThreadFunc() {
    // 1. Загрузка справочников
    while (g_Running && !g_SharedState->marketData.isLoaded) {
        try {
            SetNetworkStatus("Downloading ExchangeInfo...", false);
            RestClient restClient;
            restClient.LoadExchangeInfo(g_SharedState->marketData);

            if (g_SharedState->marketData.isLoaded) {
                SetNetworkStatus("Ready", false);
                UpdateSymbolInfo(g_CurrentSymbol, g_IsSpotMode);
            }
            else {
                SetNetworkStatus("Retrying...", true);
                std::this_thread::sleep_for(std::chrono::seconds(5));
            }
        }
        catch (...) {
            SetNetworkStatus("Network Error", true);
            std::this_thread::sleep_for(std::chrono::seconds(5));
        }
    }

    // 2. WebSocket цикл
    while (g_Running) {
        if (g_ConnectionDirty) {
            g_ConnectionDirty = false;

            // 1. Отключаем старое
            {
                std::lock_guard<std::mutex> lock(g_ConnectionMutex);
                if (g_CurrentConnection) {
                    TradingBot::Core::Logging::Info(
                        "Runner",
                        std::string("Stopping previous connection before switching to ") + g_CurrentSymbol +
                        (g_IsSpotMode ? " (SPOT)" : " (FUTURES)"));
                    g_CurrentConnection->Stop();
                }
                g_CurrentConnection = nullptr;
            }
            
            if (g_ConnectionThread.joinable()) {
                g_ConnectionThread.join();
            }

            // 2. ОЧИЩАЕМ ДАННЫЕ (Устраняет баг с "хвостами" от BTC)
            // Важно делать это здесь, когда старого коннекта уже нет, а нового еще нет
            g_SharedState->Clear();

            // 3. Подключаем новое
            try {
                auto conn = std::make_shared<BinanceConnection>(g_SharedState);
                {
                    std::lock_guard<std::mutex> lock(g_ConnectionMutex);
                    g_CurrentConnection = conn;
                }
                // BinanceConnection::Connect(..., isSpot)
                auto symbol = g_CurrentSymbol;
                auto isSpot = g_IsSpotMode;
                g_ConnectionThread = std::thread([conn, symbol, isSpot]() {
                    try {
                        conn->Connect(symbol, isSpot);
                    }
                    catch (...) {
                    }
                });
            }
            catch (...) { std::this_thread::sleep_for(std::chrono::seconds(1)); }
        }
        else {
            std::this_thread::sleep_for(std::chrono::milliseconds(100));
        }
    }

    // shutdown
    {
        std::lock_guard<std::mutex> lock(g_ConnectionMutex);
        if (g_CurrentConnection)
            g_CurrentConnection->Stop();
    }
    if (g_ConnectionThread.joinable())
        g_ConnectionThread.join();
}

void UpdateBubbles(const std::vector<Trade>& newTrades, double currentStep) {
    const float tension = 0.4f; const float dampening = 0.75f;

    static auto lastTick = std::chrono::steady_clock::now();
    auto now = std::chrono::steady_clock::now();
    float dt = std::chrono::duration<float>(now - lastTick).count();
    lastTick = now;
    if (dt < 0.0f) dt = 0.0f;
    if (dt > 0.25f) dt = 0.25f; // clamp after stalls

    bool hasNewTrade = false;
    for (const auto& t : newTrades) {
        if (t.timestamp > g_LastProcessedTradeTime) { hasNewTrade = true; break; }
    }

    if (hasNewTrade) g_TimeSinceLastTrade = 0.0f;
    else g_TimeSinceLastTrade += dt;

    bool beltActive = (g_TimeSinceLastTrade <= BUBBLE_IDLE_TIMEOUT);

    int steps = 0;
    if (beltActive) {
        g_BubbleMoveAccum += dt;
        if (g_BubbleMoveAccum >= BUBBLE_STEP_INTERVAL) {
            steps = (int)std::floor(g_BubbleMoveAccum / BUBBLE_STEP_INTERVAL);
            g_BubbleMoveAccum -= steps * BUBBLE_STEP_INTERVAL;
        }
    }

    // 1) Update existing bubbles
    auto it = g_ActiveBubbles.begin();
    while (it != g_ActiveBubbles.end()) {
        float displacement = it->targetRadiusX - it->currentRadiusX;
        it->velocityRadius += displacement * tension;
        it->velocityRadius *= dampening;
        it->currentRadiusX += it->velocityRadius;

        if (steps > 0) it->xPosition += BUBBLE_STEP_PIXELS * steps;

        if (it->xPosition > 3000.0f) it = g_ActiveBubbles.erase(it);
        else ++it;
    }

    // 2) Append new bubbles (ALWAYS spawn at START_X_POS)
    for (const auto& trade : newTrades) {
        if (trade.timestamp <= g_LastProcessedTradeTime) continue;
        g_LastProcessedTradeTime = trade.timestamp;

        double snappedPrice = std::round(trade.price / currentStep) * currentStep;
        double tradeValueQuote = trade.price * trade.quantity;

        bool merged = false;

        // Merge only into the newest bubble at the spawn location (front)
        if (!g_ActiveBubbles.empty()) {
            auto& b = g_ActiveBubbles.front();
            double priceDiff = std::abs(b.priceCenter - snappedPrice);
            if (b.isBuyerMaker == trade.isBuyerMaker && std::abs(b.xPosition - START_X_POS) < 3.0f && priceDiff < (currentStep * 50.0)) {
                b.volumeQuote += tradeValueQuote;
                b.priceCenter = snappedPrice;
                b.priceMin = snappedPrice;
                b.priceMax = snappedPrice;
                b.targetRadiusX = EstimateBubbleRadiusFromQuote(b.volumeQuote);
                b.velocityRadius += 5.0f;
                merged = true;
            }
        }

        if (!merged) {
            VisualBubble vb;
            vb.priceCenter = snappedPrice;
            vb.priceMin = snappedPrice;
            vb.priceMax = snappedPrice;
            vb.volumeQuote = tradeValueQuote;
            vb.isBuyerMaker = trade.isBuyerMaker;
            vb.xPosition = START_X_POS;
            vb.currentRadiusX = 1.0f;
            vb.targetRadiusX = EstimateBubbleRadiusFromQuote(tradeValueQuote);
            vb.velocityRadius = 10.0f;
            vb.stepAccumulator = 0.0f;
            // Newest at spawn edge
            g_ActiveBubbles.push_front(vb);
        }
    }

    // 3) Enforce belt packing AFTER adding new bubbles
    {
        float prevX = START_X_POS;
        float prevR = 0.0f;
        bool first = true;
        // Front is spawn (newest). Ensure older go to the right.
        for (auto& b : g_ActiveBubbles) {
            float r = std::max(1.0f, b.currentRadiusX);
            if (first) {
                b.xPosition = START_X_POS;
                prevX = b.xPosition;
                prevR = r;
                first = false;
                continue;
            }

            float minX = prevX + (prevR + r) - BUBBLE_OVERLAP_PIXELS;
            if (b.xPosition < minX) b.xPosition = minX;
            prevX = b.xPosition;
            prevR = r;
        }
    }

    // keep max size by removing oldest (at back)
    if (g_ActiveBubbles.size() > 500) g_ActiveBubbles.pop_back();
}

// --- UI ---
void HandleHeaderClick(int x, int y) {
    if (x >= 20 && x <= 70) {
        if (!g_IsSpotMode) {
            g_IsSpotMode = true; g_ConnectionDirty = true; g_IsDropdownOpen = false; g_SearchQuery = "";
            g_CurrentSymbol = "BTCUSDT"; UpdateSymbolInfo(g_CurrentSymbol, g_IsSpotMode);
        }
    }
    else if (x >= 80 && x <= 160) {
        if (g_IsSpotMode) {
            g_IsSpotMode = false; g_ConnectionDirty = true; g_IsDropdownOpen = false; g_SearchQuery = "";
            g_CurrentSymbol = "BTCUSDT"; UpdateSymbolInfo(g_CurrentSymbol, g_IsSpotMode);
        }
    }
    else if (x >= 200 && x <= 350) {
        g_IsDropdownOpen = !g_IsDropdownOpen; if (g_IsDropdownOpen) g_SearchQuery = "";
    }
}

void HandleDropdownClick(int x, int y) {
    if (!g_SharedState->marketData.isLoaded) return;
    float dropY = 40.0f; float searchH = 30.0f; float itemH = 25.0f;
    if (y > dropY && y < dropY + searchH) return;
    float listStartY = dropY + searchH; float relY = (float)y - listStartY; if (relY < 0) return;
    auto filtered = GetFilteredPairs();
    int index = (int)(relY / itemH);
    if (index >= 0 && index < filtered.size()) {
        std::string newSymbol = filtered[index].symbol;
        TradingBot::Core::Logging::Info("UI", std::string("Dropdown click -> ") + newSymbol);
        if (newSymbol != g_CurrentSymbol) {
            g_CurrentSymbol = newSymbol;
            TradingBot::Core::Logging::Info("UI", std::string("CurrentSymbol set -> ") + g_CurrentSymbol);
            UpdateSymbolInfo(g_CurrentSymbol, g_IsSpotMode);
            g_ConnectionDirty = true;
        }
        g_IsDropdownOpen = false;
    }
}

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {
    case WM_MOUSEWHEEL: {
        short zDelta = GET_WHEEL_DELTA_WPARAM(wParam);
        if (zDelta > 0) { if (g_ScaleIndex < g_Scales.size() - 1) g_ScaleIndex++; }
        else { if (g_ScaleIndex > 0) g_ScaleIndex--; }
        return 0;
    }
    case WM_LBUTTONDOWN: {
        int x = GET_X_LPARAM(lParam); int y = GET_Y_LPARAM(lParam);
        if (g_IsDropdownOpen) {
            if (y > 40 && x >= 200 && x <= 400) { HandleDropdownClick(x, y); return 0; }
            else { g_IsDropdownOpen = false; }
        }
        if (y < 50) HandleHeaderClick(x, y);
        return 0;
    }
    case WM_CHAR: {
        if (g_IsDropdownOpen) {
            char c = (char)wParam;
            if (c == VK_BACK) { if (!g_SearchQuery.empty()) g_SearchQuery.pop_back(); }
            else if (isalnum(c) || c == '-' || c == '_') { g_SearchQuery += c; }
        }
        return 0;
    }
    case WM_DESTROY: g_Running = false; PostQuitMessage(0); std::exit(0); return 0;
    }
    return DefWindowProc(hWnd, message, wParam, lParam);
}

int APIENTRY WinMain(_In_ HINSTANCE hInstance, _In_opt_ HINSTANCE hPrevInstance, _In_ LPSTR lpCmdLine, _In_ int nCmdShow) {
    TradingBot::Core::Logging::Logger::Init();
    g_SharedState = std::make_shared<SharedState>();
    std::thread networkThread(NetworkThreadFunc);
    WNDCLASSEX wc = { sizeof(WNDCLASSEX), CS_CLASSDC, WndProc, 0L, 0L, GetModuleHandle(NULL), NULL, NULL, NULL, NULL, L"TigerBotZone", NULL };
    RegisterClassEx(&wc);
    HWND hWnd = CreateWindow(L"TigerBotZone", L"TigerBot HFT", WS_OVERLAPPEDWINDOW, 100, 100, 1200, 1200, NULL, NULL, wc.hInstance, NULL);
    g_Graphics = std::make_unique<Graphics>();
    if (!g_Graphics->Initialize(hWnd)) return 1;
    ShowWindow(hWnd, nCmdShow);
    UpdateWindow(hWnd);
    MSG msg = { 0 };
    while (msg.message != WM_QUIT) {
        if (PeekMessage(&msg, NULL, 0U, 0U, PM_REMOVE)) { TranslateMessage(&msg); DispatchMessage(&msg); }
        else {
            g_Graphics->BeginFrame(0.12f, 0.12f, 0.14f);
            float screenW = g_Graphics->GetWidth(); float screenH = g_Graphics->GetHeight(); float headerH = 50.0f;
            float centerY = headerH + (screenH - headerH) / 2.0f; float rowHeight = 22.0f;
            double currentStep = g_CurrentTickSize * g_Scales[g_ScaleIndex];
            
            auto snap = g_SharedState->GetSnapshotForRender(80, currentStep);
            UpdateBubbles(snap.RecentTrades, currentStep);

            double bestAsk = snap.Asks.empty() ? 0 : snap.Asks[0].first;
            double bestBid = snap.Bids.empty() ? 0 : snap.Bids[0].first;
            double target = (bestAsk > 0 && bestBid > 0) ? (bestAsk + bestBid) / 2.0 : (bestAsk > 0 ? bestAsk : bestBid);
            if (target > 0) {
                if (g_IsFirstFrame || g_SmoothCenterPrice == 0) { g_SmoothCenterPrice = target; g_IsFirstFrame = false; }
                else g_SmoothCenterPrice += (target - g_SmoothCenterPrice) * 0.15;
            }

            double maxVol = 100.0;
            for (auto& p : snap.Bids) maxVol = std::max(maxVol, p.second);
            for (auto& p : snap.Asks) maxVol = std::max(maxVol, p.second);

            g_Graphics->DrawRectPixels(0, centerY - 1.0f, screenW, 2.0f, 1.0f, 0.8f, 0.0f, 0.8f);

            if (g_SmoothCenterPrice > 0) {
                auto DrawLevel = [&](const std::pair<double, double>& lvl, bool isAsk) {
                    double diff = lvl.first - g_SmoothCenterPrice;
                    double rows = diff / currentStep;
                    float y = centerY - (float)(rows * rowHeight) - (rowHeight / 2.0f);
                    if (y < headerH || y > screenH) return;
                    float w = (float)((lvl.second / maxVol) * 280.0f);
                    float r = isAsk ? COL_SELL_R : COL_BUY_R; float g = isAsk ? COL_SELL_G : COL_BUY_G; float b = isAsk ? COL_SELL_B : COL_BUY_B;
                    g_Graphics->DrawRectPixels(0, y, w, rowHeight - 1.0f, isAsk ? 0.8f : 0.2f, isAsk ? 0.2f : 0.8f, 0.2f, 1.0f);
                    std::wstringstream ss;
                    ss << FormatPrice(lvl.first) << L"  " << FormatQuoteVolume(lvl.first * lvl.second);
                    g_Graphics->DrawTextPixels(ss.str(), 10.0f, y, 300.0f, rowHeight, 12.0f, 1.0f, 1.0f, 1.0f, 1.0f);
                    };
                for (const auto& l : snap.Asks) DrawLevel(l, true);
                for (const auto& l : snap.Bids) DrawLevel(l, false);
            }

            // In the rendering loop, remove stretched ellipse drawing; keep circle only.
            for (const auto& b : g_ActiveBubbles) {
                if (g_SmoothCenterPrice > 0) {
                    float y = centerY - (float)((b.priceCenter - g_SmoothCenterPrice) / currentStep * rowHeight);
                    if (y > headerH - 20 && y < screenH + 100) {
                        float r = b.isBuyerMaker ? COL_SELL_R : COL_BUY_R;
                        float g = b.isBuyerMaker ? COL_SELL_G : COL_BUY_G;
                        float bl = b.isBuyerMaker ? COL_SELL_B : COL_BUY_B;
                        g_Graphics->DrawEllipsePixels(b.xPosition, y, b.currentRadiusX, b.currentRadiusX, r, g, bl, 0.4f);
                        g_Graphics->DrawTextCentered(FormatQuoteVolume(b.volumeQuote), b.xPosition, y, 11.0f, 1.0f, 1.0f, 1.0f, 1.0f);
                    }
                }
            }

            if (g_SmoothCenterPrice > 0) {
                float rightScaleX = screenW - 60.0f;
                g_Graphics->DrawRectPixels(rightScaleX, headerH, 1.0f, screenH - headerH, 0.5f, 0.5f, 0.5f, 1.0f);
                int rowsStep = 5;
                for (int i = 0; ; i += rowsStep) {
                    float y = centerY - (i * rowHeight); if (y < headerH) break;
                    double pct = (i * currentStep / g_SmoothCenterPrice) * 100.0;
                    g_Graphics->DrawRectPixels(rightScaleX, y, 5.0f, 1.0f, 0.7f, 0.7f, 0.7f, 1.0f);
                    if (i > 0) g_Graphics->DrawTextPixels(FormatPercent(pct), rightScaleX + 8.0f, y - 6.0f, 50.0f, 12.0f, 10.0f, 0.8f, 0.8f, 0.8f, 1.0f);
                }
                for (int i = rowsStep; ; i += rowsStep) {
                    float y = centerY + (i * rowHeight); if (y > screenH) break;
                    double pct = -(i * currentStep / g_SmoothCenterPrice) * 100.0;
                    g_Graphics->DrawRectPixels(rightScaleX, y, 5.0f, 1.0f, 0.7f, 0.7f, 0.7f, 1.0f);
                    g_Graphics->DrawTextPixels(FormatPercent(pct), rightScaleX + 8.0f, y - 6.0f, 50.0f, 12.0f, 10.0f, 0.8f, 0.8f, 0.8f, 1.0f);
                }
            }

            g_Graphics->DrawRectPixels(0, 0, screenW, headerH, 0.1f, 0.1f, 0.12f, 1.0f);
            g_Graphics->DrawRectPixels(0, headerH - 1.0f, screenW, 1.0f, 0.3f, 0.3f, 0.3f, 1.0f);
            g_Graphics->DrawTextPixels(L"SPOT", 20, 15, 50, 20, 14, g_IsSpotMode ? 1.0f : 0.5f, g_IsSpotMode ? 0.8f : 0.5f, g_IsSpotMode ? 0.2f : 0.5f, 1.0f);
            g_Graphics->DrawTextPixels(L"FUTURES", 80, 15, 80, 20, 14, !g_IsSpotMode ? 1.0f : 0.5f, !g_IsSpotMode ? 0.8f : 0.5f, !g_IsSpotMode ? 0.2f : 0.5f, 1.0f);
            float dropX = 200.0f; float dropY = 10.0f; float dropW = 150.0f;
            g_Graphics->DrawRectPixels(dropX, dropY, dropW, 30.0f, 0.2f, 0.2f, 0.25f, 1.0f);
            g_Graphics->DrawTextPixels(StringToWString(g_CurrentSymbol), dropX + 10.0f, dropY + 5.0f, 100.0f, 20.0f, 14, 1.0f, 1.0f, 1.0f, 1.0f);
            std::wstringstream ssScale; ssScale << L"Scale: x" << g_Scales[g_ScaleIndex];
            g_Graphics->DrawTextPixels(ssScale.str(), screenW - 120.0f, 15.0f, 100.0f, 20.0f, 14, 0.7f, 0.7f, 0.7f, 1.0f);

            if (g_IsDropdownOpen) {
                float listX = 200.0f; float listY = 40.0f; float listW = 200.0f;
                if (!g_SharedState->marketData.isLoaded) {
                    float r = g_HasNetworkError ? 0.8f : 0.15f; float g = g_HasNetworkError ? 0.1f : 0.15f; float b = g_HasNetworkError ? 0.1f : 0.15f;
                    g_Graphics->DrawRectPixels(listX, listY, listW, 40.0f, r, g, b, 1.0f);
                    g_Graphics->DrawTextPixels(StringToWString(g_NetworkStatus), listX + 10.0f, listY + 10.0f, listW, 20.0f, 12, 1.0f, 1.0f, 1.0f, 1.0f);
                }
                else {
                    float searchH = 30.0f; float itemH = 25.0f;
                    auto filtered = GetFilteredPairs();
                    int maxItems = 15;
                    int count = std::min((int)filtered.size(), maxItems);
                    g_Graphics->DrawRectPixels(listX, listY, listW, searchH + (count * itemH), 0.15f, 0.15f, 0.15f, 1.0f);
                    g_Graphics->DrawRectPixels(listX, listY, listW, searchH, 0.1f, 0.1f, 0.1f, 1.0f);
                    g_Graphics->DrawRectPixels(listX, listY + searchH - 1.0f, listW, 1.0f, 0.3f, 0.3f, 0.3f, 1.0f);
                    std::wstring searchStr = L"Search: " + StringToWString(g_SearchQuery);
                    g_Graphics->DrawTextPixels(searchStr, listX + 5.0f, listY + 5.0f, listW, searchH, 12, 1.0f, 1.0f, 0.0f, 1.0f);
                    for (int i = 0; i < count; i++) {
                        float y = listY + searchH + (i * itemH);
                        g_Graphics->DrawTextPixels(StringToWString(filtered[i].symbol), listX + 10.0f, y + 2.0f, listW - 20, itemH, 12, 0.9f, 0.9f, 0.9f, 1.0f);
                    }
                }
            }
            g_Graphics->EndFrame();
        }
    }
    return (int)msg.wParam;
}