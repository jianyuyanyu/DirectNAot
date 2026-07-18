#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-rawinputdevicelist
public partial struct RAWINPUTDEVICELIST
{
    public HANDLE hDevice;
    public RID_DEVICE_INFO_TYPE dwType;
}
