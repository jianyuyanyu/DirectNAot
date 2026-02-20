#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-cbtactivatestruct
public partial struct CBTACTIVATESTRUCT
{
    public BOOL fMouse;
    public HWND hWndActive;
}
