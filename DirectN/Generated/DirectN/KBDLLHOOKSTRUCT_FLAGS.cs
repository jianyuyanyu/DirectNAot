#nullable enable
namespace DirectN;

[Flags]
public enum KBDLLHOOKSTRUCT_FLAGS : uint
{
    LLKHF_EXTENDED = 1,
    LLKHF_ALTDOWN = 32,
    LLKHF_UP = 128,
    LLKHF_INJECTED = 16,
    LLKHF_LOWER_IL_INJECTED = 2,
}
