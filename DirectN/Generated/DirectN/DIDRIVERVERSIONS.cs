#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-didriverversions
public partial struct DIDRIVERVERSIONS
{
    public uint dwSize;
    public uint dwFirmwareRevision;
    public uint dwHardwareRevision;
    public uint dwFFDriverVersion;
}
