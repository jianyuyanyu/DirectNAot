namespace DirectN;

[GeneratedComInterface, Guid("ac6f5065-90c4-46ce-beb7-05e138e54117")]
public partial interface IInputCursorStaticsInterop : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFromHCursor(HCURSOR hcursor, out nint inputCursor);
}
