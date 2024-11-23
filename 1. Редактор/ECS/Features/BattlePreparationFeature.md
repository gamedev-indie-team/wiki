## Системы

-   [AttackTriggerEnterSystem](#AttackTriggerEnterSystem)
-   [CreateEventPreparationDamageSystem](#CreateEventPreparationDamageSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764607958335220&cot=10)

## AttackTriggerEnterSystem

### Фильтр

-   `+` `EventTriggerEnterTagComponent`
-   `+` `AttackTriggerTagComponent`
-   `+` `TargetComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если в сущности из `Target` есть `BlockTag`, то добавляем его на сущность `event`  
Если в сущности из `Target` есть `ImmortalTag`, то добавляем его на сущность `event`

## CreateEventPreparationDamageSystem

### Фильтр

-   `+` `EventTriggerEnterTagComponent`
-   `+` `AttackTriggerTagComponent`
-   `+` `TargetComponent`
-   `-` `BlockTagComponent`
-   `-` `ImmortalTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

-   носитель урона (`НУ`) - это либо сам `event` либо `owner` события (тот кто ударил)
-   создается копия карты урона `НУ` по характеристикам цели (если есть баланс - то можно нанести урон по балансу и т.д.)
-   из созданной карты урона создается НОВЫЙ УРОН из урона `НУ` и новой карты урона (по сути копия урона `НУ` без параметров по которым нельзя нанести урон)
-   создается событие `EventPreparationDamageEntity` с: уроном, картой урона, target owner (опционально)
