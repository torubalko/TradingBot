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
#include <boost/beast/core.hpp>
#include <boost/asio.hpp>
#include <boost/bind/bind.hpp>

#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>

#include "Graphics.h"
#include "../TradingBot.Core/SharedState.h"
#include "../TradingBot.Core/BinanceConnection.h"

using namespace TradingBot::Core;
using namespace TradingBot::Core::Network;

std::unique_ptr<Graphics> g_Graphics;
std::shared_ptr<SharedState> g_SharedState;
std::atomic<bool> g_Running(true);

const double BASE_TICK_SIZE = 0.1;
int g_ScaleIndex = 0;
std::vector<int> g_Scales = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000 };

// --- ЦВЕТА ---
const float COL_BUY_R = 0.2f, COL_BUY_G = 0.6f, COL_BUY_B = 1.0f;
const float COL_SELL_R = 1.0f, COL_SELL_G = 0.25f, COL_SELL_B = 0.25f;

const float START_X_POS = 310.0f;

// --- ГЛОБАЛЬНАЯ КАМЕРА ---
double g_SmoothCenterPrice = 0.0;
bool g_IsFirstFrame = true;

struct VisualBubble {
    double priceCenter;
    double priceMin;
    double priceMax;

    double volumeQuote;

    float currentRadiusX;
    float targetRadiusX;
    float velocityRadius;

    float xPosition;

    bool isBuyerMaker;
};

std::list<VisualBubble> g_ActiveBubbles;
long long g_LastProcessedTradeTime = 0;

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

void NetworkThreadFunc() {
    while (g_Running) {
        try {
            auto connection = std::make_shared<BinanceConnection>(g_SharedState);
            connection->Connect("BTCUSDT", false);
        }
        catch (const std::exception& e) {
            OutputDebugStringA(e.what());
            std::this_thread::sleep_for(std::chrono::seconds(2));
        }
    }
}

void UpdateBubbles(const std::vector<Trade>& newTrades, double currentStep) {
    const float tension = 0.4f;
    const float dampening = 0.75f;
    const float moveSpeed = 0.2f;

    auto it = g_ActiveBubbles.begin();
    while (it != g_ActiveBubbles.end()) {
        float displacement = it->targetRadiusX - it->currentRadiusX;
        it->velocityRadius += displacement * tension;
        it->velocityRadius *= dampening;
        it->currentRadiusX += it->velocityRadius;

        it->xPosition += moveSpeed;

        if (it->xPosition > 3000.0f) it = g_ActiveBubbles.erase(it);
        else ++it;
    }

    for (const auto& trade : newTrades) {
        if (trade.timestamp <= g_LastProcessedTradeTime) continue;
        g_LastProcessedTradeTime = trade.timestamp;

        double snappedPrice = std::round(trade.price / currentStep) * currentStep;
        double tradeValueQuote = trade.price * trade.quantity;

        bool merged = false;

        for (auto& b : g_ActiveBubbles) {
            double priceDiff = std::abs(b.priceCenter - snappedPrice);

            if (b.isBuyerMaker == trade.isBuyerMaker &&
                (b.xPosition - START_X_POS) < 3.0f &&
                priceDiff < (currentStep * 50.0)) {

                b.volumeQuote += tradeValueQuote;

                if (snappedPrice < b.priceMin) b.priceMin = snappedPrice;
                if (snappedPrice > b.priceMax) b.priceMax = snappedPrice;
                b.priceCenter = (b.priceMin + b.priceMax) / 2.0;

                float rawRadius = std::sqrt((float)b.volumeQuote) * 0.5f;
                if (rawRadius > 13.0f) rawRadius = 13.0f;
                if (rawRadius < 6.0f) rawRadius = 6.0f;

                b.targetRadiusX = rawRadius;
                b.velocityRadius += 5.0f;

                merged = true;
                break;
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

            float tR = std::sqrt((float)tradeValueQuote) * 0.5f;
            if (tR > 13.0f) tR = 13.0f;
            if (tR < 6.0f) tR = 6.0f;
            vb.targetRadiusX = tR;

            vb.velocityRadius = 10.0f;

            g_ActiveBubbles.push_back(vb);
        }
    }

    if (g_ActiveBubbles.size() > 500) g_ActiveBubbles.pop_front();
}

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {
    case WM_MOUSEWHEEL: {
        short zDelta = GET_WHEEL_DELTA_WPARAM(wParam);
        if (zDelta > 0) { if (g_ScaleIndex < g_Scales.size() - 1) g_ScaleIndex++; }
        else { if (g_ScaleIndex > 0) g_ScaleIndex--; }
    } return 0;
    case WM_SIZE: return 0;
    case WM_DESTROY:
        g_Running = false;
        PostQuitMessage(0);
        std::exit(0);
        return 0;
    }
    return DefWindowProc(hWnd, message, wParam, lParam);
}

int APIENTRY WinMain(_In_ HINSTANCE hInstance, _In_opt_ HINSTANCE hPrevInstance, _In_ LPSTR lpCmdLine, _In_ int nCmdShow) {
    g_SharedState = std::make_shared<SharedState>();
    std::thread networkThread(NetworkThreadFunc);

    WNDCLASSEX wc = { sizeof(WNDCLASSEX), CS_CLASSDC, WndProc, 0L, 0L, GetModuleHandle(NULL), NULL, NULL, NULL, NULL, L"TigerBotZone", NULL };
    RegisterClassEx(&wc);

    // --- ИЗМЕНЕНИЕ ВЫСОТЫ ---
    // Ширина 1200, Высота 1200 (было 800)
    HWND hWnd = CreateWindow(L"TigerBotZone", L"TigerBot HFT", WS_OVERLAPPEDWINDOW, 100, 100, 1200, 1200, NULL, NULL, wc.hInstance, NULL);

    g_Graphics = std::make_unique<Graphics>();
    if (!g_Graphics->Initialize(hWnd)) return 1;

    ShowWindow(hWnd, nCmdShow);
    UpdateWindow(hWnd);

    MSG msg = { 0 };
    while (msg.message != WM_QUIT) {
        if (PeekMessage(&msg, NULL, 0U, 0U, PM_REMOVE)) {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
        else {
            g_Graphics->BeginFrame(0.12f, 0.12f, 0.14f);

            double currentStep = BASE_TICK_SIZE * g_Scales[g_ScaleIndex];
            auto snap = g_SharedState->GetSnapshotForRender(60, currentStep);

            float screenHeight = g_Graphics->GetHeight();
            float screenWidth = g_Graphics->GetWidth();
            float centerY = screenHeight / 2.0f;
            float rowHeight = 22.0f;

            UpdateBubbles(snap.RecentTrades, currentStep);

            // КАМЕРА
            double bestAsk = snap.Asks.empty() ? 0 : snap.Asks[0].first;
            double bestBid = snap.Bids.empty() ? 0 : snap.Bids[0].first;
            double targetCenterPrice = 0;

            if (bestAsk > 0 && bestBid > 0) targetCenterPrice = (bestAsk + bestBid) / 2.0;
            else if (bestAsk > 0) targetCenterPrice = bestAsk;
            else if (bestBid > 0) targetCenterPrice = bestBid;

            if (targetCenterPrice > 0) {
                if (g_IsFirstFrame || g_SmoothCenterPrice == 0) {
                    g_SmoothCenterPrice = targetCenterPrice;
                    g_IsFirstFrame = false;
                }
                else {
                    g_SmoothCenterPrice += (targetCenterPrice - g_SmoothCenterPrice) * 0.15;
                }
            }

            double maxVol = 1.0;
            for (auto& p : snap.Bids) if (p.second > maxVol) maxVol = p.second;
            for (auto& p : snap.Asks) if (p.second > maxVol) maxVol = p.second;
            if (maxVol < 100) maxVol = 100;

            g_Graphics->DrawRectPixels(0, centerY - 1.0f, screenWidth, 2.0f, 1.0f, 0.8f, 0.0f, 0.8f);

            // ОТРИСОВКА
            if (g_SmoothCenterPrice > 0) {
                // ASKS
                for (const auto& level : snap.Asks) {
                    double diff = level.first - g_SmoothCenterPrice;
                    double rows = diff / currentStep;
                    float rectY = centerY - (float)(rows * rowHeight) - (rowHeight / 2.0f);

                    if (rectY < -rowHeight || rectY > screenHeight) continue;

                    float width = (float)((level.second / maxVol) * 280.0f);
                    g_Graphics->DrawRectPixels(0, rectY, width, rowHeight - 1.0f, 0.8f, 0.25f, 0.25f, 1.0f);

                    double quoteVol = level.first * level.second;
                    std::wstringstream ss;
                    ss << FormatPrice(level.first) << L"  " << FormatQuoteVolume(quoteVol);

                    g_Graphics->DrawTextPixels(ss.str(), 10.0f, rectY, 300.0f, rowHeight, 12.0f, 1.0f, 1.0f, 1.0f, 1.0f);
                }

                // BIDS
                for (const auto& level : snap.Bids) {
                    double diff = level.first - g_SmoothCenterPrice;
                    double rows = diff / currentStep;
                    float rectY = centerY - (float)(rows * rowHeight) - (rowHeight / 2.0f);

                    if (rectY < -rowHeight || rectY > screenHeight) continue;

                    float width = (float)((level.second / maxVol) * 280.0f);
                    g_Graphics->DrawRectPixels(0, rectY, width, rowHeight - 1.0f, 0.25f, 0.8f, 0.25f, 1.0f);

                    double quoteVol = level.first * level.second;
                    std::wstringstream ss;
                    ss << FormatPrice(level.first) << L"  " << FormatQuoteVolume(quoteVol);

                    g_Graphics->DrawTextPixels(ss.str(), 10.0f, rectY, 300.0f, rowHeight, 12.0f, 1.0f, 1.0f, 1.0f, 1.0f);
                }
            }

            for (const auto& b : g_ActiveBubbles) {
                float bubbleY = -9999.0f;
                if (g_SmoothCenterPrice > 0) {
                    double diff = b.priceCenter - g_SmoothCenterPrice;
                    double rows = diff / currentStep;
                    bubbleY = (centerY)-(float)(rows * rowHeight);
                }

                if (bubbleY > -200 && bubbleY < screenHeight + 200 && b.xPosition < screenWidth + 100) {
                    float r = b.isBuyerMaker ? COL_SELL_R : COL_BUY_R;
                    float g = b.isBuyerMaker ? COL_SELL_G : COL_BUY_G;
                    float bl = b.isBuyerMaker ? COL_SELL_B : COL_BUY_B;

                    float radiusX = b.currentRadiusX;
                    double spread = b.priceMax - b.priceMin;
                    float heightPx = (float)((spread / currentStep) * rowHeight);
                    if (heightPx < rowHeight) heightPx = rowHeight;

                    // Минус 1.0f для микро-зазора
                    float radiusY = (heightPx / 2.0f) + radiusX - 1.0f;

                    g_Graphics->DrawEllipsePixels(b.xPosition, bubbleY, radiusX, radiusY, r, g, bl, 0.4f);
                    g_Graphics->DrawTextCentered(FormatQuoteVolume(b.volumeQuote), b.xPosition, bubbleY, 11.0f, 1.0f, 1.0f, 1.0f, 1.0f);
                }
            }

            if (g_SmoothCenterPrice > 0) {
                // ПРАВАЯ ШКАЛА (%)
                float rightScaleX = screenWidth - 60.0f;
                g_Graphics->DrawRectPixels(rightScaleX, 0, 1.0f, screenHeight, 0.5f, 0.5f, 0.5f, 1.0f);
                int rowsStep = 5;

                // Вверх
                for (int i = 0; ; i += rowsStep) {
                    float y = centerY - (i * rowHeight);
                    if (y < 0) break;
                    double pct = (i * currentStep / g_SmoothCenterPrice) * 100.0;
                    g_Graphics->DrawRectPixels(rightScaleX, y, 5.0f, 1.0f, 0.7f, 0.7f, 0.7f, 1.0f);
                    if (i > 0) g_Graphics->DrawTextPixels(FormatPercent(pct), rightScaleX + 8.0f, y - 6.0f, 50.0f, 12.0f, 10.0f, 0.8f, 0.8f, 0.8f, 1.0f);
                }
                // Вниз
                for (int i = rowsStep; ; i += rowsStep) {
                    float y = centerY + (i * rowHeight);
                    if (y > screenHeight) break;
                    double pct = -(i * currentStep / g_SmoothCenterPrice) * 100.0;
                    g_Graphics->DrawRectPixels(rightScaleX, y, 5.0f, 1.0f, 0.7f, 0.7f, 0.7f, 1.0f);
                    g_Graphics->DrawTextPixels(FormatPercent(pct), rightScaleX + 8.0f, y - 6.0f, 50.0f, 12.0f, 10.0f, 0.8f, 0.8f, 0.8f, 1.0f);
                }

                // ИНДИКАТОР МАСШТАБА
                float scaleIndX = screenWidth - 160.0f;
                std::wstringstream ssScale;
                ssScale << L"Scale: x" << g_Scales[g_ScaleIndex];
                g_Graphics->DrawTextPixels(ssScale.str(), scaleIndX, 10.0f, 100.0f, 20.0f, 16.0f, 1.0f, 1.0f, 1.0f, 1.0f);
            }

            g_Graphics->EndFrame();
        }
    }

    std::exit(0);
    return (int)msg.wParam;
}