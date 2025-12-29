#include <atomic>
#include <thread>
#include <memory>
#include <string>
#include <vector>
#include <algorithm>
#include <iomanip>
#include <sstream>
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

void NetworkThreadFunc() {
    while (g_Running) {
        try {
            auto connection = std::make_shared<BinanceConnection>(g_SharedState);
            connection->Connect("BTCUSDT", false);
        }
        catch (const std::exception& e) {
            std::string err = "[NET ERROR] "; err += e.what(); err += "\n";
            OutputDebugStringA(err.c_str());
            std::this_thread::sleep_for(std::chrono::seconds(2));
        }
    }
}

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {
    case WM_SIZE: return 0;
    case WM_DESTROY: PostQuitMessage(0); g_Running = false; return 0;
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

            auto snap = g_SharedState->GetSnapshotForRender(50); // Берем 50 уровней

            // Расчет масштаба
            double maxVol = 1.0;
            for (auto& p : snap.Bids) if (p.second > maxVol) maxVol = p.second;
            for (auto& p : snap.Asks) if (p.second > maxVol) maxVol = p.second;
            if (maxVol < 100) maxVol = 100; // Минимальный масштаб, чтобы не дергалось на пустом рынке

            float barHeight = 0.04f;
            float startX = -0.98f;
            float gap = 0.002f; // Стык в стык

            // --- 1. ASKS (Рисуем ВВЕРХ от центра) ---
            float currentY = gap;
            for (const auto& level : snap.Asks) {
                float width = (float)((level.second / maxVol) * 1.5f);
                if (width > 1.9f) width = 1.9f; // Ограничитель ширины

                // Красный фон
                g_Graphics->DrawRect(startX, currentY + barHeight, width, barHeight - 0.002f, 0.8f, 0.25f, 0.25f, 1.0f);

                std::wstringstream ss;
                ss << std::fixed << std::setprecision(1) << level.first << L"  " << (int)level.second;

                g_Graphics->DrawTextString(ss.str(), startX + 0.02f, currentY + barHeight, barHeight - 0.002f, 12.0f, 1.0f, 1.0f, 1.0f, 1.0f);

                currentY += barHeight;
            }

            // --- 2. BIDS (Рисуем ВНИЗ от центра) ---
            currentY = -gap;
            for (const auto& level : snap.Bids) {
                float width = (float)((level.second / maxVol) * 1.5f);
                if (width > 1.9f) width = 1.9f;

                // Зеленый фон
                g_Graphics->DrawRect(startX, currentY, width, barHeight - 0.002f, 0.25f, 0.8f, 0.25f, 1.0f);

                std::wstringstream ss;
                ss << std::fixed << std::setprecision(1) << level.first << L"  " << (int)level.second;

                g_Graphics->DrawTextString(ss.str(), startX + 0.02f, currentY, barHeight - 0.002f, 12.0f, 1.0f, 1.0f, 1.0f, 1.0f);

                currentY -= barHeight;
            }

            g_Graphics->EndFrame();
        }
    }

    g_Running = false;
    if (networkThread.joinable()) networkThread.join();
    return (int)msg.wParam;
}