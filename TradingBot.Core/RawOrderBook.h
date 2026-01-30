#pragma once
#include <atomic>
#include <cstdint>
#include <cstddef>
#include <cmath>

// Tiger-style RAW order book: fixed arrays, zero alloc, single-writer (OrderBook thread)
// No STL containers or locks on the hot path.

namespace TradingBot::Core::Raw {

constexpr int MAX_LEVELS = 6000;        // wide/deep book
constexpr double EPS = 1e-12;

struct Level {
    double price;
    double qty;
};

struct SideBook {
    Level levels[MAX_LEVELS];
    int size;

    void Clear() { size = 0; }

    // linear search (acceptable with fixed upper bound)
    int Find(double price) const {
        for (int i = 0; i < size; ++i) {
            if (std::fabs(levels[i].price - price) < EPS) return i;
        }
        return -1;
    }

    // bids sorted DESC, asks sorted ASC
    template<bool IsBid>
    void Upsert(double price, double qty) {
        if (qty <= EPS) {
            Remove<IsBid>(price);
            return;
        }
        int idx = Find(price);
        if (idx >= 0) {
            levels[idx].qty = qty;
            return;
        }
        if (size >= MAX_LEVELS) return; // drop if overflow

        // insert keeping order
        int pos = size;
        if constexpr (IsBid) {
            while (pos > 0 && levels[pos - 1].price < price) {
                levels[pos] = levels[pos - 1];
                --pos;
            }
        } else {
            while (pos > 0 && levels[pos - 1].price > price) {
                levels[pos] = levels[pos - 1];
                --pos;
            }
        }
        levels[pos].price = price;
        levels[pos].qty = qty;
        ++size;
    }

    template<bool IsBid>
    void Remove(double price) {
        int idx = Find(price);
        if (idx < 0) return;
        for (int i = idx + 1; i < size; ++i) {
            levels[i - 1] = levels[i];
        }
        --size;
    }
};

struct BookState {
    SideBook bids;
    SideBook asks;
    int64_t lastUpdateId;
};

struct SnapshotView {
    const SideBook* bids;
    const SideBook* asks;
    int64_t lastUpdateId;
};

class RawOrderBook {
public:
    RawOrderBook() : active_(0) {
        buffers_[0].bids.Clear();
        buffers_[0].asks.Clear();
        buffers_[1].bids.Clear();
        buffers_[1].asks.Clear();
        buffers_[0].lastUpdateId = 0;
        buffers_[1].lastUpdateId = 0;
    }

    void Reset() {
        buffers_[0].bids.Clear();
        buffers_[0].asks.Clear();
        buffers_[1].bids.Clear();
        buffers_[1].asks.Clear();
        buffers_[0].lastUpdateId = 0;
        buffers_[1].lastUpdateId = 0;
        active_.store(0, std::memory_order_release);
    }

    // REST snapshot (deep). Uplevels expected sorted.
    void ApplySnapshot(int64_t lastUpdateId,
                       const Level* bids, int bidCount,
                       const Level* asks, int askCount) {
        BookState& target = buffers_[NextIndex()];
        target.bids.Clear();
        target.asks.Clear();
        target.lastUpdateId = lastUpdateId;

        const int bc = (bidCount > MAX_LEVELS) ? MAX_LEVELS : bidCount;
        for (int i = 0; i < bc; ++i) {
            target.bids.levels[i] = bids[i];
        }
        target.bids.size = bc;

        const int ac = (askCount > MAX_LEVELS) ? MAX_LEVELS : askCount;
        for (int i = 0; i < ac; ++i) {
            target.asks.levels[i] = asks[i];
        }
        target.asks.size = ac;

        PublishNext();
    }

    // Binance diff depth (single-thread writer). Enforces U/u rules.
    // Returns false if out-of-sync.
    bool ApplyDelta(int64_t U, int64_t u,
                    const Level* bidUpd, int bidCount,
                    const Level* askUpd, int askCount) {
        BookState& target = buffers_[NextIndex()];
        const BookState& prev = buffers_[ActiveIndex()];

        // initial copy
        target = prev;

        // Accept any forward-moving update; drop only stale
        if (u <= prev.lastUpdateId) {
            return false; // stale
        }

        for (int i = 0; i < bidCount; ++i) {
            target.bids.Upsert<true>(bidUpd[i].price, bidUpd[i].qty);
        }
        for (int i = 0; i < askCount; ++i) {
            target.asks.Upsert<false>(askUpd[i].price, askUpd[i].qty);
        }

        target.lastUpdateId = u;
        PublishNext();
        return true;
    }

    SnapshotView GetSnapshot() const {
        const BookState& s = buffers_[ActiveIndex()];
        return SnapshotView{ &s.bids, &s.asks, s.lastUpdateId };
    }

    const BookState* SnapshotPtr() const {
        return &buffers_[ActiveIndex()];
    }

private:
    int ActiveIndex() const { return active_.load(std::memory_order_acquire); }
    int NextIndex() const { return active_.load(std::memory_order_relaxed) ^ 1; }

    void PublishNext() { active_.store(active_.load(std::memory_order_relaxed) ^ 1, std::memory_order_release); }

    BookState buffers_[2];
    std::atomic<int> active_;
};

// Compression layer (read-only). groupSize>0.
struct CompressedLevel {
    double price;
    double qty;
};

struct CompressedSide {
    CompressedLevel levels[MAX_LEVELS];
    int size;
};

inline void CompressSide(const SideBook& src, CompressedSide& dst, double groupSize, bool isBid) {
    dst.size = 0;
    if (groupSize <= 0.0) return;
    int lastIndex = -1;
    for (int i = 0; i < src.size; ++i) {
        double p = src.levels[i].price;
        double bucket = std::floor(p / groupSize) * groupSize;
        if (dst.size == 0 || std::fabs(dst.levels[lastIndex].price - bucket) > EPS) {
            if (dst.size >= MAX_LEVELS) break;
            ++lastIndex;
            dst.levels[lastIndex].price = bucket;
            dst.levels[lastIndex].qty = src.levels[i].qty;
            dst.size = lastIndex + 1;
        } else {
            dst.levels[lastIndex].qty += src.levels[i].qty;
        }
    }
}

} // namespace TradingBot::Core::Raw
