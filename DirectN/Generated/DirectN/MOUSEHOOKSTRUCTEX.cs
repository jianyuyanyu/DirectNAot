#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mousehookstructex
public partial struct MOUSEHOOKSTRUCTEX
{
    public MOUSEHOOKSTRUCT Base;
    public uint mouseData;
}
