#include "Graphics.h"
#include <iostream>

const char* VS_SRC = R"(
struct VS_INPUT {
    float3 pos : POSITION;
    float4 col : COLOR;
};
struct PS_INPUT {
    float4 pos : SV_POSITION;
    float4 col : COLOR;
};
PS_INPUT main(VS_INPUT input) {
    PS_INPUT output;
    output.pos = float4(input.pos.x, input.pos.y, 0.5f, 1.0f);
    output.col = input.col;
    return output;
}
)";

const char* PS_SRC = R"(
struct PS_INPUT {
    float4 pos : SV_POSITION;
    float4 col : COLOR;
};
float4 main(PS_INPUT input) : SV_Target {
    return input.col;
}
)";

Graphics::Graphics() {}
Graphics::~Graphics() {
    if (rasterState_) rasterState_->Release();
    if (vertexBuffer_) vertexBuffer_->Release();
    if (inputLayout_) inputLayout_->Release();
    if (vertexShader_) vertexShader_->Release();
    if (pixelShader_) pixelShader_->Release();
    if (target_) target_->Release();
    if (swapChain_) swapChain_->Release();
    if (context_) context_->Release();
    if (device_) device_->Release();
}

bool Graphics::Initialize(HWND hwnd, int width, int height) {
    width_ = width;
    height_ = height;

    DXGI_SWAP_CHAIN_DESC scd = {};
    scd.BufferDesc.Width = width;
    scd.BufferDesc.Height = height;
    scd.BufferDesc.Format = DXGI_FORMAT_R8G8B8A8_UNORM;
    scd.SampleDesc.Count = 1;
    scd.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;
    scd.BufferCount = 1;
    scd.OutputWindow = hwnd;
    scd.Windowed = TRUE;
    scd.SwapEffect = DXGI_SWAP_EFFECT_DISCARD;

    HRESULT hr = D3D11CreateDeviceAndSwapChain(nullptr, D3D_DRIVER_TYPE_HARDWARE, nullptr, 0, nullptr, 0,
        D3D11_SDK_VERSION, &scd, &swapChain_, &device_, nullptr, &context_);
    if (FAILED(hr)) return false;

    ID3D11Texture2D* backBuffer = nullptr;
    swapChain_->GetBuffer(0, __uuidof(ID3D11Texture2D), (void**)&backBuffer);
    device_->CreateRenderTargetView(backBuffer, nullptr, &target_);
    backBuffer->Release();

    D3D11_VIEWPORT vp;
    vp.Width = (float)width;
    vp.Height = (float)height;
    vp.MinDepth = 0.0f;
    vp.MaxDepth = 1.0f;
    vp.TopLeftX = 0;
    vp.TopLeftY = 0;
    context_->RSSetViewports(1, &vp);

    D3D11_RASTERIZER_DESC rd = {};
    rd.FillMode = D3D11_FILL_SOLID;
    rd.CullMode = D3D11_CULL_NONE;
    device_->CreateRasterizerState(&rd, &rasterState_);
    context_->RSSetState(rasterState_);

    batchVertices_.reserve(MAX_VERTICES);
    return InitShaders();
}

bool Graphics::InitShaders() {
    ID3DBlob* blob = nullptr;
    ID3DBlob* errorBlob = nullptr;

    HRESULT hr = D3DCompile(VS_SRC, strlen(VS_SRC), nullptr, nullptr, nullptr, "main", "vs_5_0", 0, 0, &blob, &errorBlob);
    if (FAILED(hr)) {
        if (errorBlob) {
            std::cout << "VS error: " << (char*)errorBlob->GetBufferPointer() << std::endl;
            errorBlob->Release();
        }
        return false;
    }
    device_->CreateVertexShader(blob->GetBufferPointer(), blob->GetBufferSize(), nullptr, &vertexShader_);

    D3D11_INPUT_ELEMENT_DESC ied[] = {
        {"POSITION", 0, DXGI_FORMAT_R32G32B32_FLOAT, 0, 0, D3D11_INPUT_PER_VERTEX_DATA, 0},
        {"COLOR", 0, DXGI_FORMAT_R32G32B32A32_FLOAT, 0, 12, D3D11_INPUT_PER_VERTEX_DATA, 0},
    };
    device_->CreateInputLayout(ied, 2, blob->GetBufferPointer(), blob->GetBufferSize(), &inputLayout_);
    blob->Release();

    hr = D3DCompile(PS_SRC, strlen(PS_SRC), nullptr, nullptr, nullptr, "main", "ps_5_0", 0, 0, &blob, &errorBlob);
    if (FAILED(hr)) {
        if (errorBlob) {
            std::cout << "PS error: " << (char*)errorBlob->GetBufferPointer() << std::endl;
            errorBlob->Release();
        }
        return false;
    }
    device_->CreatePixelShader(blob->GetBufferPointer(), blob->GetBufferSize(), nullptr, &pixelShader_);
    blob->Release();

    D3D11_BUFFER_DESC bufDesc = {};
    bufDesc.Usage = D3D11_USAGE_DYNAMIC;
    bufDesc.ByteWidth = sizeof(Vertex) * MAX_VERTICES;
    bufDesc.BindFlags = D3D11_BIND_VERTEX_BUFFER;
    bufDesc.CPUAccessFlags = D3D11_CPU_ACCESS_WRITE;
    device_->CreateBuffer(&bufDesc, nullptr, &vertexBuffer_);

    return true;
}

void Graphics::BeginFrame(float r, float g, float b) {
    const float color[] = { r, g, b, 1.0f };
    context_->ClearRenderTargetView(target_, color);

    context_->OMSetRenderTargets(1, &target_, nullptr);
    context_->IASetInputLayout(inputLayout_);
    context_->VSSetShader(vertexShader_, nullptr, 0);
    context_->PSSetShader(pixelShader_, nullptr, 0);
    context_->IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
    context_->RSSetState(rasterState_);

    batchVertices_.clear();
}

void Graphics::DrawRect(float x, float y, float w, float h, float r, float g, float b) {
    DrawRectAlpha(x, y, w, h, r, g, b, 1.0f);
}

void Graphics::DrawRectAlpha(float x, float y, float w, float h, float r, float g, float b, float a) {
    if (batchVertices_.size() + 6 >= MAX_VERTICES) return;

    float fW = (float)width_;
    float fH = (float)height_;

    float x1 = (x / fW) * 2.0f - 1.0f;
    float y1 = -((y / fH) * 2.0f - 1.0f);
    float x2 = ((x + w) / fW) * 2.0f - 1.0f;
    float y2 = -(((y + h) / fH) * 2.0f - 1.0f);

    batchVertices_.push_back({ x1, y1, 0.0f, r, g, b, a });
    batchVertices_.push_back({ x2, y1, 0.0f, r, g, b, a });
    batchVertices_.push_back({ x1, y2, 0.0f, r, g, b, a });
    batchVertices_.push_back({ x2, y1, 0.0f, r, g, b, a });
    batchVertices_.push_back({ x2, y2, 0.0f, r, g, b, a });
    batchVertices_.push_back({ x1, y2, 0.0f, r, g, b, a });
}

void Graphics::RenderBatch() {
    if (batchVertices_.empty()) return;

    D3D11_MAPPED_SUBRESOURCE ms;
    context_->Map(vertexBuffer_, 0, D3D11_MAP_WRITE_DISCARD, 0, &ms);
    memcpy(ms.pData, batchVertices_.data(), sizeof(Vertex) * batchVertices_.size());
    context_->Unmap(vertexBuffer_, 0);

    UINT stride = sizeof(Vertex);
    UINT offset = 0;
    context_->IASetVertexBuffers(0, 1, &vertexBuffer_, &stride, &offset);
    context_->Draw((UINT)batchVertices_.size(), 0);
}

void Graphics::EndFrame() {
    RenderBatch();
    swapChain_->Present(1, 0);
}