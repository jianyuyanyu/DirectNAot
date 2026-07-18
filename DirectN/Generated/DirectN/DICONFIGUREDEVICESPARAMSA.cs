#nullable enable
namespace DirectN;

public partial struct DICONFIGUREDEVICESPARAMSA
{
    public uint dwSize;
    public uint dwcUsers;
    public PSTR lptszUserNames;
    public uint dwcFormats;
    public nint lprgFormats;
    public HWND hwnd;
    public DICOLORSET dics;
    public nint lpUnkDDSTarget;
}
