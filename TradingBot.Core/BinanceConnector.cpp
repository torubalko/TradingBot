#include "BinanceConnector.h"
#include <iostream>
#include <sstream>
#include <chrono>
#include "HttpClient.h"

namespace TradingBot::Core::Network {

    // ═══════════════════════════════════════════════════════════════
    // BinanceConnector Implementation
    // ═══════════════════════════════════════════════════════════════

    BinanceConnector::BinanceConnector(std::shared_ptr<SharedState> sharedState)
        : state_(std::move(sharedState))
    {
        // Конструктор: минимальная инициализация
    }

    BinanceConnector::~BinanceConnector() {
        Stop();
    }

    void BinanceConnector::Start(const std::string& symbol) {
        symbol_ = symbol;
        running_.store(true, std::memory_order_release);

        // ═══════════════════════════════════════════════════════════════
        // Dual Connection Architecture:
        // Создаём два независимых соединения в отдельных потоках
        // ═══════════════════════════════════════════════════════════════

        // SPOT Connection
        spotConnection_ = std::make_unique<Connection>(
            "stream.binance.com",            // WebSocket host
            "9443",                            // WebSocket port
            "api.binance.com",                 // REST API host
            "/ws",                             // Combined stream path
            symbol_,
            false,                             // isFutures = false
            state_,
            spotStats
        );

        // FUTURES Connection
        futuresConnection_ = std::make_unique<Connection>(
            "fstream.binance.com",
            "443",
            "fapi.binance.com",
            "/ws",
            symbol_,
            true,                              // isFutures = true
            state_,
            futuresStats
        );

        // Запуск в отдельных потоках (критично для low-latency)
        spotThread_ = std::thread([this]() {
            spotConnection_->Run();
        });

        futuresThread_ = std::thread([this]() {
            futuresConnection_->Run();
        });

        std::cout << "[BinanceConnector] Started: SPOT + FUTURES threads for " 
                  << symbol_ << std::endl;
    }

    void BinanceConnector::Stop() {
        if (!running_.exchange(false, std::memory_order_acq_rel)) {
            return; // Already stopped
        }

        if (spotConnection_) spotConnection_->Stop();
        if (futuresConnection_) futuresConnection_->Stop();

        if (spotThread_.joinable()) spotThread_.join();
        if (futuresThread_.joinable()) futuresThread_.join();

        std::cout << "[BinanceConnector] Stopped." << std::endl;
    }

    // ═══════════════════════════════════════════════════════════════
    // Connection Implementation
    // ═══════════════════════════════════════════════════════════════

    BinanceConnector::Connection::Connection(
        const std::string& wsHost,
        const std::string& wsPort,
        const std::string& restHost,
        const std::string& streamPath,
        const std::string& symbol,
        bool isFutures,
        std::shared_ptr<SharedState> state,
        Stats& stats
    )
        : wsHost_(wsHost)
        , wsPort_(wsPort)
        , restHost_(restHost)
        , streamPath_(streamPath)
        , symbol_(symbol)
        , isFutures_(isFutures)
        , state_(std::move(state))
        , stats_(stats)
        , resolver_(ioc_)
    {
        // ═══════════════════════════════════════════════════════════════
        // PRE-ALLOCATION: Вся память выделяется ЗДЕСЬ (Startup Phase)
        // ═══════════════════════════════════════════════════════════════

        // Резервируем буфер для diff-обновлений (Worst Case: 5000 updates)
        diffBuffer_.reserve(5000);

        // readBuffer_ автоматически управляет памятью, но можно задать max_size
        readBuffer_.max_size(1024 * 1024); // 1 MB

        // SSL context
        sslCtx_.set_default_verify_paths();
        sslCtx_.set_verify_mode(ssl::verify_none); // Для production включить verify_peer

        std::cout << "[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") << "] "
                  << "Initialized for " << symbol_ << std::endl;
    }

    void BinanceConnector::Connection::Run() {
        running_.store(true, std::memory_order_release);

        while (running_.load(std::memory_order_acquire)) {
            try {
                // ═══════════════════════════════════════════════════════════
                // Алгоритм синхронизации Order Book (Binance)
                // ═══════════════════════════════════════════════════════════

                // 1. Подключение к WebSocket
                ConnectWebSocket();
                SubscribeStreams();

                // 2. Буферизация входящих diff-обновлений
                BufferDiffs();

                // 3. Загрузка snapshot (REST)
                DownloadSnapshot();

                // 4. Синхронизация snapshot + buffered diffs
                SynchronizeOrderBook();

                // 5. Основной цикл: live updates
                synchronized_.store(true, std::memory_order_release);
                ProcessLiveUpdates();

            } catch (const std::exception& e) {
                std::cerr << "[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                          << "] Error: " << e.what() << std::endl;

                synchronized_.store(false, std::memory_order_release);

                // Reconnection delay
                std::this_thread::sleep_for(std::chrono::seconds(2));
            }
        }
    }

    void BinanceConnector::Connection::Stop() {
        running_.store(false, std::memory_order_release);

        if (ws_ && ws_->is_open()) {
            beast::error_code ec;
            ws_->close(websocket::close_code::normal, ec);
        }

        ioc_.stop();
    }

    void BinanceConnector::Connection::ConnectWebSocket() {
        // Resolve
        auto const results = resolver_.resolve(wsHost_, wsPort_);

        // Create WebSocket stream
        ws_ = std::make_unique<websocket::stream<beast::ssl_stream<tcp::socket>>>(
            ioc_, sslCtx_);

        // SNI for SSL
        if (!SSL_set_tlsext_host_name(
            ws_->next_layer().native_handle(), 
            wsHost_.c_str()))
        {
            throw beast::system_error(
                beast::error_code(
                    static_cast<int>(::ERR_get_error()),
                    net::error::get_ssl_category()),
                "Failed to set SNI");
        }

        // Connect TCP
        net::connect(beast::get_lowest_layer(*ws_), results);

        // SSL handshake
        ws_->next_layer().handshake(ssl::stream_base::client);

        // WebSocket handshake
        ws_->handshake(wsHost_, streamPath_);

        // Включаем автоматический pong ответ на ping
        ws_->control_callback(
            [this](websocket::frame_type kind, beast::string_view payload) {
                if (kind == websocket::frame_type::ping) {
                    SendPong(std::string(payload));
                }
            });

        std::cout << "[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] WebSocket connected." << std::endl;
    }

    void BinanceConnector::Connection::SubscribeStreams() {
        // ═══════════════════════════════════════════════════════════════
        // Combined Stream: подписка на @depth и @aggTrade
        // ═══════════════════════════════════════════════════════════════

        std::string symbolLower = symbol_;
        std::transform(symbolLower.begin(), symbolLower.end(), 
                       symbolLower.begin(), ::tolower);

        std::ostringstream oss;
        oss << R"({)"
            << R"("method":"SUBSCRIBE",)"
            << R"("params":[)"
            << R"(")" << symbolLower << R"(@depth",)"      // Diff Depth
            << R"(")" << symbolLower << R"(@aggTrade")"    // Aggregated Trades
            << R"(],)"
            << R"("id":1)"
            << R"(})";

        std::string subscribeMsg = oss.str();
        ws_->write(net::buffer(subscribeMsg));

        std::cout << "[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Subscribed to streams." << std::endl;
    }

    void BinanceConnector::Connection::BufferDiffs() {
        // ═══════════════════════════════════════════════════════════════
        // Этап 1: Буферизация diff-обновлений до получения snapshot
        // Цель: не потерять ни одного обновления
        // ═══════════════════════════════════════════════════════════════

        auto startTime = std::chrono::steady_clock::now();
        constexpr int MAX_BUFFER_TIME_MS = 2000; // 2 секунды буферизации

        while (running_.load(std::memory_order_acquire)) {
            auto elapsed = std::chrono::duration_cast<std::chrono::milliseconds>(
                std::chrono::steady_clock::now() - startTime).count();

            if (elapsed > MAX_BUFFER_TIME_MS) {
                break; // Переходим к загрузке snapshot
            }

            ReadMessage();
            // Сообщения будут парситься и добавляться в diffBuffer_
        }

        std::cout << "[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Buffered " << diffBuffer_.size() << " diff updates." 
                  << std::endl;
    }

    void BinanceConnector::Connection::DownloadSnapshot() {
        // ═══════════════════════════════════════════════════════════════
        // Этап 2: Синхронный REST запрос для получения snapshot
        // ═══════════════════════════════════════════════════════════════

        std::string endpoint = isFutures_ 
            ? "/fapi/v1/depth" 
            : "/api/v3/depth";

        std::ostringstream oss;
        oss << endpoint << "?symbol=" << symbol_ << "&limit=1000";

        auto startTime = std::chrono::steady_clock::now();

        std::string jsonResponse = HttpClient::Get(restHost_, oss.str());

        auto endTime = std::chrono::steady_clock::now();
        long long latencyMs = std::chrono::duration_cast<std::chrono::milliseconds>(
            endTime - startTime).count();

        state_->SetLatencySample(latencyMs);

        if (jsonResponse.empty()) {
            throw std::runtime_error("Failed to download snapshot");
        }

        // ═══════════════════════════════════════════════════════════════
        // Парсинг snapshot с Zero-Copy (simdjson)
        // ═══════════════════════════════════════════════════════════════

        simdjson::padded_string paddedJson(jsonResponse);
        simdjson::ondemand::document doc = parser_.iterate(paddedJson);

        snapshotLastUpdateId_ = doc["lastUpdateId"].get_int64();

        // Парсинг bids
        std::vector<OrderBookLevel> bids;
        bids.reserve(1000); // PRE-ALLOCATION

        auto bidsArray = doc["bids"].get_array();
        for (auto bidElement : bidsArray) {
            auto bidArray = bidElement.get_array();
            auto it = bidArray.begin();

            // Zero-Copy: получаем string_view -> std::from_chars
            std::string_view priceStr = (*it).get_string();
            ++it;
            std::string_view qtyStr = (*it).get_string();

            OrderBookLevel level;
            level.price = ParseDoubleZeroCopy(priceStr);
            level.quantity = ParseDoubleZeroCopy(qtyStr);

            bids.push_back(level);
        }

        // Парсинг asks
        std::vector<OrderBookLevel> asks;
        asks.reserve(1000); // PRE-ALLOCATION

        auto asksArray = doc["asks"].get_array();
        for (auto askElement : asksArray) {
            auto askArray = askElement.get_array();
            auto it = askArray.begin();

            std::string_view priceStr = (*it).get_string();
            ++it;
            std::string_view qtyStr = (*it).get_string();

            OrderBookLevel level;
            level.price = ParseDoubleZeroCopy(priceStr);
            level.quantity = ParseDoubleZeroCopy(qtyStr);

            asks.push_back(level);
        }

        // Применяем snapshot к SharedState
        state_->ApplyUpdate(bids, asks);
        state_->SetAppliedNow();

        std::cout << "[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Snapshot downloaded: lastUpdateId=" << snapshotLastUpdateId_ 
                  << ", latency=" << latencyMs << "ms" << std::endl;
    }

    void BinanceConnector::Connection::SynchronizeOrderBook() {
        // ═══════════════════════════════════════════════════════════════
        // Этап 3: Синхронизация buffered diffs со snapshot
        // Алгоритм Binance:
        // - Пропускаем diffs с finalUpdateId <= snapshotLastUpdateId
        // - Проверяем, что firstUpdateId <= snapshotLastUpdateId+1
        // - Применяем валидные обновления
        // ═══════════════════════════════════════════════════════════════

        size_t appliedCount = 0;

        for (auto& entry : diffBuffer_) {
            if (entry.finalUpdateId <= snapshotLastUpdateId_) {
                // Слишком старое обновление, пропускаем
                updatePool_.Release(entry.update);
                continue;
            }

            if (entry.firstUpdateId > snapshotLastUpdateId_ + 1) {
                // Разрыв в последовательности! Критическая ошибка.
                std::cerr << "[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                          << "] GAP DETECTED! Expected <= " 
                          << (snapshotLastUpdateId_ + 1)
                          << ", got " << entry.firstUpdateId << std::endl;

                // В production: переподключение
                throw std::runtime_error("Order book gap detected");
            }

            // Применяем обновление
            state_->ApplyUpdate(entry.update->bids, entry.update->asks);
            state_->SetAppliedNow();

            snapshotLastUpdateId_ = entry.finalUpdateId;
            appliedCount++;

            // Возвращаем объект в pool
            updatePool_.Release(entry.update);
        }

        // Очищаем буфер (память уже выделена, просто сбрасываем размер)
        diffBuffer_.clear();

        std::cout << "[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Synchronized: applied " << appliedCount << " buffered diffs." 
                  << std::endl;
    }

    void BinanceConnector::Connection::ProcessLiveUpdates() {
        // ═══════════════════════════════════════════════════════════════
        // Этап 4: Основной цикл - применение live updates
        // HOT PATH: минимум аллокаций, zero-copy парсинг
        // ═══════════════════════════════════════════════════════════════

        while (running_.load(std::memory_order_acquire)) {
            ReadMessage();
            // Обновления применяются в ParseDepthUpdate()
        }
    }

    void BinanceConnector::Connection::ReadMessage() {
        // Чтение одного WebSocket фрейма
        readBuffer_.clear();
        ws_->read(readBuffer_);

        std::string_view messageData(
            static_cast<const char*>(readBuffer_.data().data()),
            readBuffer_.size()
        );

        stats_.bytesReceived.fetch_add(messageData.size(), std::memory_order_relaxed);
        stats_.messagesReceived.fetch_add(1, std::memory_order_relaxed);

        // ═══════════════════════════════════════════════════════════════
        // Парсинг с Zero-Copy (simdjson On-Demand API)
        // ═══════════════════════════════════════════════════════════════

        simdjson::padded_string paddedMsg(messageData);
        simdjson::ondemand::document doc = parser_.iterate(paddedMsg);

        // Проверяем тип события
        std::string_view eventType;
        auto eField = doc["e"];
        if (!eField.error()) {
            eventType = eField.get_string();
        }

        if (eventType == "depthUpdate") {
            OrderBookUpdate* update = ParseDepthUpdate(doc);

            if (!synchronized_.load(std::memory_order_acquire)) {
                // Фаза буферизации: сохраняем в diffBuffer_
                DiffBufferEntry entry;
                entry.firstUpdateId = update->U;
                entry.finalUpdateId = update->u;
                entry.update = update;
                diffBuffer_.push_back(entry);
            } else {
                // Фаза live updates: применяем немедленно
                if (update->U <= snapshotLastUpdateId_ + 1) {
                    state_->ApplyUpdate(update->bids, update->asks);
                    state_->SetAppliedNow();

                    snapshotLastUpdateId_ = update->u;
                    stats_.updatesApplied.fetch_add(1, std::memory_order_relaxed);
                }

                // Возвращаем в pool (Zero-Allocation Hot Path)
                updatePool_.Release(update);
            }
        }
        else if (eventType == "aggTrade") {
            ParseAggTrade(doc);
        }
    }

    OrderBookUpdate* BinanceConnector::Connection::ParseDepthUpdate(
        simdjson::ondemand::document& doc)
    {
        // ═══════════════════════════════════════════════════════════════
        // КРИТИЧНО: Zero-Copy парсинг с Object Pool
        // Никаких heap allocations в hot path!
        // ═══════════════════════════════════════════════════════════════

        OrderBookUpdate* update = updatePool_.Acquire();

        update->U = doc["U"].get_int64();
        update->u = doc["u"].get_int64();
        update->E = doc["E"].get_int64();

        // Парсинг bids
        update->bids.clear();
        auto bidsArray = doc["b"].get_array();
        for (auto bidElement : bidsArray) {
            auto bidArray = bidElement.get_array();
            auto it = bidArray.begin();

            std::string_view priceStr = (*it).get_string();
            ++it;
            std::string_view qtyStr = (*it).get_string();

            OrderBookLevel level;
            level.price = ParseDoubleZeroCopy(priceStr);
            level.quantity = ParseDoubleZeroCopy(qtyStr);

            update->bids.push_back(level);
        }

        // Парсинг asks
        update->asks.clear();
        auto asksArray = doc["a"].get_array();
        for (auto askElement : asksArray) {
            auto askArray = askElement.get_array();
            auto it = askArray.begin();

            std::string_view priceStr = (*it).get_string();
            ++it;
            std::string_view qtyStr = (*it).get_string();

            OrderBookLevel level;
            level.price = ParseDoubleZeroCopy(priceStr);
            level.quantity = ParseDoubleZeroCopy(qtyStr);

            update->asks.push_back(level);
        }

        return update;
    }

    void BinanceConnector::Connection::ParseAggTrade(
        simdjson::ondemand::document& doc)
    {
        // ═══════════════════════════════════════════════════════════════
        // Парсинг aggTrade для анализа Taker Volume (future feature)
        // ═══════════════════════════════════════════════════════════════

        // Placeholder: здесь будет логика для стратегии "отскок от плотности"
        // Пока просто парсим основные поля

        std::string_view priceStr = doc["p"].get_string();
        std::string_view qtyStr = doc["q"].get_string();
        bool isBuyerMaker = doc["m"].get_bool();

        // TODO: Передать в стратегический модуль для анализа агрессии
        (void)priceStr;
        (void)qtyStr;
        (void)isBuyerMaker;
    }

    void BinanceConnector::Connection::SendPong(const std::string& payload) {
        beast::error_code ec;
        ws_->pong(websocket::ping_data(payload), ec);
        if (ec) {
            std::cerr << "[Connection] Pong error: " << ec.message() << std::endl;
        }
    }

} // namespace TradingBot::Core::Network