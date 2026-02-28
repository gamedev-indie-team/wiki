## Системы

-   [CreateEventDisableSimulationSystem](#CreateEventDisableSimulationSystem)
-   [CreateEventSetDropInventorySystem](#CreateEventSetDropInventorySystem)
-   [SetDeadTagSystem](#SetDeadTagSystem)
-   [ReleaseEntitySystem](#ReleaseEntitySystem)
-   [ResurrectPlayerSystem](#ResurrectPlayerSystem)
-   [DeleteResurrectTagSystem](#DeleteResurrectTagSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764607958493124&cot=14)

## CreateEventDisableSimulationSystem

### Фильтр

-   `+` `HealthEmptyTagComponent`
-   `+` `RigidbodyComponent`
-   `-` `PlayerTagComponent`
-   `-` `DeadTagComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Создаётся событие отключение симуляции

## CreateEventSetDropInventorySystem

### Фильтр

-   `+` `HealthEmptyTagComponent`
-   `+` `InventoryTagComponent`
-   `-` `PlayerTagComponent`
-   `-` `DeadTagComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Создаётся событие сбрасывания предметов из инвентаря

## SetDeadTagSystem

### Фильтр

-   `+` `HealthEmptyTagComponent`
-   `-` `DeadTagComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Устанавливается `DeadTagComponent`

## ReleaseEntitySystem

### Фильтр

-   `+` `EventEndDeadTagComponent`
-   `+` `TargetComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если у сущности из `TargetComponent` есть `DeadTagComponent`, то добавить `DeleteOnEndFrameType.Frame`
Если у сущности из `TargetComponent` нет `PooledGameObjectComponent`, то создаётся событие смена вида
Иначе связанный объект возвращаем в коллектор пулов

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
