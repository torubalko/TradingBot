# ? Готово! Конфигурация обновлена для Testnet

## ?? ЧТО СДЕЛАНО:

- ? Изменён `isTestnet: true`
- ? Обновлён `spotHost: testnet.binance.vision`
- ? Обновлён `futuresHost: testnet.binancefuture.com`
- ? Обновлён `snapshotUrl` на testnet

---

## ?? ЗАПУСК:

### Вариант 1: Через PowerShell (рекомендуется)

```powershell
cd TradingBot.Runner
Copy-Item config.production.json config.json -Force
```

Затем запустите проект в Visual Studio (F5)

### Вариант 2: Прямо в Visual Studio

Просто запустите проект (F5) - приложение будет использовать `config.json` по умолчанию.

Но сначала скопируйте файл вручную:
1. Откройте `TradingBot.Runner` папку в Explorer
2. Скопируйте `config.production.json`
3. Переименуйте копию в `config.json`

---

## ?? ЧТО ВЫ ДОЛЖНЫ УВИДЕТЬ:

После запуска в **Output Window (Debug)** должно быть:

```
[TradingBotApplication] Config loaded: TESTNET
[BinanceConnector] Initialized with config: TESTNET
[Connection:SPOT] Initialized for BTCUSDT
[Connection:FUTURES] Initialized for BTCUSDT

[HttpClient] Requesting: testnet.binance.vision/api/v3/depth?symbol=BTCUSDT&limit=1000
[HttpClient] DNS resolved
[HttpClient] TCP connected
[HttpClient] SSL handshake complete
[HttpClient] Request sent
[HttpClient] Response received: 200, body length: 125436

[Connection:SPOT] Snapshot downloaded: lastUpdateId=12345678, latency=120ms
[Connection:SPOT] WebSocket connected.
[Connection:SPOT] Subscribed to streams.
[Connection:SPOT] Buffered 15 diff updates.
[Connection:SPOT] Synchronized: applied 15 buffered diffs.
```

---

## ?? ЕСЛИ ЧТО-ТО НЕ РАБОТАЕТ:

### Проблема: "Failed to download snapshot"

**Решение:**
1. Проверьте интернет соединение
2. Проверьте что Testnet доступен:
```powershell
Test-NetConnection testnet.binance.vision -Port 443
```

3. Проверьте firewall/антивирус

### Проблема: WebSocket не подключается

**Решение:**
1. Проверьте что порт 443 открыт
2. Временно отключите антивирус
3. Попробуйте другую сеть (например, мобильный hotspot)

### Проблема: "Invalid API Key"

**Проверьте:**
- API ключи созданы на **testnet.binance.vision** (не на обычном Binance!)
- Ключи скопированы полностью без пробелов
- IP не заблокирован (если включен Whitelist)

---

## ?? Testnet ресурсы:

- **Testnet Dashboard:** https://testnet.binance.vision/
- **Получить тестовые деньги:** Testnet ? Deposit (на testnet.binance.vision)
- **API Documentation:** https://developers.binance.com/docs/binance-spot-api-docs

---

## ? СЛЕДУЮЩИЕ ШАГИ:

1. Скопируйте `config.production.json` ? `config.json`
2. Запустите проект (F5)
3. Проверьте Output Window
4. Если всё работает - увидите данные Order Book в окне приложения!

---

**Готово! Теперь можно безопасно тестировать на Testnet! ??**

*Примечание: Testnet использует "игрушечные" деньги, поэтому это полностью безопасно для экспериментов.*
