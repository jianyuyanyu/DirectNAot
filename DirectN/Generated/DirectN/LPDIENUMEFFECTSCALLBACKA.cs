#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDIENUMEFFECTSCALLBACKA(nint param0, nint param1);
