# Диагностика проблемы WebSocket подключения

## ?? ПРОБЛЕМА НАЙДЕНА

Приложение запускается, но WebSocket потоки падают с исключениями:
```
boost::wrapexcept<boost::system::system_error>
std::runtime_error
```

Это означает, что `BinanceConnector` **не может подключиться** к Binance WebSocket API.

---

## ?? ВОЗМОЖНЫЕ ПРИЧИНЫ:

### 1. **Порт 9443 заблокирован**
- Binance SPOT использует порт `9443`
- Проверьте firewall/антивирус

### 2. **DNS не резолвится**
- `stream.binance.com`
- `fstream.binance.com`

### 3. **SSL сертификат не валидируется**
- В коде стоит `ssl::verify_none` (небезопасно!)

### 4. **Нет интернет соединения**

---

## ? БЫСТРАЯ ПРОВЕРКА

### 1. Проверьте доступность Binance API:

#### PowerShell:
```powershell
# Проверка DNS
Resolve-DnsName stream.binance.com
Resolve-DnsName fstream.binance.com

# Проверка TCP подключения
Test-NetConnection stream.binance.com -Port 9443
Test-NetConnection fstream.binance.com -Port 443
```

#### CMD:
```cmd
# Проверка ping
ping stream.binance.com
ping fstream.binance.com
```

### 2. Проверьте HTTP REST API:
```powershell
# Должен вернуть JSON с ценами
Invoke-WebRequest -Uri "https://api.binance.com/api/v3/ticker/price?symbol=BTCUSDT"
```

---

## ??? РЕШЕНИЯ

### Решение 1: Используйте WebSocket тестер

Проверьте WebSocket вручную через браузер:
```javascript
// Откройте консоль браузера (F12) и выполните:
const ws = new WebSocket('wss://stream.binance.com:9443/ws/btcusdt@depth');
ws.onopen = () => console.log('CONNECTED');
ws.onerror = (e) => console.log('ERROR', e);
ws.onmessage = (e) => console.log('MESSAGE', e.data);
```

### Решение 2: Используйте альтернативный порт

В `BinanceConnector.cpp`, строка ~40:
```cpp
// Было:
"9443",  // WebSocket port

// Замените на:
"443",   // Стандартный HTTPS порт
```

### Решение 3: Отключите антивирус временно

Некоторые антивирусы блокируют WebSocket соединения.

### Решение 4: Добавьте более детальное логирование

В `BinanceConnector.cpp`, метод `ConnectWebSocket()`:

```cpp
void BinanceConnector::Connection::ConnectWebSocket() {
    try {
        std::cout << "[Connection] Resolving " << wsHost_ << ":" << wsPort_ << std::endl;
        auto const results = resolver_.resolve(wsHost_, wsPort_);
        std::cout << "[Connection] DNS resolved, connecting..." << std::endl;

        // Create WebSocket stream
        ws_ = std::make_unique<websocket::stream<beast::ssl_stream<tcp::socket>>>(
            ioc_, sslCtx_);

        // SNI for SSL
        if (!SSL_set_tlsext_host_name(ws_->next_layer().native_handle(), wsHost_.c_str())) {
            throw beast::system_error(...);
        }
        std::cout << "[Connection] SNI set, connecting TCP..." << std::endl;

        // Connect TCP
        net::connect(beast::get_lowest_layer(*ws_), results);
        std::cout << "[Connection] TCP connected, starting SSL handshake..." << std::endl;

        // SSL handshake
        ws_->next_layer().handshake(ssl::stream_base::client);
        std::cout << "[Connection] SSL handshake complete, upgrading to WebSocket..." << std::endl;

        // WebSocket handshake
        ws_->handshake(wsHost_, streamPath_);
        std::cout << "[Connection] WebSocket handshake complete!" << std::endl;

        // ...
    } catch (const std::exception& e) {
        std::cerr << "[Connection] FAILED at some step: " << e.what() << std::endl;
        throw;
    }
}
```

---

## ?? СЛЕДУЮЩИЕ ШАГИ

1. **Пересоберите проект** с добавленным OutputDebugStringA
2. **Запустите** приложение
3. **Проверьте Output Window (Debug)** на наличие:
   ```
   [Connection:SPOT] Error: <детали ошибки>
   [Connection:FUTURES] Error: <детали ошибки>
   ```

4. **Если ошибка не появляется**, запустите из командной строки:
   ```powershell
   cd x64\Release
   .\TradingBot.Runner.exe
   ```
   И смотрите на консольный вывод.

---

## ?? ОЖИДАЕМЫЙ НОРМАЛЬНЫЙ ВЫВОД

Если всё работает, вы должны увидеть:
```
[TradingBot] Initializing...
[TradingBot] Starting all threads...
[Connection:SPOT] Initialized for BTCUSDT
[Connection:FUTURES] Initialized for BTCUSDT
[TradingBot] Running main loop...
[Connection:SPOT] WebSocket connected.
[Connection:SPOT] Subscribed to streams.
[Connection:SPOT] Buffered 15 diff updates.
[Connection:SPOT] Snapshot downloaded: lastUpdateId=12345678, latency=120ms
[Connection:SPOT] Synchronized: applied 15 buffered diffs.
[Connection:FUTURES] WebSocket connected.
[Connection:FUTURES] Subscribed to streams.
...
```

---

## ?? ЕСЛИ ПРОБЛЕМА ОСТАЁТСЯ

Создайте Issue на GitHub с выводом:
1. Output Window (Debug)
2. Результаты `Test-NetConnection`
3. Версия Windows и настройки firewall

---

**Вероятнее всего проблема в том, что порт 9443 заблокирован или DNS не резолвится.**

Попробуйте сначала изменить порт на `443` и пересобрать проект.
