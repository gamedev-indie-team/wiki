## Сортировка зависимостей в `.asmdef`

!> Ссылки которые не указаны в `references.json` будут удалены из `.asmdef`

Расположение: `репозиторий\.scripts`

-   в `references.json` добавить новые сборки, ссылки на пакеты unity и сторонние.

    -   если в сборку добавили пакет unity, то его ставят в начале списка (алфавитный порядок)
    -   следом идут сборки на сторонние пакеты (алфавитный порядок)
    -   СВОИ новые сборки добавляются так: чем ниже сборка, тем больше у неё ссылок на предыдущие. Если сборки на одном уровне или они вложения, то добавляются по порядку

-   запустить `sort-references-run.bat`

## Установка внешних пакетов

По приоритету:

1. [openupm.com](https://openupm.com/), через [Scoped registries](https://docs.unity3d.com/2022.3/Documentation/Manual/upm-scoped.html)
    - открыть `Edit/Project Settings/Package Manager`
    - добавить `Scope` пакета
    - открыть `Window/Package Manager/My Registers`
    - выбрать нужный пакет - `install`
2. `git URL`, из репозитория пакета
    - открыть `Window/Package Manager`,
    - нажать `+` - `Add package from git URL` - вставить url
3. [asset store unity](https://assetstore.unity.com/) / прямым ассетом.
