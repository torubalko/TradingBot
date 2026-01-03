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
    void Resize(HWND hWnd);
    void BeginFrame(float r, float g, float b);
    void EndFrame();

    void DrawRectPixels(float x, float y, float w, float h, float r, float g, float b, float a);

    // Текст
    void DrawTextPixels(const std::wstring& text, float x, float y, float w, float h, float fontSize, float r, float g, float b, float a);
    void DrawTextCentered(const std::wstring& text, float centerX, float centerY, float fontSize, float r, float g, float b, float a);
    float MeasureTextWidth(const std::wstring& text, float fontSize);

    // Круг (для обычных сделок)
    void DrawCirclePixels(float centerX, float centerY, float radius, float r, float g, float b, float a);

    // НОВОЕ: Овал (Эллипс) для растянутых сделок
    void DrawEllipsePixels(float centerX, float centerY, float radiusX, float radiusY, float r, float g, float b, float a);

    float GetHeight() const { return height_; }
    float GetWidth() const { return width_; }

private:
    void FlushBatch();
    void CreateShaders();

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
    ComPtr<IDWriteTextFormat> textFormatCenter;

    std::vector<Vertex> batchVertices;
    static const int MAX_VERTICES = 4096;
    bool isD2DDrawing = false;

    float width_ = 0.0f;
    float height_ = 0.0f;
};