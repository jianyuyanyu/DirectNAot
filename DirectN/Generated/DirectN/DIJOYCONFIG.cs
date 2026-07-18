#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-dijoyconfig
public partial struct DIJOYCONFIG
{
    public uint dwSize;
    public Guid guidInstance;
    public JOYREGHWCONFIG hwc;
    public uint dwGain;
    public InlineArraySystemChar_256 wszType;
    public InlineArraySystemChar_256 wszCallout;
    public Guid guidGameport;
}
