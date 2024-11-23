## Системы

-   [GroundTriggerEnterSystem](#GroundTriggerEnterSystem)
-   [GroundTriggerExitSystem](#GroundTriggerExitSystem)
-   [MoveRigidbodySystem](#MoveRigidbodySystem)
-   [JumpSystem](#JumpSystem)
-   [MaxVelocitySystem](#MaxVelocitySystem)
-   [FallingSystem](#FallingSystem)
-   [CheckFallingSystem](#CheckFallingSystem)

[ССЫЛКА В МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764607092447009&cot=10)

## GroundTriggerEnterSystem

### Фильтр

-   `+` `EventTriggerEnterTagComponent`
-   `+` `OwnerComponent`
-   `+` `GroundTriggerTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Удаляет `JumpedTag` у `Owner`.
Добавляет `GroundTag` к `Owner`

## GroundTriggerExitSystem

### Фильтр

-   `+` `EventTriggerEnterTagComponent`
-   `+` `OwnerComponent`
-   `+` `GroundTriggerTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Удаляет `GroundTag` к `Owner`

## MoveRigidbodySystem

### Фильтр

-   `+` `RigidbodyComponent`
-   `+` `VelocityComponent`
-   `+` `DirectionMoveComponent`
-   `-` `RbStaticTagComponent`
-   `-` `RbNotSimulatedTagComponent`

### Описание

Создаётся `event` на изменение скорости, которое вычисляется через `Vector3.Scale` скорости из сущности и направление из `Direction`
Удаляется `Direction` из сущности

## MoveTransformSystem

### Фильтр

-   `+` `RootTransformComponent`
-   `+` `VelocityComponent`
-   `+` `DirectionMoveComponent`
-   `-` `RigidbodyComponent`

### Описание

Изменяет позицию через `Translate` по новой позиции `fixedDeltaTime` умноженное на `Scale` от скорости сущности и `Direction`
Удаляется `Direction` из сущности

## JumpSystem

### Фильтр

-   `+` `JumpedTagComponent`
-   `+` `RigidbodyComponent`

### Описание

Удаляется `JumpedTag` из сущности
Создаётся `event` на создание импульса

## MaxVelocitySystem

### Фильтр

-   `+` `RigidbodyComponent`
-   `-` `EventChangeRigidBodyTagComponent`
-   `-` `RbStaticTagComponent`
-   `-` `RbNotSimulatedTagComponent`

### Описание

Изменяет скорость сущности в `Rigidbody` в соответствие с конфигами

## FallingSystem

### Фильтр

-   `+` `RigidbodyComponent`
-   `+` `GravityScaleComponent`
-   `+` `FallingGravityScaleComponent`
-   `-` `RbStaticTagComponent`
-   `-` `RbNotSimulatedTagComponent`

### Описание

Изменяет `gravityScale` в `Rigidbody` у сущности на `GravityScale`, если есть `GroundTag` или нет `FallingTag`, иначе берётся `FallingGravityScale`

## CheckFallingSystem

### Фильтр

-   `+` `RigidbodyComponent`
-   `-` `RbStaticTagComponent`
-   `-` `RbNotSimulatedTagComponent`

### Описание

Если сущность падает и не имеет `FallingTag`, то он добавляется на сущность
Если сущность не падает и имеет `FallingTag`, то он удаляется из сущность
