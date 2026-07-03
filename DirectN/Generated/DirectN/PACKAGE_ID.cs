#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/appmodel/ns-appmodel-package_id
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct PACKAGE_ID
{
    public uint reserved;
    public uint processorArchitecture;
    public PACKAGE_VERSION version;
    public PWSTR name;
    public PWSTR publisher;
    public PWSTR resourceId;
    public PWSTR publisherId;
}
