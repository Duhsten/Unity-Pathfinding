using Pathfinding.Data;
using Pathfinding.Systems;
using Unity.Entities;
using Unity.Mathematics;

namespace Pathfinding.Components
{
    public struct Pathfinder : IComponentData, IEnableableComponent
    {
        public float3 from, to;

        public float requiredMinDistanceSq;

        public int agentId;


        public int pathId;

        public PathStatus pathStatus;
        // public int pathWalkerIndex;
    }
}