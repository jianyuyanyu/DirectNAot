#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ntddkbd/ns-ntddkbd-keyboard_typematic_parameters
public partial struct KEYBOARD_TYPEMATIC_PARAMETERS
{
    public ushort UnitId;
    public ushort Rate;
    public ushort Delay;
}
