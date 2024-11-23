## Системы

-   [ResurrectPlayerSystem](#ResurrectPlayerSystem)
-   [DeleteResurrectTagSystem](#DeleteResurrectTagSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764607958784068&cot=10)

## ResurrectPlayerSystem

### Фильтр

-   `+` `EventEndDeadTagComponent`
-   `+` `TargetComponent`
-   `+` `TargetComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

-   Добавляется `ImmortalTag`
-   Удаляется `DeadTag`
-   Удаляется `EndDeadTag`
-   Добавляется `ResurrectTag`
-   Создаётся `event` на изменение `Health`
-   Создаётся `event` на изменение `MaxHealth`
-   Перемещаем `entity` на последную посещённую тпб, если она есть, если нет, то остаёмся на месте

## DeleteResurrectTagSystem

### Фильтр

-   `+` `EventEndResurrectAnimationTagComponent`
-   `+` `TargetComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

-   Удаляется `ImmortalTag`
-   Удаляется `ResurrectTag`
