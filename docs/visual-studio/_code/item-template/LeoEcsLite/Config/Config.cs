using System;
using Game.Ecs.Entity.Parameters.Runtime.Abstraction;
using Game.Utils.Runtime.Exceptions;
using Leopotam.EcsLite;
using UnityEngine;

namespace $rootnamespace$
{
    /// <summary>
    /// {{ОПИСАНИЕ}}.
    /// Компонент <see cref=""/>.
    /// </summary>
    [Serializable]
    public sealed class $safeitemname$ : EntityConfigComponent
    {
        /// <summary>
        /// {{ОПИСАНИЕ}}.
        /// </summary>
        [field: SerializeField] public T Value { get; private set; }

        /// <inheritdoc/>
        public override void SetEcsComponent(ref EcsPackedEntityWithWorld entity)
        {
            if (!entity.Unpack(out var world, out int unpackEntity))
            {
                throw new NullEcsEntityException();
            }
        }
    }
}
