#include "OrderManagementSystem.h"
#include <iostream>
#include <chrono>

namespace TradingBot::Core::Trading {

    OrderManagementSystem::OrderManagementSystem(RestExecutor& executor, 
                                                 RiskManager& riskManager)
        : restExecutor_(executor), riskManager_(riskManager)
    {
    }

    // ???????????????????????????????????????????????????????????????
    // SubmitOrder: Отправка ордера (через RiskManager)
    // ???????????????????????????????????????????????????????????????
    SubmitResult OrderManagementSystem::SubmitOrder(const OrderRequest& request) {
        SubmitResult result;

        // 1. Pre-trade validation через RiskManager
        Strategy::OrderRequest riskRequest;
        riskRequest.entryPrice = request.price;
        riskRequest.quantity = request.quantity;

        RiskCheckResult riskCheck = riskManager_.ValidateOrder(riskRequest, request.price);

        if (!riskCheck.approved) {
            result.success = false;
            result.errorMessage = std::string("Risk check failed: ") + riskCheck.message;
            
            std::cerr << "[OMS] Order REJECTED: " << result.errorMessage << std::endl;
            return result;
        }

        // 2. Генерируем clientOrderId, если не задан
        OrderRequest modifiedRequest = request;
        if (modifiedRequest.clientOrderId == 0) {
            modifiedRequest.clientOrderId = GenerateClientOrderId();
        }

        // 3. Добавляем в pool (состояние PENDING)
        size_t orderSlot = AllocateOrder(modifiedRequest);

        // 4. Отправляем на биржу
        result = restExecutor_.SubmitOrder(modifiedRequest);

        if (result.success) {
            // Обновляем состояние: PENDING -> SENT
            LiveOrder& order = orderPool_[orderSlot];
            order.state = OrderState::Sent;
            order.exchangeOrderId = result.exchangeOrderId;

            std::cout << "[OMS] Order SENT: clientOrderId=" << modifiedRequest.clientOrderId
                      << ", exchangeOrderId=" << result.exchangeOrderId << std::endl;
        } else {
            // Отправка не удалась, удаляем из pool
            RemoveOrder(modifiedRequest.clientOrderId);

            std::cerr << "[OMS] Order FAILED: " << result.errorMessage << std::endl;
        }

        return result;
    }

    // ???????????????????????????????????????????????????????????????
    // CancelOrder: Отмена ордера
    // ???????????????????????????????????????????????????????????????
    CancelResult OrderManagementSystem::CancelOrder(uint64_t clientOrderId) {
        CancelResult result;

        // 1. Найти ордер в pool
        auto it = orderIndex_.find(clientOrderId);
        if (it == orderIndex_.end()) {
            result.success = false;
            result.errorMessage = "Order not found";
            return result;
        }

        size_t orderSlot = it->second;
        LiveOrder& order = orderPool_[orderSlot];

        // 2. Отправить cancel на биржу
        result = restExecutor_.CancelOrder(order.symbol, clientOrderId);

        if (result.success) {
            std::cout << "[OMS] Order CANCELED: clientOrderId=" << clientOrderId << std::endl;
        } else {
            std::cerr << "[OMS] Cancel FAILED: " << result.errorMessage << std::endl;
        }

        return result;
    }

    // ???????????????????????????????????????????????????????????????
    // ReplaceOrder: Atomic cancel + new order
    // ???????????????????????????????????????????????????????????????
    SubmitResult OrderManagementSystem::ReplaceOrder(uint64_t clientOrderId, double newPrice) {
        // 1. Cancel старый ордер
        CancelResult cancelResult = CancelOrder(clientOrderId);

        if (!cancelResult.success) {
            SubmitResult result;
            result.success = false;
            result.errorMessage = "Failed to cancel old order";
            return result;
        }

        // 2. Создать новый ордер с новой ценой
        auto it = orderIndex_.find(clientOrderId);
        if (it == orderIndex_.end()) {
            SubmitResult result;
            result.success = false;
            result.errorMessage = "Original order not found";
            return result;
        }

        LiveOrder& oldOrder = orderPool_[it->second];

        OrderRequest newRequest;
        newRequest.symbol = oldOrder.symbol;
        newRequest.side = oldOrder.side;
        newRequest.type = oldOrder.type;
        newRequest.quantity = oldOrder.originalQty - oldOrder.executedQty; // Остаток
        newRequest.price = newPrice;

        return SubmitOrder(newRequest);
    }

    // ???????????????????????????????????????????????????????????????
    // ProcessExecutionReport: Обработка отчёта об исполнении
    // ???????????????????????????????????????????????????????????????
    void OrderManagementSystem::ProcessExecutionReport(const ExecutionReport& report) {
        auto it = orderIndex_.find(report.clientOrderId);
        if (it == orderIndex_.end()) {
            // Ордер не найден в pool (возможно, уже удалён)
            return;
        }

        size_t orderSlot = it->second;
        UpdateOrder(orderSlot, report);

        // Обновляем позицию в RiskManager
        riskManager_.UpdatePosition(report);

        // Если ордер завершён, удаляем из pool
        if (report.state == OrderState::Filled ||
            report.state == OrderState::Canceled ||
            report.state == OrderState::Rejected ||
            report.state == OrderState::Expired) {
            
            RemoveOrder(report.clientOrderId);
        }
    }

    // ???????????????????????????????????????????????????????????????
    // Chasing: Включение/выключение
    // ???????????????????????????????????????????????????????????????
    void OrderManagementSystem::EnableChasing(uint64_t clientOrderId, double maxSlippage) {
        chasingOrders_[clientOrderId] = maxSlippage;
        std::cout << "[OMS] Chasing ENABLED for order " << clientOrderId << std::endl;
    }

    void OrderManagementSystem::DisableChasing(uint64_t clientOrderId) {
        chasingOrders_.erase(clientOrderId);
        std::cout << "[OMS] Chasing DISABLED for order " << clientOrderId << std::endl;
    }

    // ???????????????????????????????????????????????????????????????
    // GetOrder: Получить ордер по clientOrderId
    // ???????????????????????????????????????????????????????????????
    const LiveOrder* OrderManagementSystem::GetOrder(uint64_t clientOrderId) const {
        auto it = orderIndex_.find(clientOrderId);
        if (it == orderIndex_.end()) {
            return nullptr;
        }
        return &orderPool_[it->second];
    }

    // ???????????????????????????????????????????????????????????????
    // Internal Helpers
    // ???????????????????????????????????????????????????????????????

    uint64_t OrderManagementSystem::GenerateClientOrderId() {
        // Timestamp-based ID (nanoseconds)
        return std::chrono::duration_cast<std::chrono::nanoseconds>(
            std::chrono::system_clock::now().time_since_epoch()
        ).count();
    }

    size_t OrderManagementSystem::AllocateOrder(const OrderRequest& request) {
        size_t slot = activeCount_.fetch_add(1, std::memory_order_acq_rel);

        if (slot >= orderPool_.size()) {
            // Pool переполнен (не должно случиться при правильном использовании)
            activeCount_.fetch_sub(1, std::memory_order_acq_rel);
            throw std::runtime_error("Order pool full");
        }

        LiveOrder& order = orderPool_[slot];
        order.clientOrderId = request.clientOrderId;
        order.exchangeOrderId = 0;
        order.state = OrderState::Pending;
        order.symbol = std::string(request.symbol);
        order.side = request.side;
        order.type = request.type;
        order.originalQty = request.quantity;
        order.executedQty = 0.0;
        order.avgPrice = 0.0;
        order.lastUpdateTimeNs = request.createTimeNs;

        orderIndex_[request.clientOrderId] = slot;

        return slot;
    }

    void OrderManagementSystem::UpdateOrder(size_t index, const ExecutionReport& report) {
        LiveOrder& order = orderPool_[index];
        order.exchangeOrderId = report.exchangeOrderId;
        order.state = report.state;
        order.executedQty = report.executedQty;
        order.avgPrice = report.avgPrice;
        order.lastUpdateTimeNs = report.timestampMs * 1000000; // ms -> ns
    }

    void OrderManagementSystem::RemoveOrder(uint64_t clientOrderId) {
        auto it = orderIndex_.find(clientOrderId);
        if (it == orderIndex_.end()) {
            return;
        }

        size_t slot = it->second;
        orderIndex_.erase(it);

        // Уменьшаем счётчик активных ордеров
        size_t currentCount = activeCount_.fetch_sub(1, std::memory_order_acq_rel);

        // Если удалённый ордер не последний, перемещаем последний на его место
        if (slot < currentCount - 1) {
            orderPool_[slot] = orderPool_[currentCount - 1];
            
            // Обновляем индекс
            uint64_t movedOrderId = orderPool_[slot].clientOrderId;
            orderIndex_[movedOrderId] = slot;
        }
    }

} // namespace TradingBot::Core::Trading
