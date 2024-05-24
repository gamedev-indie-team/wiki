## Компонент конфига `EntityTagsConfig`

-   содержит список тегов, которые будут добавлены на сущность при конвертации в `ecs-entity`
-   теги, на сущность, добавляются через `System.Reflection`
-   `ecs-component` с `EntityTagAttribute` попадает в список выбора

## Валидация

На старте (`OnEnable`), проверяет дубли, и если есть дубль, то происходит ошибка `InvalidOperationException($"Tag is contained in the TagTypes")`
