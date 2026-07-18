#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-rawinput
public partial struct RAWINPUT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _data_e__Union
    {
        [FieldOffset(0)]
        public RAWMOUSE mouse;
        
        [FieldOffset(0)]
        public RAWKEYBOARD keyboard;
        
        [FieldOffset(0)]
        public RAWHID hid;
    }
    
    public RAWINPUTHEADER header;
    public _data_e__Union data;
}
