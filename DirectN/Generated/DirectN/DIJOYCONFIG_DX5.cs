#nullable enable
namespace DirectN;

public partial struct DIJOYCONFIG_DX5
{
    public uint dwSize;
    public Guid guidInstance;
    public JOYREGHWCONFIG hwc;
    public uint dwGain;
    public InlineArraySystemChar_256 wszType;
    public InlineArraySystemChar_256 wszCallout;
}
