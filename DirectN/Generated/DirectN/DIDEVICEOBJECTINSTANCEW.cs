#nullable enable
namespace DirectN;

public partial struct DIDEVICEOBJECTINSTANCEW
{
    public uint dwSize;
    public Guid guidType;
    public uint dwOfs;
    public uint dwType;
    public uint dwFlags;
    public InlineArraySystemChar_260 tszName;
    public uint dwFFMaxForce;
    public uint dwFFForceResolution;
    public ushort wCollectionNumber;
    public ushort wDesignatorIndex;
    public ushort wUsagePage;
    public ushort wUsage;
    public uint dwDimension;
    public ushort wExponent;
    public ushort wReportId;
}
