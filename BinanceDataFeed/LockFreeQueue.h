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

// ═══════════════════════════════════════════════════════════════════════════════
// TRUE SPSC RING BUFFER (Tiger Architecture)
// ═══════════════════════════════════════════════════════════════════════════════
// Single Producer Single Consumer - ZERO CAS operations
// - Producer: load tail (relaxed), store tail (release)
// - Consumer: load head (relaxed), store head (release)
// - Cache-line aligned to prevent false sharing
// - Zero-copy: memcpy into pre-allocated slots
// ═══════════════════════════════════════════════════════════════════════════════

template<typename T, size_t QueueCapacity>
class alignas(CACHE_LINE_SIZE) LockFreeQueue {
    static_assert((QueueCapacity & (QueueCapacity - 1)) == 0, "Capacity must be power of 2");
    static_assert(QueueCapacity >= 2, "Capacity must be at least 2");
    static_assert(std::is_trivially_copyable_v<T> || std::is_move_constructible_v<T>, 
                  "T must be trivially copyable or move constructible");
    
private:
    static constexpr size_t MASK = QueueCapacity - 1;
    
    // Slot with explicit padding for cache-line separation
    struct alignas(CACHE_LINE_SIZE) Slot {
        alignas(T) std::byte storage[sizeof(T)];
    };
    
public:
    LockFreeQueue() : head_(0), tail_(0) {
        // Warm up pages (fault in memory early)
        for (size_t i = 0; i < QueueCapacity; ++i) {
            std::memset(&slots_[i].storage, 0, sizeof(slots_[i].storage));
        }
    }
    
    ~LockFreeQueue() {
        // Destroy any remaining items
        if constexpr (!std::is_trivially_destructible_v<T>) {
            while (TryPop()) {}
        }
    }
    
    // ═══════════════════════════════════════════════════════════════════════════
    // Push (Producer side) - NO CAS!
    // ═══════════════════════════════════════════════════════════════════════════
    
    template<typename... Args>
    bool TryEmplace(Args&&... args) {
        // Load current tail (relaxed - only producer writes)
        size_t tail = tail_.load(std::memory_order_relaxed);
        size_t nextTail = tail + 1;
        
        // Check if queue is full
        // Read head with acquire to see consumer's progress
        size_t head = head_.load(std::memory_order_acquire);
        if (nextTail - head > QueueCapacity) {
            return false; // Queue full
        }
        
        // Get slot
        Slot& slot = slots_[tail & MASK];
        
        // Construct item in-place (zero-copy)
        T* ptr = reinterpret_cast<T*>(&slot.storage);
        new (ptr) T(std::forward<Args>(args)...);
        
        // Commit: store tail with release (makes item visible to consumer)
        tail_.store(nextTail, std::memory_order_release);
        return true;
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
            // Spin with pause instruction (x86 hint for hyper-threading)
#ifdef _MSC_VER
            _mm_pause();
#elif defined(__x86_64__) || defined(__i386__)
            __builtin_ia32_pause();
#else
            std::this_thread::yield();
#endif
        }
    }
    
    void Push(const T& item) {
        Emplace(item);
    }
    
    void Push(T&& item) {
        Emplace(std::move(item));
    }
    
    // ═══════════════════════════════════════════════════════════════════════════
    // Pop (Consumer side) - NO CAS!
    // ═══════════════════════════════════════════════════════════════════════════
    
    std::optional<T> TryPop() {
        // Load current head (relaxed - only consumer writes)
        size_t head = head_.load(std::memory_order_relaxed);
        
        // Check if queue is empty
        // Read tail with acquire to see producer's progress
        size_t tail = tail_.load(std::memory_order_acquire);
        if (head == tail) {
            return std::nullopt; // Queue empty
        }
        
        // Get slot
        Slot& slot = slots_[head & MASK];
        T* ptr = reinterpret_cast<T*>(&slot.storage);
        
        // Move/copy item out
        T item = std::move(*ptr);
        
        // Destroy object
        if constexpr (!std::is_trivially_destructible_v<T>) {
            ptr->~T();
        }
        
        // Commit: store head with release (makes slot available to producer)
        head_.store(head + 1, std::memory_order_release);
        return item;
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
            // Spin with pause
#ifdef _MSC_VER
            _mm_pause();
#elif defined(__x86_64__) || defined(__i386__)
            __builtin_ia32_pause();
#else
            std::this_thread::yield();
#endif
        }
        return std::move(*result);
    }
    
    
    // ═══════════════════════════════════════════════════════════════════════════
    // Utility (non-blocking diagnostics)
    // ═══════════════════════════════════════════════════════════════════════════
    
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
        size_t head = head_.load(std::memory_order_acquire);
        size_t tail = tail_.load(std::memory_order_acquire);
        return (tail - head) >= QueueCapacity;
    }

private:
    // ═══════════════════════════════════════════════════════════════════════════
    // Data Members - Cache-line separated for false sharing prevention
    // ═══════════════════════════════════════════════════════════════════════════
    
    // Producer cache-line (written by producer only)
    alignas(CACHE_LINE_SIZE) std::atomic<size_t> tail_;
    char padding1_[CACHE_LINE_SIZE - sizeof(std::atomic<size_t>)];
    
    // Consumer cache-line (written by consumer only)
    alignas(CACHE_LINE_SIZE) std::atomic<size_t> head_;
    char padding2_[CACHE_LINE_SIZE - sizeof(std::atomic<size_t>)];
    
    // Shared cache-line (slots array)
    alignas(CACHE_LINE_SIZE) std::array<Slot, QueueCapacity> slots_;
    
    // No copy/move
    LockFreeQueue(const LockFreeQueue&) = delete;
    LockFreeQueue& operator=(const LockFreeQueue&) = delete;
    LockFreeQueue(LockFreeQueue&&) = delete;
    LockFreeQueue& operator=(LockFreeQueue&&) = delete;
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
