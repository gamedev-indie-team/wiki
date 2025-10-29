## Системы

-   [ReleaseObjectSystem](#ReleaseObjectSystem)
-   [ChangeEnableViewSystem](#ChangeEnableViewSystem)
-   [RemoveTimerSystem](#RemoveTimerSystem)
-   [UpdateTimerSystem](#UpdateTimerSystem)
-   [UpdateFrameTimerSystem](#UpdateFrameTimerSystem)
-   [ChangeSwitchableObjectSystem](#ChangeSwitchableObjectSystem)
-   [ChangeDisabledObjectSystem](#ChangeDisabledObjectSystem)

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

## ChangeSwitchableObjectSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `SwitchableObjectComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если у сущности из `TargetComponent` нет `SwitchObject` или есть `SwitchObjectDisabledTag`, то выходим из системы
Добавляется `DeleteOnEndFrameType.Frame`
Если у сущности из `TargetComponent` в `SwitchableObjectComponent` стоит флаг `SwitchOnce`, то добавляем на эту сущность `SwitchObjectDisabledTag`
Если у `event` есть `DisabledObjectTag` , то добавляем на сущность из `TargetComponent` компонент `DisabledObjectTag`  
Сменить `MainState` на противоположный
Вызвать `SetActive` для каждого объекта из `SwitchableObjectComponent`

## ChangeDisabledObjectSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `DisabledEntityTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если сущност из `TargetComponent` мертва, то выходим из системы
Добавляется `DeleteOnEndFrameType.Frame`
Добавляется `DisabledEntityTag` на сущность из `TargetComponent` если его нет и `EventMode` равен `EcsEventMode.Add`
Удаляется `DisabledEntityTag` из сущности `TargetComponent` если `EventMode` равен `EcsEventMode.Remove`