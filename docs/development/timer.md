# Таймер {docsify-ignore-all}

?> Механизм таймеров основан на `ECS`

-   обработка таймеров выполняется в начале кадра
-   для взаимодействия **НЕ** из `ECS` используется `TimerService` (через `DI`)
    -   есть подписка на тик и конец таймера
-   все, что связано с таймерами, должно настраиваться через `TimerOptions`
-   сущности-таймеры заносить в `ITimerEcsFactory` и `ITimerEventEcsFactory`
-   виды: таймера по-времени (`TimerComponent`), таймер по кадрам (`FrameTimerComponent`)

## Жизненный цикл

-   тик таймера - `TimerTickTag` (значение таймера на текущей итерации равно 0)
-   конец таймера - `TimerExpiredTag`
-   в какой кадр удалить - `DeleteOnExpireTimer` (значение != None)
-   клонирование сущности - `CloneByTimerTickTag` + `TimerTickTag`. С новой сущности удаляются компоненты таймера
-   удаление всех **компонентов таймера** через событие `ITimerEventEcsFactory.GetEventRemoveTimerEntity`

!> Если не добавить `DeleteOnExpireTimer` (None тоже игнорируется), то таймер никогда не удалиться, но и участвовать в обработке тоже не будет

## Ссылки

-   [miro - описание TimerFeature](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764636194593507&cot=14)
