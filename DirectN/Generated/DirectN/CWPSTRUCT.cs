#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-cwpstruct
public partial struct CWPSTRUCT
{
    public LPARAM lParam;
    public WPARAM wParam;
    public uint message;
    public HWND hwnd;
}
