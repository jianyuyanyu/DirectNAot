#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ntddkbd/ns-ntddkbd-keyboard_extended_attributes
public partial struct KEYBOARD_EXTENDED_ATTRIBUTES
{
    public byte Version;
    public byte FormFactor;
    public byte KeyType;
    public byte PhysicalLayout;
    public byte VendorSpecificPhysicalLayout;
    public byte IETFLanguageTagIndex;
    public byte ImplementedInputAssistControls;
}
