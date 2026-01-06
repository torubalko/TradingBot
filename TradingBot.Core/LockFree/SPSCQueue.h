#pragma once
#include <boost/lockfree/spsc_queue.hpp>
#include <optional>
#include <memory>

namespace TradingBot::Core::LockFree {
    template<typename T, size_t Capacity = 1024>
    class SPSCQueue {
    public:
        SPSCQueue() : queue_(Capacity) {}

        // Push an element to the queue (producer side)
        bool push(const T& item) {
            return queue_.push(item);
        }

        // Push an element to the queue (move semantics)
        bool push(T&& item) {
            return queue_.push(std::move(item));
        }

        // Pop an element from the queue (consumer side)
        std::optional<T> pop() {
            T item;
            if (queue_.pop(item)) {
                return item;
            }
            return std::nullopt;
        }

        // Try to pop an element (consumer side)
        bool try_pop(T& item) {
            return queue_.pop(item);
        }

        // Check if queue is empty (approximate, lock-free)
        bool empty() const {
            return queue_.read_available() == 0;
        }

        // Get available elements to read (consumer side)
        size_t read_available() const {
            return queue_.read_available();
        }

        // Get available space to write (producer side)
        size_t write_available() const {
            return queue_.write_available();
        }

        // Reset the queue (not thread-safe, use only when no concurrent access)
        void reset() {
            queue_.reset();
        }

        // Get capacity of the queue
        constexpr size_t capacity() const {
            return Capacity;
        }

    private:
        boost::lockfree::spsc_queue<T, boost::lockfree::capacity<Capacity>> queue_;
    };

    // Dynamic capacity version using heap allocation
    template<typename T>
    class DynamicSPSCQueue {
    public:
        explicit DynamicSPSCQueue(size_t capacity) : queue_(capacity) {}

        bool push(const T& item) {
            return queue_.push(item);
        }

        bool push(T&& item) {
            return queue_.push(std::move(item));
        }

        std::optional<T> pop() {
            T item;
            if (queue_.pop(item)) {
                return item;
            }
            return std::nullopt;
        }

        bool try_pop(T& item) {
            return queue_.pop(item);
        }

        bool empty() const {
            return queue_.read_available() == 0;
        }

        size_t read_available() const {
            return queue_.read_available();
        }

        size_t write_available() const {
            return queue_.write_available();
        }

        void reset() {
            queue_.reset();
        }

    private:
        boost::lockfree::spsc_queue<T> queue_;
    };
}
