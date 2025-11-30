using Unity.Entities;

[GenerateAuthoringComponent]
public struct CounterComponent : IComponentData
{
    public int Value;
}