#pragma once
#include <atomic>
#include <cstdint>
#include <cstring>
#include <thread>
#include "../BinanceDataFeed/LockFreeQueue.h"

namespace TradingBot::Core {

// Simple POD order command
struct OrderCommand {
    enum class Side : uint8_t { Buy = 0, Sell = 1 };
    Side side;
    double price;
    double quantity;
    bool reduceOnly;
    bool postOnly;
    int64_t tsNs;
    char symbol[16];
};

// ExecutionEngine stub: consumes commands from SPSC queue and would send to Binance REST/WS
class ExecutionEngine {
public:
    ExecutionEngine()
        : running_(false) {
    }

    ~ExecutionEngine() {
        Stop();
    }

    void Start() {
        if (running_.exchange(true)) return;
        worker_ = std::thread([this] { Run(); });
    }

    void Stop() {
        if (!running_.exchange(false)) return;
        if (worker_.joinable()) worker_.join();
    }

    bool Submit(const OrderCommand& cmd) {
        return queue_.TryPush(cmd);
    }

private:
    void Run() {
        while (running_.load(std::memory_order_relaxed)) {
            auto cmdOpt = queue_.TryPop();
            if (!cmdOpt) {
#ifdef _MSC_VER
                _mm_pause();
#endif
                continue;
            }
            const OrderCommand& cmd = *cmdOpt;
            // TODO: integrate Binance Futures REST/WS here with limit/post-only/reduce-only flags.
            // Currently stubbed for clean-room architecture.
            (void)cmd;
        }
    }

    hft::LockFreeQueue<OrderCommand, 1024> queue_;
    std::atomic<bool> running_;
    std::thread worker_;
};

} // namespace TradingBot::Core
