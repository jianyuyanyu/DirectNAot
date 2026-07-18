#nullable enable
namespace DirectN;

public partial struct DICONFIGUREDEVICESPARAMSW
{
    public uint dwSize;
    public uint dwcUsers;
    public PWSTR lptszUserNames;
    public uint dwcFormats;
    public nint lprgFormats;
    public HWND hwnd;
    public DICOLORSET dics;
    public nint lpUnkDDSTarget;
}
