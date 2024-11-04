# Дополнительные функции для Ecs world

## Копирование пулов в другой мир

Метод копирует все пулы из srcWorld в dstWorld. Добавление пула в мир происходит с помощью метода EcsWorld.GetPool. Если пул уже существует в dstWorld он будет пропущен.

```
dstWorld.CopyPools(srcWorld)
```

## Копирование сущности в другой мир

Метод переносит данные из пулов в сущность dstEntity из dstWorld, которые есть в мире srcWorld по сущности srcEntity. Если какого-то пула нет в мире dstWorld и есть в srcWorld, то пул создаётся в мире dstWorld в процессе копирования. Если у dstEntity есть данные в пуле, который есть в srcEntity, то данные из srcEntity запишутся для dstEntity. Если такого пула нет, то сущность будет добавлена в пул.

Использованы методы: EcsWorld.GetAllPools, EcsWorld.GetPoolByType, EcsWorld.GetPool, EcsPool.GetComponentType, EcsPool.GetRaw, EcsPool.SetRaw, EcsPool.AddRaw.

```
srcWorld.CopyEntityInOtherWorld(srcEntity, dstWorld, dstEntity)
```
