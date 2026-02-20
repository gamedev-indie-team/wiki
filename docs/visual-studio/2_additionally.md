> Дополнительные настройки опционально, т.к. все остальное настроено в `.editorconfig`

### Включить подсказки для неявно типизированных, локальных переменных (`var`, `new()`) и входных параметров метода / функции

![image](_images/code-cleanup-visual-studio-parameters.png)

![image](_images/code-cleanup-visual-studio-parameters-example.png)

### Сортировка ошибок по кодам: вкладка "список ошибок" > правый клик > группирование > код

![image](_images/code-cleanup-visual-studio-sort-list-errors.png)

### Проверка орфографии

?>
**en**: Edit > Advanced > Toggle Spell Checker  
**ru**: Правка > Дополнительно > Переключить проверку орфографии

![image](_images/visual-studio-toggle-spell-checker.jpg)

### Отслеживать активный элемент

?> Tools > Options > Project and Solutions > General установить Track Active Item in Solution Explorer

![image](_images/track-active-item-explorer-solution.jpg)

### Добавление `.editorconfig`

**В VS2026+ уже не обязательно**

![image](_images/visual-studio-sln-add-editorconfig.png)

### Установка зависимостей

Этот пункт можно сделать 2 путями:

- восстановление `NuGet`-пакетов

    ![image](_images/visual-studio-restore-nuget.png)

- запустить `build` решения (`ctrl + shift + b`), создаться папка obj в корне, можно удалить
    ```powershell
    dotnet build .\game.sln
    ```

### Анализ кода

Можно запускать как для всего решения, так и для проекта, удобно смотреть пропущенные `warning`

![image](_images/first-start-analysis.png)
