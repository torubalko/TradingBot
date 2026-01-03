#pragma once
#include <string>
#include <fstream>
#include <mutex>

namespace TradingBot::Core {
    class Logger {
    public:
        static void Log(const std::string& message);
    private:
        static std::ofstream logFile;
        static std::mutex logMutex;
    };
}
