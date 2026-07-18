#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDIENUMEFFECTSINFILECALLBACK(nint param0, nint param1);
