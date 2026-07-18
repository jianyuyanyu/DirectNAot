#nullable enable
namespace DirectN;

public partial struct HID_COLLECTION_INFORMATION
{
    public uint DescriptorSize;
    public BOOLEAN Polled;
    public InlineArrayByte_1 Reserved1;
    public ushort VendorID;
    public ushort ProductID;
    public ushort VersionNumber;
}
