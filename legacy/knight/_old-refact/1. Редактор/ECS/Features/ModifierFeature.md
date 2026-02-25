## Системы

-   [PeriodModifierSystem](#PeriodModifierSystem)
-   [ApplyModifierSystem](#ApplyModifierSystem)
-   [DiscardModifierSystem](#DiscardModifierSystem)
-   [DeleteAppliedModifierSystem](#DeleteAppliedModifierSystem)

[ССЫЛКА В МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764600167933188&cot=14)

## PeriodModifierSystem

### Фильтр

-   `+` `ModifierTagComponent`
-   `+` `TimerComponent`
-   `-` `EventTagComponent`
-   `-` `DeleteOnEndFrameComponent`

### Описание

Работа с модификаторами у которых есть `TimerComponent`.  
Перманентный (постоянный) дублируется без компонентов таймера.

-   обрабатываются модификаторы у которых `TimerComponent` == 0
-   если модификатор **постоянный и НЕ применен**, то делается его копия и отправляется событие `GetEventRemoveTimerEntity`
-   если модификатор **временный** то отправляется событие `GetEventRemoveTimerEntity` и `GetEventDiscardModifierEntity` (отменить воздействие модификатора)

## ApplyModifierSystem

### Фильтр

-   `+` `ModifierTagComponent`
-   `+` `TargetComponent`
-   `-` `ModifierAppliedTagComponent`
-   `-` `EventTagComponent`
-   `-` `IterationCountComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`. `IterationCountComponent` т.к. `TimerComponent` есть у временных а количества итераций нет.

### Описание

Применение модификатора к цели.

-   если получилось выполнить `ChangeEntityParameterByModifier` (применить модификатор к цели), добавляем `ModifierAppliedTagComponent`, иначе удаляем модификатор

## DiscardModifierSystem

### Фильтр

**событие:**

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `OwnerComponent`
-   `+` `ModifierTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

**отменяемые модификаторы:**

-   `+` `ModifierTagComponent`
-   `+` `ModifierAppliedTagComponent`
-   `+` `DiscardOnDeleteTagComponent`
-   `+` `OwnerComponent`
-   `+` `TargetComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`, если не смогли применить модификатор, иначе в `DeleteOnEndFrameType.FixedFrame`

### Описание

Отмена воздействия модификатора и снятие тега `DiscardOnDeleteTagComponent`

-   работа только с событием `EcsEventMode.Remove`
-   из события получается владелец настроек (инициатор)
    для каждого модификатора:
    -   проверка РАВЕНСТВА владельца модификатора и инициатора
    -   если получилось выполнить `ChangeEntityParameterByModifier` (применить модификатор к цели), удаляем `DiscardOnDeleteTagPool`, иначе удаляем модификатор
-   событие удаляется

## DeleteAppliedModifierSystem

### Фильтр

-   `+` `ModifierTagComponent`
-   `+` `ModifierAppliedTagComponent`
-   `+` `TargetComponent`
-   `-` `DiscardOnDeleteTagComponent `
-   `-` `EventTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Удаляет примененные модификаторы.  
Постоянные удаляются сразу, временные после снятия флага `DiscardOnDeleteTagComponent` (это после отмены эффекта).  
Нужна отдельная система, т.к. удаляются РАЗНЫЕ ВИДЫ модификаторов в РАЗНЫХ СОСТОЯНИЯХ.

-   удаление модификаторов из фильтра
