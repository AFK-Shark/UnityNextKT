using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.LightTransport;

public class CircleArmySpawner : MonoBehaviour
{
    public GameObject prefab;
    public int countX = 100;
    public int countZ = 500;
    public float spacing = 2f;

    void Start()
    {
        var entityPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(
        prefab,
            GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null)
        );

        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        for (int x = 0; x < countX; x++)
        {
            for (int z = 0; z < countZ; z++)
            {
                var instance = entityManager.Instantiate(entityPrefab);

                float3 pos = new float3(x * spacing, 0, z * spacing);
                entityManager.SetComponentData(instance, new Center { Value = pos });
                entityManager.SetComponentData(instance, new LocalTransform { Position = pos, Rotation = quaternion.identity, Scale = 1f });
            }
        }
    }
}