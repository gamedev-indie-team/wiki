## EntityConfig

### Общее

-   создается и настраивается файл `EntityConfig`
-   на `GO` сущности вешается `EntityConfigConverter`, добавляется созданный файл

### Новый компоненты конфига

-   наследование от `EntityConfigComponent` **(обязательно)**
-   папка `Configs`, обязательно аттрибут `[Serializable]`

> есть в шаблонах студии

```csharp
    /// <inheritdoc cref="Component"/>
    [Serializable]
    public sealed class AttackSpeedConfig : EntityConfigComponent
    {
        /// <inheritdoc cref="Component.Value"/>
        [field: SerializeField, MinValue(0)] public float Value { get; private set; }

        /// <inheritdoc/>
        public override void SetEcsComponent(ref EcsPackedEntityWithWorld entity)
        {
            if (!entity.Unpack(out var world, out int unpackEntity))
            {
                throw new NullEcsEntityException();
            }

            world.GetPool<Component>().Add(unpackEntity).Value = Value;
        }
    }
```

### Компонент EntityTagsConfig

-   в список выбора попадают компоненты с аттрибутом `[Entity.Parameters.Runtime.Attributes.EntityTag]`
-   в приоритете ставить `*TagComponent`, т.к.значение не задать, лучше для НЕ тегов использовать конфиги

## Конверторы

### Общее

-   на `GO` сущности вешается `*Converter` и настраивается

### Новый конвертер

-   наследование от `MonoBehavior` и `IConvertableToEcsComponent` **(обязательно)**
-   наследование от `IDestroyableBeforeConvert` (опционально)
-   папка `Converters`

> есть в шаблонах студии

```csharp
/// <inheritdoc cref="Component"/>
public sealed class NameConverter : MonoBehaviour, IConvertableToEcsComponent, IDestroyableBeforeConvert
{
    /// <inheritdoc cref="Component.Value"/>
    [field: SerializeField] public T Value { get; private set; }

    /// <inheritdoc/>
    public void SetEcsComponent(ref EcsPackedEntityWithWorld packedWithWorld)
    {
        if (!packedWithWorld.Unpack(out EcsWorld world, out int entity)) return;

        var poolComponent = world.GetPool<Component>();
        if (!poolComponent.Has(entity)) poolComponent.Add(entity);

        poolComponent.Get(entity).Value = Value;
    }

    /// <inheritdoc/>
    void IDestroyableBeforeConvert.Destroy() => Destroy(this);
}
```
