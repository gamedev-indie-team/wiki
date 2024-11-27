## Системы

- [RemoveBlockTagByOtherStateSystem](#RemoveBlockTagByOtherStateSystem)
- [ChangeBlockTagByEventSystem](#ChangeBlockTagByEventSystem)
- [BehaviourByBlockSystem](#BehaviourByBlockSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764608546301999&cot=10)

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

- Добавлять `BlockTag` если `target` не имеет `BlockTag` и `EventMode` равен `Add`, иначе удалять.

## BehaviourByBlockSystem

### Фильтр

-   `+` `EventTriggerEnterTagComponent`
-   `+` `AttackTriggerTagComponent`
-   `+` `TargetComponent`
-   `+` `OwnerComponent`
-   `+` `BlockTagComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

- Создаём `event` для добавления силы для отталкивания ударившего.
