#pragma once
#include <string>
#include <memory>
#include <vector>
#include <functional>
#include <map>
#include "WebSocketSession.h"
#include "../Types.h"

namespace TradingBot::Core::Network {
    using DataCallback = std::function<void(const std::string&, MarketMode)>;

    struct FeedConfig {
        std::string symbol;
        MarketMode mode;
        bool subscribeDepth;
        bool subscribeAggTrades;
        std::string depthUpdateSpeed; // "100ms" or "1000ms"
    };

    class DataFeedManager {
    public:
        DataFeedManager() = default;

        ~DataFeedManager() {
            DisconnectAll();
        }

        void Subscribe(
            const FeedConfig& config,
            DataCallback onData,
            ErrorCallback onError = nullptr
        ) {
            std::string key = GenerateKey(config.symbol, config.mode);

            // Disconnect existing connection if any
            if (sessions_.count(key)) {
                sessions_[key]->Disconnect();
                sessions_.erase(key);
            }

            // Build stream names
            std::string lowerSymbol = ToLowerCase(config.symbol);
            std::vector<std::string> streams;

            if (config.subscribeDepth) {
                streams.push_back(lowerSymbol + "@depth@" + config.depthUpdateSpeed);
            }

            if (config.subscribeAggTrades) {
                streams.push_back(lowerSymbol + "@aggTrade");
            }

            if (streams.empty()) {
                return; // Nothing to subscribe
            }

            // Build WebSocket path
            std::string path = "/stream?streams=";
            for (size_t i = 0; i < streams.size(); ++i) {
                if (i > 0) path += "/";
                path += streams[i];
            }

            // Determine host based on market mode
            std::string host = GetHost(config.mode);

            // Create and connect session
            auto session = std::make_shared<WebSocketSession>();
            
            session->Connect(
                host,
                path,
                [onData, mode = config.mode](const std::string& msg) {
                    if (onData) {
                        onData(msg, mode);
                    }
                },
                onError
            );

            sessions_[key] = session;
        }

        void Unsubscribe(const std::string& symbol, MarketMode mode) {
            std::string key = GenerateKey(symbol, mode);
            if (sessions_.count(key)) {
                sessions_[key]->Disconnect();
                sessions_.erase(key);
            }
        }

        void DisconnectAll() {
            for (auto& [key, session] : sessions_) {
                session->Disconnect();
            }
            sessions_.clear();
        }

        bool IsConnected(const std::string& symbol, MarketMode mode) const {
            std::string key = GenerateKey(symbol, mode);
            auto it = sessions_.find(key);
            return it != sessions_.end() && it->second->IsConnected();
        }

        std::vector<std::string> GetActiveSubscriptions() const {
            std::vector<std::string> active;
            for (const auto& [key, session] : sessions_) {
                if (session->IsConnected()) {
                    active.push_back(key);
                }
            }
            return active;
        }

        static std::string GetRestApiHost(MarketMode mode) {
            return (mode == MarketMode::FUTURES) ? "fapi.binance.com" : "api.binance.com";
        }

        static std::string GetRestApiDepthPath(const std::string& symbol, MarketMode mode, int limit = 1000) {
            std::string endpoint = (mode == MarketMode::FUTURES) ? "/fapi/v1/depth" : "/api/v3/depth";
            return endpoint + "?symbol=" + symbol + "&limit=" + std::to_string(limit);
        }

        static std::string GetRestApiExchangeInfoPath(MarketMode mode) {
            return (mode == MarketMode::FUTURES) ? "/fapi/v1/exchangeInfo" : "/api/v3/exchangeInfo";
        }

    private:
        std::string GenerateKey(const std::string& symbol, MarketMode mode) const {
            return symbol + "_" + (mode == MarketMode::FUTURES ? "FUTURES" : "SPOT");
        }

        std::string GetHost(MarketMode mode) const {
            return (mode == MarketMode::FUTURES) ? "fstream.binance.com" : "stream.binance.com";
        }

        std::string ToLowerCase(const std::string& str) const {
            std::string result = str;
            for (char& c : result) {
                c = std::tolower(static_cast<unsigned char>(c));
            }
            return result;
        }

        std::map<std::string, std::shared_ptr<WebSocketSession>> sessions_;
    };
}
