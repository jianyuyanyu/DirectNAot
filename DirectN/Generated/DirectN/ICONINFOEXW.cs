#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-iconinfoexw
public partial struct ICONINFOEXW
{
    public uint cbSize;
    public BOOL fIcon;
    public uint xHotspot;
    public uint yHotspot;
    public HBITMAP hbmMask;
    public HBITMAP hbmColor;
    public ushort wResID;
    public InlineArraySystemChar_260 szModName;
    public InlineArraySystemChar_260 szResName;
}
