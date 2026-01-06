#pragma once
#include <vector>
#include <memory>
#include <mutex>
#include <functional>

namespace TradingBot::Core::Memory {
    template<typename T>
    class ObjectPool {
    public:
        using Deleter = std::function<void(T*)>;

        ObjectPool(size_t initialSize = 100, size_t maxSize = 1000)
            : maxSize_(maxSize) {
            reserve(initialSize);
        }

        ~ObjectPool() {
            clear();
        }

        // Get an object from the pool
        std::unique_ptr<T, Deleter> acquire() {
            std::lock_guard<std::mutex> lock(mutex_);
            
            if (pool_.empty()) {
                // Create new object if pool is empty
                T* obj = new T();
                return std::unique_ptr<T, Deleter>(obj, [this](T* ptr) { this->release(ptr); });
            }

            T* obj = pool_.back();
            pool_.pop_back();
            return std::unique_ptr<T, Deleter>(obj, [this](T* ptr) { this->release(ptr); });
        }

        // Release an object back to the pool
        void release(T* obj) {
            if (!obj) return;

            std::lock_guard<std::mutex> lock(mutex_);
            
            if (pool_.size() < maxSize_) {
                // Reset object state if it has a reset method
                if constexpr (requires { obj->reset(); }) {
                    obj->reset();
                }
                pool_.push_back(obj);
            } else {
                // Pool is full, delete the object
                delete obj;
            }
        }

        // Pre-allocate objects in the pool
        void reserve(size_t count) {
            std::lock_guard<std::mutex> lock(mutex_);
            
            for (size_t i = 0; i < count && pool_.size() < maxSize_; ++i) {
                pool_.push_back(new T());
            }
        }

        // Get current pool size
        size_t size() const {
            std::lock_guard<std::mutex> lock(mutex_);
            return pool_.size();
        }

        // Clear all objects in the pool
        void clear() {
            std::lock_guard<std::mutex> lock(mutex_);
            
            for (T* obj : pool_) {
                delete obj;
            }
            pool_.clear();
        }

        // Set maximum pool size
        void setMaxSize(size_t maxSize) {
            std::lock_guard<std::mutex> lock(mutex_);
            maxSize_ = maxSize;
            
            // Trim pool if it exceeds new max size
            while (pool_.size() > maxSize_) {
                T* obj = pool_.back();
                pool_.pop_back();
                delete obj;
            }
        }

    private:
        mutable std::mutex mutex_;
        std::vector<T*> pool_;
        size_t maxSize_;
    };
}
