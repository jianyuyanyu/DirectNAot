#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/nn-dinputd-idirectinputjoyconfig8
[GeneratedComInterface, Guid("eb0d7dfa-1990-4f27-b4d6-edf2eec4a44c")]
public partial interface IDirectInputJoyConfig8
{
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-acquire
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Acquire();
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-unacquire
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unacquire();
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-setcooperativelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCooperativeLevel(HWND param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-sendnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendNotify();
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-enumtypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumTypes(LPDIJOYTYPECALLBACK param0, nint param1);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-gettypeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeInfo(PWSTR param0, ref DIJOYTYPEINFO param1, uint param2);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-settypeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTypeInfo(PWSTR param0, ref DIJOYTYPEINFO param1, uint param2, PWSTR param3);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-deletetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteType(PWSTR param0);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-getconfig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConfig(uint param0, ref DIJOYCONFIG param1, uint param2);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-setconfig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConfig(uint param0, ref DIJOYCONFIG param1, uint param2);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-deleteconfig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteConfig(uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-getuservalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserValues(ref DIJOYUSERVALUES param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-setuservalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUserValues(ref DIJOYUSERVALUES param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-addnewhardware
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddNewHardware(HWND param0, in Guid param1);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-opentypekey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenTypeKey(PWSTR param0, uint param1, ref HKEY param2);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputjoyconfig8-openappstatuskey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenAppStatusKey(ref HKEY param0);
}
