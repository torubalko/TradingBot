# Memory Management Layer — Best Practices

## ?? Цели

1. **Zero-allocation в HOT PATH**
   - Вся память выделяется при старте (`Pre-Allocation`)
   - Hot path только переиспользует объекты из pools
   - Нет `new/delete` в критических секциях

2. **Lock-free data structures**
   - `ObjectPool` использует `boost::lockfree::stack`
   - `SPSCQueue` использует `boost::lockfree::spsc_queue`
   - Нет mutex/lock в hot path

3. **Cache-friendly memory layout**
   - Fixed-size структуры (power of 2)
   - Cache line alignment (64 bytes)
   - Padding для избежания false sharing

---

## ?? Компоненты

### 1. ObjectPool<T, PoolSize>

**Назначение:** Pre-allocated пул объектов для переиспользования

**Архитектура:**
```
???????????????????????????????????????????????????????
? ObjectPool (initialized at startup)                 ?
?                                                      ?
?  ???????? ???????? ????????        ????????        ?
?  ? Obj1 ? ? Obj2 ? ? Obj3 ?  ...   ? ObjN ?        ?
?  ???????? ???????? ????????        ????????        ?
?       ?       ?                         ?           ?
?       ?       ?                         ?           ?
?  ?????????????????????????????????????????????     ?
?  ?   boost::lockfree::stack (free list)      ?     ?
?  ??????????????????????????????????????????????     ?
???????????????????????????????????????????????????????

HOT PATH:
  T* obj = pool.Acquire();   // O(1), lock-free
  // ... use obj ...
  pool.Release(obj);          // O(1), lock-free
```

**Sizing:**
- Pool size >= max burst size * latency spike multiplier
- Пример: `ObjectPool<OrderBookUpdate, 512>`
  - Max throughput: 1000 updates/sec
  - Max latency spike: 0.5 sec
  - Pool size: 1000 * 0.5 = 500 ? round to 512

**Memory overhead:**
- `PoolSize * sizeof(T)` (pre-allocated)
- Free list: `PoolSize * sizeof(void*)` (pointers)

---

### 2. SPSCQueue<T, Capacity>

**Назначение:** Lock-free очередь для передачи данных между потоками

**Архитектура:**
```
Producer Thread           Consumer Thread
     ?                         ?
     ?                         ?
 ??????????????????????????????????
 ?   Ring Buffer (lock-free)      ?
 ?                                ?
 ? [0] [1] [2] [3] ... [N-1]     ?
 ?  ?                     ?       ?
 ?  ?                     ?       ?
 ? write               read       ?
 ? (atomic)          (atomic)     ?
 ??????????????????????????????????
```

**Producer (HOT PATH):**
```cpp
queue.push(item);  // O(1), lock-free, no mutex
```

**Consumer:**
```cpp
T item;
while (queue.pop(item)) {
    Process(item);
}
```

**Sizing:**
- Capacity >= throughput * max_processing_time
- Capacity ДОЛЖНА быть степенью двойки (для оптимизации модуля)
- Пример: `SPSCQueue<OrderBookUpdate*, 1024>`
  - Throughput: 1000 updates/sec
  - Max processing time: 1 sec (latency spike)
  - Capacity: 1000 * 1 = 1000 ? round to 1024

---

## ?? Интеграция

### Пример 1: Network Thread ? Main Thread

```cpp
// В классе:
Memory::ObjectPool<OrderBookUpdate, 512> updatePool_;
Memory::SPSCQueue<OrderBookUpdate*, 1024> updateQueue_;

// Producer (network thread):
void OnWebSocketMessage(const char* data, size_t size) {
    // Acquire от pool
    OrderBookUpdate* update = updatePool_.Acquire();
    
    // Parse
    ParseUpdate(data, size, update);
    
    // Push в queue (lock-free)
    if (!updateQueue_.push(update)) {
        // Queue full (увеличить capacity)
        updatePool_.Release(update);
    }
}

// Consumer (main thread):
void ProcessUpdates() {
    OrderBookUpdate* update;
    while (updateQueue_.pop(update)) {
        // Apply to order book
        orderBook_.ApplyUpdate(update);
        
        // Release обратно в pool
        updatePool_.Release(update);
    }
}
```

### Пример 2: Strategy ? OMS Thread

```cpp
// В StrategyEngine:
Memory::ObjectPool<OrderRequest, 256> orderPool_;
Memory::SPSCQueue<OrderRequest*, 512> orderQueue_;

// Producer (strategy thread):
void GenerateOrder(double price, double qty) {
    OrderRequest* req = orderPool_.Acquire();
    req->price = price;
    req->quantity = qty;
    
    orderQueue_.push(req);
}

// Consumer (OMS thread):
void ProcessOrders() {
    OrderRequest* req;
    while (orderQueue_.pop(req)) {
        SubmitOrder(*req);
        orderPool_.Release(req);
    }
}
```

---

## ?? Common Pitfalls

### 1. Pool Exhaustion
```cpp
// ? BAD: Не проверяем nullptr
OrderBookUpdate* update = pool.Acquire();
update->bids.push_back({price, qty});  // SEGFAULT если pool exhausted

// ? GOOD: Проверяем nullptr
OrderBookUpdate* update = pool.Acquire();
if (!update) {
    LOG_ERROR("Pool exhausted");
    return;
}
```

### 2. Queue Overflow
```cpp
// ? BAD: Игнорируем false от push
queue.push(update);  // Может вернуть false если queue full

// ? GOOD: Обрабатываем переполнение
if (!queue.push(update)) {
    LOG_WARN("Queue full, dropping update");
    pool.Release(update);  // Не забыть вернуть в pool!
}
```

### 3. Memory Leak
```cpp
// ? BAD: Забыли вернуть в pool
OrderRequest* req = pool.Acquire();
SubmitOrder(*req);
// req утечёт! Pool уменьшится на 1 объект

// ? GOOD: Всегда Release
OrderRequest* req = pool.Acquire();
SubmitOrder(*req);
pool.Release(req);  // ?
```

---

## ?? Performance Characteristics

| Operation | Complexity | Lock-free | Hot Path Safe |
|-----------|-----------|-----------|---------------|
| `ObjectPool::Acquire()` | O(1) | ? | ? |
| `ObjectPool::Release()` | O(1) | ? | ? |
| `SPSCQueue::push()` | O(1) | ? | ? |
| `SPSCQueue::pop()` | O(1) | ? | ? |

**Memory overhead:**
- `ObjectPool<T, 512>`: `512 * sizeof(T)` (pre-allocated)
- `SPSCQueue<T*, 1024>`: `1024 * 8 bytes = 8 KB` (64-bit pointers)

**Throughput:**
- Binance WebSocket: ~1000 updates/sec
- Typical latency: 0.5-2 ms
- Pool sizing: 512-1024 objects sufficient

---

## ?? Production Checklist

- [ ] All pools sized 2x-3x max burst
- [ ] All queues sized for latency spikes
- [ ] Nullptr checks after `Acquire()`
- [ ] False checks after `push()`
- [ ] All acquired objects released
- [ ] No `new/delete` in hot path
- [ ] No `std::string` construction in hot path
- [ ] No exceptions in hot path

---

## ?? Monitoring

```cpp
// Периодически проверяем pool usage:
size_t available = pool.GetAvailableCount();
size_t capacity = pool.GetCapacity();
double usage = 1.0 - (available / (double)capacity);

if (usage > 0.8) {
    LOG_WARN("Pool 80% full: %zu/%zu", 
             capacity - available, capacity);
}

// Queue depth:
size_t depth = queue.read_available();
if (depth > capacity * 0.8) {
    LOG_WARN("Queue 80% full: %zu/%zu", depth, capacity);
}
```

---

## ?? References

- `TradingBot.Core/Memory/ObjectPool.h`
- `TradingBot.Core/Memory/SPSCQueue.h`
- `TradingBot.Core/Memory/MemoryUsageExamples.h`
- Boost.Lockfree: https://www.boost.org/doc/libs/1_84_0/doc/html/lockfree.html
