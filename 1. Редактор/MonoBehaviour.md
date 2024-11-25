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
/// {DESC}.
/// </summary>
[field: SerializeField] public Type PropName { get; private set; }
```

## Для ссылочных полей дополнительные атрибуты

Необходимый `namespace` `NaughtyAttributes;`

```
Required("Required PropName")
```
