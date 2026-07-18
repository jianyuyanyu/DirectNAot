#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-rawhid
public partial struct RAWHID
{
    public uint dwSizeHid;
    public uint dwCount;
    public InlineArrayByte_1 bRawData; // variable-length array placeholder
}
