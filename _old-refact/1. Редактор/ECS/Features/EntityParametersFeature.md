## Системы

-   [ChangeHealthSystem](#ChangeHealthSystem)
-   [ChangeMaxHealthSystem](#ChangeMaxHealthSystem)
-   [ChangeBalanceSystem](#ChangeBalanceSystem)
-   [ChangeMaxBalanceSystem](#ChangeMaxBalanceSystem)
-   [ChangeSpeedAttackSystem](#ChangeSpeedAttackSystem)
-   [ChangeCriticalDamageSystem](#ChangeCriticalDamageSystem)
-   [ChangeVelocitySystem](#ChangeVelocitySystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764572814519301&cot=14)

## ChangeHealthSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `HealthComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра здоровья.

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `HealthComponent`: `[0, HealthComponent]`, если есть `MaxHealthComponent` (на `Target`) то `[0, MaxHealthComponent]`
-   если значение `= 0`, то добавляет на `Target` `HealthEmptyTagComponent`

## ChangeMaxHealthSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `MaxHealthComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра максимального здоровья.

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `MaxHealthComponent`: `[0, MaxHealthComponent]`
-   обрезание значения `HealthComponent` до `MaxHealthComponent`

## ChangeBalanceSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `BalanceComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра максимального баланса.

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `BalanceComponent`: `[0, BalanceComponent]`, если есть `MaxBalanceComponent` (на `Target`) то `[0, MaxBalanceComponent]`
-   если значение `= 0`, то добавляет на `Target` `BalanceEmptyTagComponent`

## ChangeMaxBalanceSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `MaxBalanceComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра максимального баланса.

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `MaxBalanceComponent`: `[0, MaxBalanceComponent]`
-   обрезание значения `BalanceComponent` до `MaxBalanceComponent`

## ChangeSpeedAttackSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `AttackSpeedComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра скорости атаки.

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `AttackSpeedComponent`: `[1, AttackSpeedComponent]`

## ChangeCriticalDamageSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `CriticalDamageComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра критической атаки.

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `CriticalDamageComponent.Chance`: `[0, 1]`
-   ограничение значения `CriticalDamageComponent.Factor`: `[0, CriticalDamageComponent.Factor]`

## ChangeVelocitySystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `VelocityComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра скорости сущности.

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `VelocityComponent` (X, Y): `[0, value]`
