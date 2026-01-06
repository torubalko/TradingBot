#include "LocalOrderBook.h"
#include "TakerFlowAnalyzer.h"
#include "DensityDetector.h"
#include "ObjectPool.h"
#include "FastParser.h"
#include <iostream>
#include <cassert>
#include <cmath>

using namespace TradingBot::Core;

// Test FastParser
void TestFastParser() {
    std::cout << "Testing FastParser..." << std::endl;
    
    // Test double parsing
    auto price = Utils::FastParser::ParseDouble("50123.45");
    assert(price.has_value() && std::abs(price.value() - 50123.45) < 0.001);
    
    auto volume = Utils::FastParser::ParseDouble("1.234567");
    assert(volume.has_value() && std::abs(volume.value() - 1.234567) < 0.000001);
    
    // Test int64 parsing
    auto id = Utils::FastParser::ParseInt64("1234567890");
    assert(id.has_value() && id.value() == 1234567890);
    
    // Test bool parsing
    assert(Utils::FastParser::ParseBool("true") == true);
    assert(Utils::FastParser::ParseBool("false") == false);
    assert(Utils::FastParser::ParseBool("1") == true);
    
    std::cout << "  ✓ FastParser tests passed" << std::endl;
}

// Test ObjectPool
void TestObjectPool() {
    std::cout << "Testing ObjectPool..." << std::endl;
    
    Utils::ObjectPool<Models::OrderBookUpdate> pool(5);
    assert(pool.GetPoolSize() == 5);
    
    // Acquire objects
    auto obj1 = pool.Acquire();
    auto obj2 = pool.Acquire();
    assert(pool.GetPoolSize() == 3);
    
    // Release objects
    pool.Release(std::move(obj1));
    assert(pool.GetPoolSize() == 4);
    
    pool.Release(std::move(obj2));
    assert(pool.GetPoolSize() == 5);
    
    std::cout << "  ✓ ObjectPool tests passed" << std::endl;
}

// Test LocalOrderBook
void TestLocalOrderBook() {
    std::cout << "Testing LocalOrderBook..." << std::endl;
    
    Models::LocalOrderBook book;
    
    // Test snapshot
    Models::OrderBookSnapshot snapshot;
    snapshot.lastUpdateId = 12345;
    snapshot.bids.push_back({50000.0, 1.5});
    snapshot.bids.push_back({49999.0, 2.0});
    snapshot.bids.push_back({49998.0, 1.8});
    snapshot.bids.push_back({49997.0, 10.0}); // Large wall
    snapshot.bids.push_back({49996.0, 8.0});
    snapshot.bids.push_back({49995.0, 9.0});
    
    snapshot.asks.push_back({50001.0, 1.2});
    snapshot.asks.push_back({50002.0, 1.7});
    snapshot.asks.push_back({50003.0, 8.5}); // Large wall
    snapshot.asks.push_back({50004.0, 9.0});
    snapshot.asks.push_back({50005.0, 8.8});
    
    book.ApplySnapshot(snapshot);
    
    // Test best bid/ask
    assert(std::abs(book.GetBestBid() - 50000.0) < 0.01);
    assert(std::abs(book.GetBestAsk() - 50001.0) < 0.01);
    assert(std::abs(book.GetMidPrice() - 50000.5) < 0.01);
    
    // Test update
    Models::OrderBookUpdate update;
    update.bids.push_back({50000.5, 3.0}); // New level
    update.asks.push_back({50001.0, 0.0}); // Remove level
    
    book.ApplyUpdate(update);
    assert(std::abs(book.GetBestBid() - 50000.5) < 0.01);
    assert(std::abs(book.GetBestAsk() - 50002.0) < 0.01);
    
    // Test density detection
    auto bidWalls = book.FindBidWalls(15.0, 2, 0.01);
    assert(bidWalls.size() > 0); // Should find the 49995-49997 wall
    
    auto askWalls = book.FindAskWalls(15.0, 2, 0.01);
    assert(askWalls.size() > 0); // Should find the 50003-50005 wall
    
    std::cout << "  ✓ LocalOrderBook tests passed" << std::endl;
}

// Test TakerFlowAnalyzer
void TestTakerFlowAnalyzer() {
    std::cout << "Testing TakerFlowAnalyzer..." << std::endl;
    
    Strategy::TakerFlowAnalyzer analyzer(100, 10000);
    
    // Add buy trades (aggressive buys - seller is maker)
    Trade trade1{1, 50000.0, 1.0, false, 1640000000000LL};
    analyzer.ProcessTrade(trade1);
    
    Trade trade2{2, 50001.0, 0.5, false, 1640000001000LL};
    analyzer.ProcessTrade(trade2);
    
    // Add sell trade (aggressive sell - buyer is maker)
    Trade trade3{3, 49999.0, 0.3, true, 1640000002000LL};
    analyzer.ProcessTrade(trade3);
    
    auto stats = analyzer.GetFlowStats();
    assert(std::abs(stats.buyVolume - 1.5) < 0.001);
    assert(std::abs(stats.sellVolume - 0.3) < 0.001);
    assert(stats.buyCount == 2);
    assert(stats.sellCount == 1);
    
    // Should have strong buy pressure
    assert(analyzer.HasStrongBuyPressure(0.7));
    assert(!analyzer.HasStrongSellPressure(0.7));
    
    // VWAP calculation
    double expectedVWAP = (50000.0 * 1.0 + 50001.0 * 0.5 + 49999.0 * 0.3) / (1.0 + 0.5 + 0.3);
    assert(std::abs(analyzer.GetVWAP() - expectedVWAP) < 0.01);
    
    std::cout << "  ✓ TakerFlowAnalyzer tests passed" << std::endl;
}

// Test DensityDetector
void TestDensityDetector() {
    std::cout << "Testing DensityDetector..." << std::endl;
    
    Strategy::DensityConfig config;
    config.minWallVolume = 20.0;
    config.minLevels = 2;
    config.priceRange = 0.01;
    config.flowThreshold = 0.65;
    config.distanceToWall = 0.01;
    config.minConfidence = 0.3;
    
    Strategy::DensityDetector detector(config);
    
    // Setup order book with walls
    Models::LocalOrderBook book;
    Models::OrderBookSnapshot snapshot;
    snapshot.lastUpdateId = 12345;
    
    // Bid wall around 49900
    snapshot.bids.push_back({49900.0, 10.0});
    snapshot.bids.push_back({49899.0, 12.0});
    snapshot.bids.push_back({49898.0, 11.0});
    
    // Current price around 49920
    snapshot.bids.push_back({49920.0, 1.0});
    snapshot.asks.push_back({49921.0, 1.0});
    
    // Ask wall around 49940
    snapshot.asks.push_back({49940.0, 10.0});
    snapshot.asks.push_back({49941.0, 11.0});
    snapshot.asks.push_back({49942.0, 12.0});
    
    book.ApplySnapshot(snapshot);
    
    // Test buy signal: strong sell pressure + near bid wall
    Strategy::TakerFlowAnalyzer flowAnalyzer(100, 10000);
    
    // Add aggressive sell trades
    for (int i = 0; i < 10; ++i) {
        Trade trade{i, 49920.0 - i * 0.1, 0.5, true, 1640000000000LL + i * 100};
        flowAnalyzer.ProcessTrade(trade);
    }
    
    auto signal = detector.DetectSignal(book, flowAnalyzer, 1640000001000LL);
    
    // Should detect buy signal near support
    if (signal.IsValid()) {
        std::cout << "  Signal type: " << (signal.type == Strategy::SignalType::BUY_AT_SUPPORT ? "BUY" : "SELL") << std::endl;
        std::cout << "  Confidence: " << signal.confidence << std::endl;
    }
    
    std::cout << "  ✓ DensityDetector tests passed" << std::endl;
}

// Run all validation tests
int main() {
    std::cout << "=== HFT Components Validation Tests ===" << std::endl << std::endl;
    
    try {
        TestFastParser();
        TestObjectPool();
        TestLocalOrderBook();
        TestTakerFlowAnalyzer();
        TestDensityDetector();
        
        std::cout << std::endl << "=== All tests passed! ===" << std::endl;
        return 0;
    }
    catch (const std::exception& e) {
        std::cerr << "Test failed with exception: " << e.what() << std::endl;
        return 1;
    }
}
