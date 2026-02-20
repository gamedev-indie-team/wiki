## Сортировка зависимостей в `.asmdef`

!> Ссылки которые не указаны в `references.json` будут удалены из `.asmdef`

Расположение: `репозиторий\.scripts`

- в `references.json` добавить новые сборки, ссылки на пакеты unity и сторонние.
    - если в сборку добавили пакет unity, то его ставят в начале списка (алфавитный порядок)
    - следом идут сборки на сторонние пакеты (алфавитный порядок)
    - СВОИ новые сборки добавляются так: чем ниже сборка, тем больше у неё ссылок на предыдущие. Если сборки на одном уровне или они вложения, то добавляются по порядку

- запустить `sort-references-run.bat`

## Установка внешних пакетов

По приоритету:

1. [openupm.com](https://openupm.com/), через [Scoped registries](https://docs.unity3d.com/6000.3/Documentation/Manual/upm-scoped.html)
    - открыть `Edit/Project Settings/Package Manager`
    - добавить `Scope` пакета
    - открыть `Window/Package Manager/My Registers`
    - выбрать нужный пакет - `install`
2. `git URL`, из репозитория пакета
    - открыть `Window/Package Manager`,
    - нажать `+` - `Add package from git URL` - вставить url
3. [asset store unity](https://assetstore.unity.com/) / прямым ассетом.

## MonoBehavior

Альтернатива конструктору / Awake (для вложений)

```csharp
public void Initialization()
{
}
```

`SerializeField` в виде свойств а не полей

```csharp
/// <summary>
/// {DESC}.
/// </summary>
[field: SerializeField] public Type PropName { get; private set; }
```

Для ссылочных полей дополнительные атрибуты

```csharp
NaughtyAttributes.Required("Required PropName")
```

## SerializeReference при использовании SubclassSelector

`SubclassSelector` позволяет выбирать нужные типы в полях MonoBehavior через интерфейс юнити (альтернатива другим подходам, например куче компоннетов на GO).

!> Чтобы `Type | IType` можно было выбрать в `SubclassSelector`, нужно **всей иерархии** проставить `[Serializable]` (интерфейсу мб и не надо)

```csharp
/// <summary>
/// {DESC}.
/// </summary>
[field: SerializeReference, SubclassSelector]
public Type[] Components { get; private set; } = Array.Empty<Type>();
```
