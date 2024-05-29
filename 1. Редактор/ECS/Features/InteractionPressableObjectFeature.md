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
