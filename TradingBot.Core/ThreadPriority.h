#pragma once

#include <thread>

#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>
#include <processthreadsapi.h>
#endif

namespace TradingBot::Core {

    // ???????????????????????????????????????????????????????????????????????????????
    // Thread Priority Management for HFT Applications
    // ???????????????????????????????????????????????????????????????????????????????
    
    enum class ThreadPriority {
        Idle,           // Background tasks
        Low,            // Non-critical tasks
        Normal,         // Default priority
        High,           // Important tasks
        TimeCritical    // Ultra-low latency (network, parsing)
    };

    class ThreadPriorityManager {
    public:
        // Set priority for current thread
        static bool SetCurrentThreadPriority(ThreadPriority priority) {
#ifdef _WIN32
            int winPriority;
            switch (priority) {
                case ThreadPriority::Idle:
                    winPriority = THREAD_PRIORITY_IDLE;
                    break;
                case ThreadPriority::Low:
                    winPriority = THREAD_PRIORITY_BELOW_NORMAL;
                    break;
                case ThreadPriority::Normal:
                    winPriority = THREAD_PRIORITY_NORMAL;
                    break;
                case ThreadPriority::High:
                    winPriority = THREAD_PRIORITY_ABOVE_NORMAL;
                    break;
                case ThreadPriority::TimeCritical:
                    winPriority = THREAD_PRIORITY_TIME_CRITICAL;
                    break;
                default:
                    winPriority = THREAD_PRIORITY_NORMAL;
            }
            
            HANDLE hThread = GetCurrentThread();
            return ::SetThreadPriority(hThread, winPriority) != 0;  // Use Windows API directly
#else
            // Linux: Use pthread_setschedparam with SCHED_FIFO or SCHED_RR
            // For now, return true (not implemented)
            return true;
#endif
        }

        // Set priority for specific thread
        static bool SetThreadPriority(std::thread& thread, ThreadPriority priority) {
#ifdef _WIN32
            int winPriority;
            switch (priority) {
                case ThreadPriority::Idle:
                    winPriority = THREAD_PRIORITY_IDLE;
                    break;
                case ThreadPriority::Low:
                    winPriority = THREAD_PRIORITY_BELOW_NORMAL;
                    break;
                case ThreadPriority::Normal:
                    winPriority = THREAD_PRIORITY_NORMAL;
                    break;
                case ThreadPriority::High:
                    winPriority = THREAD_PRIORITY_ABOVE_NORMAL;
                    break;
                case ThreadPriority::TimeCritical:
                    winPriority = THREAD_PRIORITY_TIME_CRITICAL;
                    break;
                default:
                    winPriority = THREAD_PRIORITY_NORMAL;
            }
            
            HANDLE hThread = reinterpret_cast<HANDLE>(thread.native_handle());
            return ::SetThreadPriority(hThread, winPriority) != 0;
#else
            return true;
#endif
        }

        // Set CPU affinity (pin thread to specific core)
        static bool SetThreadAffinity(std::thread& thread, int coreId) {
#ifdef _WIN32
            HANDLE hThread = reinterpret_cast<HANDLE>(thread.native_handle());
            DWORD_PTR mask = 1ULL << coreId;
            return SetThreadAffinityMask(hThread, mask) != 0;
#else
            // Linux: Use pthread_setaffinity_np
            return true;
#endif
        }

        // Boost current thread for time-critical section
        static bool BoostCurrentThread() {
            return SetCurrentThreadPriority(ThreadPriority::TimeCritical);
        }

        // Restore normal priority
        static bool RestoreCurrentThread() {
            return SetCurrentThreadPriority(ThreadPriority::Normal);
        }
    };

    // ???????????????????????????????????????????????????????????????????????????????
    // RAII Guard for thread priority boost
    // ???????????????????????????????????????????????????????????????????????????????
    class ThreadPriorityGuard {
    public:
        explicit ThreadPriorityGuard(ThreadPriority priority) {
            ThreadPriorityManager::SetCurrentThreadPriority(priority);
        }

        ~ThreadPriorityGuard() {
            ThreadPriorityManager::RestoreCurrentThread();
        }

        ThreadPriorityGuard(const ThreadPriorityGuard&) = delete;
        ThreadPriorityGuard& operator=(const ThreadPriorityGuard&) = delete;
    };

} // namespace TradingBot::Core
