# Copilot Instructions

## General Guidelines
- First general instruction
- Second general instruction
- Use the cloned official Binance docs in `C:\BOT\TradingBot\binance_docs` as the source of truth; no external knowledge.

## Debug Configuration for TradingBot
- For projects like TradingBot (especially BinanceDataFeed), ensure the following settings in Debug configuration:
  - Disable optimization: `<Optimization>Disabled</Optimization>` (/Od)
  - Enable full debug symbols: (/Zi, GenerateDebugInformation)
  - Avoid using LTCG and Whole Program Optimization
  - Disable Inline Expansion and aggressive optimizations
  - Check that the local `Microsoft.Cpp.x64.user.props` does not add `/O2`

## Release Configuration for TradingBot
- In Release configuration, maintain the following optimizations:
  - MaxSpeed
  - LTCG
  - COMDAT folding 
  - OptimizeReferences