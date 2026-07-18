#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5944e682-c92e-11cf-bfc7-444553540000")]
public partial interface IDirectInputDevice2A : IDirectInputDeviceA
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEffect(in Guid param0, ref DIEFFECT param1, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectInputEffect>))] out IDirectInputEffect param2, nint param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumEffects(LPDIENUMEFFECTSCALLBACKA param0, nint param1, uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffectInfo(ref DIEFFECTINFOA param0, in Guid param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetForceFeedbackState(ref uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendForceFeedbackCommand(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumCreatedEffectObjects(LPDIENUMCREATEDEFFECTOBJECTSCALLBACK param0, nint param1, uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Escape(ref DIEFFESCAPE param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Poll();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendDeviceData(uint param0, ref DIDEVICEOBJECTDATA param1, ref uint param2, uint param3);
}
