#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("bf798031-483a-4da2-aa99-5d64ed369700")]
public partial interface IDirectInput8W
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice(in Guid param0, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectInputDevice8W>))] out IDirectInputDevice8W param1, nint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumDevices(uint param0, LPDIENUMDEVICESCALLBACKW param1, nint param2, uint param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceStatus(in Guid param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RunControlPanel(HWND param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(HINSTANCE param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindDevice(in Guid param0, PWSTR param1, ref Guid param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumDevicesBySemantics(PWSTR param0, ref DIACTIONFORMATW param1, LPDIENUMDEVICESBYSEMANTICSCBW param2, nint param3, uint param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConfigureDevices(LPDICONFIGUREDEVICESCALLBACK param0, ref DICONFIGUREDEVICESPARAMSW param1, uint param2, nint param3);
}
