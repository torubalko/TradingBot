# ФИНАЛЬНЫЙ ШАГ: Исправление TradingBot.Core.vcxproj

## ? ЧТО УЖЕ СДЕЛАНО:
1. Удалены все несуществующие файлы из проекта
2. Исправлены пути к HttpClient.h
3. Добавлен статический метод GetSimple
4. Весь код готов к компиляции

## ? ЧТО ОСТАЛОСЬ:
Нужно добавить `_CRT_SECURE_NO_WARNINGS` в `TradingBot.Core.vcxproj`

---

## ИНСТРУКЦИЯ:

### 1. Откройте файл:
```
TradingBot.Core\TradingBot.Core.vcxproj
```

### 2. Найдите 2 строки (одна для Debug|x64, одна для Release|x64):
```xml
<PreprocessorDefinitions>_WIN32_WINNT=0x0A00</PreprocessorDefinitions>
```

###  3. Замените на:
```xml
<PreprocessorDefinitions>_WIN32_WINNT=0x0A00;_CRT_SECURE_NO_WARNINGS;%(PreprocessorDefinitions)</PreprocessorDefinitions>
```

### 4. Сохраните файл

### 5. В Visual Studio:
- **Build ? Clean Solution**
- **Build ? Rebuild Solution**

---

## Или через командную строку:

```powershell
# Замена через PowerShell
$vcxproj = Get-Content "TradingBot.Core\TradingBot.Core.vcxproj" -Raw
$vcxproj = $vcxproj -replace '<PreprocessorDefinitions>_WIN32_WINNT=0x0A00</PreprocessorDefinitions>', '<PreprocessorDefinitions>_WIN32_WINNT=0x0A00;_CRT_SECURE_NO_WARNINGS;%(PreprocessorDefinitions)</PreprocessorDefinitions>'
$vcxproj | Set-Content "TradingBot.Core\TradingBot.Core.vcxproj" -NoNewline

# Пересборка
msbuild /t:Rebuild /p:Configuration=Release /p:Platform=x64
```

---

## Ожидаемый результат:

```
========== Rebuild All: 2 succeeded, 0 failed, 0 skipped ==========
```

Файлы:
- ? `x64\Release\TradingBot.Core.lib`
- ? `x64\Release\TradingBot.Runner.exe`

---

## Запуск:

```powershell
x64\Release\TradingBot.Runner.exe
```

Ожидаемый вывод:
```
[TradingBot] Initializing...
[TradingBot] Starting all threads...
[TradingBot] Running main loop...
```

---

## ?? ГОТОВО!

Все файлы исправлены, осталось только добавить одну строку в `.vcxproj`.
