#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct HIDP_LINK_COLLECTION_NODE
{
    public ushort LinkUsage;
    public ushort LinkUsagePage;
    public ushort Parent;
    public ushort NumberOfChildren;
    public ushort NextSibling;
    public ushort FirstChild;
    public uint _bitfield;
    public nint UserContext;
}
