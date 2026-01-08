# Пошаговая настройка проекта TradingBot

## Проблема
Linker не может найти символы из `TradingBot.Core` при сборке `TradingBot.Runner`.

---

## Шаг 1: Очистка TradingBot.Core.vcxproj

### 1.1. Откройте файл в текстовом редакторе
Путь: `TradingBot.Core\TradingBot.Core.vcxproj`

### 1.2. Найдите секцию `<ItemGroup>` с `<ClCompile>`

Удалите строки:
```xml
<ClCompile Include="Environment.cpp" />
<ClCompile Include="RestClient.cpp" />
```

### 1.3. Найдите секцию `<ItemGroup>` с `<ClInclude>`

Удалите строки:
```xml
<ClInclude Include="Diagnostics.h" />
<ClInclude Include="Environment.h" />
<ClInclude Include="HttpClient.h" />
<ClInclude Include="LockFree\SPSCQueue.h" />
<ClInclude Include="RestClient.h" />
```

### 1.4. Добавьте `_CRT_SECURE_NO_WARNINGS` в PreprocessorDefinitions

Найдите строки:
```xml
<PreprocessorDefinitions>_WIN32_WINNT=0x0A00</PreprocessorDefinitions>
```

Замените на:
```xml
<PreprocessorDefinitions>_WIN32_WINNT=0x0A00;_CRT_SECURE_NO_WARNINGS;%(PreprocessorDefinitions)</PreprocessorDefinitions>
```

Это нужно сделать для обеих конфигураций (Debug|x64 и Release|x64).

### 1.5. Сохраните и закройте файл

---

## Шаг 2: Пересоберите Solution

### 2.1. В Visual Studio:
1. Меню: **Build ? Clean Solution**
2. Меню: **Build ? Rebuild Solution**

### 2.2. Или через командную строку:
```powershell
msbuild TradingBot.slnx /t:Clean /p:Configuration=Release /p:Platform=x64
msbuild TradingBot.slnx /t:Rebuild /p:Configuration=Release /p:Platform=x64
```

---

## Шаг 3: Проверка результата

### 3.1. Ожидаемый успех:
```
========== Rebuild All: 2 succeeded, 0 failed, 0 skipped ==========
```

### 3.2. Если остались ошибки:

**A. Linker errors (LNK2019)**
- Проверьте, что `TradingBot.Runner` ссылается на `TradingBot.Core`
- В Visual Studio:
  - ПКМ на проекте `TradingBot.Runner`
  - Properties ? Common Properties ? References
  - Должна быть ссылка на `TradingBot.Core`

**B. Warnings C4996 (localtime)**
- Уже исправлено через `_CRT_SECURE_NO_WARNINGS`
- Если warning всё ещё есть, проверьте, что изменения сохранены

**C. Ошибки компиляции**
- Запустите: `Build ? Build TradingBot.Core` отдельно
- Проверьте Output window для деталей

---

## Шаг 4: Альтернативный метод (если Шаг 1-3 не помогли)

### 4.1. Удалите промежуточные файлы:
```powershell
Remove-Item -Path "x64" -Recurse -Force
Remove-Item -Path "TradingBot.Core\x64" -Recurse -Force
Remove-Item -Path "TradingBot.Runner\x64" -Recurse -Force
Remove-Item -Path ".vs" -Recurse -Force
```

### 4.2. Восстановите NuGet пакеты:
```powershell
nuget restore
```

### 4.3. Пересоберите:
```powershell
msbuild TradingBot.slnx /t:Rebuild /p:Configuration=Release /p:Platform=x64
```

---

## Шаг 5: Проверка финальной сборки

### 5.1. Проверьте, что создались файлы:
```powershell
Get-ChildItem -Path "x64\Release" -Recurse -Include "*.lib","*.exe" | Select-Object Name
```

Ожидается:
- `TradingBot.Core.lib` ?
- `TradingBot.Runner.exe` ?

### 5.2. Запустите приложение:
```powershell
cd x64\Release
.\TradingBot.Runner.exe
```

---

## Контрольный список ?

- [ ] Удалены ссылки на несуществующие файлы из `.vcxproj`
- [ ] Добавлен `_CRT_SECURE_NO_WARNINGS`
- [ ] Выполнен Clean Solution
- [ ] Выполнен Rebuild Solution
- [ ] Создан `TradingBot.Core.lib`
- [ ] Создан `TradingBot.Runner.exe`
- [ ] Приложение запускается без ошибок

---

## Дополнительная помощь

### Проверить зависимости проекта:
```powershell
# В Visual Studio
ПКМ на Solution ? Project Dependencies
# Должно быть: TradingBot.Runner зависит от TradingBot.Core
```

### Посмотреть детальные ошибки линковки:
```powershell
msbuild TradingBot.slnx /t:Build /p:Configuration=Release /p:Platform=x64 /v:detailed > build.log
notepad build.log
```

---

## Успех! ??

После всех шагов проект должен собраться без ошибок.

Финальная проверка:
```powershell
x64\Release\TradingBot.Runner.exe
```

Ожидаемый вывод в консоли:
```
[TradingBot] Initializing...
[TradingBot] Starting all threads...
[TradingBot] Running main loop...
```
