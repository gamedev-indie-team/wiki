## Системы

-   [ChangeMaxValueHealthBarSystem](#ChangeMaxValueHealthBarSystem)
-   [ChangeValueHealthBarSystem](#ChangeValueHealthBarSystem)
-   [AddItemInventorySystem](#AddItemInventorySystem)
-   [ChangeGoldSystem](#ChangeGoldSystem)
-   [ChangeCountItemSystem](#ChangeCountItemSystem)
-   [DeleteItemSystem](#DeleteItemSystem)
-   [DeleteEventAddItemTagSystem](#DeleteEventAddItemTagSystem)
-   [DeleteEventChangeCountItemTagSystem](#DeleteEventChangeCountItemTagSystem)
-   [FastTravelPointListChangeViewSystem](#FastTravelPointListChangeViewSystem)

[МИРО](https://miro.com/app/board/uXjVPrjYGFk=/?moveToWidget=3458764605916522272&cot=10)

## ChangeMaxValueHealthBarSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `MaxHealthComponent`
-   `+` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Если у сущности из `Target` есть `HealthBar` и `MaxHealth`, то у `HealthBar` вызываем `OnChangeMaxMinValue` и `OnChangeValue`

## ChangeValueHealthBarSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `TargetComponent`
-   `+` `HealthComponent`
-   `+` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Если у сущности из `Target` есть `HealthBar` и `Health`, то у `HealthBar` вызываем `OnChangeValue`

## AddItemInventorySystem

### Фильтр

-   `+` `EventAddItemTagComponent`
-   `+` `TargetComponent`
-   `+` `OwnerComponent`
-   `+` `ItemTypeComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Если у сущности из `Owner` есть `Inventory`, то у `Inventory` вызываем `AddItem`

## ChangeGoldSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `OwnerComponent`
-   `+` `GoldComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Если у сущности из `Owner` есть `Inventory` и `Gold`, то у `Inventory` вызываем `ChangeGold`

## ChangeCountItemSystem

### Фильтр

-   `+` `EventChangeCountItemTagComponent`
-   `+` `OwnerComponent`
-   `+` `TargetComponent`
-   `+` `CountComponent`
-   `+` `ItemTypeComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Если у сущности из `Owner` есть `Inventory`, то у `Inventory` вызываем `SetCountItem`

## DeleteItemSystem

### Фильтр

-   `+` `EventDeleteItemTagComponent`
-   `+` `TargetComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Если у сущности из `Target` есть `Owner` и `Owner` имеет `Inventory`, то у `Inventory` вызываем `DeleteItem`

## DeleteEventAddItemTagSystem

### Фильтр

-   `+` `EventAddItemTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Добавляем к сущности `DeleteOnEndFrameComponent`

## DeleteEventChangeCountItemTagSystem

### Фильтр

-   `+` `EventChangeCountItemTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Добавляем к сущности `DeleteOnEndFrameComponent`

## FastTravelPointListChangeViewSystem

### Фильтр

-   `+` `EventTagComponent`
-   `+` `EventModeComponent`
-   `+` `TargetComponent`
-   `+` `FastTravelPointTagComponent`
-   `-` `DeleteOnEndFrameComponent`

Удаляется в `DeleteOnEndFrameType.FixedFrame`

### Описание

Если у сущности из `Target` есть `FastTravelPointTag`, то к ивент сущности добавляем `DeleteOnEndFrameType`  
Если `FastTravelPointUiListController` неактивен и мод из `EventModeComponent` равен `Set`, то делаем его активным, иначе делаем неактивным
