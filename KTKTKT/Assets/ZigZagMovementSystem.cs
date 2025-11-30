using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public partial class ZigZagMovementSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        Entities.ForEach((ref Translation translation, ref ZigZagMovementComponent move) =>
        {
            move.ElapsedTime += deltaTime;
            translation.Value.z += move.Speed * deltaTime;
            translation.Value.x = math.sin(move.ElapsedTime * move.Frequency) * move.Amplitude;
        }).ScheduleParallel();
    }
}