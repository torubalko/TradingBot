#pragma once
#include <atomic>
#include <cstddef>
#include <memory>
#include <new>
#include <thread>
#include <optional>
#include <type_traits>

#if defined(_MSC_VER) && (defined(_M_X64) || defined(_M_IX86))
#include <immintrin.h>
#define CPU_PAUSE() _mm_pause()
#elif defined(__GNUC__) && (defined(__x86_64__) || defined(__i386__))
#define CPU_PAUSE() __builtin_ia32_pause()
#elif defined(__aarch64__) || defined(__ARM_ARCH)
#define CPU_PAUSE() __asm__ __volatile__("yield" ::: "memory")
#else
#define CPU_PAUSE() std::this_thread::yield()
#endif

namespace TradingBot::Core::LockFree {

/// <summary>
/// A high-performance Single-Producer-Single-Consumer (SPSC) lock-free queue.
/// 
/// This implementation is optimized for true SPSC scenarios:
/// - No compare-exchange operations (uses simple atomic load/store with appropriate memory ordering)
/// - CPU pause intrinsics for efficient spin-waiting
/// - C++23 compliant (uses alignas instead of deprecated std::aligned_storage)
/// - Proper object lifetime management with std::construct_at/std::destroy_at
/// 
/// Thread Safety: 
/// - ONE thread may call Emplace/TryEmplace (producer)
/// - ONE thread may call Pop/TryPop (consumer)
/// - Multiple producers or consumers will cause undefined behavior
/// </summary>
template<typename T, size_t Capacity>
class LockFreeQueue {
    static_assert((Capacity & (Capacity - 1)) == 0, "Capacity must be a power of 2");
    static_assert(Capacity > 0, "Capacity must be greater than 0");

private:
    struct alignas(T) Slot {
        alignas(T) std::byte storage[sizeof(T)];
        
        T* ptr() noexcept {
            return reinterpret_cast<T*>(storage);
        }
        
        const T* ptr() const noexcept {
            return reinterpret_cast<const T*>(storage);
        }
    };

    // Align to cache line to prevent false sharing
    alignas(64) std::atomic<size_t> head_{0};
    alignas(64) std::atomic<size_t> tail_{0};
    alignas(64) Slot slots_[Capacity];

    static constexpr size_t index_mask = Capacity - 1;

public:
    LockFreeQueue() = default;
    
    ~LockFreeQueue() {
        // Destroy any remaining elements
        size_t current_head = head_.load(std::memory_order_relaxed);
        size_t current_tail = tail_.load(std::memory_order_relaxed);
        
        while (current_head != current_tail) {
            std::destroy_at(slots_[current_head & index_mask].ptr());
            ++current_head;
        }
    }

    // Non-copyable, non-movable
    LockFreeQueue(const LockFreeQueue&) = delete;
    LockFreeQueue& operator=(const LockFreeQueue&) = delete;
    LockFreeQueue(LockFreeQueue&&) = delete;
    LockFreeQueue& operator=(LockFreeQueue&&) = delete;

    /// <summary>
    /// Attempts to emplace an element into the queue without blocking.
    /// </summary>
    /// <returns>true if the element was successfully emplaced, false if queue is full</returns>
    template<typename... Args>
    [[nodiscard]] bool TryEmplace(Args&&... args) noexcept(std::is_nothrow_constructible_v<T, Args...>) {
        const size_t current_tail = tail_.load(std::memory_order_relaxed);
        const size_t next_tail = current_tail + 1;
        
        // SPSC optimization: use acquire for consumer's head, no CAS needed
        const size_t current_head = head_.load(std::memory_order_acquire);
        
        if (next_tail - current_head > Capacity) {
            return false; // Queue is full
        }
        
        // Construct element in-place
        std::construct_at(slots_[current_tail & index_mask].ptr(), std::forward<Args>(args)...);
        
        // SPSC optimization: simple store with release ordering
        tail_.store(next_tail, std::memory_order_release);
        return true;
    }

    /// <summary>
    /// Blocks until an element can be emplaced into the queue.
    /// Uses CPU pause instructions for efficient spin-waiting.
    /// </summary>
    template<typename... Args>
    void Emplace(Args&&... args) noexcept(std::is_nothrow_constructible_v<T, Args...>) {
        while (!TryEmplace(std::forward<Args>(args)...)) {
            CPU_PAUSE(); // Efficient spin-wait
        }
    }

    /// <summary>
    /// Attempts to pop an element from the queue without blocking.
    /// </summary>
    /// <returns>std::optional containing the element if successful, std::nullopt if queue is empty</returns>
    [[nodiscard]] std::optional<T> TryPop() noexcept(std::is_nothrow_move_constructible_v<T>) {
        const size_t current_head = head_.load(std::memory_order_relaxed);
        
        // SPSC optimization: use acquire for producer's tail, no CAS needed
        const size_t current_tail = tail_.load(std::memory_order_acquire);
        
        if (current_head == current_tail) {
            return std::nullopt; // Queue is empty
        }
        
        Slot& slot = slots_[current_head & index_mask];
        
        // Move element out and destroy
        T result = std::move(*slot.ptr());
        std::destroy_at(slot.ptr());
        
        // SPSC optimization: simple store with release ordering
        head_.store(current_head + 1, std::memory_order_release);
        
        return result;
    }

    /// <summary>
    /// Blocks until an element can be popped from the queue.
    /// Uses CPU pause instructions for efficient spin-waiting.
    /// </summary>
    [[nodiscard]] T Pop() noexcept(std::is_nothrow_move_constructible_v<T>) {
        std::optional<T> result;
        while (!(result = TryPop())) {
            CPU_PAUSE(); // Efficient spin-wait
        }
        return std::move(*result);
    }

    /// <summary>
    /// Returns the current number of elements in the queue.
    /// Note: This is an approximate count in a concurrent environment.
    /// </summary>
    [[nodiscard]] size_t Size() const noexcept {
        const size_t current_head = head_.load(std::memory_order_acquire);
        const size_t current_tail = tail_.load(std::memory_order_acquire);
        return current_tail - current_head;
    }

    /// <summary>
    /// Checks if the queue is empty.
    /// Note: Result may be stale immediately after return in concurrent environment.
    /// </summary>
    [[nodiscard]] bool Empty() const noexcept {
        return head_.load(std::memory_order_acquire) == tail_.load(std::memory_order_acquire);
    }

    /// <summary>
    /// Returns the maximum capacity of the queue.
    /// </summary>
    [[nodiscard]] static constexpr size_t Capacity_() noexcept {
        return Capacity;
    }
};

} // namespace TradingBot::Core::LockFree

#undef CPU_PAUSE
