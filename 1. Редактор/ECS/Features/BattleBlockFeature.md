## Системы

-   [RemoveBlockTagByOtherStateSystem](#RemoveBlockTagByOtherStateSystem)
-   [ChangeBlockTagByEventSystem](#ChangeBlockTagByEventSystem)
-   [RemoveEventAttackTriggerEnterByBlock](#RemoveEventAttackTriggerEnterByBlock)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764608066429220&cot=10)

## RemoveBlockTagByOtherStateSystem

### Фильтр

-   `+` `BlockTagComponent`
-   `-` `EventTagComponent`
-   `-` `OwnerComponent`
-   `-` `DeleteOnEndFrameComponent`

### Описание

Удаление компонента `BlockTagComponent` на сущности при других состояниях: атака, смерть, возрождение, прыжок

## ChangeBlockTagByEventSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `BlockTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Безопасное удаление и добавление `BlockTagComponent` на сущность

## RemoveEventAttackTriggerEnterByBlock

### Фильтр

-   `+` `EventTriggerEnterTagComponent`
-   `+` `AttackTriggerTagComponent`
-   `+` `TargetComponent`
-   `+` `BlockTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

-   удаляет событие входа в триггер урона при блоке целью
-   отталкивает ударившего
