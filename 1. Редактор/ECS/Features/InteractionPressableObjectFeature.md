## Системы

- [ChangeGameTooltipInZoneInteractionSystem](#ChangeGameTooltipInZoneInteractionSystem)
- [PressInteractiveObjectSystem](#PressInteractiveObjectSystem)

#### Системы взаимодействия

- [TeleportTargetOnLocationSystem](#TeleportTargetOnLocationSystem)
- [TeleportToSceneSystem](#TeleportToSceneSystem)

#### Системы взаимодействия c тбп

- [FastTravelPointTriggerEnterSystem](#FastTravelPointTriggerEnterSystem)
- [FastTravelPointTriggerExitSystem](#FastTravelPointTriggerExitSystem)
- [FastTravelPointActiveSystem](#FastTravelPointActiveSystem)
- [UseFastTravelPointSystem](#UseFastTravelPointSystem)
- [TransitionFastTravelPointSystem](#TransitionFastTravelPointSystem)

#### Конечная обработка взаимодействия

- [DisableGameTooltipWithOneInteractionSystem](#DisableGameTooltipWithOneInteractionSystem)
- [CreateEventChangeViewAfterInteractionSystem](#CreateEventChangeViewAfterInteractionSystem)
- [RemoveInteractivityWithOneInteractionSystem](#RemoveInteractivityWithOneInteractionSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764590634744836&cot=14)

## ChangeGameTooltipInZoneInteractionSystem

### Фильтр

- `+ OwnerComponent`
- `+ TargetComponent`
- `+ EventInZoneInteractionTagComponent`

### Описание

Включение / выключение тултипа, игроком, у интерактивных предметов, в зоне взаимодействия

- включение / выключение `gameObject` из компонента `GameTooltipComponent`

## PressInteractiveObjectSystem

### Фильтр

- `+ OwnerComponent`
- `+ TargetComponent`
- `+ EventInZoneInteractionTagComponent`
- `- DeleteOnEndFrameComponent`

- `+ OwnerComponent`
- `+ TargetComponent`
- `+ EventPressInteractiveObjectTagComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Создаёт сущность взаимодействия с интерактивным предметом

- проверяется наличие существующих нажатий по компоненту `EventPressInteractiveObjectTagComponent`
- если нажатий нет, то создаётся сущность с `OwnerComponent`, `TargetComponent` и `EventPressInteractiveObjectTagComponent`
- c сущности из `OwnerComponent` убирается компонент `InteractingWithObjectTagComponent`

## TeleportTargetOnLocationSystem

### Фильтр

- `+ OwnerComponent`
- `+ TargetComponent`
- `+ EventPressInteractiveObjectTagComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Перемещение к цели на локации

- проверяется наличие `TeleportTargetOnLocationComponent`
- берётся позиция из `RootTransformComponent` у `TargetComponent` устанавливается для `RootTransformComponent` у `OwnerComponent`

## TeleportToSceneSystem

### Фильтр

- `+ OwnerComponent`
- `+ TargetComponent`
- `+ EventPressInteractiveObjectTagComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Смена сцены, игроком

- проверяется наличие `TeleportToSceneComponent`
- берётся сцена из `TeleportToSceneComponent` и происходит её загрузка

## FastTravelPointTriggerEnterSystem

### Фильтр

- `+ OwnerComponent`
- `+ TargetComponent`
- `+ EventTriggerEnterTagComponent`
- `+ FastTravelPointTriggerTagComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Вход в `FastTravelPointTrigger`

- проверить наличие `FastTravelPointTagComponent`
- создаётся ивент для изменения `ActiveComponent`
- создаётся ивент для изменения `LastFastTravelPointComponent`
- добавляет `DeleteOnEndFrameComponent`

## FastTravelPointTriggerExitSystem

### Фильтр

- `+ OwnerComponent`
- `+ TargetComponent`
- `+ EventTriggerExitTagComponent`
- `+ FastTravelPointTriggerTagComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Выход из `FastTravelPointTrigger`

- проверить наличие `FastTravelPointTagComponent`
- скрывает ui списка точек перемещения
- добавляет `DeleteOnEndFrameComponent`

## FastTravelPointActiveSystem

### Фильтр

- `+ EventChangeActiveTagComponent`
- `+ TargetComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Добавление `ActiveTagComponent` и включения `AlternativeVisualComponent` для тбп.

- проверить наличие `FastTravelPointTagComponent`
- добавляет `DeleteOnEndFrameComponent`
- если нет `ActiveTagComponent`, создаётся ивент для смены `VisualComponent` и добавляется `ActiveTagComponent`

## UseFastTravelPointSystem

### Фильтр

- `+ EventPressInteractiveObjectTagComponent`
- `+ OwnerComponent`
- `+ TargetComponent`
- `- DeleteOnEndFrameComponent`

- `+ ItemTagComponent`
- `+ OwnerComponent`
- `+ PooledGameObjectComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Система нажатия на тбп.

- проверить наличие `FastTravelPointTagComponent` и `PlayerTagComponent`
- если ui список точек перемещения выключен, то включается, иначе выключается и добавляется `DeleteOnEndFrameComponent`
- респавн всех на точках спавна
- создаётся ивент для изменения `LastFastTravelPointComponent` для `TargetComponent`
- добавляет `DeleteOnEndFrameComponent` к сущностям у которых есть `PooledGameObjectComponent` и EcsLinkPool == null из компонента
- добавляет `DeleteOnEndFrameComponent` к сущности из фильтра

## TransitionFastTravelPointSystem

### Фильтр

- `+ EventTransitionFastTravelPointComponent`
- `+ OwnerComponent`
- `+ TargetComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Система перехода на тбп.

- проверить наличие `FastTravelPointTagComponent` и `RootTransformComponent` у `TargetComponent` и `RootTransformComponent` у `OwnerComponent`
- берётся позиция из `RootTransformComponent` у `TargetComponent` устанавливается для `RootTransformComponent` у `OwnerComponent`
- создаётся ивент для изменения `LastFastTravelPointComponent` для `TargetComponent`

## DisableGameTooltipWithOneInteractionSystem

### Фильтр

- `+ EventPressInteractiveObjectTagComponent`
- `+ OwnerComponent`
- `+ TargetComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Система перехода на тбп.

- проверить наличие `OneInteractionTagComponent` и `GameTooltipComponent`
- включает `GameObject` из `GameTooltipComponent`

## CreateEventChangeViewAfterInteractionSystem

### Фильтр

- `+ EventPressInteractiveObjectTagComponent`
- `+ OwnerComponent`
- `+ TargetComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Добавление события смены визуального представления у `TargetComponent`, после взаимодействия.

- проверить наличие `NotAllowChangeViewTagComponent`
- создаётся ивент для смены `VisualComponent`

## RemoveInteractivityWithOneInteractionSystem

### Фильтр

- `+ EventPressInteractiveObjectTagComponent`
- `+ OwnerComponent`
- `+ TargetComponent`
- `- DeleteOnEndFrameComponent`

### Описание

Удаление интерактивности у предметов (после взаимодействия) с `OneInteractionTagComponent`

- проверить наличие `OneInteractionTagComponent` и отсутствие `DeleteOnEndFrameComponent` у `TargetComponent`
- добавляет `DeleteOnEndFrameComponent` к `TargetComponent`
