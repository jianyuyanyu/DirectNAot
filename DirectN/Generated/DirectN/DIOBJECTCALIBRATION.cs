#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-diobjectcalibration
public partial struct DIOBJECTCALIBRATION
{
    public int lMin;
    public int lCenter;
    public int lMax;
}
