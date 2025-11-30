using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct ZigZagMovementComponent : IComponentData
{
    public float Speed;
    public float Amplitude;
    public float Frequency;
    public float ElapsedTime;
}