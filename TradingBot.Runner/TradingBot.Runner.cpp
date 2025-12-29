// 1. СТАНДАРТНЫЕ БИБЛИОТЕКИ
#include <atomic>
#include <thread>
#include <memory>
#include <string>
#include <vector>

// 2. BOOST
#include <boost/beast/core.hpp>
#include <boost/asio.hpp>
#include <boost/bind/bind.hpp>

// 3. WINDOWS (Настройки для компиляции)
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

// Сетевой поток
void NetworkThreadFunc() {
    try {
        boost::asio::io_context ioc;

        // Заглушка, чтобы поток жил, пока мы тестируем графику
        while (g_Running) {
            std::this_thread::sleep_for(std::chrono::milliseconds(100));
        }
    }
    catch (const std::exception& e) {
        OutputDebugStringA(e.what());
    }
}

// Обработчик сообщений
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {
    case WM_SIZE:
        return 0;
    case WM_DESTROY:
        PostQuitMessage(0);
        g_Running = false;
        return 0;
    }
    return DefWindowProc(hWnd, message, wParam, lParam);
}

// ТОЧКА ВХОДА
int APIENTRY WinMain(_In_ HINSTANCE hInstance, _In_opt_ HINSTANCE hPrevInstance, _In_ LPSTR lpCmdLine, _In_ int nCmdShow) {
    // 1. Инициализация логики
    g_SharedState = std::make_shared<SharedState>();

    // 2. Старт сети
    std::thread networkThread(NetworkThreadFunc);

    // 3. Регистрация класса окна
    WNDCLASSEX wc = { sizeof(WNDCLASSEX), CS_CLASSDC, WndProc, 0L, 0L, GetModuleHandle(NULL), NULL, NULL, NULL, NULL, L"TigerBotZone", NULL };
    RegisterClassEx(&wc);

    // 4. Создание окна
    HWND hWnd = CreateWindow(L"TigerBotZone", L"TigerBot HFT (DX11)",
        WS_OVERLAPPEDWINDOW, 100, 100, 1280, 800,
        NULL, NULL, wc.hInstance, NULL);

    // 5. Инициализация Графики
    g_Graphics = std::make_unique<Graphics>();
    if (!g_Graphics->Initialize(hWnd)) {
        MessageBox(NULL, L"DirectX 11 Init Failed", L"Error", MB_ICONERROR);

        // ВАЖНОЕ ДОПОЛНЕНИЕ: Если графика не стартанула, нужно тоже остановить поток, иначе краш
        g_Running = false;
        if (networkThread.joinable()) {
            networkThread.join();
        }

        return 1;
    }

    ShowWindow(hWnd, nCmdShow);
    UpdateWindow(hWnd);

    // 6. Главный цикл
    MSG msg;
    ZeroMemory(&msg, sizeof(msg));

    while (msg.message != WM_QUIT) {
        if (PeekMessage(&msg, NULL, 0U, 0U, PM_REMOVE)) {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
        else {
            // --- РЕНДЕР ---
            g_Graphics->BeginFrame(0.0f, 0.2f, 0.5f);
            g_Graphics->DrawRect(-0.25f, 0.25f, 0.5f, 0.5f, 1.0f, 0.0f, 0.0f, 1.0f);
            g_Graphics->EndFrame();
        }
    }

    // 7. ЗАВЕРШЕНИЕ РАБОТЫ (ИСПРАВЛЕНИЕ КРАША)
    g_Running = false; // Сигнализируем потоку на выход

    if (networkThread.joinable()) {
        networkThread.join(); // Ждем, пока поток завершится
    }

    return (int)msg.wParam;
}