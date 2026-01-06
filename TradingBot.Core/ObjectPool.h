#pragma once
#include <vector>
#include <memory>
#include <mutex>

namespace TradingBot::Core::Utils {
    // Thread-safe object pool for reusing OrderBookUpdate objects
    template<typename T>
    class ObjectPool {
    public:
        explicit ObjectPool(size_t initialSize = 100) {
            pool_.reserve(initialSize);
            for (size_t i = 0; i < initialSize; ++i) {
                pool_.push_back(std::make_unique<T>());
            }
        }

        std::unique_ptr<T> Acquire() {
            std::lock_guard<std::mutex> lock(mutex_);
            if (pool_.empty()) {
                ++allocations_;
                return std::make_unique<T>();
            }
            auto obj = std::move(pool_.back());
            pool_.pop_back();
            return obj;
        }

        void Release(std::unique_ptr<T> obj) {
            if (!obj) return;
            std::lock_guard<std::mutex> lock(mutex_);
            if (pool_.size() < maxPoolSize_) {
                pool_.push_back(std::move(obj));
            }
        }

        size_t GetPoolSize() const {
            std::lock_guard<std::mutex> lock(mutex_);
            return pool_.size();
        }

        size_t GetAllocations() const { return allocations_; }

    private:
        mutable std::mutex mutex_;
        std::vector<std::unique_ptr<T>> pool_;
        size_t maxPoolSize_ = 500;
        std::atomic<size_t> allocations_{ 0 };
    };
}
