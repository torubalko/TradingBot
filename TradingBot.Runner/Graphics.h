#pragma once
#include <d3d11.h>
#include <d2d1.h>
#include <dwrite.h>
#include <wrl/client.h>
#include <DirectXMath.h>
#include <vector>
#include <string>

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

    // Новые методы для рисования в ПИКСЕЛЯХ
    void DrawRectPixels(float x, float y, float w, float h, float r, float g, float b, float a);
    void DrawTextPixels(const std::wstring& text, float x, float y, float w, float h, float fontSize, float r, float g, float b, float a);

    // Получить высоту экрана в пикселях
    float GetHeight() const { return height_; }
    float GetWidth() const { return width_; }

private:
    void FlushBatch();
    void CreateShaders();

    // Хелпер для перевода пикселей в координаты DirectX (-1..1)
    float PixelToNdcX(float x);
    float PixelToNdcY(float y);

    ComPtr<ID3D11Device> device;
    ComPtr<ID3D11DeviceContext> context;
    ComPtr<IDXGISwapChain> swapChain;
    ComPtr<ID3D11RenderTargetView> target;

    ComPtr<ID3D11VertexShader> vertexShader;
    ComPtr<ID3D11PixelShader> pixelShader;
    ComPtr<ID3D11InputLayout> inputLayout;
    ComPtr<ID3D11Buffer> vertexBuffer;

    ComPtr<ID2D1Factory> d2dFactory;
    ComPtr<ID2D1RenderTarget> d2dRenderTarget;
    ComPtr<ID2D1SolidColorBrush> d2dBrush;
    ComPtr<IDWriteFactory> writeFactory;
    ComPtr<IDWriteTextFormat> textFormat;

    std::vector<Vertex> batchVertices;
    static const int MAX_VERTICES = 4096;
    bool isD2DDrawing = false;

    // Размеры экрана
    float width_ = 0.0f;
    float height_ = 0.0f;
};