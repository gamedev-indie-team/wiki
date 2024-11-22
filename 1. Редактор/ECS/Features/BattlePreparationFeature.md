## Системы

- [AttackTriggerEnterSystem](#AttackTriggerEnterSystem)
- [CreateEventPreparationDamageSystem](#CreateEventPreparationDamageSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764607958335220&cot=10)

## AttackTriggerEnterSystem

### Фильтр

- `+` `EventTriggerEnterTagComponent`
- `+` `AttackTriggerTagComponent`
- `+` `TargetComponent`
- `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если в сущности из `Target` есть `BlockTag`, то добавляем его на сущность `event`
Если в сущности из `Target` есть `ImmortalTag`, то добавляем его на сущность `event`

## CreateEventPreparationDamageSystem

### Фильтр

- `+` `EventTriggerEnterTagComponent`
- `+` `AttackTriggerTagComponent`
- `+` `TargetComponent`
- `-` `DeleteOnEndFrameComponent`
- `-` `ImmortalTagComponent`
- `-` `BlockTagComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

// TODO: @chudov-d
