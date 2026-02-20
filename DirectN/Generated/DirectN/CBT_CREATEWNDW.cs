#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-cbt_createwndw
public partial struct CBT_CREATEWNDW
{
    public nint lpcs;
    public HWND hwndInsertAfter;
}
