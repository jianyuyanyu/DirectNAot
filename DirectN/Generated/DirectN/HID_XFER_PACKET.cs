#nullable enable
namespace DirectN;

public partial struct HID_XFER_PACKET
{
    public nint reportBuffer;
    public uint reportBufferLen;
    public byte reportId;
}
