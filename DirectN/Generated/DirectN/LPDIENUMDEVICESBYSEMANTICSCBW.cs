#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDIENUMDEVICESBYSEMANTICSCBW(nint param0, nint /* IDirectInputDevice8W */ param1, uint param2, uint param3, nint param4);
