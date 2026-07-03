#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-cursorinfo
public partial struct CURSORINFO
{
    public uint cbSize;
    public CURSORINFO_FLAGS flags;
    public HCURSOR hCursor;
    public POINT ptScreenPos;
}
