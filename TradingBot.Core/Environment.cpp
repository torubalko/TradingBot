#include "Environment.h"
#include <nlohmann/json.hpp>
#include <boost/version.hpp>
#include <openssl/opensslv.h>

namespace TradingBot::Core {
    std::string Environment::GetSystemInfo() {
        nlohmann::json report;
        report["Status"] = "Online";
        report["Boost"] = BOOST_LIB_VERSION;
        report["OpenSSL"] = OPENSSL_VERSION_TEXT;
        return report.dump(4);
    }
}