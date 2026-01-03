#define _CRT_SECURE_NO_WARNINGS
#include "Logger.h"
#include <chrono>
#include <iomanip>
#include <iostream>

namespace TradingBot::Core {
    std::ofstream Logger::logFile("bot_log.txt", std::ios::out | std::ios::trunc);
    std::mutex Logger::logMutex;

    void Logger::Log(const std::string& message) {
        std::lock_guard<std::mutex> lock(logMutex);
        if (logFile.is_open()) {
            auto now = std::chrono::system_clock::now();
            auto time = std::chrono::system_clock::to_time_t(now);
            auto ms = std::chrono::duration_cast<std::chrono::milliseconds>(now.time_since_epoch()) % 1000;

            logFile << std::put_time(std::localtime(&time), "%H:%M:%S")
                << "." << std::setfill('0') << std::setw(3) << ms.count()
                << " " << message << std::endl;
        }
    }
}
