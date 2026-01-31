#pragma once

#include <string>
#include <string_view>
#include <unordered_map>
#include <shared_mutex>
#include <vector>
#include <charconv>
#include <sstream>

#include "../simdjson/simdjson-master/singleheader/simdjson.h"

#ifdef _WIN32
#include <windows.h>
#endif

namespace TradingBot::Core {

struct PositionSnapshot {
    double positionAmt{0.0};
    double entryPrice{0.0};
    double unrealizedPnl{0.0};
    double markPrice{0.0};
    double isolatedWallet{0.0};
    double initialMargin{0.0};
    double maintMargin{0.0};
    std::string positionSide;
    int64_t updateTime{0};
};

struct OrderTradeUpdate {
    int64_t orderId{0};
    int64_t tradeTime{0};
    double price{0.0};
    double quantity{0.0};
    double avgPrice{0.0};
    double lastFilledQty{0.0};
    double cumFilledQty{0.0};
    std::string symbol;
    std::string orderStatus;
    std::string orderType;
    std::string side;
    std::string positionSide;
};

class UserStreamState {
public:
    void ApplyPayload(std::string_view payload) {
        try {
            auto docRes = parser_.iterate(payload.data(), payload.size(), payload.size() + simdjson::SIMDJSON_PADDING);
            if (docRes.error()) {
                return;
            }
            simdjson::ondemand::document doc = std::move(docRes).value();
            std::string_view eventType;
            if (doc["e"].get_string().get(eventType)) {
                return;
            }
            if (eventType == "ACCOUNT_UPDATE") {
                HandleAccountUpdate(doc);
                return;
            }
            if (eventType == "ORDER_TRADE_UPDATE") {
                HandleOrderTradeUpdate(doc);
                return;
            }
        } catch (...) {
        }
    }

    std::unordered_map<std::string, PositionSnapshot> GetPositions() const {
        std::shared_lock lock(mutex_);
        return positions_;
    }

    std::unordered_map<int64_t, OrderTradeUpdate> GetOrderUpdates() const {
        std::shared_lock lock(mutex_);
        return orderUpdates_;
    }

private:
    void HandleAccountUpdate(simdjson::ondemand::document& doc) {
        int64_t eventTime = 0;
        auto eventTimeRes = doc["E"].get_int64();
        if (!eventTimeRes.error()) {
            eventTime = eventTimeRes.value();
        }

        auto accountObj = doc["a"];
        auto positionsObj = accountObj["P"].get_array();
        if (positionsObj.error()) {
            return;
        }

        std::unordered_map<std::string, PositionSnapshot> updates;
        for (auto pos : positionsObj.value()) {
            auto objRes = pos.get_object();
            if (objRes.error()) {
                continue;
            }
            auto obj = objRes.value();

            std::string_view symbol;
            if (obj["s"].get_string().get(symbol)) {
                continue;
            }

            PositionSnapshot snap{};
            snap.positionAmt = ParseDouble(obj, "pa");
            snap.entryPrice = ParseDouble(obj, "ep");
            snap.unrealizedPnl = ParseDouble(obj, "up");
            snap.markPrice = ParseDouble(obj, "mp");
            snap.isolatedWallet = ParseDouble(obj, "iw");
            snap.initialMargin = ParseDouble(obj, "im");
            snap.maintMargin = ParseDouble(obj, "ma");
            snap.positionSide = ParseString(obj, "ps");
            snap.updateTime = eventTime;
            updates.emplace(std::string(symbol), std::move(snap));
        }

        if (!updates.empty()) {
            std::unique_lock lock(mutex_);
            for (auto& [sym, snap] : updates) {
                positions_[sym] = std::move(snap);
            }
        }

#ifdef _WIN32
        std::ostringstream oss;
        oss << "[UserStream] ACCOUNT_UPDATE positions=" << updates.size() << "\n";
        OutputDebugStringA(oss.str().c_str());
#endif
    }

    void HandleOrderTradeUpdate(simdjson::ondemand::document& doc) {
        auto orderObj = doc["o"].get_object();
        if (orderObj.error()) {
            return;
        }
        auto obj = orderObj.value();

        OrderTradeUpdate update{};
        update.symbol = ParseString(obj, "s");
        update.orderStatus = ParseString(obj, "X");
        update.orderType = ParseString(obj, "o");
        update.side = ParseString(obj, "S");
        update.positionSide = ParseString(obj, "ps");
        update.price = ParseDouble(obj, "p");
        update.avgPrice = ParseDouble(obj, "ap");
        update.quantity = ParseDouble(obj, "q");
        update.lastFilledQty = ParseDouble(obj, "l");
        update.cumFilledQty = ParseDouble(obj, "z");

        auto orderIdRes = obj["i"].get_int64();
        if (!orderIdRes.error()) {
            update.orderId = orderIdRes.value();
        }
        auto tradeTimeRes = obj["T"].get_int64();
        if (!tradeTimeRes.error()) {
            update.tradeTime = tradeTimeRes.value();
        }

        if (update.orderId != 0) {
            std::unique_lock lock(mutex_);
            orderUpdates_[update.orderId] = std::move(update);
        }

#ifdef _WIN32
        std::ostringstream oss;
        oss << "[UserStream] ORDER_TRADE_UPDATE orderId=" << update.orderId
            << " symbol=" << update.symbol
            << " status=" << update.orderStatus
            << " side=" << update.side
            << " qty=" << update.quantity
            << " avgPrice=" << update.avgPrice
            << "\n";
        OutputDebugStringA(oss.str().c_str());
#endif
    }
    static double ParseDouble(simdjson::ondemand::object& obj, const char* field) {
        std::string_view value;
        if (obj[field].get_string().get(value)) {
            return 0.0;
        }
        double out = 0.0;
        std::from_chars(value.data(), value.data() + value.size(), out);
        return out;
    }

    static std::string ParseString(simdjson::ondemand::object& obj, const char* field) {
        std::string_view value;
        if (obj[field].get_string().get(value)) {
            return {};
        }
        return std::string(value);
    }

    mutable std::shared_mutex mutex_;
    std::unordered_map<std::string, PositionSnapshot> positions_;
    std::unordered_map<int64_t, OrderTradeUpdate> orderUpdates_;
    simdjson::ondemand::parser parser_{};
};

} // namespace TradingBot::Core
