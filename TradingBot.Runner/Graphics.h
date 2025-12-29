#pragma once

// === ИСПРАВЛЕНИЕ КОНФЛИКТА WINSOCK ===
// Эти две строки обязательны перед <Windows.h>, иначе будет конфликт с Boost/Network
#ifndef WIN32_LEAN_AND_MEAN
#define WIN32_LEAN_AND_MEAN
#endif
#define _WINSOCKAPI_ // Запрещаем Windows.h подключать старый сокет
// =====================================

#include <Windows.h>
#include <d3d11.h>
#include <d3dcompiler.h>
#include <vector>

#pragma comment(lib, "d3d11.lib")
#pragma comment(lib, "d3dcompiler.lib")

struct Vertex {
    float x, y, z;
    float r, g, b, a;
};

class Graphics {
public:
    Graphics();
    ~Graphics();

    bool Initialize(HWND hwnd, int width, int height);

    void BeginFrame(float r, float g, float b);
    void EndFrame();

    // Обычный прямоугольник
    void DrawRect(float x, float y, float w, float h, float r, float g, float b);

    // Прямоугольник с прозрачностью (Alpha)
    void DrawRectAlpha(float x, float y, float w, float h, float r, float g, float b, float a);

    int GetWidth() const { return width_; }
    int GetHeight() const { return height_; }

private:
    bool InitShaders();
    void RenderBatch();

    ID3D11Device* device_ = nullptr;
    ID3D11DeviceContext* context_ = nullptr;
    IDXGISwapChain* swapChain_ = nullptr;
    ID3D11RenderTargetView* target_ = nullptr;

    ID3D11VertexShader* vertexShader_ = nullptr;
    ID3D11PixelShader* pixelShader_ = nullptr;
    ID3D11InputLayout* inputLayout_ = nullptr;
    ID3D11Buffer* vertexBuffer_ = nullptr;

    ID3D11BlendState* blendState_ = nullptr;
    ID3D11RasterizerState* rasterState_ = nullptr;
    ID3D11DepthStencilState* depthState_ = nullptr;

    std::vector<Vertex> batchVertices_;
    const size_t MAX_VERTICES = 500000;

    int width_ = 0;
    int height_ = 0;
};