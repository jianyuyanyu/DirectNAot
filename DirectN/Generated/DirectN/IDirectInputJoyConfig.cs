#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("1de12ab1-c9f5-11cf-bfc7-444553540000")]
public partial interface IDirectInputJoyConfig
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Acquire();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unacquire();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCooperativeLevel(HWND param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendNotify();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumTypes(LPDIJOYTYPECALLBACK param0, nint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeInfo(PWSTR param0, ref DIJOYTYPEINFO param1, uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTypeInfo(PWSTR param0, ref DIJOYTYPEINFO param1, uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteType(PWSTR param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConfig(uint param0, ref DIJOYCONFIG param1, uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConfig(uint param0, ref DIJOYCONFIG param1, uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteConfig(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserValues(ref DIJOYUSERVALUES param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUserValues(ref DIJOYUSERVALUES param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddNewHardware(HWND param0, in Guid param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenTypeKey(PWSTR param0, uint param1, ref HKEY param2);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig-openconfigkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenConfigKey(uint param0, uint param1, ref HKEY param2);
}
