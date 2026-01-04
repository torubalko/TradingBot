#pragma once
#include <memory>
#include <string>
#include <atomic>
#include <thread>
#include <array>
#include <vector>
#include <deque>
#include <charconv>
#include <string_view>

#include <boost/beast/core.hpp>
#include <boost/beast/ssl.hpp>
#include <boost/beast/websocket.hpp>
#include <boost/asio/ip/tcp.hpp>
#include <boost/asio/ssl/stream.hpp>
#include <boost/lockfree/spsc_queue.hpp>

#include "simdjson.h"
#include "SharedState.h"
#include "Types.h"

namespace TradingBot::Core::Network {

    namespace beast = boost::beast;
    namespace websocket = beast::websocket;
    namespace net = boost::asio;
    namespace ssl = boost::asio::ssl;
    using tcp = boost::asio::ip::tcp;

    // ═══════════════════════════════════════════════════════════════
    // Pre-allocated структуры для Zero-Allocation в Hot Path
    // ═══════════════════════════════════════════════════════════════

    // Object Pool для переиспользования OrderBookUpdate структур
    template<typename T, size_t PoolSize = 256>
    class ObjectPool {
    public:
        ObjectPool() {
            // PRE-ALLOCATION: Выделяем всю память при старте
            pool_.reserve(PoolSize);
            for (size_t i = 0; i < PoolSize; ++i) {
                pool_.emplace_back(std::make_unique<T>());
                freeList_.push(pool_.back().get());
            }
        }

        T* Acquire() {
            T* obj = nullptr;
            if (freeList_.pop(obj)) {
                return obj;
            }
            // Fallback: если пул исчерпан (не должно происходить в production)
            return new T();
        }

        void Release(T* obj) {
            // Очищаем содержимое для переиспользования
            obj->bids.clear();
            obj->asks.clear();
            freeList_.push(obj);
        }

    private:
        std::vector<std::unique_ptr<T>> pool_;
        boost::lockfree::stack<T*> freeList_{ PoolSize };
    };

    // Буфер для хранения diff-обновлений до получения snapshot
    struct DiffBufferEntry {
        long long firstUpdateId{ 0 };
        long long finalUpdateId{ 0 };
        OrderBookUpdate* update{ nullptr }; // Указатель на объект из pool
    };

    // ═══════════════════════════════════════════════════════════════
    // Основной класс BinanceConnector
    // ═══════════════════════════════════════════════════════════════

    class BinanceConnector {
    public:
        explicit BinanceConnector(std::shared_ptr<SharedState> sharedState);
        ~BinanceConnector();

        // Запуск подключения к Spot и Futures одновременно
        void Start(const std::string& symbol);
        void Stop();

        // Статистика
        struct Stats {
            std::atomic<uint64_t> messagesReceived{ 0 };
            std::atomic<uint64_t> updatesApplied{ 0 };
            std::atomic<uint64_t> bytesReceived{ 0 };
        };
        Stats spotStats;
        Stats futuresStats;

    private:
        // ═══════════════════════════════════════════════════════════════
        // Внутренний класс для одного WebSocket соединения
        // ═══════════════════════════════════════════════════════════════
        class Connection {
        public:
            Connection(
                const std::string& wsHost,
                const std::string& wsPort,
                const std::string& restHost,
                const std::string& streamPath,
                const std::string& symbol,
                bool isFutures,
                std::shared_ptr<SharedState> state,
                Stats& stats
            );

            void Run(); // Основной цикл работы в отдельном потоке
            void Stop();

        private:
            // ═══════════════════════════════════════════════════════════
            // Этапы синхронизации Order Book (согласно алгоритму Binance)
            // ═══════════════════════════════════════════════════════════

            // 1. Буферизация входящих diff-обновлений
            void BufferDiffs();

            // 2. Загрузка snapshot через REST API
            void DownloadSnapshot();

            // 3. Синхронизация snapshot + buffered diffs
            void SynchronizeOrderBook();

            // 4. Основной цикл: применение live updates
            void ProcessLiveUpdates();

            // ═══════════════════════════════════════════════════════════
            // WebSocket операции
            // ═══════════════════════════════════════════════════════════

            void ConnectWebSocket();
            void SubscribeStreams();
            void ReadMessage();
            void SendPong(const std::string& payload);

            // ═══════════════════════════════════════════════════════════
            // Парсинг с Zero-Copy (simdjson + std::from_chars)
            // ═══════════════════════════════════════════════════════════

            // КРИТИЧНО: Парсинг без создания std::string
            // Используем std::string_view -> std::from_chars -> double
            inline double ParseDoubleZeroCopy(std::string_view sv) {
                double result = 0.0;
                auto [ptr, ec] = std::from_chars(sv.data(), sv.data() + sv.size(), result);
                if (ec != std::errc()) {
                    // Логируем ошибку, но не бросаем исключение в hot path
                    return 0.0;
                }
                return result;
            }

            // Парсинг depth update (diff)
            OrderBookUpdate* ParseDepthUpdate(simdjson::ondemand::document& doc);

            // Парсинг aggTrade
            void ParseAggTrade(simdjson::ondemand::document& doc);

            // ═══════════════════════════════════════════════════════════
            // Члены класса
            // ═══════════════════════════════════════════════════════════

            std::string wsHost_;
            std::string wsPort_;
            std::string restHost_;
            std::string streamPath_;
            std::string symbol_;
            bool isFutures_;
            std::shared_ptr<SharedState> state_;
            Stats& stats_;

            // Boost.Asio + Beast
            net::io_context ioc_;
            ssl::context sslCtx_{ ssl::context::tlsv12_client };
            tcp::resolver resolver_;
            std::unique_ptr<websocket::stream<beast::ssl_stream<tcp::socket>>> ws_;

            // simdjson parser (thread-local)
            simdjson::ondemand::parser parser_;

            // PRE-ALLOCATED: Буфер для WebSocket сообщений
            beast::flat_buffer readBuffer_;

            // PRE-ALLOCATED: Буфер для diff-обновлений до синхронизации
            // ВАЖНО: reserve() вызывается в конструкторе
            std::deque<DiffBufferEntry> diffBuffer_;

            // Object Pool для OrderBookUpdate
            ObjectPool<OrderBookUpdate, 512> updatePool_;

            // Lock-free SPSC очередь для передачи updates в стратегию
            // (если потребуется отдельный thread для strategy logic)
            boost::lockfree::spsc_queue<OrderBookUpdate*, 
                boost::lockfree::capacity<1024>> updateQueue_;

            // Состояние синхронизации
            std::atomic<bool> running_{ false };
            std::atomic<bool> synchronized_{ false };
            long long snapshotLastUpdateId_{ 0 };

            // Thread-safety
            std::mutex mutex_;
        };

        // ═══════════════════════════════════════════════════════════════
        // Члены BinanceConnector
        // ═══════════════════════════════════════════════════════════════

        std::shared_ptr<SharedState> state_;
        std::string symbol_;

        // Два независимых соединения в отдельных потоках
        std::unique_ptr<Connection> spotConnection_;
        std::unique_ptr<Connection> futuresConnection_;

        std::thread spotThread_;
        std::thread futuresThread_;

        std::atomic<bool> running_{ false };
    };

} // namespace TradingBot::Core::Network