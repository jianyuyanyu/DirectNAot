#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-debughookinfo
public partial struct DEBUGHOOKINFO
{
    public uint idThread;
    public uint idThreadInstaller;
    public LPARAM lParam;
    public WPARAM wParam;
    public int code;
}
