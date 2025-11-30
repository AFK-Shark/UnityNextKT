using System.Collections;
using Unity.Entities;

public partial class CounterSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        Entities.ForEach((ref CounterComponent counter) =>
        {
            counter.Value++;
        }).ScheduleParallel();
    }
}