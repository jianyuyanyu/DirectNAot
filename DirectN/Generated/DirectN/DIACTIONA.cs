#nullable enable
namespace DirectN;

public partial struct DIACTIONA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public PSTR lptszActionName;
        
        [FieldOffset(0)]
        public uint uResIdString;
    }
    
    public nuint uAppData;
    public uint dwSemantic;
    public uint dwFlags;
    public _Anonymous_e__Union Anonymous;
    public Guid guidInstance;
    public uint dwObjID;
    public uint dwHow;
}
