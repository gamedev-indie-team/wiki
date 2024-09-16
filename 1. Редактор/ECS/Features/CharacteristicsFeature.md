## Системы

-   [ChangeHealthSystem](#ChangeHealthSystem)
-   [ChangeMaxHealthSystem](#ChangeMaxHealthSystem)
-   [ChangeBalanceSystem](#ChangeBalanceSystem)
-   [ChangeMaxBalanceSystem](#ChangeMaxBalanceSystem)
-   [ChangeSpeedAttackSystem](#ChangeSpeedAttackSystem)
-   [ChangeCriticalDamageSystem](#ChangeCriticalDamageSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764572814519301&cot=14)

## ChangeHealthSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `HealthComponent`
-   `-` `DeleteOnEndFrameComponent`
-   опционально `EventModeComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра здоровья.  
Работает с `EcsEventMode.Set` и `EcsEventMode.Add` (по умолчанию, если нет `EventModeComponent`).

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `HealthComponent`: `[0, HealthComponent]`, если есть `MaxHealthComponent` (на `Target`) то `[0, MaxHealthComponent]`
-   если значение `= 0`, то добавляет на `Target` `HealthEmptyTagComponent`

## ChangeMaxHealthSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `MaxHealthComponent`
-   `-` `DeleteOnEndFrameComponent`
-   опционально `EventModeComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра максимального здоровья.  
Работает с `EcsEventMode.Set` и `EcsEventMode.Add` (по умолчанию, если нет `EventModeComponent`).

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `MaxHealthComponent`: `[0, MaxHealthComponent]`
-   обрезание значения `HealthComponent` до `MaxHealthComponent`

## ChangeBalanceSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `BalanceComponent`
-   `-` `DeleteOnEndFrameComponent`
-   опционально `EventModeComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра максимального баланса.  
Работает с `EcsEventMode.Set` и `EcsEventMode.Add` (по умолчанию, если нет `EventModeComponent`).

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `BalanceComponent`: `[0, BalanceComponent]`, если есть `MaxBalanceComponent` (на `Target`) то `[0, MaxBalanceComponent]`
-   если значение `= 0`, то добавляет на `Target` `BalanceEmptyTagComponent`

## ChangeMaxBalanceSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `MaxBalanceComponent`
-   `-` `DeleteOnEndFrameComponent`
-   опционально `EventModeComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра максимального здоровья.  
Работает с `EcsEventMode.Set` и `EcsEventMode.Add` (по умолчанию, если нет `EventModeComponent`).

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `MaxBalanceComponent`: `[0, MaxBalanceComponent]`
-   обрезание значения `BalanceComponent` до `MaxBalanceComponent`

## ChangeSpeedAttackSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `AttackSpeedComponent`
-   `-` `DeleteOnEndFrameComponent`
-   опционально `EventModeComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра скорости атаки.  
Работает с `EcsEventMode.Set` и `EcsEventMode.Add` (по умолчанию, если нет `EventModeComponent`).

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `AttackSpeedComponent`: `[1, AttackSpeedComponent]`

## ChangeCriticalDamageSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `CriticalDamageComponent`
-   `-` `DeleteOnEndFrameComponent`
-   опционально `EventModeComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Изменение параметра критической атаки атаки.  
Работает с `EcsEventMode.Set` и `EcsEventMode.Add` (по умолчанию, если нет `EventModeComponent`).

-   обновление значения параметра, в зависимости от `EcsEventMode`
-   ограничение значения `CriticalDamageComponent.Chance`: `[0, 1]`
-   ограничение значения `CriticalDamageComponent.Factor`: `[0, CriticalDamageComponent.Factor]`
