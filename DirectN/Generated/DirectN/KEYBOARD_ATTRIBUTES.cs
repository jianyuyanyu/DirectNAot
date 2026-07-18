#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ntddkbd/ns-ntddkbd-keyboard_attributes
public partial struct KEYBOARD_ATTRIBUTES
{
    public KEYBOARD_ID KeyboardIdentifier;
    public ushort KeyboardMode;
    public ushort NumberOfFunctionKeys;
    public ushort NumberOfIndicators;
    public ushort NumberOfKeysTotal;
    public uint InputDataQueueLength;
    public KEYBOARD_TYPEMATIC_PARAMETERS KeyRepeatMinimum;
    public KEYBOARD_TYPEMATIC_PARAMETERS KeyRepeatMaximum;
}
