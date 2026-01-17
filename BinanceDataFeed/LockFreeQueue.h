#pragma once

#include <atomic>
#include <array>
#include <cstddef>
#include <new>
#include <optional>
#include <type_traits>
#include <memory>
#include <cstring>

namespace hft {

constexpr size_t CACHE_LINE_SIZE = 64;

// ???????????????????????????????????????????????????????????????????????????????
// LOCK-FREE SPSC QUEUE FOR HFT
// ???????????????????????????????????????????????????????????????????????????????
// Single Producer Single Consumer (SPSC) ring buffer
// - No locks, no syscalls
// - Cache-line aligned to prevent false sharing
// - Suitable for inter-thread communication
// ???????????????????????????????????????????????????????????????????????????????

template<typename T, size_t QueueCapacity>
class alignas(CACHE_LINE_SIZE) LockFreeQueue {
    static_assert((QueueCapacity & (QueueCapacity - 1)) == 0, "Capacity must be power of 2");
    static_assert(QueueCapacity >= 2, "Capacity must be at least 2");
    
public:
    LockFreeQueue() : head_(0), tail_(0) {
        for (size_t i = 0; i < QueueCapacity; ++i) {
            slots_[i].sequence.store(i, std::memory_order_relaxed);
            // Touch memory to fault in pages early (warm-up)
            std::memset(&slots_[i].storage, 0, sizeof(slots_[i].storage));
        }
    }
    
    ~LockFreeQueue() {
        // Destroy any remaining items
        while (TryPop()) {}
    }
    
    // ???????????????????????????????????????????????????????????????????????????
    // Push (Producer side)
    // ???????????????????????????????????????????????????????????????????????????
    
    template<typename... Args>
    bool TryEmplace(Args&&... args) {
        size_t tail = tail_.load(std::memory_order_relaxed);
        
        for (;;) {
            Slot& slot = slots_[tail & MASK];
            size_t seq = slot.sequence.load(std::memory_order_acquire);
            intptr_t diff = static_cast<intptr_t>(seq) - static_cast<intptr_t>(tail);
            
            if (diff == 0) {
                // Slot is ready for writing
                if (tail_.compare_exchange_weak(tail, tail + 1, std::memory_order_relaxed)) {
                    // We got the slot
                    new (&slot.storage) T(std::forward<Args>(args)...);
                    slot.sequence.store(tail + 1, std::memory_order_release);
                    return true;
                }
            } else if (diff < 0) {
                // Queue is full
                return false;
            } else {
                // Another producer got here first (shouldn't happen in SPSC)
                tail = tail_.load(std::memory_order_relaxed);
            }
        }
    }
    
    bool TryPush(const T& item) {
        return TryEmplace(item);
    }
    
    bool TryPush(T&& item) {
        return TryEmplace(std::move(item));
    }
    
    // Blocking push with spin
    template<typename... Args>
    void Emplace(Args&&... args) {
        while (!TryEmplace(std::forward<Args>(args)...)) {
            // Spin - could add backoff or yield here
            std::atomic_thread_fence(std::memory_order_seq_cst);
        }
    }
    
    void Push(const T& item) {
        Emplace(item);
    }
    
    void Push(T&& item) {
        Emplace(std::move(item));
    }
    
    // ???????????????????????????????????????????????????????????????????????????
    // Pop (Consumer side)
    // ???????????????????????????????????????????????????????????????????????????
    
    std::optional<T> TryPop() {
        size_t head = head_.load(std::memory_order_relaxed);
        
        for (;;) {
            Slot& slot = slots_[head & MASK];
            size_t seq = slot.sequence.load(std::memory_order_acquire);
            intptr_t diff = static_cast<intptr_t>(seq) - static_cast<intptr_t>(head + 1);
            
            if (diff == 0) {
                // Slot has data
                if (head_.compare_exchange_weak(head, head + 1, std::memory_order_relaxed)) {
                    // We got the slot
                    T* ptr = reinterpret_cast<T*>(&slot.storage);
                    T item = std::move(*ptr);
                    ptr->~T();
                    slot.sequence.store(head + QueueCapacity, std::memory_order_release);
                    return item;
                }
            } else if (diff < 0) {
                // Queue is empty
                return std::nullopt;
            } else {
                // Another consumer got here first (shouldn't happen in SPSC)
                head = head_.load(std::memory_order_relaxed);
            }
        }
    }
    
    bool TryPop(T& item) {
        auto result = TryPop();
        if (result) {
            item = std::move(*result);
            return true;
        }
        return false;
    }
    
    // Blocking pop with spin
    T Pop() {
        std::optional<T> result;
        while (!(result = TryPop())) {
            // Spin
            std::atomic_thread_fence(std::memory_order_seq_cst);
        }
        return std::move(*result);
    }
    
    // ???????????????????????????????????????????????????????????????????????????
    // Utility
    // ???????????????????????????????????????????????????????????????????????????
    
    bool Empty() const {
        size_t head = head_.load(std::memory_order_acquire);
        size_t tail = tail_.load(std::memory_order_acquire);
        return head == tail;
    }
    
    size_t Size() const {
        size_t head = head_.load(std::memory_order_acquire);
        size_t tail = tail_.load(std::memory_order_acquire);
        return tail - head;
    }
    
    static constexpr size_t GetCapacity() { return QueueCapacity; }
    
    bool Full() const {
        return Size() >= QueueCapacity;
    }

private:
    static constexpr size_t MASK = QueueCapacity - 1;
    
    struct alignas(CACHE_LINE_SIZE) Slot {
        std::atomic<size_t> sequence;
        typename std::aligned_storage<sizeof(T), alignof(T)>::type storage;
    };
    
    // Separate cache lines for head and tail to prevent false sharing
    alignas(CACHE_LINE_SIZE) std::atomic<size_t> head_;
    alignas(CACHE_LINE_SIZE) std::atomic<size_t> tail_;
    alignas(CACHE_LINE_SIZE) std::array<Slot, QueueCapacity> slots_;
};

// ???????????????????????????????????????????????????????????????????????????????
// Message wrapper for the queue
// ???????????????????????????????????????????????????????????????????????????????
struct RawMessage {
    static constexpr size_t kMaxPayload = 8192; // adjust if needed
    std::array<char, kMaxPayload + 64> buf{};   // +padding for simdjson
    size_t size{0};
    int64_t receiveTimestampNs{0};

    RawMessage() = default;

    RawMessage(const char* ptr, size_t len, int64_t ts) {
        Set(ptr, len, ts);
    }

    RawMessage(RawMessage&& other) noexcept = default;
    RawMessage& operator=(RawMessage&& other) noexcept = default;

    RawMessage(const RawMessage&) = delete;
    RawMessage& operator=(const RawMessage&) = delete;

    bool Set(const char* ptr, size_t len, int64_t ts) {
        if (len > kMaxPayload) return false;
        std::memcpy(buf.data(), ptr, len);
        std::fill(buf.begin() + len, buf.begin() + len + 64, '\0');
        size = len;
        receiveTimestampNs = ts;
        return true;
    }

    bool IsValid() const { return size > 0 && size <= kMaxPayload; }

    const char* Data() const { return buf.data(); }
    size_t Size() const { return size; }
    int64_t ReceiveTimestampNs() const { return receiveTimestampNs; }
};

// Default queue size for WebSocket messages
using DefaultQueueCapacity = std::integral_constant<size_t, 4096>;
using MessageQueue = LockFreeQueue<RawMessage, DefaultQueueCapacity::value>;

// Lightweight virtual interface to allow runtime capacity selection
class IMessageQueue {
public:
    virtual ~IMessageQueue() = default;
    virtual bool TryPush(RawMessage&& msg) = 0;
    virtual std::optional<RawMessage> TryPop() = 0;
    virtual size_t Size() const = 0;
    virtual size_t Capacity() const = 0;
};

// Adapter over templated SPSC queue
template<size_t QueueCap>
class LockFreeQueueAdapter : public IMessageQueue {
public:
    bool TryPush(RawMessage&& msg) override {
        return queue_.TryPush(std::move(msg));
    }

    std::optional<RawMessage> TryPop() override {
        return queue_.TryPop();
    }

    size_t Size() const override { return queue_.Size(); }
    size_t Capacity() const override { return QueueCap; }

private:
    LockFreeQueue<RawMessage, QueueCap> queue_;
};

inline size_t NextPowerOfTwo(size_t v) {
    if (v < 2) return 2;
    v--;
    v |= v >> 1;
    v |= v >> 2;
    v |= v >> 4;
    v |= v >> 8;
    v |= v >> 16;
#if UINTPTR_MAX > 0xFFFFFFFF
    v |= v >> 32;
#endif
    return ++v;
}

// Factory choosing nearest power-of-two up to a sane cap
inline std::unique_ptr<IMessageQueue> CreateMessageQueue(size_t desiredCapacity) {
    // Cap to avoid giant static arrays when RawMessage is large
    const size_t capped = std::min<size_t>(desiredCapacity == 0 ? DefaultQueueCapacity::value : desiredCapacity, 65536u);
    const size_t pow2 = std::max<size_t>(NextPowerOfTwo(capped), 1024);

    switch (pow2) {
    case 1024: return std::make_unique<LockFreeQueueAdapter<1024>>();
    case 2048: return std::make_unique<LockFreeQueueAdapter<2048>>();
    case 4096: return std::make_unique<LockFreeQueueAdapter<4096>>();
    case 8192: return std::make_unique<LockFreeQueueAdapter<8192>>();
    case 16384: return std::make_unique<LockFreeQueueAdapter<16384>>();
    case 32768: return std::make_unique<LockFreeQueueAdapter<32768>>();
    default:
        return std::make_unique<LockFreeQueueAdapter<65536>>();
    }
}

} // namespace hft
