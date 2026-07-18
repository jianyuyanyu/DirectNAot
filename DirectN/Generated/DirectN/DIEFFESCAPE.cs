#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinput/ns-dinput-dieffescape
public partial struct DIEFFESCAPE
{
    public uint dwSize;
    public uint dwCommand;
    public nint lpvInBuffer;
    public uint cbInBuffer;
    public nint lpvOutBuffer;
    public uint cbOutBuffer;
}
