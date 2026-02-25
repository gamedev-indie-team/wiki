Легковесный компонентно-ориентированный ооп фреймворк. Имеет поддержку редактора **Unity3d**

## Мир

Представлен в виде `SceneEntityWorld<TEntity>` и `IEntityWorld<TEntity>`.  
Управляет ЖЦ сущностей. Есть реализация по умолчанию для `SceneEntity` в виде `SceneEntityWorld`.

Свойства:

- `IsInitialized`
- `IsEnabled`
- `IEntityWorld<TEntity>.Entities`

Методы этапов ЖЦ:

- `Initialize`
- `Enable`
- `Disable`
- `Dispose`

Методы обновления:

- `Tick`
- `FixedTick`
- `LateTick`

Методы работы с сущностями:

- `AddEntity`
- `RemoveEntity`

Собственная реализация:

```csharp
    /// <inheritdoc cref="SceneEntityWorld{T}" />
    public sealed class GameEntityWorld : SceneEntityWorld<GameEntity>
    {
    }
```

## Сущность

Реализация набора компонентов и свойств. Всегда расширяет `IEntity`.

Реализация по умолчанию:

- `SceneEntity`: самая базовая сущность, представляет собой `MonoBehaviour` c расширением `IEntity`. Сама по себе не работает, только с внешнем управлением (приоритетно от мира)
    - `EntityComponentCollection`: коллекция компонентов сущности (только уникальные), с быстрыми методами `Add`, `Has`, `Get`
- `SceneEntityUnityLifecycle`: расширение для `SceneEntity`, только работает от ЖЦ unity3d

Свойства:

- `IsInitialized`
- `IsEnabled`
- `IsDestroyOnDispose`: уничтожить `GameObject` при вызове `Dispose`
- `Transform`
- `IEntity.Components`
- `RawComponents`: для добавления через редактор

Методы этапов ЖЦ:

- `Initialize`
- `Enable`
- `Disable`
- `Dispose`

Методы обновления:

- `Tick`
- `FixedTick`
- `LateTick`

Методы работы с компонентами:

- `AddEntityComponent`
- `RemoveEntityComponent`
- `HasEntityComponent`
- `GetEntityComponent`

Собственная реализация:

```csharp
    /// <summary>
    /// Игровая сущность.
    /// </summary>
    public interface IGameEntity : IEntity
    {
    }

    /// <inheritdoc cref="IGameEntity" />
    public sealed class GameEntity : SceneEntity, IGameEntity
    {
    }
```

### Компонент сущности

Единица реализации логики и обработки данных. Можно добавлять через редактор или код (нужно реализовать конструктор). Готовые компоненты: `GameObjectActivationBehavior`

Название зависит от выполняемой задачи + окончания:

- `[Name]Component`: только состояние или состояние и обработка логики
- `[Что-делает]Behavior`: только обработка логики

Должен расширять:

- обязательно `IEntityComponent`
- опционально: `IEntityInitializable`, `IEntityEnable`, `IEntityDisable`, `IEntityTickable`, `IEntityFixedTickable`, `IEntityLateTickable`, `IDisposable`

Собственная реализация:

```csharp
    [Serializable]
    public sealed class GameComponent : IEntityComponent
    {
        [SerializeField] private Vector3 position;
        [SerializeField] private TriggerEvents trigger;
    }
```

## Пул объектов

Сервис для управления и инициализации пулов объектов для префабов `GameObject`

Основные особенности:

- основан на `UnityEngine.Pool`
- коллекция пулов сделана на `PoolOption[]`
    - `PoolOption`: параметры пула (и для `UnityEngine.Pool`)
    - `IPoolBehavior`и `SceneEntityPoolBehavior<TEntity>`: поведение пула. Позволяет определить создание, получение, возврат и уничтожение объектов в пуле. Реализация по умолчанию `SceneEntityPoolBehavior`

Методы этапов ЖЦ:

- `Initialize`
- `Dispose`

Методы работы с пулом:

- `AddPool`
- `Get<T>`: возврат нового объекта или его компонента (`T`) по **prefab**.
- `Release`

Собственная реализация:

```csharp
    /// <inheritdoc cref="IPoolBehavior"/>
    [Serializable]
    public sealed class GameEntityPoolBehavior : SceneEntityPoolBehavior<GameEntity>
    {
        /// <inheritdoc/>
        public override void Bind(SceneEntityWorld<GameEntity> world)
        {
            World = world;
        }
    }
```
