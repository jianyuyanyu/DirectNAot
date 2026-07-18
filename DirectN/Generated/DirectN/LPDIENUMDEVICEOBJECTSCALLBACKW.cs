#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDIENUMDEVICEOBJECTSCALLBACKW(nint param0, nint param1);
