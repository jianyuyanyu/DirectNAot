#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-cwpretstruct
public partial struct CWPRETSTRUCT
{
    public LRESULT lResult;
    public LPARAM lParam;
    public WPARAM wParam;
    public uint message;
    public HWND hwnd;
}
