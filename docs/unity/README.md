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

## Тестирование

Используется [NUnit](https://nunit.org/) и его [Constraint Model](https://docs.nunit.org/articles/nunit/writing-tests/assertions/assertion-models/constraint.html)

### Виды

- **EditMode тесты (Unit-тесты)**: проверяют логику кода (функции, классы) без запуска игры, работая быстрее. Используются для проверки математических расчетов (или логики инвентаря)
    - путь размещения: **[_сборка_фичи_]\Editor\Tests.EditMode**
    - имя проекта/файла `.asmdef`: **[_сборка_фичи_].Tests.EditMode** (в имени **игнорируется папка Editor**)
- **PlayMode тесты (Интеграционные/Системные)**: запускают игру, проверяя поведение игровых объектов (`GameObject`), физику, сцены, корутины и UI-взаимодействия
    - путь размещения: **[_сборка_фичи_]\Tests.PlayMode**
    - имя проекта: **[_сборка_фичи_].Tests.PlayMode** (файл аналогично)
- атрибут `[UnityTest]`: предназначен для **EditMode тестов** и **PlayMode тестов**. Он указывает Unity на то, что тест следует запускать как корутину
- у тестов **не должно быть `namespace`** (для удобства просмотра в `Test runner`)

### `.editorconfig` для сборок тестов и правила

Т.к. не удается ограничить правила для пути сборок в корневом `.editorconfig`, то нужно создать локальный файл для сборки на уровне `.asmdef`

```csharp
# отключает правило локально

root = false

[*.cs]
dotnet_diagnostic.SA1600.severity = none
```
