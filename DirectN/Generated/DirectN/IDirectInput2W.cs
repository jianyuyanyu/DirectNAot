#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5944e663-aa8a-11cf-bfc7-444553540000")]
public partial interface IDirectInput2W : IDirectInputW
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindDevice(in Guid param0, PWSTR param1, ref Guid param2);
}
