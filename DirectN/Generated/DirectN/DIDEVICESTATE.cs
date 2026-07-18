#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-didevicestate
public partial struct DIDEVICESTATE
{
    public uint dwSize;
    public uint dwState;
    public uint dwLoad;
}
