#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-dijoyuservalues
public partial struct DIJOYUSERVALUES
{
    public uint dwSize;
    public JOYREGUSERVALUES ruv;
    public InlineArraySystemChar_256 wszGlobalDriver;
    public InlineArraySystemChar_256 wszGameportEmulator;
}
