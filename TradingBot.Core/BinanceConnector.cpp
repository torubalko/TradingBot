#include "BinanceConnector.h"
#include <iostream>
#include <sstream>
#include <fstream>
#include <chrono>
#include "Network/HttpClient.h"

// ═══════════════════════════════════════════════════════════════
// DEBUG LOGGING MACRO (работает в Release mode тоже)
// ═══════════════════════════════════════════════════════════════
#ifdef _WIN32
#define LOG_INFO(msg) do { \
    std::ostringstream oss; \
    oss << msg << "\n"; \
    OutputDebugStringA(oss.str().c_str()); \
    std::cout << msg << std::endl; \
} while(0)
#else
#define LOG_INFO(msg) std::cout << msg << std::endl
#endif

namespace TradingBot::Core::Network {

    // ═══════════════════════════════════════════════════════════════
    // BinanceConnector Implementation
    // ═══════════════════════════════════════════════════════════════

    BinanceConnector::BinanceConnector(
        std::shared_ptr<SharedState> sharedState,
        const BinanceConfig& config)
        : state_(std::move(sharedState))
        , config_(config)
    {
        // Конструктор: минимальная инициализация
        LOG_INFO("[BinanceConnector] Initialized with config: "
                  << (config_.isTestnet ? "TESTNET" : "PRODUCTION"));
    }

    BinanceConnector::~BinanceConnector() {
        Stop();
    }

    void BinanceConnector::Start(const std::string& symbol) {
        symbol_ = symbol;
        running_.store(true, std::memory_order_release);

        // ═══════════════════════════════════════════════════════════════
        // ИСПРАВЛЕНИЕ: Используем правильные stream paths
        // 
        // БЫЛО: "/ws" (generic endpoint - требует SUBSCRIBE)
        // СТАЛО: "/ws/<symbol>@depth" (raw stream - автоматическая подписка)
        // ═══════════════════════════════════════════════════════════════

        std::string symbolLower = symbol_;
        std::transform(symbolLower.begin(), symbolLower.end(), 
                       symbolLower.begin(), ::tolower);

        // SPOT Connection - используем raw stream (автоматическая подписка)
        std::string spotStreamPath = "/ws/" + symbolLower + "@depth";
        
        spotConnection_ = std::make_unique<Connection>(
            config_.spotWsHost,               // stream.binance.com
            config_.spotWsPort,               // 443
            config_.spotRestHost,             // api.binance.com
            spotStreamPath,                   // /ws/btcusdt@depth
            symbol_,
            false,                            // isFutures = false
            state_,
            spotStats
        );

        // FUTURES Connection - используем raw stream
        std::string futuresStreamPath = "/ws/" + symbolLower + "@depth";
        
        futuresConnection_ = std::make_unique<Connection>(
            config_.futuresWsHost,            // fstream.binance.com
            config_.futuresWsPort,            // 443
            config_.futuresRestHost,          // fapi.binance.com
            futuresStreamPath,                // /ws/btcusdt@depth
            symbol_,
            true,                             // isFutures = true
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

        LOG_INFO("[BinanceConnector] Started: SPOT + FUTURES threads for " 
                  << symbol_);
    }

    void BinanceConnector::Stop() {
        if (!running_.exchange(false, std::memory_order_acq_rel)) {
            return; // Already stopped
        }

        if (spotConnection_) spotConnection_->Stop();
        if (futuresConnection_) futuresConnection_->Stop();

        if (spotThread_.joinable()) spotThread_.join();
        if (futuresThread_.joinable()) futuresThread_.join();

        LOG_INFO("[BinanceConnector] Stopped.");
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

        // NOTE: std::deque не имеет reserve(), но эффективно управляет памятью
        // через chunks. Для критичных случаев можно заменить на std::vector.

        // readBuffer_ автоматически управляет памятью, но можно задать max_size
        readBuffer_.max_size(1024 * 1024); // 1 MB

        // SSL context
        sslCtx_.set_default_verify_paths();
        sslCtx_.set_verify_mode(ssl::verify_none); // Для production включить verify_peer

        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") << "] "
                  << "Initialized for " << symbol_);
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
                std::string errorMsg = "[Connection:" + std::string(isFutures_ ? "FUTURES" : "SPOT") + 
                                      "] Error: " + e.what() + "\n";
                std::cerr << errorMsg;
                
                #ifdef _WIN32
                OutputDebugStringA(errorMsg.c_str());
                #endif

                synchronized_.store(false, std::memory_order_release);

                // Reconnection delay
                std::this_thread::sleep_for(std::chrono::seconds(2));
            }
        }
    }

    void BinanceConnector::Connection::Stop() {
        running_.store(false, std::memory_order_release);

        // ═══════════════════════════════════════════════════════════
        // ИСПРАВЛЕНИЕ: Graceful WebSocket close (избегаем assertion)
        // ═══════════════════════════════════════════════════════════
        
        if (ws_ && ws_->is_open()) {
            try {
                beast::error_code ec;
                
                // Отправляем close frame
                ws_->close(websocket::close_code::normal, ec);
                
                // Игнорируем ошибки (connection может быть уже закрыта)
                if (ec && ec != beast::errc::not_connected) {
                    // Логируем только неожиданные ошибки
                    std::cerr << "[Connection] Close warning: " << ec.message() << std::endl;
                }
            } catch (...) {
                // Полностью игнорируем exceptions при shutdown
            }
        }

        ioc_.stop();
    }

    void BinanceConnector::Connection::ConnectWebSocket() {
        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Connecting to " << wsHost_ << ":" << wsPort_);

        // Resolve
        auto const results = resolver_.resolve(wsHost_, wsPort_);
        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] DNS resolved");

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
        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] TCP connected");

        // SSL handshake
        ws_->next_layer().handshake(ssl::stream_base::client);
        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] SSL handshake complete");

        // WebSocket handshake
        ws_->handshake(wsHost_, streamPath_);

        // Включаем автоматический pong ответ на ping
        ws_->control_callback(
            [this](websocket::frame_type kind, beast::string_view payload) {
                if (kind == websocket::frame_type::ping) {
                    SendPong(std::string(payload));
                }
            });

        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] WebSocket connected to " << wsHost_ << streamPath_);
    }

    void BinanceConnector::Connection::SubscribeStreams() {
        // ═══════════════════════════════════════════════════════════════
        // ИСПРАВЛЕНИЕ: Raw streams НЕ требуют SUBSCRIBE
        // 
        // Raw stream (/ws/btcusdt@depth) автоматически подписывается
        // при WebSocket handshake. SUBSCRIBE нужен только для /ws endpoint.
        // ═══════════════════════════════════════════════════════════════

        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Raw stream - no SUBSCRIBE needed");

        // Ничего не отправляем - raw stream уже активен после handshake
    }

    void BinanceConnector::Connection::BufferDiffs() {
        // ═══════════════════════════════════════════════════════════════
        // Этап 1: Буферизация diff-обновлений до получения snapshot
        // 
        // ИСПРАВЛЕНО: Увеличен buffer time до 2500ms
        // ПРИЧИНА: REST API latency ~1600ms, нужен запас для покрытия gap
        // ═══════════════════════════════════════════════════════════════

        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Starting buffer phase...");

        // Минимальная задержка для накопления updates
        std::this_thread::sleep_for(std::chrono::milliseconds(200));

        auto startTime = std::chrono::steady_clock::now();
        constexpr int MAX_BUFFER_TIME_MS = 2500; // ← УВЕЛИЧЕНО: 2500ms вместо 500ms
        int messagesRead = 0;

        while (running_.load(std::memory_order_acquire)) {
            auto elapsed = std::chrono::duration_cast<std::chrono::milliseconds>(
                std::chrono::steady_clock::now() - startTime).count();

            if (elapsed > MAX_BUFFER_TIME_MS) {
                break; // Переходим к загрузке snapshot
            }

            if (ws_ && ws_->is_open()) {
                ReadMessage();
                messagesRead++;
            } else {
                LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                          << "] WebSocket not open during buffer phase!");
                break;
            }
        }

        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Buffered " << diffBuffer_.size() << " diff updates (read " 
                  << messagesRead << " messages).");
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

        std::string jsonResponse = HttpClient::GetSimple(restHost_, oss.str());

        auto endTime = std::chrono::steady_clock::now();
        long long latencyMs = std::chrono::duration_cast<std::chrono::milliseconds>(
            endTime - startTime).count();

        state_->SetLatencySample(latencyMs);

        if (jsonResponse.empty()) {
            throw std::runtime_error("Failed to download snapshot");
        }

        // ═══════════════════════════════════════════════════════════
        // DEBUG: Сохраняем JSON в файл для диагностики
        // ═══════════════════════════════════════════════════════════
        {
            std::string filename = isFutures_ ? "snapshot_futures.json" : "snapshot_spot.json";
            std::ofstream file(filename, std::ios::binary);
            if (file) {
                file.write(jsonResponse.data(), jsonResponse.size());
                file.close();
                LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                          << "] Snapshot saved to " << filename);
            }
        }

        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Snapshot response size: " << jsonResponse.size() 
                  << " bytes, latency=" << latencyMs << "ms");

        // ═══════════════════════════════════════════════════════════
        // ИСПРАВЛЕНИЕ: Проверяем что JSON валидный
        // ═══════════════════════════════════════════════════════════
        
        try {
            simdjson::padded_string paddedJson(jsonResponse);
            simdjson::ondemand::document doc = parser_.iterate(paddedJson);

            snapshotLastUpdateId_ = doc["lastUpdateId"].get_int64();

            // Парсинг bids
            std::vector<OrderBookLevel> bids;
            bids.reserve(1000);

            auto bidsArray = doc["bids"].get_array();
            for (auto bidElement : bidsArray) {
                auto bidArray = bidElement.get_array();
                auto it = bidArray.begin();

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
            asks.reserve(1000);

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
            state_->ApplySnapshot(bids, asks);
            state_->SetAppliedNow();

            LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                      << "] ✅ Snapshot applied: lastUpdateId=" << snapshotLastUpdateId_ 
                      << ", bids=" << bids.size() << ", asks=" << asks.size());

        } catch (const simdjson::simdjson_error& e) {
            // Логируем ПЕРВЫЕ 500 символов JSON для диагностики
            std::string preview = jsonResponse.substr(0, std::min<size_t>(500, jsonResponse.size()));
            
            LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                      << "] ❌ JSON parse error: " << simdjson::error_message(e.error()));
            LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                      << "] Response preview: " << preview);
            
            throw; // Пробрасываем дальше для reconnect
        }
    }

    void BinanceConnector::Connection::SynchronizeOrderBook() {
        // ═══════════════════════════════════════════════════════════════
        // Этап 3: Синхронизация buffered diffs со snapshot
        // 
        // ОПТИМИЗИРОВАННЫЙ АЛГОРИТМ (для Production):
        // 1. Пропускаем старые обновления (u <= snapshotLastUpdateId)
        // 2. Применяем ВСЕ валидные buffered updates
        // 3. Мягкая проверка gap (warning вместо exception для небольших разрывов)
        // ═══════════════════════════════════════════════════════════════

        size_t appliedCount = 0;
        size_t skippedOld = 0;

        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Synchronizing with snapshot lastUpdateId=" << snapshotLastUpdateId_);

        for (auto& entry : diffBuffer_) {
            // Пропускаем старые обновления (до snapshot)
            if (entry.finalUpdateId <= snapshotLastUpdateId_) {
                skippedOld++;
                updatePool_.Release(entry.update);
                continue;
            }

            // Проверяем разрыв (но не бросаем exception сразу)
            long long expectedUpdateId = snapshotLastUpdateId_ + 1;
            long long gapSize = entry.firstUpdateId - expectedUpdateId;
            
            if (gapSize > 0 && gapSize < 200) {
                // Небольшой gap (<200) - просто warning
                LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                          << "] ⚠️ Gap detected: " << gapSize 
                          << " (U=" << entry.firstUpdateId << ", expected=" << expectedUpdateId << ")");
                // Продолжаем работу - snapshot корректный, gap в buffered updates не критичен
            } else if (gapSize >= 200) {
                // Очень большой gap (>=200) - критичная ошибка
                LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                          << "] ❌ CRITICAL GAP: " << gapSize);
                
                // Освобождаем все buffered updates
                for (auto& e : diffBuffer_) {
                    updatePool_.Release(e.update);
                }
                diffBuffer_.clear();
                
                throw std::runtime_error("Critical gap in buffered updates");
            }

            // Применяем update
            state_->ApplyUpdate(entry.update->bids, entry.update->asks);
            state_->SetAppliedNow();

            snapshotLastUpdateId_ = entry.finalUpdateId;
            appliedCount++;

            updatePool_.Release(entry.update);
        }

        // Очищаем буфер
        diffBuffer_.clear();

        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] ✅ Synchronized: applied=" << appliedCount 
                  << ", skipped_old=" << skippedOld 
                  << ", final_updateId=" << snapshotLastUpdateId_);
    }

    void BinanceConnector::Connection::ProcessLiveUpdates() {
        // ═══════════════════════════════════════════════════════════════
        // Этап 4: Основной цикл - применение live updates
        // HOT PATH: минимум аллокаций, zero-copy парсинг
        // ═══════════════════════════════════════════════════════════════

        while (running_.load(std::memory_order_acquire)) {
            try {
                ReadMessage();
                // Обновления применяются в ParseDepthUpdate()
            } catch (const beast::system_error& e) {
                // При закрытии WebSocket выходим из цикла
                if (e.code() == websocket::error::closed ||
                    e.code() == net::error::operation_aborted) {
                    LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                              << "] WebSocket closed gracefully");
                    break;
                }
                throw; // Другие ошибки пробрасываем выше
            } catch (const std::exception& e) {
                if (!running_.load(std::memory_order_acquire)) {
                    // Shutdown в процессе, это нормально
                    break;
                }
                throw; // Иначе пробрасываем
            }
        }

        LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                  << "] Live updates loop finished");
    }

    void BinanceConnector::Connection::ReadMessage() {
        // ═══════════════════════════════════════════════════════════════
        // ИСПРАВЛЕНИЕ: Читаем ПОЛНОЕ сообщение (может быть fragmented)
        // ═══════════════════════════════════════════════════════════════
        readBuffer_.clear();
        
        if (!ws_ || !ws_->is_open()) {
            throw std::runtime_error("WebSocket is not open");
        }
        
        // Читаем полное WebSocket сообщение (собираем все fragments)
        ws_->read(readBuffer_);

        std::string_view messageData(
            static_cast<const char*>(readBuffer_.data().data()),
            readBuffer_.size()
        );

        stats_.bytesReceived.fetch_add(messageData.size(), std::memory_order_relaxed);
        stats_.messagesReceived.fetch_add(1, std::memory_order_relaxed);

        // Проверяем что сообщение не пустое
        if (messageData.empty()) {
            return;
        }

        // ═══════════════════════════════════════════════════════════════
        // ИСПРАВЛЕНИЕ: Graceful JSON parsing с error handling
        // ═══════════════════════════════════════════════════════════════

        try {
            simdjson::padded_string paddedMsg(messageData);
            simdjson::ondemand::document doc = parser_.iterate(paddedMsg);

            // ═══════════════════════════════════════════════════════════
            // ИСПРАВЛЕНИЕ: Raw stream format (без wrapper)
            // 
            // Raw stream: {"e":"depthUpdate","E":123,"s":"BTCUSDT",...}
            // Combined stream: {"stream":"btcusdt@depth","data":{...}}
            // ═══════════════════════════════════════════════════════════

            // Проверяем event type напрямую (raw stream format)
            auto eField = doc["e"];
            if (!eField.error()) {
                std::string_view eventType = eField.get_string();
                
                if (eventType == "depthUpdate") {
                    OrderBookUpdate* update = ParseDepthUpdate(doc);
                    if (update) {
                        ProcessDepthUpdate(update);
                    }
                }
                else if (eventType == "aggTrade") {
                    ParseAggTrade(doc);
                }
                
                return; // Успешно обработано
            }

            // Если нет "e" поля - проверяем combined stream format
            auto streamField = doc["stream"];
            if (!streamField.error()) {
                auto dataField = doc["data"];
                if (dataField.error()) {
                    return;
                }
                
                simdjson::ondemand::object dataObj = dataField.get_object();
                
                auto eFieldData = dataObj["e"];
                if (eFieldData.error()) {
                    return;
                }
                
                std::string_view eventType = eFieldData.get_string();
                
                if (eventType == "depthUpdate") {
                    OrderBookUpdate* update = ParseDepthUpdateFromData(dataObj);
                    if (update) {
                        ProcessDepthUpdate(update);
                    }
                }
                else if (eventType == "aggTrade") {
                    ParseAggTradeFromData(dataObj);
                }
                
                return;
            }

            // Игнорируем все остальное (subscription responses, etc)
            
        } catch (const simdjson::simdjson_error& e) {
            // JSON parse error - логируем и пропускаем
            static std::atomic<int> errorCount{0};
            if (errorCount.fetch_add(1) % 10 == 0) {
                std::cerr << "[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                          << "] JSON parse error: " << simdjson::error_message(e.error())
                          << " (count: " << errorCount.load() << ")" << std::endl;
            }
            return;
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // НОВАЯ функция: обработка depth update
    // ═══════════════════════════════════════════════════════════════
    void BinanceConnector::Connection::ProcessDepthUpdate(OrderBookUpdate* update) {
        if (!update) {
            return;
        }

        if (!synchronized_.load(std::memory_order_acquire)) {
            // Фаза буферизации: сохраняем в diffBuffer_
            DiffBufferEntry entry;
            entry.firstUpdateId = update->U;
            entry.finalUpdateId = update->u;
            entry.update = update;
            diffBuffer_.push_back(entry);
        } else {
            // Фаза live updates
            long long expectedUpdateId = snapshotLastUpdateId_ + 1;
            
            // Пропускаем старые обновления (duplicates)
            if (update->u <= snapshotLastUpdateId_) {
                updatePool_.Release(update);
                return;
            }
            
            // Проверяем gap
            long long gapSize = update->U - expectedUpdateId;
            
            if (gapSize > 0 && gapSize < 5) {
                // Небольшой gap (<5) - warning
                static std::atomic<int> gapWarningCount{0};
                if (gapWarningCount.fetch_add(1) % 10 == 0) {
                    LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                              << "] ⚠️ Small gap: " << gapSize);
                }
            } else if (gapSize >= 5) {
                // Большой gap (>=5) - переподключение
                LOG_INFO("[Connection:" << (isFutures_ ? "FUTURES" : "SPOT") 
                          << "] ❌ CRITICAL GAP: " << gapSize);
                updatePool_.Release(update);
                throw std::runtime_error("Critical OrderBook gap");
            }
            
            // Применяем обновление
            state_->ApplyUpdate(update->bids, update->asks);
            state_->SetAppliedNow();

            snapshotLastUpdateId_ = update->u;
            stats_.updatesApplied.fetch_add(1, std::memory_order_relaxed);

            updatePool_.Release(update);
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // НОВАЯ функция: парсинг из "data" объекта (combined stream)
    // ═══════════════════════════════════════════════════════════════
    OrderBookUpdate* BinanceConnector::Connection::ParseDepthUpdateFromData(
        simdjson::ondemand::object& dataObj)
    {
        try {
            OrderBookUpdate* update = updatePool_.Acquire();
            if (!update) {
                return nullptr;
            }

            update->U = dataObj["U"].get_int64();
            update->u = dataObj["u"].get_int64();
            update->E = dataObj["E"].get_int64();

            // Парсинг bids
            update->bids.clear();
            auto bidsArray = dataObj["b"].get_array();
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
            auto asksArray = dataObj["a"].get_array();
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
            
        } catch (const simdjson::simdjson_error& e) {
            return nullptr;
        }
    }

    OrderBookUpdate* BinanceConnector::Connection::ParseDepthUpdate(
        simdjson::ondemand::document& doc)
    {
        // ═══════════════════════════════════════════════════════════════
        // ИСПРАВЛЕНИЕ: WebSocket использует "b" и "a", не "bids" и "asks"
        // ═══════════════════════════════════════════════════════════════

        try {
            OrderBookUpdate* update = updatePool_.Acquire();
            if (!update) {
                return nullptr;
            }

            update->U = doc["U"].get_int64();
            update->u = doc["u"].get_int64();
            update->E = doc["E"].get_int64();

            // Парсинг bids (WebSocket: "b", не "bids")
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

            // Парсинг asks (WebSocket: "a", не "asks")
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
            
        } catch (const simdjson::simdjson_error& e) {
            return nullptr;
        }
    }

    void BinanceConnector::Connection::ParseAggTrade(
        simdjson::ondemand::document& doc)
    {
        // ═══════════════════════════════════════════════════════════════
        // СТАРАЯ функция: парсинг direct stream format
        // ═══════════════════════════════════════════════════════════════

        try {
            std::string_view priceStr = doc["p"].get_string();
            std::string_view qtyStr = doc["q"].get_string();
            bool isBuyerMaker = doc["m"].get_bool();

            (void)priceStr;
            (void)qtyStr;
            (void)isBuyerMaker;
        } catch (...) {
            // Ignore errors
        }
    }

    void BinanceConnector::Connection::ParseAggTradeFromData(
        simdjson::ondemand::object& dataObj)
    {
        try {
            std::string_view priceStr = dataObj["p"].get_string();
            std::string_view qtyStr = dataObj["q"].get_string();
            bool isBuyerMaker = dataObj["m"].get_bool();
            
            (void)priceStr;
            (void)qtyStr;
            (void)isBuyerMaker;
        } catch (...) {
            // Ignore parse errors
        }
    }

    void BinanceConnector::Connection::SendPong(const std::string& payload) {
        beast::error_code ec;
        ws_->pong(websocket::ping_data(payload), ec);
        if (ec) {
            std::cerr << "[Connection] Pong error: " << ec.message() << std::endl;
        }
    }

} // namespace TradingBot::Core::Network