## Системы

-   [CooldownAbilitySystem](#CooldownAbilitySystem)
-   [ExecuteAnimationAbilitySystem](#ExecuteAnimationAbilitySystem)
-   [ExecuteAbilitySystem](#ExecuteAbilitySystem)

## CooldownAbilitySystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `OwnerComponent`
-   `+` `AbilityComponent`
-   `-` `TimerComponent`
-   `-` `DeleteOnEndFrameComponent`  

### Фильтр для сущности с таймером

-   `+` `EventTagComponent`
-   `+` `OwnerComponent`
-   `+` `AbilityComponent`
-   `+` `TimerComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание
Проверяет наличие время отката на способность для владельца из `OwnerComponent`, то есть проверяет наличие сущности с таймером.

## ExecuteAnimationAbilitySystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `AbilityComponent`
-   `+` `OwnerComponent`
-   `+` `ExecuteAnimationAbilityTagComponent`
-   `-` `TimerComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание
Добавляет компонент способности на владельца, чтобы воспроизвести анимацию эффектов способности дальше.

## ExecuteAbilitySystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `AbilityComponent`
-   `+` `OwnerComponent`
-   `-` `TimerComponent`
-   `-` `ExecuteAnimationAbilityTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание
Выполнение эффектов способности и создания сущности со временем отката способности, если время отката больше 0.