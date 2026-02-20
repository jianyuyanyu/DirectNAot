#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-changefilterstruct
public partial struct CHANGEFILTERSTRUCT
{
    public uint cbSize;
    public MSGFLTINFO_STATUS ExtStatus;
}
