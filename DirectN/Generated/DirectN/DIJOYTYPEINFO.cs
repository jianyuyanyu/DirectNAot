#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-dijoytypeinfo
public partial struct DIJOYTYPEINFO
{
    public uint dwSize;
    public JOYREGHWSETTINGS hws;
    public Guid clsidConfig;
    public InlineArraySystemChar_256 wszDisplayName;
    public InlineArraySystemChar_260 wszCallout;
    public InlineArraySystemChar_256 wszHardwareId;
    public uint dwFlags1;
    public uint dwFlags2;
    public InlineArraySystemChar_256 wszMapFile;
}
