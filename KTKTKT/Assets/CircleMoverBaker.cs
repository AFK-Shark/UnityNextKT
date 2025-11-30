using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class CircleMoverBaker : Baker<CircleMoverAuthoring>
{
    public override void Bake(CircleMoverAuthoring authoring)
    {
        var entity = GetEntity(TransformUsageFlags.Dynamic);

        AddComponent(entity, new MoveSpeed { Value = authoring.Speed });
        AddComponent(entity, new Radius { Value = authoring.Radius });
        AddComponent(entity, new LocalTransform());
        AddComponent(entity, new Center { Value = authoring.transform.position });
    }
}