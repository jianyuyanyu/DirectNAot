#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ntddkbd/ns-ntddkbd-keyboard_indicator_parameters
public partial struct KEYBOARD_INDICATOR_PARAMETERS
{
    public ushort UnitId;
    public ushort LedFlags;
}
