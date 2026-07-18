#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOLEAN PHIDP_INSERT_SCANCODES(nint /* optional void* */ Context, PSTR NewScanCodes, uint Length);
