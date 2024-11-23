## Системы

-   [FollowTriggerEnterSystem](#FollowTriggerEnterSystem)
-   [FollowTriggerExitSystem](#FollowTriggerExitSystem)
-   [PatrolSystem](#PatrolSystem)
-   [MoveToTargetPointSystem](#MoveToTargetPointSystem)
-   [AttackSystem](#AttackSystem)
-   [BlockSystem](#BlockSystem)
-   [DisableBlockSystem](#DisableBlockSystem)
-   [DeleteBattleTagSystem](#DeleteBattleTagSystem)

## FollowTriggerEnterSystem

### Фильтр

-   `+` `EventTriggerEnterTagComponent`
-   `+` `FollowTriggerTagComponent`
-   `+` `OwnerComponent`
-   `+` `TargetComponent`
-   `+` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Смена `DirectionComponent`.  
Установка `Transform` из `RootTransformComponent` в `CurrentTargetPointComponent`
Добавление `FollowTagComponent`

## FollowTriggerExitSystem

### Фильтр

-   `+` `EventTriggerExitTagComponent`
-   `+` `FollowTriggerTagComponent`
-   `+` `OwnerComponent`
-   `+` `DeleteOnEndFrameComponent`

### Описание

Смена `DirectionComponent`.  
Установка `Transform` из `PatrolPointComponent` по индексу из `CurrentTargetPoint` в `CurrentTargetPointComponent`
Удаление `FollowTagComponent`

## PatrolSystem

### Фильтр

-   `+` `WayPointTriggerTagComponent`
-   `+` `EventTriggerEnterTagComponent`
-   `+` `TargetComponent`
-   `+` `CurrentTargetPointComponent`
-   `+` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если на `WayPoint` стоит флаг `UseInteraction` то добавляется `InteractingWithObjectTagComponent`
Если на `WayPoint` стоит флаг `Jump` то добавляется `JumpedTagComponent`
Изменяется `CurrentTargetPointComponent` на следующую `WayPoint`

## MoveToTargetPointSystem

### Фильтр

-   `+` `AiTagComponent`
-   `+` `CurrentTargetPointComponent`
-   `+` `RootTransformComponent`
-   `+` `VelocityComponent`
-   `-` `AttackTagComponent`
-   `-` `BlockTagComponent`
-   `-` `DirectionMoveComponent`
-   `-` `DeleteOnEndFrameComponent`

### Описание

Изменяется `DirectionMoveComponent` в зависимости от разницы позиции из `RootTransformComponent` и `CurrentTargetPoint`
Изменяется `DirectionComponent` в зависимости от знака разницы позиции из `RootTransformComponent` и `CurrentTargetPoint`

## AttackSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `OwnerComponent`
-   `+` `AttackZoneTagComponent`
-   `-` `DeleteOnEndFrameComponent`

### Описание

Создаёт событие по смене `AttackTagComponent` с флагом `Add`
Устанавливает в `DirectionMoveComponent` `Vector2.zero`

## BlockSystem

### Фильтр

-   `+` `AttackStartTagComponent`
-   `+` `RootTransformComponent`
-   `-` `DeleteOnEndFrameComponent`

### Фильтр событий

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `OwnerComponent`
-   `+` `AttackZoneTagComponent`
-   `-` `DeleteOnEndFrameComponent`

### Описание

Создаёт событие по смене `AttackTagComponent` с флагом `Remove`
Добавить `BlockTagComponent`
Создаёт событие отключения блока

## DisableBlockSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TimerComponent`
-   `+` `BlockTagComponent`
-   `+` `TargetComponent`

### Описание

Удаляет `BlockTagComponent`

## DeleteBattleTagSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `OwnerComponent`
-   `+` `AttackZoneTagComponent`
-   `+` `DeleteOnEndFrameComponent`

### Фильтр таймера

-   `+` `EventTagComponent`
-   `+` `TimerComponent`
-   `+` `BlockTagComponent`
-   `+` `TargetComponent`

### Описание

Создаёт событие по смене `AttackTagComponent` с флагом `Remove`
Устанавливает значение в `TimerComponent` в сущности из фильтра таймера из компонента `BlockTagComponent`
