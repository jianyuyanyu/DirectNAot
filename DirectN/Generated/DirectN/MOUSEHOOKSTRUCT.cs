#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mousehookstruct
public partial struct MOUSEHOOKSTRUCT
{
    public POINT pt;
    public HWND hwnd;
    public uint wHitTestCode;
    public nuint dwExtraInfo;
}
