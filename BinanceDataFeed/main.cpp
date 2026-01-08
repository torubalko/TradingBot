#include <iostream>
#include <string>
#include <csignal>
#include <atomic>
#include <thread>
#include <chrono>
#include <iomanip>

#include "HighSpeedDataFeed.h"

using namespace hft;

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
    int64_t lastStatsTime = HighResTimer::NowMs();
    int64_t lastFullReportTime = HighResTimer::NowMs();

    while (g_Running) {
        std::this_thread::sleep_for(std::chrono::milliseconds(100));

        if (!g_Running || !g_DataFeed) break;

        int64_t now = HighResTimer::NowMs();

        // Print stats every second
        if (now - lastStatsTime >= 1000) {
            lastStatsTime = now;

            // Get order book data
            if (g_DataFeed->HasOrderBook(symbol)) {
                const auto& ob = g_DataFeed->GetOrderBook(symbol);

                // Get atomic counters
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

                // Single line compact output
                std::cout << std::fixed << std::setprecision(2)
                          << "[" << symbol << "] "
                          << "Mid: " << ob.GetMidPrice()
                          << " | Spread: " << ob.GetSpreadBps() << "bps"
                          << " | Depth: " << depthUpdates << "/s"
                          << " | Ticks: " << bookTickerUpdates << "/s"
                          << " | Trades: " << trades << " ($" << std::setprecision(0) << tradeVol << ")"
                          << " | Levels: " << ob.BidLevels() << "/" << ob.AskLevels()
                          << " | Drops: " << g_DataFeed->GetDroppedMessages()
                          << " | Qmax: " << g_DataFeed->GetQueueHighWaterMark()
                          << "\n    " << lt.GetSummaryString()
                          << std::endl;
            }
        }

        // Print full latency report every 10 seconds
        if (now - lastFullReportTime >= 10000) {
            lastFullReportTime = now;
            std::cout << "\n" << g_DataFeed->GetLatencyTracker().GetSummaryString() << "\n" << std::endl;
        }
    }
}

// ═══════════════════════════════════════════════════════════════════════════════
// MAIN
// ═══════════════════════════════════════════════════════════════════════════════
int main(int argc, char* argv[]) {
    std::signal(SIGINT, SignalHandler);
    std::signal(SIGTERM, SignalHandler);
    
    std::cout << R"(
╔═══════════════════════════════════════════════════════════════════════════════╗
║   BINANCE HFT DATA FEED - Ultra-Low Latency Market Data                       ║
║   Lock-Free Architecture | Multi-Threaded | simdjson Parsing                  ║
╚═══════════════════════════════════════════════════════════════════════════════╝
)" << std::endl;
    
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
    config.messageQueueSize = 16384;
    config.enableLatencyTracking = true;
    config.enableDetailedLogging = false;
    
    std::cout << "[CONFIG] Symbol: " << symbol << "\n";
    std::cout << "[CONFIG] Streams: depth@100ms, bookTicker, aggTrade\n";
    std::cout << "[CONFIG] Threads: " << config.numParserThreads << " parser, " 
              << std::thread::hardware_concurrency() << " CPU cores\n\n";
    
    try {
        g_DataFeed = std::make_unique<BinanceDataFeed>(config);
        
        // Set lightweight callbacks (no I/O!)
        g_DataFeed->SetDepthUpdateCallback(OnDepthUpdate);
        g_DataFeed->SetBookTickerCallback(OnBookTicker);
        g_DataFeed->SetAggTradeCallback(OnAggTrade);
        
        g_DataFeed->Start();
        
        std::cout << "[STATUS] Data feed started. Press Ctrl+C to stop.\n\n";
        
        // Start display thread (single thread for all output)
        std::thread displayThread(DisplayThread, symbol);
        
        // Wait for shutdown
        while (g_Running) {
            std::this_thread::sleep_for(std::chrono::milliseconds(100));
        }
        
        g_DataFeed->Stop();
        
        if (displayThread.joinable()) {
            displayThread.join();
        }
        
        // Final report
        std::cout << "\n[FINAL REPORT]\n";
        g_DataFeed->GetLatencyTracker().PrintReport();
        
    } catch (const std::exception& e) {
        std::cerr << "[FATAL] " << e.what() << std::endl;
        return 1;
    }
    
    std::cout << "[STATUS] Shutdown complete.\n";
    return 0;
}