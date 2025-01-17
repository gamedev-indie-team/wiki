## Системы

-   [PeriodDamageSystem](#PeriodDamageSystem)
-   [AddingCriticalDamageSystem](#AddingCriticalDamageSystem)
-   [DamageSplittingSystem](#DamageSplittingSystem)
-   [DamageCalculationSystem](#DamageCalculationSystem)
-   [ApplyDamageSystem](#ApplyDamageSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764613604360834&cot=10)

## PeriodDamageSystem

### Фильтр

-   `+` `EventPreparationDamageTagComponent`
-   `+` `TargetComponent`
-   `+` `DamageMapComponent`
-   `+` `DamageComponent`
-   `-` `TimerComponent`

### Описание

Если значение в `Timer` == 0, то создаём `event` подготовленного урона

## AddingCriticalDamageSystem

### Фильтр

-   `+` `EventPreparationDamageTagComponent`
-   `+` `TargetComponent`
-   `+` `DamageMapComponent`
-   `+` `DamageComponent`
-   `+` `OwnerComponent`
-   `-` `TimerComponent`

### Описание

Если есть компонент `HitWeak`, умножаем каждое значение в Damage в 2 раза
Если `chance` больше значения в рандоме, то умножаем Damage в `factor` из компонента `CriticalDamage`

## DamageSplittingSystem

### Фильтр

-   `+` `EventPreparationDamageTagComponent`
-   `+` `TargetComponent`
-   `+` `DamageMapComponent`
-   `+` `DamageComponent`
-   `-` `TimerComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Нарезает урон на `entity` по `damageType` из `DamageComponent`

## DamageCalculationSystem

### Фильтр

-   `+` `TargetComponent`
-   `+` `DamageTypeComponent`
-   `+` `DamageVolumeComponent`
-   `+` `TargetDamageComponent`
-   `+` `ResistVolumeComponent`

### Описание

Вычисление урона с учётом сопротивления в `ResistVolume`

## ApplyDamageSystem

### Фильтр

-   `+` `TargetComponent`
-   `+` `DamageVolumeComponent`
-   `+` `TargetDamageComponent`
-   `-` `DeleteOnEndFrameComponent`

### Описание

Уменьшение характеристики из `TargetDamage` на значение урона `DamageVolume`
Добавление `HitTag`
