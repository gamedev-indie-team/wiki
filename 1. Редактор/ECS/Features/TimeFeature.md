## Системы

-   [RemoveTimerSystem](#RemoveTimerSystem)
-   [UpdateFrameTimerSystem](#UpdateFrameTimerSystem)
-   [UpdateTimerSystem](#UpdateTimerSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764636195076347&cot=10)

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

## UpdateFrameTimerSystem

### Фильтр

-   `+` `FrameTimerComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если `FrameTimer` не равен 0, то `FrameTimer` уменьшается на 1, иначе добавляется `DeleteOnEndFrameType.Frame`

## UpdateTimerSystem

### Фильтр

-   `+` `TimerComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если `Timer` != 0, то выполняется уменьшение `Timer`  
Иначе ЕСЛИ есть `IterationCount`, то

-   `Timer` становится равным `PeriodTimer`,
-   выполняется уменьшение `Timer`,
-   `IterationCount` уменьшается на 1

Если `IterationCount` == 0 и нет `NotDeleteByUpdateTimerTagPool` добавляется `DeleteOnEndFrameType.Frame`
