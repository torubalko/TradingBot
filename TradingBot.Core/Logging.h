#pragma once

#include <string>
#include <mutex>
#include <fstream>
#include <filesystem>
#include <chrono>
#include <iomanip>
#include <sstream>
#include <windows.h>

namespace TradingBot::Core::Logging {

enum class Level { Debug, Info, Warn, Error };

class Logger {
public:
    static void Init(const std::wstring& fileName = L"TradingBot.log")
    {
        std::lock_guard<std::mutex> lock(mu());
        path() = DefaultLogPath(fileName);
        EnsureDir(path().parent_path());
        // touch file
        std::ofstream f(path(), std::ios::app);
    }

    static void Write(Level lvl, const std::string& tag, const std::string& msg)
    {
        std::lock_guard<std::mutex> lock(mu());
        if(path().empty())
            Init();

        std::ostringstream line;
        line << Timestamp() << " [" << ToString(lvl) << "]";
        if(!tag.empty()) line << " [" << tag << "]";
        line << " " << msg << "\n";

        auto s = line.str();
        {
            std::ofstream f(path(), std::ios::app);
            f << s;
        }
        ::OutputDebugStringA(s.c_str());
    }

    static std::filesystem::path GetPath()
    {
        std::lock_guard<std::mutex> lock(mu());
        return path();
    }

private:
    static std::mutex& mu() { static std::mutex m; return m; }
    static std::filesystem::path& path() { static std::filesystem::path p; return p; }

    static std::string ToString(Level lvl)
    {
        switch(lvl)
        {
        case Level::Debug: return "DBG";
        case Level::Info:  return "INF";
        case Level::Warn:  return "WRN";
        case Level::Error: return "ERR";
        }
        return "UNK";
    }

    static std::string Timestamp()
    {
        using namespace std::chrono;
        auto now = system_clock::now();
        auto t = system_clock::to_time_t(now);
        std::tm tm{};
        localtime_s(&tm, &t);

        auto ms = duration_cast<milliseconds>(now.time_since_epoch()) % 1000;
        std::ostringstream ss;
        ss << std::put_time(&tm, "%Y-%m-%d %H:%M:%S")
           << '.' << std::setfill('0') << std::setw(3) << ms.count();
        return ss.str();
    }

    static std::filesystem::path DefaultLogPath(const std::wstring& fileName)
    {
        wchar_t buf[MAX_PATH]{};
        if(::GetModuleFileNameW(nullptr, buf, MAX_PATH) == 0)
            return std::filesystem::path(fileName);

        auto exeDir = std::filesystem::path(buf).parent_path();
        return exeDir / L"logs" / fileName;
    }

    static void EnsureDir(const std::filesystem::path& dir)
    {
        std::error_code ec;
        std::filesystem::create_directories(dir, ec);
    }
};

inline void Debug(const std::string& tag, const std::string& msg) { Logger::Write(Level::Debug, tag, msg); }
inline void Info(const std::string& tag, const std::string& msg)  { Logger::Write(Level::Info, tag, msg); }
inline void Warn(const std::string& tag, const std::string& msg)  { Logger::Write(Level::Warn, tag, msg); }
inline void Error(const std::string& tag, const std::string& msg) { Logger::Write(Level::Error, tag, msg); }

}
