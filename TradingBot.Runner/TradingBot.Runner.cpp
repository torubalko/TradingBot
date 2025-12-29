#include "BinanceConnection.h"
#include "Graphics.h"
#include "SharedState.h"
#include <string>
#include <thread>
#include <vector>
#include <cmath>
#include <iostream>
#include <atomic>

Graphics gfx;
std::shared_ptr<TradingBot::Core::SharedState> sharedState;
std::shared_ptr<TradingBot::Core::Network::BinanceConnection> client;
std::atomic<bool> running{ true };

const bool DIGITS[10][7] = {
    {1,1,1,0,1,1,1}, {0,0,1,0,0,1,0}, {1,0,1,1,1,0,1}, {1,0,1,1,0,1,1}, {0,1,1,1,0,1,0},
    {1,1,0,1,0,1,1}, {1,1,0,1,1,1,1}, {1,0,1,0,0,1,0}, {1,1,1,1,1,1,1}, {1,1,1,1,0,1,1}
};

void DrawDigit(float x, float y, int d, float size, float r, float g, float b) {
    if (d < 0 || d > 9) return;
    float t = size;
    float len = size * 3.0f;
    if (DIGITS[d][0]) gfx.DrawRect(x + t, y, len, t, r, g, b);
    if (DIGITS[d][1]) gfx.DrawRect(x, y + t, t, len, r, g, b);
    if (DIGITS[d][2]) gfx.DrawRect(x + len + t, y + t, t, len, r, g, b);
    if (DIGITS[d][3]) gfx.DrawRect(x + t, y + len + t, len, t, r, g, b);
    if (DIGITS[d][4]) gfx.DrawRect(x, y + len + 2 * t, t, len, r, g, b);
    if (DIGITS[d][5]) gfx.DrawRect(x + len + t, y + len + 2 * t, t, len, r, g, b);
    if (DIGITS[d][6]) gfx.DrawRect(x + t, y + 2 * len + 2 * t, len, t, r, g, b);
}

void DrawNumber(float x, float y, double val, int precision, float size, float r, float g, float b) {
    std::string s = std::to_string(val);
    size_t dot = s.find('.');
    if (dot != std::string::npos) s = s.substr(0, dot + 1 + precision);
    float curX = x;
    float step = size * 6.0f;
    for (char c : s) {
        if (c == '.') {
            gfx.DrawRect(curX + size, y + size * 7, size, size, r, g, b);
            curX += size * 3;
        }
        else {
            DrawDigit(curX, y, c - '0', size, r, g, b);
            curX += step;
        }
    }
}

void Render() {
   

    auto snap = sharedState->GetSnapshotForRender(80);
    int w = gfx.GetWidth();
    int h = gfx.GetHeight();

    gfx.BeginFrame(0.0f, 0.0f, 0.4f); // Тёмно-синий фон

    gfx.DrawRect(100, 100, 300, 300, 1.0f, 0.0f, 0.0f); // Тестовый квадрат

    if (snap.Asks.empty() && snap.Bids.empty()) {
        gfx.EndFrame();
        return;
    }

    float cy = h / 2.0f;
    float rowH = 22.0f;
    float fontSz = 1.0f;
    float maxVol = 2.0f;
    float priceX = w - 90.0f;
    float volW = w - 100.0f;

    // Asks
    for (size_t i = 0; i < snap.Asks.size(); ++i) {
        float y = cy - (i + 1) * rowH;
        if (y < -rowH) continue;
        double p = snap.Asks[i].first;
        double v = snap.Asks[i].second;
        float barLen = (float)((v / maxVol) * volW);
        if (barLen > volW) barLen = volW;
        gfx.DrawRect(0, y, (float)w, 1, 0.2f, 0.2f, 0.2f);
        gfx.DrawRect(priceX - barLen - 10, y + 2, barLen, rowH - 4, 0.8f, 0.2f, 0.2f);
        DrawNumber(priceX, y + 5, p, 1, fontSz, 1.0f, 1.0f, 1.0f);
        if (v > 0.01) DrawNumber(priceX - barLen - 50, y + 5, v, 3, fontSz, 0.7f, 0.7f, 0.7f);
    }

    // Bids
    for (size_t i = 0; i < snap.Bids.size(); ++i) {
        float y = cy + i * rowH;
        if (y > h) break;
        double p = snap.Bids[i].first;
        double v = snap.Bids[i].second;
        float barLen = (float)((v / maxVol) * volW);
        if (barLen > volW) barLen = volW;
        gfx.DrawRect(0, y, (float)w, 1, 0.2f, 0.2f, 0.2f);
        gfx.DrawRect(priceX - barLen - 10, y + 2, barLen, rowH - 4, 0.2f, 0.8f, 0.2f);
        DrawNumber(priceX, y + 5, p, 1, fontSz, 1.0f, 1.0f, 1.0f);
        if (v > 0.01) DrawNumber(priceX - barLen - 50, y + 5, v, 3, fontSz, 0.7f, 0.7f, 0.7f);
    }

    gfx.DrawRect(0, cy - 1, (float)w, 3, 1.0f, 1.0f, 0.0f); // Спред

    gfx.EndFrame();
}

LRESULT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam) {
    if (uMsg == WM_CLOSE || uMsg == WM_DESTROY) {
        running = false;
        PostQuitMessage(0);
        return 0;
    }
    return DefWindowProc(hwnd, uMsg, wParam, lParam);
}

int RunBot(HINSTANCE hInstance) {
    WNDCLASSEX wc = { sizeof(WNDCLASSEX), CS_OWNDC, WndProc, 0, 0, hInstance, nullptr, LoadCursor(nullptr, IDC_ARROW), nullptr, nullptr, L"TigerBotClass", nullptr };
    RegisterClassEx(&wc);

    int scrW = GetSystemMetrics(SM_CXSCREEN);
    int scrH = GetSystemMetrics(SM_CYSCREEN);
    int winW = 500;
    int winH = 900;

    HWND hwnd = CreateWindowEx(0, L"TigerBotClass", L"TIGER X - DIRECTX ENGINE",
        WS_OVERLAPPEDWINDOW | WS_VISIBLE,
        (scrW - winW) / 2, (scrH - winH) / 2, winW, winH,
        nullptr, nullptr, hInstance, nullptr);

    if (!gfx.Initialize(hwnd, winW, winH)) return -1;

    sharedState = std::make_shared<TradingBot::Core::SharedState>();
    client = std::make_shared<TradingBot::Core::Network::BinanceConnection>(sharedState);

    std::thread netThread([&]() { client->Connect("btcusdt", false); });
    netThread.detach();

    MSG msg = {};
    while (running) {
        if (PeekMessage(&msg, nullptr, 0, 0, PM_REMOVE)) {
            if (msg.message == WM_QUIT) break;
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
        else {
            Render();
            std::this_thread::sleep_for(std::chrono::milliseconds(16));
        }
    }

    client->Stop();
    
    return 0;
}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE, LPSTR, int) {
    return RunBot(hInstance);
}