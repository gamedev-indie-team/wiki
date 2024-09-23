[< назад][0]

> сперва нужно обновить студию до последней версии

## Подключение visual studio 2022 в unity

-   в `Preferences` > `External Tools` выбрать `visual studio`
-   нажать кнопку `Regenerate projects files`

![image][1]

## Первый запуск

-   [настроить Code cleanup][2]

-   запустить `build` решения (`ctrl + shift + b`)
    ```PowerShell
    dotnet build .\game.sln
    ```

## Анализ кода

Можно запускать как для всего решения, так и для проекта, удобно смотреть пропущенные `warning`

![image](../../Resources/first-start-analysis.png)

[0]: ../../README.md
[1]: ../../Resources/visual-studio-unity-add.jpg
[2]: ./0.%20Code%20cleanup.md
