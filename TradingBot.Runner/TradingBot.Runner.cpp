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
#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>
#include "Graphics.h"
#include "Types.h"
#include "SharedState.h"
#include "BinanceConnection.h"
using namespace TradingBot::Core;
using namespace TradingBot::Core::Network;
std::unique_ptr<Graphics> g_Graphics;
std::shared_ptr<SharedState> g_SharedState;
std::atomic<bool> g_Running(true);
std::string g_TargetSymbol = "BTCUSDT";
std::vector<int> g_Scales = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000 };
int g_ScaleIndex = 0;
double g_SmoothCenterPrice = 0.0;
bool g_IsFirstFrame = true;
struct VisualBubble {
    double priceCenter;
    double priceMin, priceMax;
    double volumeQuote;
    float currentRadiusX, targetRadiusX, velocityRadius;
    float xPosition;
    bool isBuyerMaker;
};
std::list<VisualBubble> g_ActiveBubbles;
long long g_LastProcessedTradeTime = 0;
std::wstring FormatPrice(double price, int precision) {
    std::wstringstream ss;
    ss << std::fixed << std::setprecision(precision) << price;
    return ss.str();
}
std::wstring FormatQuoteVolume(double vol) {
    std::wstringstream ss;
    ss << std::fixed;
    if (vol >= 1000000.0) ss << std::setprecision(1) << (vol / 1000000.0) << L"M";
    else if (vol >= 1000.0) ss << std::setprecision(0) << (vol / 1000.0) << L"k";
    else ss << std::setprecision(0) << vol;
    return ss.str();
}
void NetworkThreadFunc() {
    auto symbols = BinanceConnection::GetExchangeInfo(g_SharedState->currentMode);
    if (!symbols.empty()) {
        g_SharedState->availableSymbols = symbols;
        for (const auto& s : symbols) {
            if (s.symbol == g_TargetSymbol) {
                g_SharedState->currentSymbol = s;
                break;
            }
        }
    }
    while (g_Running) {
        try {
            auto connection = std::make_shared<BinanceConnection>(g_SharedState);
            connection->Connect(g_TargetSymbol, g_SharedState->currentMode);
        }
        catch (...) {
            std::this_thread::sleep_for(std::chrono::seconds(5));
        }
    }
}
void UpdateBubbles(const std::vector<Trade>& newTrades, double currentStep) {
    const float START_X = 310.0f;
    const float moveSpeed = 0.2f;
    auto it = g_ActiveBubbles.begin();
    while (it != g_ActiveBubbles.end()) {
        float displacement = it->targetRadiusX - it->currentRadiusX;
        it->currentRadiusX += displacement * 0.1f;
        it->xPosition += moveSpeed;
        if (it->xPosition > 3000.0f) it = g_ActiveBubbles.erase(it);
        else ++it;
    }
    for (const auto& trade : newTrades) {
        if (trade.timestamp <= g_LastProcessedTradeTime) continue;
        g_LastProcessedTradeTime = trade.timestamp;
        double snappedPrice = std::round(trade.price / currentStep) * currentStep;
        double val = trade.price * trade.quantity;
        bool merged = false;
        for (auto& b : g_ActiveBubbles) {
            if (b.isBuyerMaker == trade.isBuyerMaker && std::abs(b.xPosition - START_X) < 5.0f && std::abs(b.priceCenter - snappedPrice) < (currentStep * 50.0)) {
                b.volumeQuote += val;
                if (snappedPrice < b.priceMin) b.priceMin = snappedPrice;
                if (snappedPrice > b.priceMax) b.priceMax = snappedPrice;
                b.priceCenter = (b.priceMin + b.priceMax) / 2.0;
                float r = std::sqrt((float)b.volumeQuote) * 0.5f;
                b.targetRadiusX = std::clamp(r, 5.0f, 15.0f);
                merged = true;
                break;
            }
        }
        if (!merged) {
            VisualBubble vb;
            vb.priceCenter = snappedPrice;
            vb.priceMin = vb.priceMax = snappedPrice;
            vb.volumeQuote = val;
            vb.isBuyerMaker = trade.isBuyerMaker;
            vb.xPosition = START_X;
            vb.currentRadiusX = 2.0f;
            float r = std::sqrt((float)val) * 0.5f;
            vb.targetRadiusX = std::clamp(r, 5.0f, 15.0f);
            vb.velocityRadius = 0;
            g_ActiveBubbles.push_back(vb);
        }
    }
    if (g_ActiveBubbles.size() > 500) g_ActiveBubbles.pop_front();
}
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {
    case WM_MOUSEWHEEL: {
        short zDelta = GET_WHEEL_DELTA_WPARAM(wParam);
        if (zDelta > 0 && g_ScaleIndex < g_Scales.size() - 1) g_ScaleIndex++;
        else if (g_ScaleIndex > 0) g_ScaleIndex--;
    } return 0;
    case WM_DESTROY:
        g_Running = false;
        PostQuitMessage(0);
        return 0;
    }
    return DefWindowProc(hWnd, message, wParam, lParam);
}
int APIENTRY WinMain(HINSTANCE hInstance, HINSTANCE, LPSTR, int nCmdShow) {
    g_SharedState = std::make_shared<SharedState>();
    std::thread networkThread(NetworkThreadFunc);
    WNDCLASSEX wc = { sizeof(WNDCLASSEX), CS_CLASSDC, WndProc, 0L, 0L, GetModuleHandle(NULL), NULL, NULL, NULL, NULL, L"TigerBot", NULL };
    RegisterClassEx(&wc);
    HWND hWnd = CreateWindow(L"TigerBot", L"TigerBot C++", WS_OVERLAPPEDWINDOW, 50, 50, 1200, 1000, NULL, NULL, wc.hInstance, NULL);
    g_Graphics = std::make_unique<Graphics>();
    if (!g_Graphics->Initialize(hWnd)) return 1;
    ShowWindow(hWnd, nCmdShow);
    MSG msg = { 0 };
    while (msg.message != WM_QUIT) {
        if (PeekMessage(&msg, NULL, 0U, 0U, PM_REMOVE)) {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
        else {
            g_Graphics->BeginFrame(0.12f, 0.12f, 0.14f);
            double tickSize = g_SharedState->currentSymbol.tickSize;
            if (tickSize == 0) tickSize = 0.1;
            double currentStep = tickSize * g_Scales[g_ScaleIndex];
            auto snap = g_SharedState->GetSnapshotForRender(60, currentStep);
            float screenH = g_Graphics->GetHeight();
            float screenW = g_Graphics->GetWidth();
            float centerY = screenH / 2.0f;
            float rowH = 22.0f;
            UpdateBubbles(snap.RecentTrades, currentStep);
            double targetP = 0;
            if (!snap.Asks.empty() && !snap.Bids.empty()) targetP = (snap.Asks[0].first + snap.Bids[0].first) / 2.0;
            if (targetP > 0) {
                if (g_IsFirstFrame) { g_SmoothCenterPrice = targetP; g_IsFirstFrame = false; }
                else g_SmoothCenterPrice += (targetP - g_SmoothCenterPrice) * 0.1f;
            }
            if (g_SmoothCenterPrice > 0) {
                double maxVol = 1.0;
                for (const auto& lvl : snap.Asks) maxVol = std::max(maxVol, lvl.second);
                for (const auto& lvl : snap.Bids) maxVol = std::max(maxVol, lvl.second);
                if (maxVol <= 1.0) maxVol = 1000.0;
                for (const auto& lvl : snap.Asks) {
                    float y = centerY - (float)((lvl.first - g_SmoothCenterPrice) / currentStep * rowH) - rowH / 2;
                    if (y < 0 || y > screenH) continue;
                    float w = (float)(lvl.second / maxVol * 300.0);
                    g_Graphics->DrawRectPixels(0, y, w, rowH - 1, 0.8f, 0.2f, 0.2f, 1.0f);
                    std::wstringstream ss;
                    ss << FormatPrice(lvl.first, snap.CurrentSymbolInfo.pricePrecision);
                    g_Graphics->DrawTextPixels(ss.str(), 10, y, 200, rowH, 12, 1, 1, 1, 1);
                }
                for (const auto& lvl : snap.Bids) {
                    float y = centerY - (float)((lvl.first - g_SmoothCenterPrice) / currentStep * rowH) - rowH / 2;
                    if (y < 0 || y > screenH) continue;
                    float w = (float)(lvl.second / maxVol * 300.0);
                    g_Graphics->DrawRectPixels(0, y, w, rowH - 1, 0.2f, 0.8f, 0.2f, 1.0f);
                    std::wstringstream ss;
                    ss << FormatPrice(lvl.first, snap.CurrentSymbolInfo.pricePrecision);
                    g_Graphics->DrawTextPixels(ss.str(), 10, y, 200, rowH, 12, 1, 1, 1, 1);
                }
            }
            for (auto& b : g_ActiveBubbles) {
                if (g_SmoothCenterPrice == 0) continue;
                float y = centerY - (float)((b.priceCenter - g_SmoothCenterPrice) / currentStep * rowH);
                float radiusY = ((b.priceMax - b.priceMin) / currentStep * rowH / 2.0f);
                if (radiusY < b.currentRadiusX) radiusY = b.currentRadiusX; // мин размер
                if (b.isBuyerMaker) // Sell
                    g_Graphics->DrawEllipsePixels(b.xPosition, y, b.currentRadiusX, radiusY, 1.0f, 0.3f, 0.3f, 0.5f);
                else // Buy
                    g_Graphics->DrawEllipsePixels(b.xPosition, y, b.currentRadiusX, radiusY, 0.3f, 0.6f, 1.0f, 0.5f);
            }
            g_Graphics->DrawRectPixels(0, 0, screenW, 40, 0.2f, 0.2f, 0.2f, 1.0f);
            std::wstringstream title;
            title << L"TigerBot | " << std::wstring(g_TargetSymbol.begin(), g_TargetSymbol.end()) << L" | Scale: x" << g_Scales[g_ScaleIndex];
            g_Graphics->DrawTextPixels(title.str(), 10, 5, 500, 30, 16, 1, 1, 1, 1);
            g_Graphics->EndFrame();
        }
    }
    if (networkThread.joinable()) {
        g_Running = false;
        networkThread.join();
    }
    return 0;
}