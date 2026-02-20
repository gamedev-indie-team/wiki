using Game.Ecs.Base.Runtime.Interfaces;
using Game.Utils.Runtime.Exceptions;
using Leopotam.EcsLite;
using UnityEngine;

namespace $rootnamespace$
{
    /// <summary>
    /// {{ОПИСАНИЕ}}.
    /// Компонент <see cref=""/>.
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class $safeitemname$ : MonoBehaviour, IConvertableToEcsComponent, IDestroyableBeforeConvert
    {
        /// <summary>
        /// {{ОПИСАНИЕ}}.
        /// </summary>
        [field: SerializeField] public TValue Value { get; private set; }

        /// <inheritdoc/>
        public void SetEcsComponent(ref EcsPackedEntityWithWorld packedWithWorld)
        {
            if (!packedWithWorld.Unpack(out var world, out int entity))
            {
                throw new NullEcsEntityException(gameObject);
            }
        }

        /// <inheritdoc/>
        void IDestroyableBeforeConvert.Destroy() => Destroy(this);
    }
}
