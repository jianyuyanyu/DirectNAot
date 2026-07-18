#nullable enable
namespace DirectN;

public partial struct DIDEVICEINSTANCEA
{
    public uint dwSize;
    public Guid guidInstance;
    public Guid guidProduct;
    public uint dwDevType;
    public InlineArrayFoundationCHAR_260 tszInstanceName;
    public InlineArrayFoundationCHAR_260 tszProductName;
    public Guid guidFFDriver;
    public ushort wUsagePage;
    public ushort wUsage;
}
