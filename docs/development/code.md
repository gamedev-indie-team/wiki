## Dependency injection

При добавлении компонента `InjectServices` на `GameObject`, механизм `DI` попытается произвести инъекцию при запуске сцены.  
Если нужно внедрить что-то вложенным объектам, то передавать `IObjectResolver container`.

?> Одного компонента в корне объекта достаточно, чтобы инъекция была произведена и потомкам

Класс C# — инъекция происходит в обычном режиме, через конструктор при создании.  
MonoBehavior — компоненту на сцене добавить метод, с нужными параметрами:

```csharp
// воспринимается как конструктор
[VContainer.Inject, JetBrains.Annotations.UsedImplicitly]
private void DependencyInject()
{
}
```

## MonoBehavior

?> Альтернатива конструктору / Awake (для вложений)

```csharp
public void Initialization()
{
}
```

?> SerializeField в виде свойств а не полей

```csharp
/// <summary>
/// {DESC}.
/// </summary>
[field: SerializeField] public Type PropName { get; private set; }
```

?> Для ссылочных полей дополнительные атрибуты

```csharp
NaughtyAttributes.Required("Required PropName")
```

### SerializeReference при использовании SubclassSelector

`SubclassSelector` позволяет выбирать нужные типы в полях MonoBehavior через интерфейс юнити (альтернатива другим подходам, например куче компоннетов на GO).

!> Чтобы `Type | IType` можно было выбрать в `SubclassSelector`, нужно ВСЕЙ иерархии проставить `[Serializable]` (интерфейсу мб и не надо)

```csharp
/// <summary>
/// {DESC}.
/// </summary>
[field: SerializeReference, SubclassSelector]
public Type[] Components { get; private set; } = Array.Empty<Type>();
```
