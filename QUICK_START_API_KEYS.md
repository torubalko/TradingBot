# ? БЫСТРЫЙ СТАРТ: Вставка API ключей

## ?? ТРИ ПРОСТЫХ ШАГА:

### 1?? Откройте файл:
```
TradingBot.Runner/config.production.json
```

### 2?? Замените:
```json
"apiKey": "PASTE_YOUR_REAL_API_KEY_HERE",
"secretKey": "PASTE_YOUR_REAL_SECRET_KEY_HERE",
```

### 3?? Запустите:
```powershell
# Скопируйте конфиг:
cd TradingBot.Runner
Copy-Item config.production.json config.json -Force

# Запустите бота:
cd ..\x64\Release
.\TradingBot.Runner.exe
```

---

## ?? ВАЖНО:

- ? Файл **config.production.json** защищён `.gitignore`
- ? У ваших ключей включено: **Reading + Futures Trading**
- ? **НЕ** включайте **Withdrawals**!
- ?? Настройте **IP Whitelist** на Binance для безопасности

---

## ?? Проблемы?

Читайте подробную инструкцию: **HOW_TO_INSERT_API_KEYS.md**

---

**Готово! Теперь вставьте ключи и запустите бота! ??**
