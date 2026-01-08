#pragma once
#include <chrono>
#include <string>
#include <iostream>
#include <iomanip>
#include <sstream>

// ═══════════════════════════════════════════════════════════════
// Performance Monitor: Измерение задержек на каждом этапе
// ═══════════════════════════════════════════════════════════════

class PerformanceMonitor {
public:
    using Clock = std::chrono::high_resolution_clock;
    using TimePoint = Clock::time_point;
    using Microseconds = std::chrono::microseconds;

    struct Metrics {
        long long dnsResolutionUs = 0;
        long long tcpConnectionUs = 0;
        long long sslHandshakeUs = 0;
        long long wsHandshakeUs = 0;
        long long messageReceiveUs = 0;
        long long jsonParseUs = 0;
        long long totalUs = 0;

        // Статистика за последнюю секунду
        int messagesPerSecond = 0;
        long long avgLatencyUs = 0;
        long long minLatencyUs = 999999999;
        long long maxLatencyUs = 0;
    };

    void StartTimer() {
        startTime_ = Clock::now();
    }

    void StopTimerAndLog(const std::string& stage, long long& targetMetric) {
        auto elapsed = std::chrono::duration_cast<Microseconds>(
            Clock::now() - startTime_
        ).count();
        
        targetMetric = elapsed;
        
        LogTiming(stage, elapsed);
    }

    void LogTiming(const std::string& stage, long long microseconds) {
        std::cout << "[⏱️  " << std::setw(20) << std::left << stage << "] "
                  << std::setw(8) << std::right << microseconds << " μs";
        
        if (microseconds > 10000) {
            std::cout << "  ⚠️  SLOW!";
        } else if (microseconds < 1000) {
            std::cout << "  ✅ FAST";
        }
        
        std::cout << std::endl;
    }

    void ResetMetrics() {
        currentMetrics_ = Metrics{};
    }

    const Metrics& GetMetrics() const {
        return currentMetrics_;
    }

    void PrintSummary() {
        std::cout << "\n═════════════════════════════════════════════════════\n";
        std::cout << "📊 PERFORMANCE SUMMARY\n";
        std::cout << "═════════════════════════════════════════════════════\n";
        
        std::cout << "DNS Resolution:     " << std::setw(8) << currentMetrics_.dnsResolutionUs << " μs\n";
        std::cout << "TCP Connection:     " << std::setw(8) << currentMetrics_.tcpConnectionUs << " μs\n";
        std::cout << "SSL Handshake:      " << std::setw(8) << currentMetrics_.sslHandshakeUs << " μs\n";
        std::cout << "WebSocket Handshake:" << std::setw(8) << currentMetrics_.wsHandshakeUs << " μs\n";
        std::cout << "Message Receive:    " << std::setw(8) << currentMetrics_.messageReceiveUs << " μs\n";
        std::cout << "JSON Parse:         " << std::setw(8) << currentMetrics_.jsonParseUs << " μs\n";
        std::cout << "─────────────────────────────────────────────────────\n";
        std::cout << "TOTAL LATENCY:      " << std::setw(8) << currentMetrics_.totalUs << " μs\n";
        std::cout << "                    " << std::setw(8) << (currentMetrics_.totalUs / 1000.0) << " ms\n";
        std::cout << "═════════════════════════════════════════════════════\n\n";
    }

    void PrintRealTimeStats() {
        std::cout << "📈 [REAL-TIME] "
                  << "Msg/s: " << currentMetrics_.messagesPerSecond
                  << " | Avg: " << currentMetrics_.avgLatencyUs << "μs"
                  << " | Min: " << currentMetrics_.minLatencyUs << "μs"
                  << " | Max: " << currentMetrics_.maxLatencyUs << "μs"
                  << std::endl;
    }

    Metrics& GetMetricsRef() {
        return currentMetrics_;
    }

private:
    TimePoint startTime_;
    Metrics currentMetrics_;
};