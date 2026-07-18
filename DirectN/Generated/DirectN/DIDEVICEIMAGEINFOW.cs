#nullable enable
namespace DirectN;

public partial struct DIDEVICEIMAGEINFOW
{
    public InlineArraySystemChar_260 tszImagePath;
    public uint dwFlags;
    public uint dwViewID;
    public RECT rcOverlay;
    public uint dwObjID;
    public uint dwcValidPts;
    public InlineArrayPOINT_5 rgptCalloutLine;
    public RECT rcCalloutRect;
    public uint dwTextAlign;
}
