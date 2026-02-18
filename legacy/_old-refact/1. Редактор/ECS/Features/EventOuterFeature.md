## Системы

-   [EventBossDeadSystem](#EventBossDeadSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764625502002294&cot=10)

## EventBossDeadSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `DeadTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.Frame`

### Описание

В случае смерти босса, будет выполнены все `action`, которые подвязанные к `EventHandler`