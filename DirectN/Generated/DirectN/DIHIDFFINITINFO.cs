#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/ns-dinputd-dihidffinitinfo
public partial struct DIHIDFFINITINFO
{
    public uint dwSize;
    public PWSTR pwszDeviceInterface;
    public Guid GuidInstance;
}
