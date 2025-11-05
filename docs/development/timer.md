# Таймер {docsify-ignore-all}

?> Механизм таймеров основан на `ECS`

-   обработка таймеров выполняется в начале кадра
-   для взаимодействия **НЕ** из `ECS` используется `TimerService` (через `DI`)
    -   есть подписка на тик и конец таймера
-   все, что связано с таймерами, должно настраиваться через `TimerOptions`
-   сущности-таймеры заносить в `ITimerEcsFactory` и `ITimerEventEcsFactory`
-   основные компоненты жизненного цикла:
    -   `TimerTickTag` — значение таймера на текущей итерации равно 0
    -   `TimerExpiredTag` — конец таймера

## Ссылки

-   [miro - описание TimerFeature](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764636194593507&cot=14)
