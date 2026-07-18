#nullable enable
namespace DirectN;

public partial struct DIACTIONFORMATW
{
    public uint dwSize;
    public uint dwActionSize;
    public uint dwDataSize;
    public uint dwNumActions;
    public nint rgoAction;
    public Guid guidActionMap;
    public uint dwGenre;
    public uint dwBufferSize;
    public int lAxisMin;
    public int lAxisMax;
    public HINSTANCE hInstString;
    public FILETIME ftTimeStamp;
    public uint dwCRC;
    public InlineArraySystemChar_260 tszActionMap;
}
