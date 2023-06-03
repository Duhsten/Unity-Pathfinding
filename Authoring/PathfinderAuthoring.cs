using Pathfinding.Components;
using Pathfinding.Data;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Authoring
{
    public class PathfinderAuthoring : MonoBehaviour
    {
        public float minDistance;

        public class PathfinderAuthoringBaker : Baker<PathfinderAuthoring>
        {
            public override void Bake(PathfinderAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);
                AddComponent(entity, new Pathfinder
                {
                    from = default,
                    to = default,
                    requiredMinDistanceSq = math.pow(authoring.minDistance, 2),
                    agentId = 0,
                    pathId = 0,
                    pathStatus = PathStatus.None
                });
                SetComponentEnabled<Pathfinder>(entity, false);
                AddBuffer<PathBuffer>(entity);
            }
        }
    }
}