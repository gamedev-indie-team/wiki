using Game.Ecs.Base.Runtime.Infrastructure;
using Leopotam.EcsLite;

namespace $rootnamespace$
{
    /// <summary>
    /// {{ОПИСАНИЕ}}.
    /// </summary>
    [RegisterEcsSystem(VContainer.Lifetime.Singleton)]
    public sealed class $safeitemname$ : IEcsInitSystem, IEcsRunSystem
    {
        private EcsFilter filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="$safeitemname$"/> class.
        /// </summary>
        public $safeitemname$()
        {
        }

        /// <inheritdoc/>
        public void Init(IEcsSystems systems)
        {
            filter = systems.GetWorld()
                .Filter<T>()
                .End();
        }

        /// <inheritdoc/>
        public void Run(IEcsSystems systems)
        {
            foreach (var entity in filter)
            {
            }
        }
    }
}