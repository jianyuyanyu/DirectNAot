#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("57d7c6bd-2356-11d3-8e9d-00c04f6844ae")]
public partial interface IDirectInputDevice7W : IDirectInputDevice2W
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumEffectsInFile(PWSTR param0, LPDIENUMEFFECTSINFILECALLBACK param1, nint param2, uint param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteEffectToFile(PWSTR param0, uint param1, ref DIFILEEFFECT param2, uint param3);
}
