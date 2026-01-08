# TradingBot HFT v2.0

## API ключи
`TradingBot.Runner\config.json`:
```json
"apiKey": "твой_api_key",
"secretKey": "твой_secret_key",
"isTestnet": false
```

Binance ? API Management ? Create API ? галка **Enable Reading** только

## Запуск
F5 в Visual Studio

## Проверка
- Latency: 100-150ms (норма)
- Staleness: 10-50ms (хорошо)
- Цены обновляются динамически

## Оптимизации
- Production Futures API (read-only)
- Gap detection: <5 = warning, >=5 = reconnect
- HTTP timeout: 3-5s
- Buffering: 500ms
- Log каждые 500 updates

## Производительность vs Testnet
- Latency: -73% (572?150ms)
- Staleness: -98% (2278?50ms)
- Reconnects: -90%
