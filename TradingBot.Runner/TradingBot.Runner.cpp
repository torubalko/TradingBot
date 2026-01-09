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
#include "OrderBookRenderer.h"
#include "BinanceFeedAdapter.h"
#include "../BinanceDataFeed/HighSpeedDataFeed.h"

using TradingBot::Core::SharedState;
using TradingBot::Core::ExternalMetricsSnapshot;

std::unique_ptr<Graphics> g_Graphics;
std::unique_ptr<OrderBookRenderer> g_OrderBookRenderer;
std::shared_ptr<SharedState> g_SharedState;
std::atomic<bool> g_Running(true);

std::unique_ptr<hft::BinanceDataFeed> g_Feed;
std::unique_ptr<BinanceFeedAdapter> g_FeedAdapter;

std::vector<int> g_Scales = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000 };
int g_ScaleIndex = 0;

// ═══════════════════════════════════════════════════════════════
// Trading Bot Thread: Запуск основной логики бота
// ═══════════════════════════════════════════════════════════════

void TradingBotThreadFunc() {
    try {
        OutputDebugStringA("[TradingBot] Initializing BinanceDataFeed...\n");

        g_SharedState = std::make_shared<SharedState>();
        g_FeedAdapter = std::make_unique<BinanceFeedAdapter>(g_SharedState);

        hft::DataFeedConfig cfg;
        cfg.subscribeDepth = true;
        cfg.subscribeBookTicker = true;
        cfg.subscribeAggTrade = true;
        cfg.depthSpeed = "@100ms";
        cfg.numParserThreads = std::max<int>(4, static_cast<int>(std::thread::hardware_concurrency()));
        cfg.messageQueueSize = 32768;
        cfg.enableLatencyTracking = true;
        cfg.enableDetailedLogging = false;

        g_Feed = std::make_unique<hft::BinanceDataFeed>(cfg);

        g_Feed->SetDepthUpdateCallback([adapter = g_FeedAdapter.get()](const std::string& sym, const hft::ParsedDepthUpdate& upd) {
            if (adapter) adapter->OnDepth(sym, upd);
        });
        g_Feed->SetBookTickerCallback([adapter = g_FeedAdapter.get()](const std::string& sym, const hft::ParsedBookTicker& bt) {
            if (adapter) adapter->OnBookTicker(sym, bt);
        });
        g_Feed->SetAggTradeCallback([adapter = g_FeedAdapter.get()](const std::string& sym, const hft::ParsedAggTrade& tr) {
            if (adapter) adapter->OnAggTrade(sym, tr);
        });

        g_Feed->Start();

        // Metrics pump: update external metrics every 200 ms
        while (g_Running) {
            ExternalMetricsSnapshot snap{};
            auto& lt = g_Feed->GetLatencyTracker();
            snap.exchLatencyNs = lt.GetExchangeAvgNs();
            snap.netLatencyNs = lt.GetNetworkAvgNs();
            snap.enqueueLatencyNs = lt.GetEnqueueAvgNs();
            snap.parseLatencyNs = lt.GetParseAvgNs();
            snap.processLatencyNs = lt.GetProcessAvgNs();
            snap.callbackLatencyNs = lt.GetCallbackAvgNs();
            snap.procChainLatencyNs = snap.enqueueLatencyNs + snap.parseLatencyNs + snap.processLatencyNs + snap.callbackLatencyNs;
            snap.endToEndP99Ns = lt.GetEndToEndP99Ms() * 1'000'000; // ms->ns
            snap.messagesPerSecond = lt.GetMessagesPerSecond();
            snap.droppedMessages = g_Feed->GetDroppedMessages();
            snap.queueHighWater = g_Feed->GetQueueHighWaterMark();
            g_SharedState->UpdateExternalMetrics(snap);

            std::this_thread::sleep_for(std::chrono::milliseconds(200));
        }

        g_Feed->Stop();
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
        if (g_Feed) g_Feed->Stop();
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
    // Detach console to keep only the graphics window
    FreeConsole();

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
    if (g_SharedState) {
        g_OrderBookRenderer = std::make_unique<OrderBookRenderer>(
            g_Graphics.get(),
            g_SharedState
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
            bool runningFeed = (g_Feed != nullptr);
            std::wstring status = runningFeed ? L"RUNNING" : L"STOPPED";
            float statusR = runningFeed ? 0.0f : 1.0f;
            float statusG = runningFeed ? 1.0f : 0.0f;
            g_Graphics->DrawTextPixels(status, screenWidth - 120, 15, 100, 20, 14, statusR, statusG, 0.0f, 1.0f);

            if (g_SharedState) {
                auto sharedState = g_SharedState;
                // Получаем метрики
                auto metrics = sharedState->GetMetrics();
                auto ext = sharedState->GetExternalMetrics();
                
                float y = headerHeight + 20;
                float x = 20;
                
                // Latency/staleness in milliseconds
                std::wstringstream ss;
                ss << L"Latency: " << metrics.latencyMs << L" ms";
                g_Graphics->DrawTextPixels(ss.str(), x, y, 250, 18, 12, 0.8f, 1.0f, 0.8f, 1.0f);
                ss.str(L""); ss.clear();
                ss << L"Staleness: " << metrics.stalenessMs << L" ms";
                g_Graphics->DrawTextPixels(ss.str(), x, y + 18, 250, 18, 12, 0.8f, 1.0f, 0.8f, 1.0f);

                auto toMs = [](long long ns) { return ns / 1'000'000.0; };

                float yExt = y + 40;
                ss.str(L""); ss.clear();
                ss << L"Net " << std::fixed << std::setprecision(3) << toMs(ext.netLatencyNs) << L" ms"
                   << L" | Proc " << toMs(ext.procChainLatencyNs) << L" ms";
                g_Graphics->DrawTextPixels(ss.str(), x, yExt, 400, 18, 12, 0.8f, 0.9f, 1.0f, 1.0f);

                ss.str(L""); ss.clear();
                ss << L"E2E P99 " << toMs(ext.endToEndP99Ns) << L" ms"
                   << L" | Drops " << ext.droppedMessages
                   << L" | Qmax " << ext.queueHighWater
                   << L" | " << ext.messagesPerSecond << L" msg/s";
                g_Graphics->DrawTextPixels(ss.str(), x, yExt + 18, 520, 18, 12, 0.8f, 0.9f, 1.0f, 1.0f);

                // Order Book visualization
                if (g_OrderBookRenderer) {
                    float obX = 20;
                    float obY = headerHeight + 120;
                    float obWidth = screenWidth - 40;
                    float obHeight = screenHeight - headerHeight - 140;
                    g_OrderBookRenderer->Render(obX, obY, obWidth, obHeight);
                }
            }

            g_Graphics->EndFrame();
            std::this_thread::sleep_for(std::chrono::milliseconds(1));
        }
    }

    OutputDebugStringA("[TradingBot] Shutting down...\n");
    g_Running = false;
    if (g_Feed) g_Feed->Stop();
    if (tradingBotThread.joinable()) tradingBotThread.join();
    OutputDebugStringA("[TradingBot] Shutdown complete\n");

    return (int)msg.wParam;
}