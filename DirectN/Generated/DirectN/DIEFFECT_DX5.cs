#nullable enable
namespace DirectN;

public partial struct DIEFFECT_DX5
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwDuration;
    public uint dwSamplePeriod;
    public uint dwGain;
    public uint dwTriggerButton;
    public uint dwTriggerRepeatInterval;
    public uint cAxes;
    public nint rgdwAxes;
    public nint rglDirection;
    public nint lpEnvelope;
    public uint cbTypeSpecificParams;
    public nint lpvTypeSpecificParams;
}
