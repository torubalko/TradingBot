#include "Graphics.h"
#include <d3dcompiler.h>
#include <string>

#pragma comment(lib, "d3d11.lib")
#pragma comment(lib, "d3dcompiler.lib")

// Шейдеры встроенные (Embedded HLSL) для упрощения
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

Graphics::~Graphics() {
    // ComPtr сам все очистит
}

bool Graphics::Initialize(HWND hWnd) {
    DXGI_SWAP_CHAIN_DESC scd = {};
    scd.BufferCount = 1;
    scd.BufferDesc.Format = DXGI_FORMAT_R8G8B8A8_UNORM;
    scd.BufferDesc.Width = 0;
    scd.BufferDesc.Height = 0;
    scd.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;
    scd.OutputWindow = hWnd;
    scd.SampleDesc.Count = 1;
    scd.Windowed = TRUE;
    scd.SwapEffect = DXGI_SWAP_EFFECT_DISCARD;

    // !!! ИСПРАВЛЕНИЕ ЗДЕСЬ !!!
    // БЫЛО: D3D11_CREATE_DEVICE_DEBUG
    // СТАЛО: 0
    // Это убирает требование SDK Layers, программа запустится на любом ПК
    UINT createDeviceFlags = 0;
#ifdef _DEBUG
    // Если очень хочется отладку и инструменты установлены, можно раскомментировать:
    // createDeviceFlags |= D3D11_CREATE_DEVICE_DEBUG;
#endif

    HRESULT hr = D3D11CreateDeviceAndSwapChain(
        NULL,
        D3D_DRIVER_TYPE_HARDWARE,
        NULL,
        createDeviceFlags, // <-- ИЗМЕНЕНО
        NULL,
        0,
        D3D11_SDK_VERSION,
        &scd,
        &swapChain,
        &device,
        NULL,
        &context);

    if (FAILED(hr)) {
        // Добавим вывод кода ошибки в Output для диагностики, если снова не запустится
        std::string msg = "D3D11CreateDevice Failed with code: " + std::to_string(hr) + "\n";
        OutputDebugStringA(msg.c_str());
        return false;
    }

    ComPtr<ID3D11Texture2D> backBuffer;
    swapChain->GetBuffer(0, __uuidof(ID3D11Texture2D), (void**)backBuffer.GetAddressOf());
    device->CreateRenderTargetView(backBuffer.Get(), NULL, &target);

    // Viewport
    D3D11_VIEWPORT vp = {};
    vp.Width = 1280;
    vp.Height = 800;
    vp.MinDepth = 0.0f;
    vp.MaxDepth = 1.0f;
    context->RSSetViewports(1, &vp);

    CreateShaders();

    // Динамический Vertex Buffer
    D3D11_BUFFER_DESC bd = {};
    bd.Usage = D3D11_USAGE_DYNAMIC;
    bd.ByteWidth = sizeof(Vertex) * MAX_VERTICES;
    bd.BindFlags = D3D11_BIND_VERTEX_BUFFER;
    bd.CPUAccessFlags = D3D11_CPU_ACCESS_WRITE;
    device->CreateBuffer(&bd, NULL, &vertexBuffer);

    return true;
}

void Graphics::CreateShaders() {
    ComPtr<ID3DBlob> vsBlob, psBlob, errBlob;

    // Компиляция VS
    // Добавим флаг D3DCOMPILE_DEBUG только в Debug конфигурации, но для компилятора это не так критично
    UINT compileFlags = 0; // D3DCOMPILE_ENABLE_STRICTNESS;

    D3DCompile(VS_SRC, strlen(VS_SRC), NULL, NULL, NULL, "main", "vs_5_0", compileFlags, 0, &vsBlob, &errBlob);
    if (errBlob) OutputDebugStringA((char*)errBlob->GetBufferPointer());
    device->CreateVertexShader(vsBlob->GetBufferPointer(), vsBlob->GetBufferSize(), NULL, &vertexShader);

    // Input Layout
    D3D11_INPUT_ELEMENT_DESC ied[] = {
        {"POSITION", 0, DXGI_FORMAT_R32G32B32_FLOAT, 0, 0, D3D11_INPUT_PER_VERTEX_DATA, 0},
        {"COLOR", 0, DXGI_FORMAT_R32G32B32A32_FLOAT, 0, 12, D3D11_INPUT_PER_VERTEX_DATA, 0},
    };
    device->CreateInputLayout(ied, 2, vsBlob->GetBufferPointer(), vsBlob->GetBufferSize(), &inputLayout);

    // Компиляция PS
    D3DCompile(PS_SRC, strlen(PS_SRC), NULL, NULL, NULL, "main", "ps_5_0", compileFlags, 0, &psBlob, &errBlob);
    device->CreatePixelShader(psBlob->GetBufferPointer(), psBlob->GetBufferSize(), NULL, &pixelShader);
}

void Graphics::BeginFrame(float r, float g, float b) {
    float color[] = { r, g, b, 1.0f };
    context->ClearRenderTargetView(target.Get(), color);
    context->OMSetRenderTargets(1, target.GetAddressOf(), NULL);

    // Установка шейдеров
    context->VSSetShader(vertexShader.Get(), 0, 0);
    context->PSSetShader(pixelShader.Get(), 0, 0);
    context->IASetInputLayout(inputLayout.Get());

    batchVertices.clear();
}

void Graphics::DrawRect(float x, float y, float w, float h, float r, float g, float b, float a) {
    if (batchVertices.size() + 6 >= MAX_VERTICES) {
        FlushBatch();
    }

    float left = x; float right = x + w;
    float top = y; float bottom = y - h;

    batchVertices.push_back({ left, bottom, 0, r,g,b,a });
    batchVertices.push_back({ left, top,    0, r,g,b,a });
    batchVertices.push_back({ right,bottom, 0, r,g,b,a });

    batchVertices.push_back({ right,bottom, 0, r,g,b,a });
    batchVertices.push_back({ left, top,    0, r,g,b,a });
    batchVertices.push_back({ right, top,   0, r,g,b,a });
}

void Graphics::FlushBatch() {
    if (batchVertices.empty()) return;

    D3D11_MAPPED_SUBRESOURCE ms;
    context->Map(vertexBuffer.Get(), 0, D3D11_MAP_WRITE_DISCARD, 0, &ms);
    memcpy(ms.pData, batchVertices.data(), sizeof(Vertex) * batchVertices.size());
    context->Unmap(vertexBuffer.Get(), 0);

    UINT stride = sizeof(Vertex);
    UINT offset = 0;
    context->IASetVertexBuffers(0, 1, vertexBuffer.GetAddressOf(), &stride, &offset);
    context->IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);

    context->Draw((UINT)batchVertices.size(), 0);

    batchVertices.clear();
}

void Graphics::EndFrame() {
    FlushBatch();
    swapChain->Present(1, 0);
}