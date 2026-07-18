#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-rid_device_info_mouse
public partial struct RID_DEVICE_INFO_MOUSE
{
    public uint dwId;
    public uint dwNumberOfButtons;
    public uint dwSampleRate;
    public BOOL fHasHorizontalWheel;
}
