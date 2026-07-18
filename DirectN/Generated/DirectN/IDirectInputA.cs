#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("89521360-aa8a-11cf-bfc7-444553540000")]
public partial interface IDirectInputA
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice(in Guid param0, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectInputDeviceA>))] out IDirectInputDeviceA param1, nint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumDevices(uint param0, LPDIENUMDEVICESCALLBACKA param1, nint param2, uint param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceStatus(in Guid param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RunControlPanel(HWND param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(HINSTANCE param0, uint param1);
}
