#include <atomic>
#include <thread>
#include <memory>
#include <string>
#include <iostream>
#include <sstream>
#include <iomanip>

#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>

#include "Graphics.h"
#include "OrderBookRenderer.h"  // НОВОЕ
#include "../TradingBot.Core/TradingBotApplication.h"

// ═══════════════════════════════════════════════════════════════
// НОВАЯ АРХИТЕКТУРА: Использование TradingBotApplication
// ═══════════════════════════════════════════════════════════════

using namespace TradingBot::Core;

std::unique_ptr<Graphics> g_Graphics;
std::unique_ptr<TradingBotApplication> g_TradingBot;
std::unique_ptr<OrderBookRenderer> g_OrderBookRenderer;  // НОВОЕ
std::atomic<bool> g_Running(true);

const double BASE_TICK_SIZE = 0.1;
int g_ScaleIndex = 0;
std::vector<int> g_Scales = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000 };

double g_SmoothCenterPrice = 0.0;
bool g_IsFirstFrame = true;

// ═══════════════════════════════════════════════════════════════
// Trading Bot Thread: Запуск основной логики бота
// ═══════════════════════════════════════════════════════════════
void TradingBotThreadFunc() {
    try {
        OutputDebugStringA("[TradingBot] Initializing...\n");
        
        // Создаём приложение
        g_TradingBot = std::make_unique<TradingBotApplication>();

        // Инициализация с конфигом
        if (!g_TradingBot->Initialize("./config.json")) {
            OutputDebugStringA("[TradingBot] ERROR: Failed to initialize\n");
            g_Running = false;
            return;
        }

        OutputDebugStringA("[TradingBot] Starting all threads...\n");
        
        // Запускаем все потоки (WebSocket, Logger, TCP Server, etc.)
        g_TradingBot->Start();

        OutputDebugStringA("[TradingBot] Running main loop...\n");

        // Запускаем главный цикл (MAIN THREAD processing)
        g_TradingBot->Run();

        OutputDebugStringA("[TradingBot] Main loop finished\n");
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
        if (zDelta > 0) { if (g_ScaleIndex < g_Scales.size() - 1) g_ScaleIndex++; }
        else { if (g_ScaleIndex > 0) g_ScaleIndex--; }
    } return 0;
    
    case WM_SIZE:
        if (g_Graphics) {
            g_Graphics->Resize(hWnd);
        }
        return 0;
    
    case WM_DESTROY:
        OutputDebugStringA("[TradingBot] Window closing, shutting down...\n");
        g_Running = false;
        
        if (g_TradingBot) {
            g_TradingBot->Stop();
        }
        
        PostQuitMessage(0);
        return 0;
    }
    return DefWindowProc(hWnd, message, wParam, lParam);
}

// ═══════════════════════════════════════════════════════════════
// WinMain: Entry Point
// ═══════════════════════════════════════════════════════════════

int APIENTRY WinMain(_In_ HINSTANCE hInstance, 
                     _In_opt_ HINSTANCE hPrevInstance, 
                     _In_ LPSTR lpCmdLine, 
                     _In_ int nCmdShow) 
{
    // Запускаем Trading Bot в отдельном потоке
    std::thread tradingBotThread(TradingBotThreadFunc);

    // Создаём окно для визуализации
    WNDCLASSEXW wc = {  // Было WNDCLASSEX, теперь WNDCLASSEXW
        sizeof(WNDCLASSEXW), 
        CS_CLASSDC, 
        WndProc, 
        0L, 0L, 
        GetModuleHandle(NULL), 
        NULL, NULL, NULL, NULL, 
        L"TradingBotWindow", 
        NULL 
    };
    RegisterClassExW(&wc);  // Было RegisterClassEx, теперь RegisterClassExW

    HWND hWnd = CreateWindowW(  // Было CreateWindow, теперь CreateWindowW
        L"TradingBotWindow", 
        L"TradingBot HFT v2.0", 
        WS_OVERLAPPEDWINDOW, 
        100, 100, 1200, 1200, 
        NULL, NULL, 
        wc.hInstance, 
        NULL
    );

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
    if (g_TradingBot) {
        g_OrderBookRenderer = std::make_unique<OrderBookRenderer>(
            g_Graphics.get(),
            g_TradingBot->GetSharedState()
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
            float headerHeight = 50.0f;

            // Header
            g_Graphics->DrawRectPixels(0, 0, screenWidth, headerHeight, 0.1f, 0.1f, 0.12f, 1.0f);
            g_Graphics->DrawRectPixels(0, headerHeight - 1.0f, screenWidth, 1.0f, 0.3f, 0.3f, 0.3f, 1.0f);

            g_Graphics->DrawTextPixels(L"TradingBot HFT v2.0", 20, 15, 200, 20, 14, 1.0f, 1.0f, 1.0f, 1.0f);
            g_Graphics->DrawTextPixels(L"BTCUSDT", 250, 15, 100, 20, 14, 0.8f, 0.8f, 1.0f, 1.0f);

            // Status
            std::wstring status = g_TradingBot ? L"RUNNING" : L"STOPPED";
            float statusR = g_TradingBot ? 0.0f : 1.0f;
            float statusG = g_TradingBot ? 1.0f : 0.0f;
            g_Graphics->DrawTextPixels(status, screenWidth - 120, 15, 100, 20, 14, statusR, statusG, 0.0f, 1.0f);

            // ═══════════════════════════════════════════════════════════════
            // НОВОЕ: Базовая визуализация Order Book
            // ═══════════════════════════════════════════════════════════════
            if (g_TradingBot) {
                auto sharedState = g_TradingBot->GetSharedState();
                if (sharedState) {
                    // Получаем метрики
                    auto metrics = sharedState->GetMetrics();
                    
                    float y = headerHeight + 20;
                    float x = 20;
                    
                    // Показываем латентность и staleness
                    std::wstringstream ss;
                    ss << L"Latency: " << metrics.latencyMs << L" ms";
                    g_Graphics->DrawTextPixels(ss.str(), x, y, 200, 20, 12, 0.8f, 1.0f, 0.8f, 1.0f);
                    
                    ss.str(L"");
                    ss << L"Staleness: " << metrics.stalenessMs << L" ms";
                    g_Graphics->DrawTextPixels(ss.str(), x, y + 20, 200, 20, 12, 0.8f, 1.0f, 0.8f, 1.0f);
                    
                    // Показываем что Order Book синхронизирован
                    g_Graphics->DrawTextPixels(L"Order Book: SYNCHRONIZED", x, y + 50, 300, 20, 14, 0.0f, 1.0f, 0.0f, 1.0f);
                    
                    // ═══════════════════════════════════════════════════════════
                    // НОВОЕ: GPU-accelerated Order Book Rendering
                    // ═══════════════════════════════════════════════════════════
                    if (g_OrderBookRenderer) {
                        float obX = 20;
                        float obY = headerHeight + 90;
                        float obWidth = screenWidth - 40;
                        float obHeight = screenHeight - headerHeight - 110;
                        
                        g_OrderBookRenderer->Render(obX, obY, obWidth, obHeight);
                    }
                }
            }

            g_Graphics->EndFrame();
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // Cleanup
    // ═══════════════════════════════════════════════════════════════
    OutputDebugStringA("[TradingBot] Shutting down...\n");
    
    g_Running = false;

    if (g_TradingBot) {
        g_TradingBot->Stop();
    }

    if (tradingBotThread.joinable()) {
        tradingBotThread.join();
    }

    OutputDebugStringA("[TradingBot] Shutdown complete\n");

    return (int)msg.wParam;
}