using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine.LightTransport;

public class CircleGizmosDrawer : MonoBehaviour
{
    public int maxDraw = 1000;

    void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;

        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        var entities = entityManager.GetAllEntities();
        int count = 0;

        foreach (var entity in entities)
        {
            if (entityManager.HasComponent<LocalTransform>(entity))
            {
                var pos = entityManager.GetComponentData<LocalTransform>(entity).Position;
                Gizmos.DrawSphere(pos, 0.2f);

                count++;
                if (count >= maxDraw) break;
            }
        }

        entities.Dispose();
    }
}