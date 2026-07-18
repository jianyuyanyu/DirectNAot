#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDIENUMCREATEDEFFECTOBJECTSCALLBACK(nint /* IDirectInputEffect */ param0, nint param1);
