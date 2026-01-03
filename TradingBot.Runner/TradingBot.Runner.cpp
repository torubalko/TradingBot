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
#include "../TradingBot.Core/RestClient.h"

using namespace TradingBot::Core;
using namespace TradingBot::Core::Network;

std::unique_ptr<Graphics> g_Graphics;
std::shared_ptr<SharedState> g_SharedState;
std::atomic<bool> g_Running(true);

const double BASE_TICK_SIZE = 0.1;
int g_ScaleIndex = 0;
std::vector<int> g_Scales = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000 };

const float START_X_POS = 310.0f;

double g_SmoothCenterPrice = 0.0;
bool g_IsFirstFrame = true;

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
    try {
        OutputDebugStringA("[TigerBot] Starting REST Client...\n");
        RestClient restClient;
        restClient.LoadExchangeInfo(g_SharedState->marketData);

        if (g_SharedState->marketData.isLoaded) {
            OutputDebugStringA("[TigerBot] Market Data Loaded Successfully!\n");
        }
        else {
            OutputDebugStringA("[TigerBot] Warning: Market Data is empty.\n");
        }
    }
    catch (const std::exception& e) {
        OutputDebugStringA("[TigerBot] REST Error: ");
        OutputDebugStringA(e.what());
        OutputDebugStringA("\n");
    }

    while (g_Running) {
        try {
            std::string currentPair = "BTCUSDT";
            auto connection = std::make_shared<BinanceConnection>(g_SharedState);
            connection->Connect(currentPair, false);
        }
        catch (const std::exception& e) {
            OutputDebugStringA(e.what());
            std::this_thread::sleep_for(std::chrono::seconds(2));
        }
    }
}

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {
    case WM_MOUSEWHEEL: {
        short zDelta = GET_WHEEL_DELTA_WPARAM(wParam);
        if (zDelta > 0) { if (g_ScaleIndex < g_Scales.size() - 1) g_ScaleIndex++; }
        else { if (g_ScaleIndex > 0) g_ScaleIndex--; }
    } return 0;
    case WM_SIZE:
        if (g_Graphics) {
            g_Graphics->Resize(hWnd);
        }
        return 0;
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

            float screenWidth = g_Graphics->GetWidth();
            float screenHeight = g_Graphics->GetHeight();
            float headerHeight = 50.0f;

            float chartAreaY = headerHeight;
            float chartAreaHeight = screenHeight - headerHeight;
            float centerY = chartAreaY + (chartAreaHeight / 2.0f);
            float rowHeight = 22.0f;

            double currentStep = BASE_TICK_SIZE * g_Scales[g_ScaleIndex];
            auto snap = g_SharedState->GetSnapshotForRender(80, currentStep);

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

            if (g_SmoothCenterPrice > 0) {
                for (const auto& level : snap.Asks) {
                    double diff = level.first - g_SmoothCenterPrice;
                    double rows = diff / currentStep;
                    float rectY = centerY - (float)(rows * rowHeight) - (rowHeight / 2.0f);
                    if (rectY < -headerHeight || rectY > screenHeight) continue;

                    float width = (float)((level.second / maxVol) * 280.0f);
                    g_Graphics->DrawRectPixels(0, rectY, width, rowHeight - 1.0f, 0.8f, 0.25f, 0.25f, 1.0f);

                    double quoteVol = level.first * level.second;
                    std::wstringstream ss;
                    ss << FormatPrice(level.first) << L"  " << FormatQuoteVolume(quoteVol);
                    g_Graphics->DrawTextPixels(ss.str(), 10.0f, rectY, 300.0f, rowHeight, 12.0f, 1.0f, 1.0f, 1.0f, 1.0f);
                }

                for (const auto& level : snap.Bids) {
                    double diff = level.first - g_SmoothCenterPrice;
                    double rows = diff / currentStep;
                    float rectY = centerY - (float)(rows * rowHeight) - (rowHeight / 2.0f);
                    if (rectY < -headerHeight || rectY > screenHeight) continue;

                    float width = (float)((level.second / maxVol) * 280.0f);
                    g_Graphics->DrawRectPixels(0, rectY, width, rowHeight - 1.0f, 0.25f, 0.8f, 0.25f, 1.0f);

                    double quoteVol = level.first * level.second;
                    std::wstringstream ss;
                    ss << FormatPrice(level.first) << L"  " << FormatQuoteVolume(quoteVol);
                    g_Graphics->DrawTextPixels(ss.str(), 10.0f, rectY, 300.0f, rowHeight, 12.0f, 1.0f, 1.0f, 1.0f, 1.0f);
                }
            }

            if (g_SmoothCenterPrice > 0) {
                float rightScaleX = screenWidth - 60.0f;
                g_Graphics->DrawRectPixels(rightScaleX, headerHeight, 1.0f, screenHeight - headerHeight, 0.5f, 0.5f, 0.5f, 1.0f);
                int rowsStep = 5;

                for (int i = 0; ; i += rowsStep) {
                    float y = centerY - (i * rowHeight);
                    if (y < headerHeight) break;
                    double pct = (i * currentStep / g_SmoothCenterPrice) * 100.0;
                    g_Graphics->DrawRectPixels(rightScaleX, y, 5.0f, 1.0f, 0.7f, 0.7f, 0.7f, 1.0f);
                    if (i > 0) g_Graphics->DrawTextPixels(FormatPercent(pct), rightScaleX + 8.0f, y - 6.0f, 50.0f, 12.0f, 10.0f, 0.8f, 0.8f, 0.8f, 1.0f);
                }
                for (int i = rowsStep; ; i += rowsStep) {
                    float y = centerY + (i * rowHeight);
                    if (y > screenHeight) break;
                    double pct = -(i * currentStep / g_SmoothCenterPrice) * 100.0;
                    g_Graphics->DrawRectPixels(rightScaleX, y, 5.0f, 1.0f, 0.7f, 0.7f, 0.7f, 1.0f);
                    g_Graphics->DrawTextPixels(FormatPercent(pct), rightScaleX + 8.0f, y - 6.0f, 50.0f, 12.0f, 10.0f, 0.8f, 0.8f, 0.8f, 1.0f);
                }
            }

            g_Graphics->DrawRectPixels(0, 0, screenWidth, headerHeight, 0.1f, 0.1f, 0.12f, 1.0f);
            g_Graphics->DrawRectPixels(0, headerHeight - 1.0f, screenWidth, 1.0f, 0.3f, 0.3f, 0.3f, 1.0f);

            g_Graphics->DrawTextPixels(L"SPOT", 20, 15, 50, 20, 14, 0.6f, 0.6f, 0.6f, 1.0f);
            g_Graphics->DrawTextPixels(L"FUTURES", 80, 15, 80, 20, 14, 1.0f, 0.8f, 0.2f, 1.0f);

            float dropX = 200.0f;
            float dropY = 10.0f;
            float dropW = 150.0f;
            float dropH = 30.0f;
            g_Graphics->DrawRectPixels(dropX, dropY, dropW, dropH, 0.2f, 0.2f, 0.25f, 1.0f);
            g_Graphics->DrawTextPixels(L"BTCUSDT", dropX + 10.0f, dropY + 5.0f, 100.0f, 20.0f, 14, 1.0f, 1.0f, 1.0f, 1.0f);

            std::wstringstream ssScale;
            ssScale << L"Scale: x" << g_Scales[g_ScaleIndex];
            g_Graphics->DrawTextPixels(ssScale.str(), screenWidth - 120.0f, 15.0f, 100.0f, 20.0f, 14, 0.7f, 0.7f, 0.7f, 1.0f);

            g_Graphics->EndFrame();
        }
    }

    std::exit(0);
    return (int)msg.wParam;
}