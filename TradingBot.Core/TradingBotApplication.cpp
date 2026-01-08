#include "TradingBotApplication.h"
#include "BinanceConfig.h"
#include <iostream>
#include <thread>
#include <chrono>
#include <csignal>
#include <fstream>
#include <nlohmann/json.hpp>

namespace TradingBot::Core {

    static std::atomic<bool> g_shutdownRequested{false};

    void SignalHandler(int signal) {
        std::cout << "\n[SIGNAL] Shutdown requested (signal " << signal << ")" << std::endl;
        g_shutdownRequested.store(true, std::memory_order_release);
    }

    TradingBotApplication::TradingBotApplication()
        : sharedState_(std::make_shared<SharedState>())
    {
        std::signal(SIGINT, SignalHandler);
        std::signal(SIGTERM, SignalHandler);
    }

    TradingBotApplication::~TradingBotApplication() {
        Stop();
    }

    bool TradingBotApplication::Initialize(const std::string& configPath) {
        std::cout << "[TradingBotApplication] Initializing..." << std::endl;

        // ???????????????????????????????????????????????????????????????
        // Загрузка конфигурации из config.json
        // ???????????????????????????????????????????????????????????????
        
        BinanceConfig binanceConfig;
        
        try {
            std::ifstream configFile(configPath);
            if (!configFile.is_open()) {
                std::cerr << "[TradingBotApplication] Failed to open config file: " 
                          << configPath << std::endl;
                return false;
            }

            nlohmann::json config;
            configFile >> config;

            // Парсинг API секции
            if (config.contains("api")) {
                auto& apiCfg = config["api"];
                
                binanceConfig.apiKey = apiCfg.value("apiKey", "");
                binanceConfig.secretKey = apiCfg.value("secretKey", "");
                binanceConfig.isTestnet = apiCfg.value("isTestnet", false);
                
                if (binanceConfig.isTestnet) {
                    // Testnet URLs
                    binanceConfig.spotRestHost = "testnet.binance.vision";
                    binanceConfig.futuresRestHost = "testnet.binancefuture.com";
                    // WebSocket streams используют PRODUCTION хосты!
                    binanceConfig.spotWsHost = "stream.binance.com";
                    binanceConfig.futuresWsHost = "fstream.binance.com";
                    binanceConfig.spotWsPort = "443";
                    binanceConfig.futuresWsPort = "443";
                } else {
                    // Production URLs
                    binanceConfig.spotRestHost = "api.binance.com";
                    binanceConfig.futuresRestHost = "fapi.binance.com";
                    binanceConfig.spotWsHost = "stream.binance.com";
                    binanceConfig.futuresWsHost = "fstream.binance.com";
                    binanceConfig.spotWsPort = "443";
                    binanceConfig.futuresWsPort = "443";
                }
                
                binanceConfig.connectionTimeoutMs = apiCfg.value("connectionTimeoutMs", 5000);
                binanceConfig.requestTimeoutMs = apiCfg.value("requestTimeoutMs", 10000);
                binanceConfig.maxRetries = apiCfg.value("maxRetries", 3);
                binanceConfig.retryDelayMs = apiCfg.value("retryDelayMs", 1000);
                
                std::cout << "[TradingBotApplication] Config loaded: "
                          << (binanceConfig.isTestnet ? "TESTNET" : "PRODUCTION") << std::endl;
            }
        } catch (const std::exception& e) {
            std::cerr << "[TradingBotApplication] Failed to parse config: " 
                      << e.what() << std::endl;
            return false;
        }

        // Создание BinanceConnector с конфигурацией
        binanceConnector_ = std::make_unique<Network::BinanceConnector>(
            sharedState_,
            binanceConfig
        );

        std::cout << "[TradingBotApplication] Initialization complete" << std::endl;
        return true;
    }

    void TradingBotApplication::Start() {
        if (running_.load(std::memory_order_acquire)) {
            return;
        }

        std::cout << "[TradingBotApplication] Starting..." << std::endl;
        running_.store(true, std::memory_order_release);

        binanceConnector_->Start("BTCUSDT");

        telemetryThread_ = std::thread(&TradingBotApplication::TelemetryThreadLoop, this);

        std::cout << "[TradingBotApplication] Started" << std::endl;
    }

    void TradingBotApplication::Stop() {
        if (!running_.load(std::memory_order_acquire)) {
            return;
        }

        std::cout << "[TradingBotApplication] Stopping..." << std::endl;
        running_.store(false, std::memory_order_release);

        binanceConnector_->Stop();

        if (telemetryThread_.joinable()) {
            telemetryThread_.join();
        }

        GracefulShutdown();
        std::cout << "[TradingBotApplication] Stopped" << std::endl;
    }

    void TradingBotApplication::Run() {
        std::cout << "[TradingBotApplication] Main loop started" << std::endl;
        MainThreadLoop();
        std::cout << "[TradingBotApplication] Main loop finished" << std::endl;
    }

    void TradingBotApplication::MainThreadLoop() {
        // ???????????????????????????????????????????????????????????????
        // MAIN THREAD LOOP: Просто ждём сигнала остановки
        // 
        // Order Book snapshot теперь публикуется НЕМЕДЛЕННО при каждом
        // update в SharedState::ApplyUpdate() - это НАМНОГО быстрее!
        // ???????????????????????????????????????????????????????????????
        
        while (running_.load(std::memory_order_acquire) && 
               !g_shutdownRequested.load(std::memory_order_acquire)) 
        {
            // Спим короткое время
            std::this_thread::sleep_for(std::chrono::milliseconds(100));
        }
    }

    void TradingBotApplication::TelemetryThreadLoop() {
        while (running_.load(std::memory_order_acquire)) {
            std::this_thread::sleep_for(std::chrono::seconds(5));
            
            if (!running_.load(std::memory_order_acquire)) {
                break;
            }

            std::cout << "[Telemetry] Running..." << std::endl;
        }
    }

    void TradingBotApplication::GracefulShutdown() {
        std::cout << "[TradingBotApplication] Graceful shutdown..." << std::endl;
    }

} // namespace TradingBot::Core
