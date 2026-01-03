#pragma once
#include <d3d11.h>
#include <d2d1.h>
#include <dwrite.h>
#include <wrl/client.h>
#include <DirectXMath.h>
#include <vector>
#include <string>
#include <unordered_map>

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

    void DrawTextPixels(const std::wstring& text, float x, float y, float w, float h, float fontSize, float r, float g, float b, float a);
    void DrawTextCentered(const std::wstring& text, float centerX, float centerY, float fontSize, float r, float g, float b, float a);
    float MeasureTextWidth(const std::wstring& text, float fontSize);

    void DrawCirclePixels(float centerX, float centerY, float radius, float r, float g, float b, float a);
    void DrawEllipsePixels(float centerX, float centerY, float radiusX, float radiusY, float r, float g, float b, float a);

    float GetHeight() const { return height_; }
    float GetWidth() const { return width_; }

private:
    void FlushBatch();
    void CreateShaders();

    float PixelToNdcX(float x);
    float PixelToNdcY(float y);

    struct TextLayoutKey {
        std::wstring text;
        float width = 0;
        float height = 0;
        bool centered = false;

        bool operator==(const TextLayoutKey& o) const {
            return width == o.width && height == o.height && centered == o.centered && text == o.text;
        }
    };

    struct TextLayoutKeyHash {
        size_t operator()(const TextLayoutKey& k) const noexcept {
            size_t h = std::hash<std::wstring>{}(k.text);
            auto mix = [&](size_t v) { h ^= v + 0x9e3779b97f4a7c15ULL + (h << 6) + (h >> 2); };
            mix(std::hash<float>{}(k.width));
            mix(std::hash<float>{}(k.height));
            mix(std::hash<bool>{}(k.centered));
            return h;
        }
    };

    struct CachedLayout {
        ComPtr<IDWriteTextLayout> layout;
        uint64_t lastUsedFrame = 0;
    };

    ComPtr<IDWriteTextLayout> GetOrCreateLayout(const std::wstring& text, float w, float h, bool centered);
    void GarbageCollectLayouts();

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

    // text cache
    std::unordered_map<TextLayoutKey, CachedLayout, TextLayoutKeyHash> layoutCache_;
    uint64_t frameCounter_ = 0;

    float width_ = 0.0f;
    float height_ = 0.0f;
};