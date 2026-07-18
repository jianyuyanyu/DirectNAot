#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ntddkbd/ns-ntddkbd-keyboard_indicator_translation
public partial struct KEYBOARD_INDICATOR_TRANSLATION
{
    public ushort NumberOfIndicatorKeys;
    public InlineArrayINDICATOR_LIST_1 IndicatorList; // variable-length array placeholder
}
