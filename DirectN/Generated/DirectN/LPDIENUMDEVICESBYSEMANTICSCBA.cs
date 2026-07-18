#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDIENUMDEVICESBYSEMANTICSCBA(nint param0, nint /* IDirectInputDevice8A */ param1, uint param2, uint param3, nint param4);
