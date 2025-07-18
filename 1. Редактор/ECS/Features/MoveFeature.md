## Системы

-   [ChangeMoveDirectionSystem](#ChangeMoveDirectionSystem)
-   [CheckDirectionHorizontalSystem](#CheckDirectionHorizontalSystem)

[ССЫЛКА В МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764607093380246&cot=10)

## GroundTriggerEnterSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `DirectionMoveComponent`
-   `+` `TargetComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

Если у сущности нет `DirectionMove`, то добавляем `DirectionMove` к сущности из `event`, если есть, то берём только значение

## CheckDirectionHorizontalSystem

### Фильтр

-   `+` `DirectionMoveComponent`
-   `+` `DirectionViewComponent`

### Описание

Создаётся `event` для изменения `DirectionView` с новым значением полученным из метода `GetNumberAsDirectionView`
