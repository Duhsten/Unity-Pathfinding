using Pathfinding.Components;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

namespace Pathfinding.Authoring
{
    public class PathfinderAuthoring : MonoBehaviour
    {
        public float minDistance;

        public int agentId;

        public class PathfinderAuthoringBaker : Baker<PathfinderAuthoring>
        {
            public override void Bake(PathfinderAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);

                Debug.Log(NavMesh.GetSettingsNameFromID(authoring.agentId));
                ;
                AddComponent(entity, new Pathfinder
                {
                    from = default,
                    to = default,
                    requiredMinDistanceSq = math.pow(authoring.minDistance, 2),
                    agentId = NavMesh.GetSettingsByIndex(authoring.agentId).agentTypeID,
                    pathId = 0,
                    pathStatus = 0
                });
                SetComponentEnabled<Pathfinder>(entity, false);
                AddBuffer<PathBuffer>(entity);
            }
        }
    }
}