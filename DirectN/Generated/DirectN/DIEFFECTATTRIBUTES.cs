#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-dieffectattributes
public partial struct DIEFFECTATTRIBUTES
{
    public uint dwEffectId;
    public uint dwEffType;
    public uint dwStaticParams;
    public uint dwDynamicParams;
    public uint dwCoords;
}
