#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-eventmsg
public partial struct EVENTMSG
{
    public uint message;
    public uint paramL;
    public uint paramH;
    public uint time;
    public HWND hwnd;
}
