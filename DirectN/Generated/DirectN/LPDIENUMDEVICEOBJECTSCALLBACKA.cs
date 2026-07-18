#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDIENUMDEVICEOBJECTSCALLBACKA(nint param0, nint param1);
