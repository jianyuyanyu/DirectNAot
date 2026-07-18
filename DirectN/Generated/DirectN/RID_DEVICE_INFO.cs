#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-rid_device_info
public partial struct RID_DEVICE_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public RID_DEVICE_INFO_MOUSE mouse;
        
        [FieldOffset(0)]
        public RID_DEVICE_INFO_KEYBOARD keyboard;
        
        [FieldOffset(0)]
        public RID_DEVICE_INFO_HID hid;
    }
    
    public uint cbSize;
    public RID_DEVICE_INFO_TYPE dwType;
    public _Anonymous_e__Union Anonymous;
}
