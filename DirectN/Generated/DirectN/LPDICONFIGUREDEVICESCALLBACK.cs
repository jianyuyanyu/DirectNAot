#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDICONFIGUREDEVICESCALLBACK(nint /* nint */ param0, nint param1);
