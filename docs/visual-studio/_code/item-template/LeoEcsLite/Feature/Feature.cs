using System;
using Game.Ecs.Base.Runtime.Interfaces;
using Leopotam.EcsLite;
using VContainer;

namespace $rootnamespace$
{
    /// <summary>
    /// Feature $rootnamespace$.
    /// </summary>
    public sealed class $safeitemname$ : IEcsFeature
    {
        /// <inheritdoc/>
        public void Init(IObjectResolver objectResolver, IEcsSystems systems)
        {
            if (objectResolver is null)
            {
                throw new ArgumentNullException(nameof(objectResolver));
            }

            if (systems is null)
            {
                throw new ArgumentNullException(nameof(systems));
            }

            systems
                .Add(objectResolver.Resolve<T>())
                .Add(objectResolver.Resolve<T>());
        }
    }
}
