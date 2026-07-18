#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9a4cb685-236d-11d3-8e9d-00c04f6844ae")]
public partial interface IDirectInput7W : IDirectInput2W
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeviceEx(in Guid param0, in Guid param1, out nint param2, nint param3);
}
