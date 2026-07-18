#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-rawinputdevice
public partial struct RAWINPUTDEVICE
{
    public ushort usUsagePage;
    public ushort usUsage;
    public RAWINPUTDEVICE_FLAGS dwFlags;
    public HWND hwndTarget;
}
