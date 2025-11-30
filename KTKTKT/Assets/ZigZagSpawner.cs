public class ZigZagSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public int count = 1000;

    void Start()
    {
        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        var entityPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(ballPrefab, GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null));

        for (int i = 0; i < count; i++)
        {
            var entity = entityManager.Instantiate(entityPrefab);
            entityManager.AddComponentData(entity, new ZigZagMovementComponent
            {
                Speed = 5f,
                Amplitude = 2f,
                Frequency = 2f,
                ElapsedTime = 0f
            });
        }
    }
}