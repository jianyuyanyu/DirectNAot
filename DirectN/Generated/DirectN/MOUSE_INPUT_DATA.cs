#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ntddmou/ns-ntddmou-mouse_input_data
public partial struct MOUSE_INPUT_DATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public ushort ButtonFlags;
            public ushort ButtonData;
        }
        
        [FieldOffset(0)]
        public uint Buttons;
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
    }
    
    public ushort UnitId;
    public ushort Flags;
    public _Anonymous_e__Union Anonymous;
    public uint RawButtons;
    public int LastX;
    public int LastY;
    public uint ExtraInformation;
}
