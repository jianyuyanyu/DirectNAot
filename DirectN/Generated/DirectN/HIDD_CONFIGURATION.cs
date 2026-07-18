#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct HIDD_CONFIGURATION
{
    public nint cookie;
    public uint size;
    public uint RingBufferSize;
}
