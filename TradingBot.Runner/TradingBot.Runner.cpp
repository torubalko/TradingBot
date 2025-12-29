// 1. СТАНДАРТНЫЕ БИБЛИОТЕКИ
#include <atomic>
#include <thread>
#include <memory>
#include <string>
#include <vector>
#include <algorithm>
#include <iomanip> // Для красивого вывода цен (fixed, setprecision)
#include <sstream>

// 2. BOOST
#include <boost/beast/core.hpp>
#include <boost/asio.hpp>
#include <boost/bind/bind.hpp>

// 3. WINDOWS
#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>

// 4. НАШИ ЗАГОЛОВКИ
#include "Graphics.h"
#include "../TradingBot.Core/SharedState.h"
#include "../TradingBot.Core/BinanceConnection.h"

using namespace TradingBot::Core;
using namespace TradingBot::Core::Network;

// Глобальные переменные
std::unique_ptr<Graphics> g_Graphics;
std::shared_ptr<SharedState> g_SharedState;
std::atomic<bool> g_Running(true);
std::atomic<int> g_UpdateCounter(0); // Счетчик обновлений, чтобы видеть, что бот жив

// Сетевой поток
void NetworkThreadFunc() {
    try {
        auto connection = std::make_shared<BinanceConnection>(g_SharedState);
        // При каждом обновлении увеличиваем счетчик "жизни"
        // (В реальном коде лучше через колбэк, но так проще для теста)
        connection->Connect("BTCUSDT", false);
    }
    catch (const std::exception& e) {
        OutputDebugStringA(e.what());
    }
}

// Вспомогательная функция для рисования текста (GDI)
void DrawTextOverlay(HWND hWnd, const RenderSnapshot& snap, float currentPrice) {
    HDC hdc = GetDC(hWnd);

    // Настройка шрифта
    SetBkMode(hdc, TRANSPARENT); // Прозрачный фон у текста
    HFONT hFont = CreateFont(14, 0, 0, 0, FW_BOLD, FALSE, FALSE, FALSE, DEFAULT_CHARSET, OUT_DEFAULT_PRECIS, CLIP_DEFAULT_PRECIS, DEFAULT_QUALITY, DEFAULT_PITCH | FF_SWISS, L"Segoe UI");
    HFONT hOldFont = (HFONT)SelectObject(hdc, hFont);

    RECT clientRect;
    GetClientRect(hWnd, &clientRect);
    int width = clientRect.right;
    int height = clientRect.bottom;
    int centerY = height / 2;
    int rowHeight = (int)(height * 0.023f); // Высота строки, должна совпадать с Graphics.cpp

    // --- 1. Рисуем ASKS (Продавцы, Красные, Сверху) ---
    SetTextColor(hdc, RGB(255, 200, 200)); // Бледно-красный текст
    int y = centerY - rowHeight; // Начинаем чуть выше центра и идем вверх

    // Asks в снепшоте лежат от дешевых к дорогим (0 = лучшая цена)
    // Нам нужно рисовать лучшую цену (0) ближе к центру
    for (size_t i = 0; i < snap.Asks.size() && i < 20; ++i) {
        auto& level = snap.Asks[i];

        std::wstringstream ss;
        ss << std::fixed << std::setprecision(2) << level.first << L"   Vol: " << (int)level.second;

        RECT r = { 20, y, width, y + rowHeight };
        DrawText(hdc, ss.str().c_str(), -1, &r, DT_LEFT | DT_NOCLIP | DT_SINGLELINE | DT_VCENTER);

        y -= rowHeight; // Двигаемся вверх
    }

    // --- 2. Рисуем BIDS (Покупатели, Зеленые, Снизу) ---
    SetTextColor(hdc, RGB(200, 255, 200)); // Бледно-зеленый текст
    y = centerY + 2; // Чуть ниже центра
    for (size_t i = 0; i < snap.Bids.size() && i < 20; ++i) {
        auto& level = snap.Bids[i];

        std::wstringstream ss;
        ss << std::fixed << std::setprecision(2) << level.first << L"   Vol: " << (int)level.second;

        RECT r = { 20, y, width, y + rowHeight };
        DrawText(hdc, ss.str().c_str(), -1, &r, DT_LEFT | DT_NOCLIP | DT_SINGLELINE | DT_VCENTER);

        y += rowHeight; // Двигаемся вниз
    }

    // --- 3. Рисуем статус ---
    SetTextColor(hdc, RGB(255, 255, 255));
    std::wstringstream status;
    status << L"TIGER BOT HFT | BTCUSDT | LIVE";
    RECT rStatus = { 10, 10, 400, 50 };
    DrawText(hdc, status.str().c_str(), -1, &rStatus, DT_LEFT);

    // Уборка
    SelectObject(hdc, hOldFont);
    DeleteObject(hFont);
    ReleaseDC(hWnd, hdc);
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

    HWND hWnd = CreateWindow(L"TigerBotZone", L"TigerBot HFT (DX11)", WS_OVERLAPPEDWINDOW, 100, 100, 450, 800, NULL, NULL, wc.hInstance, NULL);

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
            // 1. Рисуем Графику (Полоски)
            g_Graphics->BeginFrame(0.12f, 0.12f, 0.14f);

            auto snap = g_SharedState->GetSnapshotForRender(40);

            double maxVol = 1.0;
            for (auto& p : snap.Bids) if (p.second > maxVol) maxVol = p.second;
            for (auto& p : snap.Asks) if (p.second > maxVol) maxVol = p.second;

            float barHeight = 0.023f;
            float currentY = 0.0f;

            // Asks (Вверх)
            for (const auto& level : snap.Asks) {
                float width = (float)((level.second / maxVol) * 1.8f);
                g_Graphics->DrawRect(-1.0f, currentY + barHeight, width, barHeight - 0.002f, 0.8f, 0.2f, 0.2f, 1.0f);
                currentY += barHeight;
            }

            // Bids (Вниз)
            currentY = 0.0f;
            for (const auto& level : snap.Bids) {
                float width = (float)((level.second / maxVol) * 1.8f);
                g_Graphics->DrawRect(-1.0f, currentY, width, barHeight - 0.002f, 0.2f, 0.8f, 0.2f, 1.0f);
                currentY -= barHeight;
            }

            g_Graphics->EndFrame();

            // 2. Рисуем Текст (Поверх графики)
            DrawTextOverlay(hWnd, snap, 0.0f);

            // Небольшая пауза, чтобы не грузить ЦП на 100%
            std::this_thread::sleep_for(std::chrono::milliseconds(16));
        }
    }

    g_Running = false;
    if (networkThread.joinable()) networkThread.join();
    return (int)msg.wParam;
}