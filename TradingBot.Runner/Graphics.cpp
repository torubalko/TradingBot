#include "Graphics.h"
#include <d3dcompiler.h>
#include <string>

#pragma comment(lib, "d3d11.lib")
#pragma comment(lib, "d3dcompiler.lib")
#pragma comment(lib, "d2d1.lib")
#pragma comment(lib, "dwrite.lib")

const char* VS_SRC = R"(
struct VS_IN { float3 pos : POSITION; float4 col : COLOR; };
struct PS_IN { float4 pos : SV_POSITION; float4 col : COLOR; };
PS_IN main(VS_IN input) {
    PS_IN output;
    output.pos = float4(input.pos, 1.0f);
    output.col = input.col;
    return output;
}
)";

const char* PS_SRC = R"(
struct PS_IN { float4 pos : SV_POSITION; float4 col : COLOR; };
float4 main(PS_IN input) : SV_Target {
    return input.col;
}
)";

Graphics::Graphics() {
    batchVertices.reserve(MAX_VERTICES);
}

Graphics::~Graphics() {}

bool Graphics::Initialize(HWND hWnd) {
    RECT rc;
    GetClientRect(hWnd, &rc);
    width_ = (float)(rc.right - rc.left);
    height_ = (float)(rc.bottom - rc.top);

    DXGI_SWAP_CHAIN_DESC scd = {};
    scd.BufferCount = 1;
    scd.BufferDesc.Width = (UINT)width_;
    scd.BufferDesc.Height = (UINT)height_;
    scd.BufferDesc.Format = DXGI_FORMAT_B8G8R8A8_UNORM;
    scd.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;
    scd.OutputWindow = hWnd;
    scd.SampleDesc.Count = 1;
    scd.Windowed = TRUE;
    scd.SwapEffect = DXGI_SWAP_EFFECT_DISCARD;

    UINT createDeviceFlags = D3D11_CREATE_DEVICE_BGRA_SUPPORT;
    HRESULT hr = D3D11CreateDeviceAndSwapChain(NULL, D3D_DRIVER_TYPE_HARDWARE, NULL, createDeviceFlags, NULL, 0, D3D11_SDK_VERSION, &scd, &swapChain, &device, NULL, &context);
    if (FAILED(hr)) return false;

    ComPtr<ID3D11Texture2D> backBuffer;
    swapChain->GetBuffer(0, IID_PPV_ARGS(&backBuffer));
    device->CreateRenderTargetView(backBuffer.Get(), NULL, &target);

    D2D1CreateFactory(D2D1_FACTORY_TYPE_SINGLE_THREADED, d2dFactory.GetAddressOf());
    DWriteCreateFactory(DWRITE_FACTORY_TYPE_SHARED, __uuidof(IDWriteFactory), (IUnknown**)writeFactory.GetAddressOf());

    ComPtr<IDXGISurface> dxgiBackBuffer;
    swapChain->GetBuffer(0, IID_PPV_ARGS(&dxgiBackBuffer));

    D2D1_RENDER_TARGET_PROPERTIES props = D2D1::RenderTargetProperties(
        D2D1_RENDER_TARGET_TYPE_DEFAULT,
        D2D1::PixelFormat(DXGI_FORMAT_UNKNOWN, D2D1_ALPHA_MODE_PREMULTIPLIED)
    );
    d2dFactory->CreateDxgiSurfaceRenderTarget(dxgiBackBuffer.Get(), &props, &d2dRenderTarget);
    d2dRenderTarget->CreateSolidColorBrush(D2D1::ColorF(D2D1::ColorF::White), &d2dBrush);

    // ‘ÓÏ‡Ú ‰Îˇ ÒÚ‡Í‡Ì‡ (—ÎÂ‚‡)
    writeFactory->CreateTextFormat(L"Segoe UI", NULL, DWRITE_FONT_WEIGHT_SEMI_BOLD, DWRITE_FONT_STYLE_NORMAL, DWRITE_FONT_STRETCH_NORMAL, 12.0f, L"en-us", &textFormat);
    textFormat->SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT_CENTER);
    textFormat->SetTextAlignment(DWRITE_TEXT_ALIGNMENT_LEADING);

    // ÕŒ¬Œ≈: ‘ÓÏ‡Ú ‰Îˇ ÔÛÁ˚¸ÍÓ‚ (÷ÂÌÚ)
    writeFactory->CreateTextFormat(L"Segoe UI", NULL, DWRITE_FONT_WEIGHT_BOLD, DWRITE_FONT_STYLE_NORMAL, DWRITE_FONT_STRETCH_NORMAL, 11.0f, L"en-us", &textFormatCenter);
    textFormatCenter->SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT_CENTER);
    textFormatCenter->SetTextAlignment(DWRITE_TEXT_ALIGNMENT_CENTER);

    D3D11_VIEWPORT vp = { 0, 0, width_, height_, 0.0f, 1.0f };
    context->RSSetViewports(1, &vp);

    CreateShaders();

    D3D11_BUFFER_DESC bd = {};
    bd.Usage = D3D11_USAGE_DYNAMIC;
    bd.ByteWidth = sizeof(Vertex) * MAX_VERTICES;
    bd.BindFlags = D3D11_BIND_VERTEX_BUFFER;
    bd.CPUAccessFlags = D3D11_CPU_ACCESS_WRITE;
    device->CreateBuffer(&bd, NULL, &vertexBuffer);

    return true;
}

void Graphics::CreateShaders() {
    ComPtr<ID3DBlob> vsBlob, psBlob;
    D3DCompile(VS_SRC, strlen(VS_SRC), NULL, NULL, NULL, "main", "vs_5_0", 0, 0, &vsBlob, NULL);
    device->CreateVertexShader(vsBlob->GetBufferPointer(), vsBlob->GetBufferSize(), NULL, &vertexShader);

    D3D11_INPUT_ELEMENT_DESC ied[] = {
        {"POSITION", 0, DXGI_FORMAT_R32G32B32_FLOAT, 0, 0, D3D11_INPUT_PER_VERTEX_DATA, 0},
        {"COLOR", 0, DXGI_FORMAT_R32G32B32A32_FLOAT, 0, 12, D3D11_INPUT_PER_VERTEX_DATA, 0},
    };
    device->CreateInputLayout(ied, 2, vsBlob->GetBufferPointer(), vsBlob->GetBufferSize(), &inputLayout);

    D3DCompile(PS_SRC, strlen(PS_SRC), NULL, NULL, NULL, "main", "ps_5_0", 0, 0, &psBlob, NULL);
    device->CreatePixelShader(psBlob->GetBufferPointer(), psBlob->GetBufferSize(), NULL, &pixelShader);
}

void Graphics::BeginFrame(float r, float g, float b) {
    if (isD2DDrawing) { d2dRenderTarget->EndDraw(); isD2DDrawing = false; }
    float color[] = { r, g, b, 1.0f };
    context->ClearRenderTargetView(target.Get(), color);
    context->OMSetRenderTargets(1, target.GetAddressOf(), NULL);
    context->VSSetShader(vertexShader.Get(), 0, 0);
    context->PSSetShader(pixelShader.Get(), 0, 0);
    context->IASetInputLayout(inputLayout.Get());
    batchVertices.clear();
}

void Graphics::FlushBatch() {
    if (batchVertices.empty()) return;
    D3D11_MAPPED_SUBRESOURCE ms;
    context->Map(vertexBuffer.Get(), 0, D3D11_MAP_WRITE_DISCARD, 0, &ms);
    memcpy(ms.pData, batchVertices.data(), sizeof(Vertex) * batchVertices.size());
    context->Unmap(vertexBuffer.Get(), 0);
    UINT stride = sizeof(Vertex), offset = 0;
    context->IASetVertexBuffers(0, 1, vertexBuffer.GetAddressOf(), &stride, &offset);
    context->IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
    context->Draw((UINT)batchVertices.size(), 0);
    batchVertices.clear();
}

float Graphics::PixelToNdcX(float x) { return (x / width_) * 2.0f - 1.0f; }
float Graphics::PixelToNdcY(float y) { return 1.0f - (y / height_) * 2.0f; }

void Graphics::DrawRectPixels(float x, float y, float w, float h, float r, float g, float b, float a) {
    if (batchVertices.size() + 6 >= MAX_VERTICES) FlushBatch();
    float left = PixelToNdcX(x);
    float right = PixelToNdcX(x + w);
    float top = PixelToNdcY(y);
    float bottom = PixelToNdcY(y + h);
    batchVertices.push_back({ left,  bottom, 0, r,g,b,a });
    batchVertices.push_back({ left,  top,    0, r,g,b,a });
    batchVertices.push_back({ right, bottom, 0, r,g,b,a });
    batchVertices.push_back({ right, bottom, 0, r,g,b,a });
    batchVertices.push_back({ left,  top,    0, r,g,b,a });
    batchVertices.push_back({ right, top,    0, r,g,b,a });
}

void Graphics::DrawTextPixels(const std::wstring& text, float x, float y, float w, float h, float fontSize, float r, float g, float b, float a) {
    FlushBatch();
    if (!isD2DDrawing) { d2dRenderTarget->BeginDraw(); isD2DDrawing = true; }
    d2dBrush->SetColor(D2D1::ColorF(r, g, b, a));
    D2D1_RECT_F layoutRect = D2D1::RectF(x, y - 2.0f, x + w, y + h - 2.0f);
    d2dRenderTarget->DrawTextW(text.c_str(), (UINT32)text.length(), textFormat.Get(), layoutRect, d2dBrush.Get());
}

// === ÕŒ¬Œ≈: –»—Œ¬¿Õ»≈ “≈ —“¿ œŒ ÷≈Õ“–” ===
void Graphics::DrawTextCentered(const std::wstring& text, float centerX, float centerY, float fontSize, float r, float g, float b, float a) {
    FlushBatch();
    if (!isD2DDrawing) { d2dRenderTarget->BeginDraw(); isD2DDrawing = true; }
    d2dBrush->SetColor(D2D1::ColorF(r, g, b, a));

    // –ËÒÛÂÏ ÔˇÏÓÛ„ÓÎ¸ÌËÍ ‚ÓÍÛ„ ˆÂÌÚ‡, ÚÂÍÒÚ ‚˚Ó‚ÌˇÂÚÒˇ Ò‡Ï
    float halfSize = 50.0f;
    D2D1_RECT_F layoutRect = D2D1::RectF(centerX - halfSize, centerY - halfSize, centerX + halfSize, centerY + halfSize);

    d2dRenderTarget->DrawTextW(text.c_str(), (UINT32)text.length(), textFormatCenter.Get(), layoutRect, d2dBrush.Get());
}

// === ÕŒ¬Œ≈: »«Ã≈–≈Õ»≈ “≈ —“¿ ===
float Graphics::MeasureTextWidth(const std::wstring& text, float fontSize) {
    ComPtr<IDWriteTextLayout> layout;
    writeFactory->CreateTextLayout(text.c_str(), (UINT32)text.length(), textFormatCenter.Get(), 1000.0f, 1000.0f, &layout);
    DWRITE_TEXT_METRICS metrics;
    layout->GetMetrics(&metrics);
    return metrics.width;
}

void Graphics::DrawCirclePixels(float centerX, float centerY, float radius, float r, float g, float b, float a) {
    FlushBatch();
    if (!isD2DDrawing) { d2dRenderTarget->BeginDraw(); isD2DDrawing = true; }
    d2dBrush->SetColor(D2D1::ColorF(r, g, b, a));
    D2D1_ELLIPSE ellipse = D2D1::Ellipse(D2D1::Point2F(centerX, centerY), radius, radius);
    d2dRenderTarget->FillEllipse(ellipse, d2dBrush.Get());
}

void Graphics::EndFrame() {
    FlushBatch();
    if (isD2DDrawing) { d2dRenderTarget->EndDraw(); isD2DDrawing = false; }
    swapChain->Present(1, 0);
}