#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5944e662-aa8a-11cf-bfc7-444553540000")]
public partial interface IDirectInput2A : IDirectInputA
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindDevice(in Guid param0, PSTR param1, ref Guid param2);
}
