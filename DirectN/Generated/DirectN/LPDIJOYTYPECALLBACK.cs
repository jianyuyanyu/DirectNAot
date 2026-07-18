#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDIJOYTYPECALLBACK(PWSTR param0, nint param1);
