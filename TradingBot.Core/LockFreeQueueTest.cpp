// Simple test file for LockFreeQueue - validates basic functionality
// This is not a full test suite, just a sanity check

#include "LockFreeQueue.h"
#include <iostream>
#include <string>
#include <cassert>

using namespace TradingBot::Core::LockFree;

void TestBasicOperations() {
    LockFreeQueue<int, 8> queue;
    
    // Test empty queue
    assert(queue.Empty());
    assert(queue.Size() == 0);
    
    // Test TryEmplace and TryPop
    assert(queue.TryEmplace(42));
    assert(!queue.Empty());
    assert(queue.Size() == 1);
    
    auto result = queue.TryPop();
    assert(result.has_value());
    assert(*result == 42);
    assert(queue.Empty());
    
    // Test multiple elements
    for (int i = 0; i < 8; ++i) {
        assert(queue.TryEmplace(i * 10));
    }
    
    // Queue should be full now (capacity = 8)
    assert(!queue.TryEmplace(999)); // Should fail
    
    // Pop all elements
    for (int i = 0; i < 8; ++i) {
        auto val = queue.TryPop();
        assert(val.has_value());
        assert(*val == i * 10);
    }
    
    assert(queue.Empty());
    
    std::cout << "TestBasicOperations: PASSED\n";
}

void TestWithStrings() {
    LockFreeQueue<std::string, 4> queue;
    
    assert(queue.TryEmplace("Hello"));
    assert(queue.TryEmplace("World"));
    assert(queue.TryEmplace("Lock"));
    assert(queue.TryEmplace("Free"));
    
    assert(queue.Size() == 4);
    
    auto s1 = queue.TryPop();
    assert(s1.has_value() && *s1 == "Hello");
    
    auto s2 = queue.TryPop();
    assert(s2.has_value() && *s2 == "World");
    
    auto s3 = queue.TryPop();
    assert(s3.has_value() && *s3 == "Lock");
    
    auto s4 = queue.TryPop();
    assert(s4.has_value() && *s4 == "Free");
    
    assert(queue.Empty());
    
    std::cout << "TestWithStrings: PASSED\n";
}

struct NonTrivial {
    int* data;
    
    NonTrivial(int val) : data(new int(val)) {}
    NonTrivial(const NonTrivial&) = delete;
    NonTrivial& operator=(const NonTrivial&) = delete;
    
    NonTrivial(NonTrivial&& other) noexcept : data(other.data) {
        other.data = nullptr;
    }
    
    NonTrivial& operator=(NonTrivial&& other) noexcept {
        if (this != &other) {
            delete data;
            data = other.data;
            other.data = nullptr;
        }
        return *this;
    }
    
    ~NonTrivial() {
        delete data;
    }
    
    int value() const { return data ? *data : -1; }
};

void TestNonTrivialType() {
    LockFreeQueue<NonTrivial, 4> queue;
    
    queue.TryEmplace(100);
    queue.TryEmplace(200);
    
    auto obj1 = queue.TryPop();
    assert(obj1.has_value());
    assert(obj1->value() == 100);
    
    auto obj2 = queue.TryPop();
    assert(obj2.has_value());
    assert(obj2->value() == 200);
    
    assert(queue.Empty());
    
    std::cout << "TestNonTrivialType: PASSED\n";
}

#ifndef NO_MAIN
int main() {
    std::cout << "Running LockFreeQueue tests...\n\n";
    
    TestBasicOperations();
    TestWithStrings();
    TestNonTrivialType();
    
    std::cout << "\nAll tests PASSED!\n";
    return 0;
}
#endif
