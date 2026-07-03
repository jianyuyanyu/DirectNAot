#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/appmodel/ns-appmodel-package_version
public partial struct PACKAGE_VERSION
{
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public ushort Revision;
            public ushort Build;
            public ushort Minor;
            public ushort Major;
        }
        
        [FieldOffset(0)]
        public ulong Version;
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
    }
    
    public _Anonymous_e__Union Anonymous;
}
