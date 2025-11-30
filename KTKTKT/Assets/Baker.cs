using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct MoveSpeed : IComponentData
{
    public float Value;
}

[GenerateAuthoringComponent]
public struct Radius : IComponentData
{
    public float Value;
}

public struct Center : IComponentData
{
    public float3 Value;
}