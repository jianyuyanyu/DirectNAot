#nullable enable
namespace DirectN;

public partial struct HIDP_KEYBOARD_MODIFIER_STATE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public uint _bitfield;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public uint ul;
    }
    
    public _Anonymous_e__Union Anonymous;
}
