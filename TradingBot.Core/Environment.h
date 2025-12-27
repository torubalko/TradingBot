#pragma once
#include <string>
namespace TradingBot::Core {
    class Environment {
    public:
        static std::string GetSystemInfo();
    };
}