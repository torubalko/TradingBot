#pragma once
#include <atomic>
#include <chrono>
#include <algorithm>

namespace TradingBot::Core::Network {
    // Connection states
    enum class ConnectionState {
        DISCONNECTED,
        CONNECTING,
        CONNECTED,
        RECONNECTING,
        FAILED
    };

    // Reconnect strategy with exponential backoff
    class ReconnectStrategy {
    public:
        ReconnectStrategy(
            int initialDelayMs = 1000,
            int maxDelayMs = 60000,
            double backoffMultiplier = 2.0,
            int maxAttempts = -1) // -1 = infinite
            : initialDelayMs_(initialDelayMs),
              maxDelayMs_(maxDelayMs),
              backoffMultiplier_(backoffMultiplier),
              maxAttempts_(maxAttempts) {}

        // Get next delay before reconnect attempt
        int GetNextDelay() {
            if (maxAttempts_ >= 0 && attempts_ >= maxAttempts_) {
                return -1; // Signal to stop retrying
            }

            int delay = currentDelayMs_;
            currentDelayMs_ = std::min(
                static_cast<int>(currentDelayMs_ * backoffMultiplier_),
                maxDelayMs_
            );
            ++attempts_;
            lastAttemptTime_ = std::chrono::steady_clock::now();
            return delay;
        }

        // Reset strategy after successful connection
        void Reset() {
            attempts_ = 0;
            currentDelayMs_ = initialDelayMs_;
            consecutiveFailures_ = 0;
        }

        // Record a failed attempt
        void RecordFailure() {
            ++consecutiveFailures_;
        }

        // Record successful connection
        void RecordSuccess() {
            consecutiveFailures_ = 0;
            Reset();
        }

        int GetAttempts() const { return attempts_; }
        int GetConsecutiveFailures() const { return consecutiveFailures_; }
        int GetCurrentDelay() const { return currentDelayMs_; }

        auto GetLastAttemptTime() const { return lastAttemptTime_; }

    private:
        int initialDelayMs_;
        int maxDelayMs_;
        double backoffMultiplier_;
        int maxAttempts_;
        int currentDelayMs_;
        int attempts_ = 0;
        int consecutiveFailures_ = 0;
        std::chrono::steady_clock::time_point lastAttemptTime_;
    };

    // Connection health monitor
    class ConnectionMonitor {
    public:
        ConnectionMonitor(long long heartbeatIntervalMs = 30000,
                         long long timeoutMs = 60000)
            : heartbeatIntervalMs_(heartbeatIntervalMs),
              timeoutMs_(timeoutMs) {
            UpdateActivity();
        }

        // Update last activity timestamp
        void UpdateActivity() {
            lastActivityTime_ = std::chrono::steady_clock::now();
            ++messageCount_;
        }

        // Check if connection appears dead
        bool IsTimedOut() const {
            auto now = std::chrono::steady_clock::now();
            auto elapsed = std::chrono::duration_cast<std::chrono::milliseconds>(
                now - lastActivityTime_).count();
            return elapsed > timeoutMs_;
        }

        // Check if heartbeat is needed
        bool NeedsHeartbeat() const {
            auto now = std::chrono::steady_clock::now();
            auto elapsed = std::chrono::duration_cast<std::chrono::milliseconds>(
                now - lastHeartbeatTime_).count();
            return elapsed > heartbeatIntervalMs_;
        }

        void RecordHeartbeat() {
            lastHeartbeatTime_ = std::chrono::steady_clock::now();
        }

        long long GetMessageCount() const { return messageCount_; }
        
        auto GetLastActivityTime() const { return lastActivityTime_; }

    private:
        long long heartbeatIntervalMs_;
        long long timeoutMs_;
        std::chrono::steady_clock::time_point lastActivityTime_;
        std::chrono::steady_clock::time_point lastHeartbeatTime_;
        std::atomic<long long> messageCount_{ 0 };
    };
}
