[< назад][0]

> сперва нужно обновить студию до последней версии  
> после всех настроек, желательно перезапустить студию, могут проблемы / конфликты с правилами из `.editorconfig`

## Подключение visual studio 2022 в unity

1.  в `Preferences` > `External Tools` выбрать `visual studio`
2.  нажать кнопку `Regenerate projects files`

![image][1]

3.  запуск `.sln` через выбранный редактор (приоритетный запуск, т.к. голый запуск может терять контент или `NuGet`)

![image][2]

## Первый запуск visual studio

1.  [настроить Code cleanup (форматирование и исправление)][3]
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

[0]: ../../README.md
[1]: ../../Resources/first-start-unity-external-tools.jpg
[2]: ../../Resources/first-start-unity-open-sln.jpg
[3]: ./0.%20Code%20cleanup.md
[4]: ./1.%20Item%20Template.md
[5]: ./2.%20Code%20Snippets.md
[6]: ../../Resources/first-start-sln-add-editorconfig.png
[7]: ../../Resources/visual-studio-restore-nuget.png
[8]: ../../Resources/first-start-toggle-spell-checker.jpg
[9]: ../../Resources/first-start-analysis.png
[10]: ../../Resources/track-active-item-explorer-solution.jpg
