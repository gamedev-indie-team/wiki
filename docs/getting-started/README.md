# Подключение IDE к Unity

?>
В `Preferences` > `External Tools` выбрать `visual studio`  
Нажать кнопку `Regenerate projects files`

![image](../_images/start-unity-external-tools.jpg)

?> Запуск `.sln` через выбранный редактор (приоритетный запуск, т.к. голый запуск может терять контент или `NuGet`)

![image](../_images/start-unity-open-sln.jpg)

## Первый запуск visual studio

!> Обновить студию до последней версии. После всех настроек, желательно перезапустить студию, могут проблемы / конфликты с правилами из `.editorconfig`

## Code cleanup (форматирование и исправление)

?>
**en**: Tools > Options > Text Editor > Code Cleanup  
**ru**: Средства > Параметры > Текстовый редактор > Очистка кода

> [список правил `Code cleanup` от Microsoft](https://learn.microsoft.com/en-us/visualstudio/ide/code-styles-and-code-cleanup?view=vs-2022#code-cleanup-settings)

-   включить пункт `Запустить профиль "Очистка кода" при сохранении` | `Run Code Cleanup profile on save`

    <details>
      <summary>Результат RU</summary>
      <img src="../_images/code-cleanup-on-save-ru.png" alt="настройки при ru локализации">
    </details>
    <details>
      <summary>Результат EN</summary>
      <img src="../_images/code-cleanup-on-save-en.png" alt="настройки при en локализации">
    </details>

-   в настройках очистки кода добавить **ВСЕ ПРАВИЛА**, кроме:

    <details>
      <summary>Результат RU</summary>
      <img src="../_images/code-cleanup-rules-ru.png" alt="настройки при ru локализации">
    </details>
    <details>
      <summary>Результат EN</summary>
      <img src="../_images/code-cleanup-rules-en.png" alt="настройки при en локализации">
    </details>

### Дополнительные настройки (опционально, т.к. все остальное настроено в `.editorconfig`)

-   включить подсказки для неявно типизированных, локальных переменных (`var`, `new()`) и входных параметров метода / функции

    <details>
      <summary>Настройка и пример</summary>
      <img src="../_images/code-cleanup-visual-studio-parameters.png" alt="настройки">
      <img src="../_images/code-cleanup-visual-studio-parameters-example.png" alt="пример">
    </details>

-   сортировка ошибок по кодам: вкладка "список ошибок" > правый клик > группирование > код

    <details>
      <summary>Настройка</summary>
      <img src="../_images/code-cleanup-visual-studio-sort-list-errors.png" alt="пример">
    </details>

## Item Template (шаблоны для файлов)

?>
**en**: Tools > Options > Projects and Solutions > Locations  
**ru**: Средства > Параметры > Проекты и решения > Расположения

-   пункт `User item template location` | `Расположение шаблонов элементов пользователя`
-   выбрать папку `TemplateItem` в `/путь к репозиторию кода game/` + `/.ide/TemplateItem`
-   перезагрузить `visual studio`

    ![результат настройки](../_images/item-template-result.jpg)

## Code Snippets (шаблоны для кода)

2.  [настроить Item Template (шаблоны для файлов)][4]
3.  [настроить Code Snippets (шаблоны для кода)][5]
4.  добавить `.editorconfig` к решению

    ![image][6]

5.  установка зависимостей. Этот пункт можно сделать 2 путями:

    1. восстановление `NuGet`-пакетов

        ![image][7]

    2. запустить `build` решения (`ctrl + shift + b`), создаться папка obj в корне, можно удалить

        ```PowerShell
        dotnet build .\game.sln
        ```

6.  включение проверки орфографии

    > Edit > Advanced > Toggle Spell Checker

    ![image][8]

## Опционально

### Анализ кода

Можно запускать как для всего решения, так и для проекта, удобно смотреть пропущенные `warning`

![image][9]

### Обозреватель решения

> Отслеживать активный элемент
> `Tools` > `Options` > `Project and Solutions` > `General` установить `Track Active Item in Solution Explorer`

![image][10]

[4]: ./1.%20Item%20Template.md
[5]: ./2.%20Code%20Snippets.md
[6]: ../../Resources/first-start-sln-add-editorconfig.png
[7]: ../../Resources/visual-studio-restore-nuget.png
[8]: ../../Resources/first-start-toggle-spell-checker.jpg
[9]: ../../Resources/first-start-analysis.png
[10]: ../../Resources/track-active-item-explorer-solution.jpg

## Возможные проблемы

-   правила из `.editorconfig`, которые помечены как `none`, отображаются как `warning` в списке ошибок. Тут или перезапуск студии, либо само пройдет (бывает тупит)
-   **`Code Cleanup` НИКАК не экспортируется и не переносится**. Может случиться так, что при обновлении студии, пропадут настройки, тут придется опять настраивать руками
