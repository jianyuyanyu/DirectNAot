#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-diobjectattributes
public partial struct DIOBJECTATTRIBUTES
{
    public uint dwFlags;
    public ushort wUsagePage;
    public ushort wUsage;
}
