#pragma once
#include <d3d11.h>
#include <wrl/client.h> // Для ComPtr
#include <DirectXMath.h>
#include <vector>

// Используем ComPtr для автоматического управления памятью DX11
using Microsoft::WRL::ComPtr;

struct Vertex {
    float x, y, z;
    float r, g, b, a;
};

class Graphics {
public:
    Graphics();
    ~Graphics();

    bool Initialize(HWND hWnd);
    void BeginFrame(float r, float g, float b);
    void EndFrame();

    // Продвинутый рендеринг (Батчинг)
    void DrawRect(float x, float y, float w, float h, float r, float g, float b, float a);
    void FlushBatch(); // Отрисовать накопленное

private:
    void CreateShaders();

    ComPtr<ID3D11Device> device;
    ComPtr<ID3D11DeviceContext> context;
    ComPtr<IDXGISwapChain> swapChain;
    ComPtr<ID3D11RenderTargetView> target;

    ComPtr<ID3D11VertexShader> vertexShader;
    ComPtr<ID3D11PixelShader> pixelShader;
    ComPtr<ID3D11InputLayout> inputLayout;
    ComPtr<ID3D11Buffer> vertexBuffer;

    // Батчинг
    std::vector<Vertex> batchVertices;
    static const int MAX_VERTICES = 2048; // Размер буфера
};