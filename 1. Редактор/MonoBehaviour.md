## Альтернатива конструктору

```
public void Initialization()
{
}
```

## SerializeField в виде свойств а не полей

Обязательно описание

```
/// <summary>
///     .
/// </summary>
[field: SerializeField] public Type PropName { get; private set; }
```

## Для ссылочных полей дополнительные атрибуты

Необходимый `namespace` `using NaughtyAttributes;`

```
Required("Required PropName")
```
