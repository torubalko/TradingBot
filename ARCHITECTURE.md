# TradingBot - Архитектура проекта

## Обзор

TradingBot - это Windows-приложение для визуализации биржевого стакана и сделок Binance в реальном времени.

```
┌─────────────────────────────────────────────────────────┐
│                   TradingBot.Runner                     │
│  ┌─────────────────────────────────────────────────┐   │
│  │          Graphics (D3D11/D2D)                   │   │
│  │  - Order Book Visualization                     │   │
│  │  - Trade Bubbles Animation                      │   │
│  │  - UI Controls                                  │   │
│  └─────────────────────────────────────────────────┘   │
│                         │                                │
│                         ▼                                │
│  ┌─────────────────────────────────────────────────┐   │
│  │         Rendering Thread (Main)                 │   │
│  │  - 60 FPS render loop                           │   │
│  │  - User input handling                          │   │
│  │  - GetSnapshotForRender()                       │   │
│  └─────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────┘
                          │
                          │ std::shared_ptr<SharedState>
                          │
┌─────────────────────────▼───────────────────────────────┐
│                   TradingBot.Core                       │
│  ┌─────────────────────────────────────────────────┐   │
│  │             SharedState                         │   │
│  │  - Order Book Data (std::map)                   │   │
│  │  - Trade Queue (std::deque)                     │   │
│  │  - Thread-safe access (std::mutex)              │   │
│  └─────────────────────────────────────────────────┘   │
│                         ▲                                │
│                         │                                │
│  ┌─────────────────────────────────────────────────┐   │
│  │         Network Thread                          │   │
│  │  1. RestClient: Load ExchangeInfo               │   │
│  │  2. BinanceConnection: WebSocket                │   │
│  │     - @depth stream (100ms updates)             │   │
│  │     - @trade stream                             │   │
│  └─────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────┘
                          │
                          │ Boost.Beast (SSL/WebSocket)
                          │
┌─────────────────────────▼───────────────────────────────┐
│                   Binance API                           │
│  - REST API (fapi.binance.com)                          │
│  - WebSocket (fstream.binance.com)                      │
└─────────────────────────────────────────────────────────┘
```

## Модули

### TradingBot.Core

#### 1. Network Layer
- **BinanceConnection**: WebSocket клиент для получения рыночных данных
- **RestClient**: HTTP клиент для загрузки справочной информации
- **JsonParser**: Парсинг JSON ответов от Binance

#### 2. Data Layer
- **SharedState**: Центральное хранилище данных с потокобезопасным доступом
- **MarketCache**: Информация о торговых парах (Spot/Futures)
- **Types**: Определения структур данных (OrderBook, Trade, и т.д.)

### TradingBot.Runner

#### 1. Graphics Layer
- **Graphics**: Обертка над Direct3D11/Direct2D для рендеринга
  - Batching примитивов
  - Текст через DirectWrite
  - Эллипсы для trade bubbles

#### 2. UI Layer
- Основной rendering loop
- Обработка пользовательского ввода
- Визуализация биржевого стакана
- Анимация trade bubbles

## Поток данных

### 1. Инициализация
```
1. Создание SharedState
2. Запуск Network Thread
3. RestClient загружает ExchangeInfo
4. Создание Graphics и главного окна
5. Старт Rendering Loop
```

### 2. Цикл работы

**Network Thread:**
```
Loop:
  1. Проверка g_ConnectionDirty
  2. Если нужно:
     - Остановить старое соединение
     - Очистить SharedState
     - Создать новое BinanceConnection
  3. BinanceConnection.Connect():
     - Загрузить snapshot (REST)
     - Подключиться к WebSocket
     - Получать updates:
       * @depth -> SharedState.ApplyUpdate()
       * @trade -> SharedState.AddTrade()
```

**Rendering Thread:**
```
Loop (60 FPS):
  1. Получить RenderSnapshot
  2. Обновить Trade Bubbles (физика)
  3. Рендерить:
     - Order Book (Bids/Asks)
     - Trade Bubbles
     - UI Controls
     - Price Scale
  4. EndFrame()
```

### 3. Переключение инструмента

```
User clicks on dropdown -> Select "ETHUSDT"
    │
    ▼
g_CurrentSymbol = "ETHUSDT"
g_ConnectionDirty = true
UpdateSymbolInfo()
    │
    ▼
Network Thread замечает dirty flag
    │
    ▼
Stop old connection
Clear SharedState
Connect to new symbol
```

## Многопоточность

### Thread Safety

**Защищенные ресурсы:**
1. `SharedState::mutex_` - для Bids/Asks/Trades
2. `g_ConnectionMutex` - для текущего соединения
3. `g_StatusMutex` - для статуса сети
4. `instrumentsMutex` - для MarketCache

**Lock-free данные:**
- `std::atomic<bool> g_Running`
- `std::atomic<bool> g_ConnectionDirty`

### Синхронизация

```cpp
// Network Thread пишет
{
    std::lock_guard<std::mutex> lock(mutex_);
    Bids[price] = quantity;
}

// Rendering Thread читает
{
    std::lock_guard<std::mutex> lock(mutex_);
    snap.Bids.assign(...);
}
```

## Визуализация

### Order Book Rendering

```
Price Grid:
  ┌────────────────────┐
  │ 43210.5  ▓▓▓▓▓▓   │ <- Ask (Red)
  │ 43210.0  ▓▓▓▓▓▓▓  │
  │ 43209.5  ▓▓▓▓▓▓▓▓ │
  ├────────────────────┤ <- Mid Price (Orange line)
  │ 43209.0 ▓▓▓▓▓▓▓▓  │ <- Bid (Blue)
  │ 43208.5 ▓▓▓▓▓▓▓▓▓ │
  │ 43208.0 ▓▓▓▓▓▓    │
  └────────────────────┘

Bar width ∝ Volume at price level
```

### Trade Bubbles

```
Bubble lifecycle:
  1. Trade arrives -> Create bubble at START_X_POS
  2. Animation:
     - radius = √(volume) * 0.5
     - Spring physics (tension + dampening)
     - Move right (moveSpeed)
  3. Merge nearby bubbles (same direction, close price)
  4. Remove when x > 3000px

Color:
  - Green = Buyer initiated (market buy)
  - Red = Seller initiated (market sell)
```

### Price Scaling

```cpp
// Динамическое масштабирование
double currentStep = tickSize * scales[scaleIndex];
// scales = {1, 2, 5, 10, 20, 50, ...}

// Примеры:
// BTC: tickSize=0.1, scale=10 -> 1.0 USDT steps
// ETH: tickSize=0.01, scale=5 -> 0.05 USDT steps
```

### Camera System

```cpp
// Плавное следование за ценой
double target = (bestAsk + bestBid) / 2.0;
g_SmoothCenterPrice += (target - g_SmoothCenterPrice) * 0.15;

// Позиция на экране
float y = centerY - (price - g_SmoothCenterPrice) / currentStep * rowHeight;
```

## Зависимости

### Основные библиотеки
- **Boost** (Beast, Asio, PropertyTree) - Сеть и JSON
- **nlohmann/json** - Современный JSON парсинг
- **OpenSSL** - SSL/TLS
- **Direct3D11** - Графика
- **Direct2D / DirectWrite** - 2D графика и текст

### Системные API
- **WinSock2** - Сетевые операции
- **Windows Crypto API** - Загрузка корневых сертификатов

## Конфигурация

### Compile-time константы

```cpp
// Сеть
const int MAX_TRADES = 1000;          // SharedState.h:53
const int MAX_BUBBLES = 500;          // Runner.cpp:255

// Графика
const int MAX_VERTICES = 4096;        // Graphics.h:68
const float START_X_POS = 310.0f;     // Runner.cpp:48

// UI
const float HEADER_HEIGHT = 50.0f;
const float ROW_HEIGHT = 22.0f;
```

### Runtime параметры

```cpp
// Масштабы
std::vector<int> g_Scales = {1, 2, 5, 10, 20, 50, 100, ...};

// Цвета
COL_BUY_R/G/B   = (0.2, 0.6, 1.0)    // Синий
COL_SELL_R/G/B  = (1.0, 0.25, 0.25)  // Красный
```

## Производительность

### Оптимизации

1. **Графика:**
   - Batching вершин (до 4096 за draw call)
   - Отсечение невидимых элементов
   - Ограничение FPS через VSync

2. **Данные:**
   - `std::map` для O(log n) поиска по цене
   - Агрегация уровней для снижения количества отрисовок
   - Ограничение размера очередей

3. **Сеть:**
   - WebSocket для низкой задержки
   - Параллельная обработка @depth и @trade
   - Буферизация SSL (8192*8 bytes)

### Метрики

- **Задержка отрисовки:** < 16ms (60 FPS)
- **Частота обновлений:** 100ms (@depth stream)
- **Память:** ~50MB (зависит от количества пар)

## Расширяемость

### Добавление новой биржи

```cpp
// 1. Создать интерфейс
class IExchangeConnection {
    virtual void Connect(const std::string& symbol) = 0;
    virtual void Stop() = 0;
};

// 2. Реализовать для новой биржи
class KrakenConnection : public IExchangeConnection {
    // ...
};

// 3. Фабрика для создания
std::shared_ptr<IExchangeConnection> CreateConnection(
    ExchangeType type, std::shared_ptr<SharedState> state) {
    switch (type) {
        case ExchangeType::Binance: return std::make_shared<BinanceConnection>(state);
        case ExchangeType::Kraken: return std::make_shared<KrakenConnection>(state);
    }
}
```

### Добавление новых индикаторов

```cpp
// SharedState.h - добавить вычисление
struct RenderSnapshot {
    std::vector<std::pair<double, double>> Bids;
    std::vector<std::pair<double, double>> Asks;
    std::vector<Trade> RecentTrades;
    
    // Новое:
    double VWAP;      // Volume Weighted Average Price
    double OI;        // Open Interest
    ImbalanceData imbalance; // Order flow imbalance
};
```

## Известные ограничения

1. **Windows Only** - Использует Windows API (D3D11, Crypto)
2. **Binance Only** - Жестко привязан к формату Binance API
3. **Single Symbol** - Отображается только один инструмент
4. **No Historical Data** - Только real-time, нет истории
5. **No Trading** - Только мониторинг, нет размещения ордеров

## Дальнейшее развитие

### Короткий срок
- [ ] Исправить SSL verification
- [ ] Добавить логирование
- [ ] Вынести конфигурацию в файл

### Средний срок
- [ ] Поддержка множественных инструментов
- [ ] Сохранение настроек UI
- [ ] Экспорт данных в CSV

### Долгий срок
- [ ] Кросс-платформенность (OpenGL вместо D3D)
- [ ] Поддержка других бирж
- [ ] Торговые функции (размещение ордеров)
- [ ] Исторические данные и replay

---

*Дата: 2026-01-01*
