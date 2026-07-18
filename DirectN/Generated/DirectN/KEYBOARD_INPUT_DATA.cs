#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ntddkbd/ns-ntddkbd-keyboard_input_data
public partial struct KEYBOARD_INPUT_DATA
{
    public ushort UnitId;
    public ushort MakeCode;
    public ushort Flags;
    public ushort Reserved;
    public uint ExtraInformation;
}
