## Системы

-   [ReleaseObjectSystem](#ReleaseObjectSystem)
-   [ChangeEnableViewSystem](#ChangeEnableViewSystem)
-   [RemoveTimerSystem](#RemoveTimerSystem)
-   [UpdateTimerSystem](#UpdateTimerSystem)
-   [UpdateFrameTimerSystem](#UpdateFrameTimerSystem)
-   [SwitchVisualAndAlternateVisualSystem](#SwitchVisualAndAlternateVisualSystem)
-   [DeleteOnEndFrameSystem](#DeleteOnEndFrameSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764605611778059&cot=10)

## ReleaseObjectSystem

### Фильтр

-   `+` `DeleteOnEndFrameComponent`
-   `+` `PooledGameObjectComponent`

### Описание

Если `EcsLinkPool` не `null` в `PooledGameObjectComponent`, тогда вызывается `Release`  
Удаляется `DeleteOnEndFrameType.Frame`

## ChangeEnableViewSystem

### Фильтр

-   `+` `EventChangeEnableViewTagComponent`
-   `+` `ViewEntityComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Выполнение `Show` у `ViewEntity` при наличии `EnableViewTag`, иначе выполняется `Hide`

## RemoveTimerSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `TimerComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если `EventMode` равен `Remove` и `Timer` равен -1, удаляется `Timer`
Добавляется `DeleteOnEndFrameType.Frame`

## UpdateTimerSystem

### Фильтр

-   `+` `TimerComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если `Timer` не равен 0 выполняется уменьшение `Timer`, иначе
Если есть `IterationCount`, то `Timer` становится равным `PeriodTimer`, выполняется уменьшение `Timer`, `IterationCount` уменьшается на 1
Если `IterationCount` = 0 и нет `NotDeleteByUpdateTimerTagPool` добавляется `DeleteOnEndFrameType.Frame`

## UpdateFrameTimerSystem

### Фильтр

-   `+` `FrameTimerComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если `FrameTimer` не равен 0 `FrameTimer` уменьшается на 1, иначе добавляется `DeleteOnEndFrameType.Frame`

## SwitchVisualAndAlternateVisualSystem

### Фильтр

-   `+` `EventChangeVisualTagComponent`
-   `+` `TargetComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

`View` меняется `Active` на противоположный от текущего
`ViewEndState` меняется `Active` на противоположный от текущего
Добавляется `DeleteOnEndFrameType.Frame`

## DeleteOnEndFrameSystem

### Фильтр

-   `+` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если `DeleteOnEndFrame` равен `DeleteOnEndFrameType.Frame` то  
Если есть `SnapshotEntityPool` то сущность из этого компонента и удаляем из мира  
Если есть `RootTransform` то удаляем объект с помощью `UnityEngine.Object.Destroy`, иначе с помощью `World.DelEntity`
