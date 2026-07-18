#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-diffdeviceattributes
public partial struct DIFFDEVICEATTRIBUTES
{
    public uint dwFlags;
    public uint dwFFSamplePeriod;
    public uint dwFFMinTimeResolution;
}
