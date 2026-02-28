?> легковесный компонентно-ориентированный ооп фреймворк. Имеет поддержку редактора **Unity3d**

## Мир

Представлен в виде `SceneEntityWorld<TEntity>` расширяющий `IEntityWorld<TEntity>`  
Управляет ЖЦ сущностей. Есть реализация по умолчанию для `SceneEntity` в виде `SceneEntityWorld`

Свойства:

- `IsInitialized`
- `IsEnabled`
- `Entities`

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

Реализация набора компонентов и свойств. Всегда расширяет `IEntity`  
Для новых типов сущностей максимально **только 1 уровень наследования** от `IEntity` и `SceneEntity`

Реализация по умолчанию:

- `SceneEntity`: самая базовая сущность, представляет собой `MonoBehaviour` c расширением `IEntity`. Сама по себе не работает, только с внешнем управлением (приоритетно от мира)
    - `EntityComponentCollection`: коллекция компонентов сущности (только уникальные), с быстрыми методами `Add`, `Has`, `Get`
- `SceneEntityUnityLifecycle`: расширение для `SceneEntity`, только работает от ЖЦ unity3d

Свойства:

- `IsInitialized`
- `IsEnabled`
- `IsDestroyOnDispose`: уничтожить `GameObject` при вызове `Dispose`
- `Transform`
- `Components`

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

Единица реализации логики и обработки данных. Можно добавлять через редактор или код (нужно реализовать конструктор)  
Готовые компоненты: `GameObjectActivationBehavior`

Название зависит от выполняемой задачи + окончания:

- `[Имя]Component`: только состояние или состояние и обработка логики
- `[Что-делает]Behavior`: только обработка логики

Должен расширять:

- обязательно `IEntityComponent` и аттрибут `[Serializable]`
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

Сервис для управления и инициализации пулов объектов из префабов

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

Собственная реализация поведения пула:

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

## Дополнительные части

- реактивные поля и свойства: интерфейсы `IReadOnlyReactiveVariable<T>`, `IReactiveVariable<T>`
    - можно подписываться на изменения через событие или метод-расширение `Subscribe` (для удобной отписки)
    - реализация `ReactiveVariable<T>`
- триггеры: `TriggerEvents` и `TriggerEvents2D`
    - события на вход (`OnEnter`, `OnEnter2D`) и выход (`OnExit`, `OnExit2D`), необходим коллайдер
    - `ignoreLayers`: выбор какие слои (unity3D) игнорировать
- прокси: `ProxyEntity<TEntity>` расширяющий `IProxyEntity<TEntity>`
    - нужно добавить оригинальную `IEntity`, которая может находится в другой части `GameObject`
    - реализация `ProxySceneEntity`
- подписка: структура `Subscription`
    - позволяет подписаться и **отписку передать**, как объект, в другое место
- таймер: `DownTimer`
    - поля: текущее время и длительность, текущая итерация и количество итераций, статус таймера
    - свойства: законченный таймер и прогресс
    - события: старт, стоп, тик, завершение, сброс, изменений длительности, изменение текущей итерации, изменение количество итераций
    - состояние: простой(`Idle`), запущенный (`Playing`), пауза(`Paused`) и завершённый(`Completed`)
- кулдаун: `Cooldown`
    - поля: время, длительность кулдауна
    - свойства: прогресс, закончен ли кулдаун
    - события: тик, изменения длительности, сброс кулдауна и завершения кулдауна

### Расширения

- `EventExtensions`
    - `Subscribe` для `IReadOnlyReactiveVariable<T>`: подписка на изменение значения реактивной переменной
- `ColliderExtension`
    - `TryGetEntity<TEntity>` для `Collider` и `Collider2D`: поиск на `GameObject` компонента `IEntity` или `IProxyEntity<TEntity>`
- `LayerMaskExtension`
    - `LayerMask.Contains`: проверяет содержит ли маска указанный слой
