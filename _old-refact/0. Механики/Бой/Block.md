# Компоненты

-   `AllowBlockTagComponent` - сущность может ставить блок (настройка сущности)
-   `BlockTagComponent` - состояние блокирования
-   `EventChangeBlockTagComponent` - событие изменения состояния блока

# Механизм

1. через `IBattleEventEcsFactory.GetEventChangeBlockTagEntity` создается событие смены состояния блокирования
2. если на сущности есть `AllowBlockTagComponent` то сущность становится в состояние блокирования (ставится `BlockTagComponent`)
3. если сущность имеет состояние: **атака**, **смерть**, **возрождение**, **прыжок** (полет), то `AllowBlockTagComponent` **убирается**
4. при блокировании атакующий откидывается в противоположном направлении от своего просмотра, через `IPhysicsEventEcsFactory.GetEventAddForceEntity`

-   всегда отражается 100% урона
