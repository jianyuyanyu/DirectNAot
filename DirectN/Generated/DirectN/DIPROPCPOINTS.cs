#nullable enable
namespace DirectN;

public partial struct DIPROPCPOINTS
{
    public DIPROPHEADER diph;
    public uint dwCPointsNum;
    public InlineArrayCPOINT_8 cp;
}
