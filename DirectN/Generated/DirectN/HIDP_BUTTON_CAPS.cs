#nullable enable
namespace DirectN;

public partial struct HIDP_BUTTON_CAPS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Range_e__Struct
        {
            public ushort UsageMin;
            public ushort UsageMax;
            public ushort StringMin;
            public ushort StringMax;
            public ushort DesignatorMin;
            public ushort DesignatorMax;
            public ushort DataIndexMin;
            public ushort DataIndexMax;
        }
        
        public struct _NotRange_e__Struct
        {
            public ushort Usage;
            public ushort Reserved1;
            public ushort StringIndex;
            public ushort Reserved2;
            public ushort DesignatorIndex;
            public ushort Reserved3;
            public ushort DataIndex;
            public ushort Reserved4;
        }
        
        [FieldOffset(0)]
        public _Range_e__Struct Range;
        
        [FieldOffset(0)]
        public _NotRange_e__Struct NotRange;
    }
    
    public ushort UsagePage;
    public byte ReportID;
    public BOOLEAN IsAlias;
    public ushort BitField;
    public ushort LinkCollection;
    public ushort LinkUsage;
    public ushort LinkUsagePage;
    public BOOLEAN IsRange;
    public BOOLEAN IsStringRange;
    public BOOLEAN IsDesignatorRange;
    public BOOLEAN IsAbsolute;
    public ushort ReportCount;
    public ushort Reserved2;
    public InlineArrayUInt32_9 Reserved;
    public _Anonymous_e__Union Anonymous;
}
