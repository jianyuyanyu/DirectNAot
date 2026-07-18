#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate NTSTATUS PFN_HidP_GetVersionInternal(nint Version);
