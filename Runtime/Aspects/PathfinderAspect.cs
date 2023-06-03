using Pathfinding.Components;
using Unity.Entities;
using Unity.Mathematics;

namespace Pathfinding.Aspects
{
    public readonly partial struct PathfinderAspect : IAspect
    {
        public readonly RefRW<Pathfinder> pathfinderRef;
        public readonly EnabledRefRW<Pathfinder> pathfinderEnabledRef;

        public void FindPath(float3 from, float3 to)
        {
            ref var pf = ref pathfinderRef.ValueRW;
            pf.from = from;
            pf.to = to;
            pathfinderEnabledRef.ValueRW = true;
        }
    }
}