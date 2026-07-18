#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ntddmou/ns-ntddmou-mouse_attributes
public partial struct MOUSE_ATTRIBUTES
{
    public ushort MouseIdentifier;
    public ushort NumberOfButtons;
    public ushort SampleRate;
    public uint InputDataQueueLength;
}
