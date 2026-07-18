#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dinputd/nn-dinputd-idirectinputeffectdriver
[GeneratedComInterface, Guid("02538130-898f-11d0-9ad0-00a0c9a06e35")]
public partial interface IDirectInputEffectDriver
{
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-deviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeviceID(uint param0, uint param1, uint param2, uint param3, nint param4);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-getversions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersions(ref DIDRIVERVERSIONS param0);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-escape
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Escape(uint param0, uint param1, ref DIEFFESCAPE param2);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-setgain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGain(uint param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-sendforcefeedbackcommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendForceFeedbackCommand(uint param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-getforcefeedbackstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetForceFeedbackState(uint param0, ref DIDEVICESTATE param1);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-downloadeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadEffect(uint param0, uint param1, ref uint param2, ref DIEFFECT param3, uint param4);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-destroyeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DestroyEffect(uint param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-starteffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartEffect(uint param0, uint param1, uint param2, uint param3);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-stopeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopEffect(uint param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/dinputd/nf-dinputd-idirectinputeffectdriver-geteffectstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffectStatus(uint param0, uint param1, ref uint param2);
}
