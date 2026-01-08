#pragma once
#include <string>

namespace TradingBot::Core {

    // ???????????????????????????????????????????????????????????????
    // Конфигурация подключения к Binance API
    // ???????????????????????????????????????????????????????????????
    struct BinanceConfig {
        // API Keys (optional для публичных streams)
        std::string apiKey;
        std::string secretKey;

        // Testnet или Production
        bool isTestnet = false;

        // Hostnames для REST API
        std::string spotRestHost;     // e.g. api.binance.com или testnet.binance.vision
        std::string futuresRestHost;  // e.g. fapi.binance.com или testnet.binancefuture.com
        
        // Hostnames для WebSocket (ВНИМАНИЕ: для Testnet streams используют production URLs!)
        std::string spotWsHost;       // e.g. stream.binance.com (для обоих!)
        std::string spotWsPort = "443";
        
        std::string futuresWsHost;    // e.g. fstream.binance.com (для обоих!)
        std::string futuresWsPort = "443";

        // Timeouts
        int connectionTimeoutMs = 5000;
        int requestTimeoutMs = 10000;

        // Retry settings
        int maxRetries = 3;
        int retryDelayMs = 1000;

        // Factory methods
        static BinanceConfig Production() {
            BinanceConfig cfg;
            cfg.isTestnet = false;
            cfg.spotRestHost = "api.binance.com";
            cfg.futuresRestHost = "fapi.binance.com";
            cfg.spotWsHost = "stream.binance.com";
            cfg.futuresWsHost = "fstream.binance.com";
            return cfg;
        }

        static BinanceConfig Testnet() {
            BinanceConfig cfg;
            cfg.isTestnet = true;
            // REST API использует testnet хосты
            cfg.spotRestHost = "testnet.binance.vision";
            cfg.futuresRestHost = "testnet.binancefuture.com";
            // WebSocket streams используют PRODUCTION хосты (это особенность Binance Testnet!)
            cfg.spotWsHost = "stream.binance.com";
            cfg.futuresWsHost = "fstream.binance.com";
            cfg.spotWsPort = "443";
            cfg.futuresWsPort = "443";
            return cfg;
        }
    };

} // namespace TradingBot::Core
