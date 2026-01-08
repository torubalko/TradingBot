# ?? Инструкция: Как вставить API ключи

## ? ШАГ 1: Откройте файл config.production.json

Файл находится здесь:
```
TradingBot.Runner/config.production.json
```

## ? ШАГ 2: Замените плейсхолдеры на ваши реальные ключи

Найдите эти строки:
```json
"apiKey": "PASTE_YOUR_REAL_API_KEY_HERE",
"secretKey": "PASTE_YOUR_REAL_SECRET_KEY_HERE",
```

Замените на ваши ключи:
```json
"apiKey": "ваш_api_key_с_binance",
"secretKey": "ваш_secret_key_с_binance",
```

### Пример (НЕ используйте эти ключи - это пример!):
```json
"apiKey": "xMzY5NjE4ODAwMzg0NjE4ODAwMzg0NjE4ODAwMzg0NjE4MDAwMzg0NjE4MDAwMz",
"secretKey": "NjE4MDAwMzg0NjE4MDAwMzg0NjE4MDAwMzg0NjE4MDAwMzg0NjE4MDAwMzg0NjE4MDAwMzg=",
```

## ? ШАГ 3: Сохраните файл

**ВАЖНО:** Этот файл защищён `.gitignore` и НЕ будет закоммичен в Git!

---

## ?? ШАГ 4: Запуск приложения с production конфигом

### Вариант A: Через Visual Studio

1. Откройте **TradingBot.Runner** ? Properties ? Debugging
2. В **Command Arguments** добавьте:
```
config.production.json
```

### Вариант B: Через командную строку

```powershell
cd x64\Release
.\TradingBot.Runner.exe config.production.json
```

### Вариант C: Переименуйте файл (самый простой)

Если приложение ищет `config.json` по умолчанию:
```powershell
# В папке TradingBot.Runner
Copy-Item config.production.json config.json -Force
```

**ВНИМАНИЕ:** `config.json` НЕ защищён `.gitignore`! После копирования добавьте его в .gitignore вручную.

---

## ?? БЕЗОПАСНОСТЬ

### ?? КРИТИЧЕСКИ ВАЖНО:

1. **НЕ КОММИТЬТЕ файлы с ключами!**
   ```powershell
   # Проверьте что файл игнорируется:
   git status
   # config.production.json НЕ должен появиться в списке
   ```

2. **Проверьте права доступа ключей на Binance:**
   - ? Enable Reading - ДА
   - ? Enable Futures Trading - ДА (у вас включено)
   - ? Enable Spot Trading - НЕТ (если не нужно)
   - ? Enable Withdrawals - **ОБЯЗАТЕЛЬНО НЕТ!**

3. **Настройте IP Whitelist (РЕКОМЕНДУЕТСЯ):**
   ```powershell
   # Узнайте свой IP:
   Invoke-WebRequest -Uri "https://api.ipify.org"
   
   # Добавьте этот IP в Binance API Management ? IP Whitelist
   ```

4. **Храните секретный ключ в безопасном месте:**
   - Запишите в password manager
   - Сделайте бэкап (не на GitHub!)

---

## ?? ЧТО ДЕЛАТЬ ЕСЛИ КЛЮЧИ СКОМПРОМЕТИРОВАНЫ

Если вы случайно закоммитили ключи в Git:

1. **НЕМЕДЛЕННО удалите ключи на Binance:**
   - Binance.com ? API Management ? Delete API Key

2. **Создайте новые ключи**

3. **Очистите Git history:**
   ```bash
   git filter-branch --force --index-filter \
     "git rm --cached --ignore-unmatch config.production.json" \
     --prune-empty --tag-name-filter cat -- --all
   
   git push origin --force --all
   ```

---

## ? ПРОВЕРКА

После вставки ключей запустите приложение и проверьте лог:

### Ожидаемый вывод:
```
[TradingBotApplication] Config loaded: PRODUCTION
[BinanceConnector] Initialized with config: PRODUCTION
[Connection:FUTURES] Initialized for BTCUSDT
[Connection:FUTURES] WebSocket connected.
[Connection:FUTURES] Subscribed to streams.
```

### Если появляется ошибка "Invalid API Key":
- Проверьте что ключ скопирован полностью (без пробелов)
- Проверьте что IP не заблокирован (если включен Whitelist)

### Если появляется "Signature invalid":
- Проверьте время на компьютере:
  ```powershell
  w32tm /resync
  ```

---

## ?? ГОТОВО!

После выполнения всех шагов ваше приложение будет подключено к **реальному** Binance API с возможностью:
- ? Читать рыночные данные
- ? Торговать на фьючерсном рынке
- ? Не может выводить средства (безопасно!)

**Удачной торговли!** ????
