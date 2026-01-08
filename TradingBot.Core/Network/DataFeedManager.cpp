#include "DataFeedManager.h"
#include <iostream>

namespace TradingBot::Core::Network {

    DataFeedManager::DataFeedManager() {
        // Конструктор: минимальная инициализация
    }

    // ???????????????????????????????????????????????????????????????
    // ProcessMessage: Главный метод маршрутизации (HOT PATH)
    // ???????????????????????????????????????????????????????????????
    void DataFeedManager::ProcessMessage(std::string_view rawJson) {
        try {
            // 1. Парсим JSON через simdjson (zero-copy)
            simdjson::padded_string paddedMsg(rawJson);
            simdjson::ondemand::document doc = parser_.iterate(paddedMsg);

            // 2. Проверяем, это Combined Stream или прямой стрим
            if (Parsing::FastParser::IsCombinedStream(doc)) {
                ProcessCombinedStream(doc);
                return;
            }

            // 3. Определяем тип события
            std::string_view eventType = Parsing::FastParser::GetEventType(doc);

            // 4. Маршрутизация по типу
            if (eventType == "depthUpdate") {
                HandleDepthUpdate(doc);
            }
            else if (eventType == "aggTrade") {
                HandleAggTrade(doc);
            }
            // Другие типы событий можно добавить здесь
            else if (!eventType.empty()) {
                // Неизвестный тип события
                if (errorCallback_) {
                    errorCallback_("Unknown event type: " + std::string(eventType));
                }
            }
        }
        catch (const simdjson::simdjson_error& e) {
            if (errorCallback_) {
                errorCallback_(std::string("simdjson parse error: ") + e.what());
            }
        }
        catch (const std::exception& e) {
            if (errorCallback_) {
                errorCallback_(std::string("Parse error: ") + e.what());
            }
        }
    }

    // ???????????????????????????????????????????????????????????????
    // ProcessCombinedStream: Обработка Combined Stream wrapper
    // ???????????????????????????????????????????????????????????????
    void DataFeedManager::ProcessCombinedStream(simdjson::ondemand::document& doc) {
        try {
            // Combined Stream format: {"stream":"...", "data":{...}}
            std::string_view streamName = doc["stream"].get_string().value();
            
            // Извлекаем data как объект
            auto dataObj = doc["data"].get_object();
            
            // Определяем тип по названию стрима
            if (streamName.find("@depth") != std::string_view::npos) {
                // depthUpdate
                if (depthCallback_) {
                    // Парсим depth update из вложенного объекта
                    cachedUpdate_.bids.clear();
                    cachedUpdate_.asks.clear();
                    
                    // Извлекаем поля (используем поля из OrderBookUpdate: u, U)
                    cachedUpdate_.u = dataObj["u"].get_uint64().value();
                    cachedUpdate_.U = dataObj["U"].get_uint64().value();
                    
                    // Парсим bids
                    auto bidsArray = dataObj["b"].get_array();
                    for (auto bidItem : bidsArray) {
                        auto bidArray = bidItem.get_array();
                        auto it = bidArray.begin();
                        std::string_view priceStr = (*it).get_string().value();
                        ++it;
                        std::string_view qtyStr = (*it).get_string().value();
                        
                        OrderBookLevel level;
                        level.price = Parsing::FastParser::ParseDoubleZeroCopy(priceStr);
                        level.quantity = Parsing::FastParser::ParseDoubleZeroCopy(qtyStr);
                        cachedUpdate_.bids.push_back(level);
                    }
                    
                    // Парсим asks
                    auto asksArray = dataObj["a"].get_array();
                    for (auto askItem : asksArray) {
                        auto askArray = askItem.get_array();
                        auto it = askArray.begin();
                        std::string_view priceStr = (*it).get_string().value();
                        ++it;
                        std::string_view qtyStr = (*it).get_string().value();
                        
                        OrderBookLevel level;
                        level.price = Parsing::FastParser::ParseDoubleZeroCopy(priceStr);
                        level.quantity = Parsing::FastParser::ParseDoubleZeroCopy(qtyStr);
                        cachedUpdate_.asks.push_back(level);
                    }
                    
                    depthCallback_(cachedUpdate_);
                }
            }
            else if (streamName.find("@aggTrade") != std::string_view::npos) {
                // aggTrade
                if (tradeCallback_) {
                    // Парсим aggTrade из вложенного объекта
                    cachedTrade_.tradeId = dataObj["a"].get_uint64().value();
                    
                    std::string_view priceStr = dataObj["p"].get_string().value();
                    std::string_view qtyStr = dataObj["q"].get_string().value();
                    
                    cachedTrade_.price = Parsing::FastParser::ParseDoubleZeroCopy(priceStr);
                    cachedTrade_.quantity = Parsing::FastParser::ParseDoubleZeroCopy(qtyStr);
                    cachedTrade_.timestampMs = dataObj["T"].get_uint64().value();
                    cachedTrade_.isBuyerMaker = dataObj["m"].get_bool().value();
                    
                    tradeCallback_(cachedTrade_);
                }
            }
        }
        catch (const std::exception& e) {
            if (errorCallback_) {
                errorCallback_(std::string("Combined stream error: ") + e.what());
            }
        }
    }

    // ???????????????????????????????????????????????????????????????
    // HandleDepthUpdate: Обработка diff обновлений стакана
    // ???????????????????????????????????????????????????????????????
    void DataFeedManager::HandleDepthUpdate(simdjson::ondemand::document& doc) {
        if (!depthCallback_) {
            return;
        }

        bool success = Parsing::FastParser::ParseDepthUpdate(doc, cachedUpdate_);
        if (success) {
            depthCallback_(cachedUpdate_);
        }
        else if (errorCallback_) {
            errorCallback_("Failed to parse depthUpdate");
        }
    }

    // ???????????????????????????????????????????????????????????????
    // HandleAggTrade: Обработка агрегированных сделок
    // ???????????????????????????????????????????????????????????????
    void DataFeedManager::HandleAggTrade(simdjson::ondemand::document& doc) {
        if (!tradeCallback_) {
            return;
        }

        bool success = Parsing::FastParser::ParseAggTrade(doc, cachedTrade_);
        if (success) {
            tradeCallback_(cachedTrade_);
        }
        else if (errorCallback_) {
            errorCallback_("Failed to parse aggTrade");
        }
    }

} // namespace TradingBot::Core::Network
