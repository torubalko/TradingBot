#include <iostream>
#include <string>
#include <csignal>
#include <atomic>
#include <thread>
#include <chrono>
#include <iomanip>
#ifdef _WIN32
extern "C" __declspec(dllimport) int __stdcall FreeConsole(void);
#pragma comment(linker, "/SUBSYSTEM:WINDOWS /ENTRY:mainCRTStartup")
#endif

#include "HighSpeedDataFeed.h"

using namespace hft;

static constexpr bool kShowConsole = false;

// ═══════════════════════════════════════════════════════════════════════════════
// Global state
// ═══════════════════════════════════════════════════════════════════════════════
std::atomic<bool> g_Running{true};
std::unique_ptr<BinanceDataFeed> g_DataFeed;

// Atomic counters for stats (lock-free)
std::atomic<int64_t> g_DepthUpdates{0};
std::atomic<int64_t> g_BookTickerUpdates{0};
std::atomic<int64_t> g_TradeCount{0};
std::atomic<double> g_TradeVolume{0};
std::atomic<double> g_LastTradePrice{0};
std::atomic<bool> g_LastTradeSide{false};

// ═══════════════════════════════════════════════════════════════════════════════
// Signal handler
// ═══════════════════════════════════════════════════════════════════════════════
void SignalHandler(int signal) {
    std::cout << "\n[SIGNAL] Shutting down...\n";
    g_Running = false;
}

// ═══════════════════════════════════════════════════════════════════════════════
// Callbacks - just update atomic counters (no console output!)
// ═══════════════════════════════════════════════════════════════════════════════

void OnDepthUpdate(const std::string& symbol, const ParsedDepthUpdate& update) {
    g_DepthUpdates.fetch_add(1, std::memory_order_relaxed);
}

void OnBookTicker(const std::string& symbol, const ParsedBookTicker& ticker) {
    g_BookTickerUpdates.fetch_add(1, std::memory_order_relaxed);
}

void OnAggTrade(const std::string& symbol, const ParsedAggTrade& trade) {
    g_TradeCount.fetch_add(1, std::memory_order_relaxed);
    
    // Atomic double update (relaxed, ok for stats)
    double vol = trade.price * trade.quantity;
    double oldVol = g_TradeVolume.load(std::memory_order_relaxed);
    while (!g_TradeVolume.compare_exchange_weak(oldVol, oldVol + vol, std::memory_order_relaxed));
    
    g_LastTradePrice.store(trade.price, std::memory_order_relaxed);
    g_LastTradeSide.store(trade.isBuyerMaker, std::memory_order_relaxed);
}

// ═══════════════════════════════════════════════════════════════════════════════
// Display thread - single thread for all console output (no races!)
// ═══════════════════════════════════════════════════════════════════════════════
void DisplayThread(const std::string& symbol) {
    size_t lastLen = 0;

    while (g_Running) {
        std::this_thread::sleep_for(std::chrono::milliseconds(100)); // ~10 Hz

        if (!g_Running || !g_DataFeed) break;

        if (g_DataFeed->HasOrderBook(symbol)) {
            const auto& ob = g_DataFeed->GetOrderBook(symbol);

            int64_t depthUpdates = g_DepthUpdates.exchange(0, std::memory_order_relaxed);
            int64_t bookTickerUpdates = g_BookTickerUpdates.exchange(0, std::memory_order_relaxed);
            int64_t trades = g_TradeCount.exchange(0, std::memory_order_relaxed);

            double tradeVol = 0;
            double oldVol = g_TradeVolume.load(std::memory_order_relaxed);
            while (!g_TradeVolume.compare_exchange_weak(oldVol, 0.0, std::memory_order_relaxed)) {
                oldVol = g_TradeVolume.load(std::memory_order_relaxed);
            }
            tradeVol = oldVol;

            auto& lt = g_DataFeed->GetLatencyTracker();

            std::ostringstream line;
            line << std::fixed << std::setprecision(2)
                 << "[" << symbol << "] "
                 << "Mid: " << ob.GetMidPrice()
                 << " | Spread: " << ob.GetSpreadBps() << "bps"
                 << " | Depth: " << depthUpdates << "/s"
                 << " | Ticks: " << bookTickerUpdates << "/s"
                 << " | Trades: " << trades << " ($" << std::setprecision(0) << tradeVol << ")"
                 << " | Levels: " << ob.BidLevels() << "/" << ob.AskLevels()
                 << " | Drops: " << g_DataFeed->GetDroppedMessages()
                 << " | Qmax: " << g_DataFeed->GetQueueHighWaterMark()
                 << " | Total: " << lt.GetEndToEndP99Ms() << "ms"
                 << " | " << lt.GetMessagesPerSecond() << " msg/s";

            std::string out = line.str();
            if (out.size() < lastLen) out.append(lastLen - out.size(), ' ');
            lastLen = out.size();

            std::cout << "\r" << out << std::flush;
        }
    }

    std::cout << std::endl;
}

// ═══════════════════════════════════════════════════════════════════════════════
// MAIN
// ═══════════════════════════════════════════════════════════════════════════════
int main(int argc, char* argv[]) {
    if (!kShowConsole) {
#ifdef _WIN32
        FreeConsole();
#endif
    }

    std::signal(SIGINT, SignalHandler);
    std::signal(SIGTERM, SignalHandler);
    
    if (kShowConsole) {
        std::cout << R"(
╔═══════════════════════════════════════════════════════════════════════════════╗
║   BINANCE HFT DATA FEED - Ultra-Low Latency Market Data                       ║
║   Lock-Free Architecture | Multi-Threaded | simdjson Parsing                  ║
╚═══════════════════════════════════════════════════════════════════════════════╝
)" << std::endl;
    }
    
    // Parse command line
    std::string symbol = "btcusdt";
    if (argc > 1) {
        symbol = argv[1];
        std::transform(symbol.begin(), symbol.end(), symbol.begin(), ::tolower);
    }
    
    // Configuration
    DataFeedConfig config;
    config.host = "fstream.binance.com";
    config.port = "443";
    config.symbols = {symbol};
    
    config.subscribeDepth = true;
    config.subscribeBookTicker = true;
    config.subscribeAggTrade = true;
    
    config.depthSpeed = "@100ms";
    config.numParserThreads = std::max<int>(4, static_cast<int>(std::thread::hardware_concurrency()));
    config.messageQueueSize = 32768;
    config.enableLatencyTracking = true;
    config.enableDetailedLogging = false;
    
    if (kShowConsole) {
        std::cout << "[CONFIG] Symbol: " << symbol << "\n";
        std::cout << "[CONFIG] Streams: depth@100ms, bookTicker, aggTrade\n";
        std::cout << "[CONFIG] Threads: " << config.numParserThreads << " parser, " 
                  << std::thread::hardware_concurrency() << " CPU cores\n\n";
    }
    
    try {
        g_DataFeed = std::make_unique<BinanceDataFeed>(config);
        
        // Set lightweight callbacks (no I/O!)
        g_DataFeed->SetDepthUpdateCallback(OnDepthUpdate);
        g_DataFeed->SetBookTickerCallback(OnBookTicker);
        g_DataFeed->SetAggTradeCallback(OnAggTrade);
        
        g_DataFeed->Start();
        
        if (kShowConsole) {
            std::cout << "[STATUS] Data feed started. Press Ctrl+C to stop.\n\n";
        }
        
        std::thread displayThread;
        if (kShowConsole) {
            // Start display thread (single thread for all output)
            displayThread = std::thread(DisplayThread, symbol);
        }
        
        // Wait for shutdown
        while (g_Running) {
            std::this_thread::sleep_for(std::chrono::milliseconds(100));
        }
        
        g_DataFeed->Stop();
        
        if (displayThread.joinable()) {
            displayThread.join();
        }
        
        if (kShowConsole) {
            // Final report
            std::cout << "\n[FINAL REPORT]\n";
            g_DataFeed->GetLatencyTracker().PrintReport();
        }
        
    } catch (const std::exception& e) {
        if (kShowConsole) {
            std::cerr << "[FATAL] " << e.what() << std::endl;
        }
        return 1;
    }
    
    if (kShowConsole) {
        std::cout << "[STATUS] Shutdown complete.\n";
    }
    return 0;
}