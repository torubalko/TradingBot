# ? Интеграция Binance Spot API с конфигурацией

## ?? ЧТО СДЕЛАНО:

### 1. **Создан BinanceConfig.h**
- Структура для хранения параметров подключения к Binance
- Поддержка Testnet и Production
- Хранение API ключей (apiKey, secretKey)
- Настраиваемые хосты для SPOT и FUTURES

### 2. **Обновлён BinanceConnector**
- Теперь принимает `BinanceConfig` в конструкторе
- Использует URLs из конфигурации вместо hardcoded значений
- Поддерживает переключение между Testnet и Production

### 3. **Обновлён TradingBotApplication**
- Загружает конфигурацию из `config.json`
- Парсит настройки API используя nlohmann::json
- Передаёт конфигурацию в BinanceConnector

---

## ?? СТРУКТУРА КОНФИГУРАЦИИ

### config.json:
```json
{
  "api": {
    "apiKey": "YOUR_API_KEY_HERE",
    "secretKey": "YOUR_SECRET_KEY_HERE",
    "isTestnet": true,
    "spotHost": "testnet.binance.vision",
    "futuresHost": "testnet.binancefuture.com",
    "connectionTimeoutMs": 5000,
    "requestTimeoutMs": 10000,
    "maxRetries": 3,
    "retryDelayMs": 1000
  }
}
```

---

## ?? КАК ПОЛУЧИТЬ API КЛЮЧИ

### Testnet (для тестирования):
1. Перейдите на https://testnet.binance.vision/
2. Войдите через GitHub
3. Перейдите в API Key Management
4. Нажмите "Generate HMAC_SHA256 Key"
5. Скопируйте `API Key` и `Secret Key`

### Production (реальная торговля):
1. Войдите на https://www.binance.com/
2. Перейдите в Profile ? API Management
3. Создайте новый API ключ
4. **ВАЖНО:** Включите только нужные разрешения:
   - ? Enable Reading (для получения балансов)
   - ? Enable Spot & Margin Trading (для торговли)
   - ? Enable Withdrawals (НЕ включайте!)
5. Настройте IP Whitelist для безопасности

---

## ?? АРХИТЕКТУРА ПОДКЛЮЧЕНИЯ

```
TradingBotApplication
    ?
    ??> Загрузка config.json
    ?   ??> Создание BinanceConfig
    ?
    ??> BinanceConnector(config)
            ?
            ??> SPOT Connection
            ?   ??> WebSocket: testnet.binance.vision:443/ws
            ?   ??> REST API: testnet.binance.vision/api/v3/
            ?
            ??> FUTURES Connection
                ??> WebSocket: stream.binancefuture.com:443/ws
                ??> REST API: testnet.binancefuture.com/fapi/v1/
```

---

## ?? ПРИМЕРЫ ИСПОЛЬЗОВАНИЯ

### 1. Testnet (по умолчанию):
```json
{
  "api": {
    "apiKey": "",
    "secretKey": "",
    "isTestnet": true
  }
}
```

### 2. Production:
```json
{
  "api": {
    "apiKey": "YOUR_REAL_API_KEY",
    "secretKey": "YOUR_REAL_SECRET_KEY",
    "isTestnet": false
  }
}
```

---

## ?? ФУНКЦИОНАЛЬНОСТЬ

### Текущая:
- ? Подключение к WebSocket Streams (Market Data)
- ? Загрузка Order Book Snapshots (REST API)
- ? Real-time Order Book Updates
- ? Переключение Testnet/Production

### Запланированная (с API ключами):
- ? Размещение ордеров (POST /api/v3/order)
- ? Отмена ордеров (DELETE /api/v3/order)
- ? Получение баланса (GET /api/v3/account)
- ? Подписание запросов HMAC SHA256

---

## ?? БЕЗОПАСНОСТЬ

### ?? ВАЖНО:

1. **НЕ COMMIT API КЛЮЧИ** в Git!
   - Добавьте `config.json` в `.gitignore`
   - Используйте environment variables в production

2. **Используйте IP Whitelist** на Binance:
   - Ограничьте доступ только с вашего IP
   - Меняйте ключи регулярно

3. **Testnet для тестирования**:
   - Всегда тестируйте сначала на Testnet
   - Testnet использует fake деньги

4. **Минимальные разрешения**:
   - НЕ включайте Withdrawal permission
   - Только Reading + Spot Trading

---

## ?? TROUBLESHOOTING

### Проблема: WebSocket не подключается

**Решение:**
1. Проверьте firewall/антивирус
2. Проверьте интернет соединение
3. Попробуйте:
```powershell
Test-NetConnection testnet.binance.vision -Port 443
```

### Проблема: "Invalid signature"

**Причины:**
1. Неправильный secretKey
2. Неправильное время на компьютере (должно быть синхронизировано)
3. Неправильный алгоритм подписи

**Решение:**
```powershell
# Проверить время
w32tm /query /status
# Синхронизировать время
w32tm /resync
```

### Проблема: "IP address has been restricted"

**Решение:**
1. Перейдите в API Management на Binance
2. Отключите IP Whitelist ИЛИ
3. Добавьте ваш IP в Whitelist:
```powershell
# Узнать свой IP
Invoke-WebRequest -Uri "https://api.ipify.org"
```

---

## ?? ССЫЛКИ

- [Binance API Documentation](https://developers.binance.com/docs/binance-spot-api-docs)
- [Binance Testnet](https://testnet.binance.vision/)
- [API Key Types](https://developers.binance.com/docs/binance-spot-api-docs/faqs/api_key_types)
- [Request Signing (HMAC SHA256)](https://developers.binance.com/docs/binance-spot-api-docs/rest-api/request-security#signed-endpoint-examples-for-post-apiv3order)

---

## ? СЛЕДУЮЩИЕ ШАГИ

1. **Получить Testnet API ключи** на https://testnet.binance.vision/
2. **Добавить ключи в config.json**
3. **Запустить приложение**
4. **Проверить Output Window на подключение**

Если всё работает, вы увидите:
```
[TradingBotApplication] Config loaded: TESTNET
[BinanceConnector] Initialized with config: TESTNET
[Connection:SPOT] Initialized for BTCUSDT
[Connection:FUTURES] Initialized for BTCUSDT
[Connection:SPOT] WebSocket connected.
[Connection:SPOT] Subscribed to streams.
[Connection:SPOT] Snapshot downloaded: lastUpdateId=12345678
```

---

**Готово! Теперь проект поддерживает загрузку конфигурации из config.json и может работать как с Testnet, так и с Production Binance API.** ??
