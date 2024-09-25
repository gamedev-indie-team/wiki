[< назад][0]

> сперва нужно обновить студию до последней версии

## Подключение visual studio 2022 в unity

1.  в `Preferences` > `External Tools` выбрать `visual studio`
2.  нажать кнопку `Regenerate projects files`

![image][1]

3.  запуск `.sln` через выбранный редактор (приоритетный запуск, т.к. голый запуск может терять контент или `NuGet`)

![image][2]

## Первый запуск visual studio

1.  [настроить Code cleanup][3]

2.  установка зависимостей. Этот пункт можно сделать 2 путями:

    1. восстановление `NuGet`-пакетов

        ![image][4]

    2. запустить `build` решения (`ctrl + shift + b`), создаться папка obj в корне, можно удалить

        ```PowerShell
        dotnet build .\game.sln
        ```

## Анализ кода

Можно запускать как для всего решения, так и для проекта, удобно смотреть пропущенные `warning`

![image](../../Resources/first-start-analysis.png)

[0]: ../../README.md
[1]: ../../Resources/first-start-unity-external-tools.jpg
[2]: ../../Resources/first-start-unity-open-sln.jpg
[3]: ./0.%20Code%20cleanup.md
[4]: ../../Resources/visual-studio-restore-nuget.png
