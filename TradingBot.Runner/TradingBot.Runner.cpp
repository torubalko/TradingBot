#include <atomic>
#include <thread>
#include <memory>
#include <string>
#include <vector>
#include <algorithm>
#include <iomanip>
#include <sstream>
#include <cmath>
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
std::vector<int> g_Scales = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000 };

std::wstring FormatPrice(double price) {
    std::wstringstream ss;
    ss << std::fixed;
    double roundedPrice = price;

    if (price >= 1000.0) {
        roundedPrice = std::round(price * 10.0) / 10.0;
        ss << std::setprecision(1) << roundedPrice;
    }
    else if (price >= 10.0) {
        roundedPrice = std::round(price * 100.0) / 100.0;
        ss << std::setprecision(2) << roundedPrice;
    }
    else if (price >= 1.0) {
        roundedPrice = std::round(price * 1000.0) / 1000.0;
        ss << std::setprecision(3) << roundedPrice;
    }
    else if (price < 0.001) {
        ss << std::setprecision(8) << price;
    }
    else {
        roundedPrice = std::round(price * 100000.0) / 100000.0;
        ss << std::setprecision(5) << roundedPrice;
    }
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

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {
    case WM_MOUSEWHEEL:
    {
        short zDelta = GET_WHEEL_DELTA_WPARAM(wParam);
        if (zDelta > 0) {
            if (g_ScaleIndex < g_Scales.size() - 1) g_ScaleIndex++;
        }
        else {
            if (g_ScaleIndex > 0) g_ScaleIndex--;
        }
    }
    return 0;
    case WM_SIZE: return 0;
    case WM_DESTROY:
        PostQuitMessage(0);
        g_Running = false;
        return 0;
    }
    return DefWindowProc(hWnd, message, wParam, lParam);
}

int APIENTRY WinMain(_In_ HINSTANCE hInstance, _In_opt_ HINSTANCE hPrevInstance, _In_ LPSTR lpCmdLine, _In_ int nCmdShow) {
    g_SharedState = std::make_shared<SharedState>();
    std::thread networkThread(NetworkThreadFunc);

    WNDCLASSEX wc = { sizeof(WNDCLASSEX), CS_CLASSDC, WndProc, 0L, 0L, GetModuleHandle(NULL), NULL, NULL, NULL, NULL, L"TigerBotZone", NULL };
    RegisterClassEx(&wc);

    HWND hWnd = CreateWindow(L"TigerBotZone", L"TigerBot HFT", WS_OVERLAPPEDWINDOW, 100, 100, 500, 800, NULL, NULL, wc.hInstance, NULL);

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

            double maxVol = 1.0;
            for (auto& p : snap.Bids) if (p.second > maxVol) maxVol = p.second;
            for (auto& p : snap.Asks) if (p.second > maxVol) maxVol = p.second;
            if (maxVol < 100) maxVol = 100;

            float screenHeight = g_Graphics->GetHeight();
            float screenWidth = g_Graphics->GetWidth();
            float centerY = screenHeight / 2.0f;

            float rowHeight = 22.0f;
            float gap = 2.0f;

            // --- ЖЕЛТАЯ ЛИНИЯ ---
            g_Graphics->DrawRectPixels(0, centerY - 1.0f, screenWidth, 2.0f, 1.0f, 0.8f, 0.0f, 0.8f);

            // --- 1. ASKS ---
            float currentY = centerY - rowHeight - 2.0f;
            for (const auto& level : snap.Asks) {
                if (currentY < -rowHeight) break;
                float width = (float)((level.second / maxVol) * (screenWidth * 0.8f));
                if (width > screenWidth - 20) width = screenWidth - 20;
                g_Graphics->DrawRectPixels(0, currentY, width, rowHeight - 1.0f, 0.8f, 0.25f, 0.25f, 1.0f);
                std::wstringstream ss;
                ss << FormatPrice(level.first) << L"  " << (int)std::round(level.second);
                g_Graphics->DrawTextPixels(ss.str(), 10.0f, currentY, 300.0f, rowHeight, 12.0f, 1.0f, 1.0f, 1.0f, 1.0f);
                currentY -= rowHeight;
            }

            // --- 2. BIDS ---
            currentY = centerY + 2.0f;
            for (const auto& level : snap.Bids) {
                if (currentY > screenHeight) break;
                float width = (float)((level.second / maxVol) * (screenWidth * 0.8f));
                if (width > screenWidth - 20) width = screenWidth - 20;
                g_Graphics->DrawRectPixels(0, currentY, width, rowHeight - 1.0f, 0.25f, 0.8f, 0.25f, 1.0f);
                std::wstringstream ss;
                ss << FormatPrice(level.first) << L"  " << (int)std::round(level.second);
                g_Graphics->DrawTextPixels(ss.str(), 10.0f, currentY, 300.0f, rowHeight, 12.0f, 1.0f, 1.0f, 1.0f, 1.0f);
                currentY += rowHeight;
            }

            // --- 3. НОВОЕ: СДЕЛКИ КАК В TIGER TRADE ---
            for (const auto& trade : snap.RecentTrades) {
                float tradeY = -9999.0f;

                // 3.1 Поиск Y
                for (size_t i = 0; i < snap.Asks.size(); ++i) {
                    double aggPrice = std::ceil(trade.price / currentStep - 0.000001) * currentStep;
                    if (std::abs(snap.Asks[i].first - aggPrice) < 0.00001) {
                        tradeY = (centerY - 2.0f) - (i * rowHeight) + (rowHeight / 2.0f);
                        break;
                    }
                }
                if (tradeY == -9999.0f) {
                    for (size_t i = 0; i < snap.Bids.size(); ++i) {
                        double aggPrice = std::floor(trade.price / currentStep + 0.000001) * currentStep;
                        if (std::abs(snap.Bids[i].first - aggPrice) < 0.00001) {
                            tradeY = (centerY + 2.0f) + (i * rowHeight) + (rowHeight / 2.0f);
                            break;
                        }
                    }
                }

                if (tradeY > 0 && tradeY < screenHeight) {
                    // 3.2 Формируем текст объема (как в Tiger)
                    std::wstringstream tradeSS;
                    tradeSS << (int)trade.quantity;
                    std::wstring tradeText = tradeSS.str();

                    // 3.3 Считаем радиус от размера текста (Секрет Tiger)
                    // Радиус = половина ширины текста + небольшой отступ
                    float textWidth = g_Graphics->MeasureTextWidth(tradeText, 11.0f);
                    float radius = (textWidth / 2.0f) + 4.0f;

                    // Минимальный размер, чтобы выглядело как круг
                    if (radius < 10.0f) radius = 10.0f;
                    // Максимум - не больше высоты строки
                    if (radius > rowHeight / 1.8f) radius = rowHeight / 1.8f;

                    // 3.4 Цвета из Tiger Trade (Полупрозрачные)
                    float r, g, b, a = 0.5f; // Alpha ~127
                    if (trade.isBuyerMaker) { // Продажа (Sell) - Красный
                        r = 178.0f / 255.0f; g = 34.0f / 255.0f; b = 34.0f / 255.0f;
                    }
                    else { // Покупка (Buy) - Синий/Голубой
                        r = 70.0f / 255.0f; g = 130.0f / 255.0f; b = 180.0f / 255.0f;
                    }

                    // 3.5 Рисуем
                    float bubbleX = screenWidth - 50.0f;
                    g_Graphics->DrawCirclePixels(bubbleX, tradeY, radius, r, g, b, a);
                    // Белый текст внутри
                    g_Graphics->DrawTextCentered(tradeText, bubbleX, tradeY, 11.0f, 1.0f, 1.0f, 1.0f, 1.0f);
                }
            }

            g_Graphics->EndFrame();
        }
    }

    g_Running = false;
    if (networkThread.joinable()) networkThread.join();
    return (int)msg.wParam;
}