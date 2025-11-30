using UnityEngine;
using Unity.Entities;

public class CounterProvider : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        var entityPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(prefab, GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null));

        var entity = entityManager.Instantiate(entityPrefab);
        entityManager.AddComponentData(entity, new CounterComponent { Value = 0 });
    }
}