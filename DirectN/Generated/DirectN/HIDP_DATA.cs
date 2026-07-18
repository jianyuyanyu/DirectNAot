#nullable enable
namespace DirectN;

public partial struct HIDP_DATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint RawValue;
        
        [FieldOffset(0)]
        public BOOLEAN On;
    }
    
    public ushort DataIndex;
    public ushort Reserved;
    public _Anonymous_e__Union Anonymous;
}
