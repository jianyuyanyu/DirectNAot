#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-rid_device_info_keyboard
public partial struct RID_DEVICE_INFO_KEYBOARD
{
    public uint dwType;
    public uint dwSubType;
    public uint dwKeyboardMode;
    public uint dwNumberOfFunctionKeys;
    public uint dwNumberOfIndicators;
    public uint dwNumberOfKeysTotal;
}
