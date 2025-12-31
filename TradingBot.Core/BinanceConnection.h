#pragma once
#include <string>
#include <memory>
#include <thread>
#include <atomic>
#include <vector>
#include "SharedState.h"
#include "Types.h"

namespace TradingBot::Core::Network {

    class BinanceConnection {
    public:
        BinanceConnection(std::shared_ptr<SharedState> state);
        ~BinanceConnection();

        // Добавлен параметр mode
        void Connect(const std::string& symbol, MarketMode mode);
        void Disconnect();

        // Статический метод для получения списка монет (HTTP)
        static std::vector<SymbolInfo> GetExchangeInfo(MarketMode mode);

    private:
        void WebSocketThread(const std::string& symbol, MarketMode mode);
        void DownloadSnapshot(const std::string& symbol, MarketMode mode);

        // Вспомогательный метод для HTTP запросов
        static std::string PerformHttpRequest(const std::string& host, const std::string& path);

        std::shared_ptr<SharedState> state_;
        std::atomic<bool> running_;
        std::thread wsThread_;
    };
}