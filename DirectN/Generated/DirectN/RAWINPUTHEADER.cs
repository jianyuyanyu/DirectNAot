#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-rawinputheader
public partial struct RAWINPUTHEADER
{
    public uint dwType;
    public uint dwSize;
    public HANDLE hDevice;
    public WPARAM wParam;
}
