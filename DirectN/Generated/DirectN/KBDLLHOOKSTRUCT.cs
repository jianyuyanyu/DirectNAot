#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-kbdllhookstruct
public partial struct KBDLLHOOKSTRUCT
{
    public uint vkCode;
    public uint scanCode;
    public KBDLLHOOKSTRUCT_FLAGS flags;
    public uint time;
    public nuint dwExtraInfo;
}
