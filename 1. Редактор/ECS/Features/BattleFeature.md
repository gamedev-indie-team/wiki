## Системы

-   [ChangeAttackTagSystem](#ChangeAttackTagSystem)
-   [ChangeHitTagSystem](#ChangeHitTagSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764590182712348&cot=14)

## ChangeAttackTagSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `AttackTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Добавление / удаление компонента `AttackTagComponent`.  
Работает с `EcsEventMode.Add` и `EcsEventMode.Del`.

-   добавление `AttackTagComponent` при `EcsEventMode.Add` и этого тега нет на `Target`
-   удаление `AttackTagComponent` с `Target` если `EcsEventMode.Del`

## ChangeHitTagSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `HitTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Добавление / удаление компонента `HitTagComponent`.  
Работает с `EcsEventMode.Add` и `EcsEventMode.Del`.

-   добавление `HitTagComponent` при `EcsEventMode.Add` и этого тега нет на `Target`
-   удаление `HitTagComponent` с `Target` если `EcsEventMode.Del`
