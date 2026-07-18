#nullable enable
namespace DirectN;

public partial struct DIDEVICEINSTANCEW
{
    public uint dwSize;
    public Guid guidInstance;
    public Guid guidProduct;
    public uint dwDevType;
    public InlineArraySystemChar_260 tszInstanceName;
    public InlineArraySystemChar_260 tszProductName;
    public Guid guidFFDriver;
    public ushort wUsagePage;
    public ushort wUsage;
}
