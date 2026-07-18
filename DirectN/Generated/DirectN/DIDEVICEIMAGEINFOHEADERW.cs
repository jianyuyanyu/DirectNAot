#nullable enable
namespace DirectN;

public partial struct DIDEVICEIMAGEINFOHEADERW
{
    public uint dwSize;
    public uint dwSizeImageInfo;
    public uint dwcViews;
    public uint dwcButtons;
    public uint dwcAxes;
    public uint dwcPOVs;
    public uint dwBufferSize;
    public uint dwBufferUsed;
    public nint lprgImageInfoArray;
}
