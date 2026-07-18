#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-joyreghwvalues
public partial struct JOYREGHWVALUES
{
    public JOYRANGE jrvHardware;
    public InlineArrayUInt32_4 dwPOVValues;
    public uint dwCalFlags;
}
