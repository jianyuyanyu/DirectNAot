#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT HOOKPROC(int code, WPARAM wParam, LPARAM lParam);
