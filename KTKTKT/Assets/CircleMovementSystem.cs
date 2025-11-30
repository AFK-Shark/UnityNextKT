using Unity.Burst;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

[BurstCompile]
public partial struct CircleMovementSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        float time = (float)state.WorldTime.ElapsedTime;

        state.Dependency = new CircleMoveJob
        {
            Time = time
        }.ScheduleParallel(state.Dependency);
    }

    [BurstCompile]
    public partial struct CircleMoveJob : IJobEntity
    {
        public float Time;

        public void Execute(ref LocalTransform transform, in MoveSpeed speed, in Radius radius, in Center center)
        {
            float angle = Time * speed.Value;
            transform.Position = center.Value + new float3(
                math.cos(angle) * radius.Value,
                0f,
                math.sin(angle) * radius.Value
            );
        }
    }
}