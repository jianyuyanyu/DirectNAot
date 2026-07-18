#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDIENUMEFFECTSCALLBACKW(nint param0, nint param1);
