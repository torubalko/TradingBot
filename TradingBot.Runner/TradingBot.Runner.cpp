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

// Глобальные переменные
std::unique_ptr<Graphics> g_Graphics;
std::shared_ptr<SharedState> g_SharedState;
std::atomic<bool> g_Running(true);

// --- УПРАВЛЕНИЕ СЖАТИЕМ ---
// Базовый шаг цены (для BTC это 0.1)
// В идеале его надо брать из InstrumentInfo, но пока зададим жестко для BTC
const double BASE_TICK_SIZE = 0.1;

// Текущий множитель сжатия (1, 2, 5, 10, 20, 50, 100...)
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

// Обработчик сообщений (Здесь ловим колесико)
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {
    case WM_MOUSEWHEEL:
    {
        // Получаем направление прокрутки
        short zDelta = GET_WHEEL_DELTA_WPARAM(wParam);
        if (zDelta > 0) {
            // Крутим от себя -> Сжимаем стакан (увеличиваем индекс)
            if (g_ScaleIndex < g_Scales.size() - 1) g_ScaleIndex++;
        }
        else {
            // Крутим к себе -> Разжимаем стакан
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

            // 1. Вычисляем текущий шаг цены
            // Scale = 1 -> шаг 0.1
            // Scale = 10 -> шаг 1.0 (агрегация x10)
            double currentStep = BASE_TICK_SIZE * g_Scales[g_ScaleIndex];

            // 2. Получаем уже сжатые данные
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

            // --- РИСУЕМ ЖЕЛТУЮ ЛИНИЮ СПРЕДА ---
            g_Graphics->DrawRectPixels(0, centerY - 1.0f, screenWidth, 2.0f, 1.0f, 0.8f, 0.0f, 0.8f);

            // --- 1. ASKS (ВВЕРХ) ---
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

            // --- 2. BIDS (ВНИЗ) ---
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

            // Можно нарисовать текущее сжатие где-то в углу для отладки
            // (опционально)

            g_Graphics->EndFrame();
        }
    }

    g_Running = false;
    if (networkThread.joinable()) networkThread.join();
    return (int)msg.wParam;
}