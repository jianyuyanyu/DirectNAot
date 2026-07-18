#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct HIDP_EXTENDED_ATTRIBUTES
{
    public byte NumGlobalUnknowns;
    public InlineArrayByte_3 Reserved;
    public nint GlobalUnknowns;
    public InlineArrayUInt32_1 Data; // variable-length array placeholder
}
