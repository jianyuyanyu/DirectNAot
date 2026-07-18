#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-rawmouse
public partial struct RAWMOUSE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public ushort usButtonFlags;
            public ushort usButtonData;
        }
        
        [FieldOffset(0)]
        public uint ulButtons;
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
    }
    
    public MOUSE_STATE usFlags;
    public _Anonymous_e__Union Anonymous;
    public uint ulRawButtons;
    public int lLastX;
    public int lLastY;
    public uint ulExtraInformation;
}
