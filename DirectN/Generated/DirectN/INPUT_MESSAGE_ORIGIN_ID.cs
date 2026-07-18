#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ne-winuser-input_message_origin_id
public enum INPUT_MESSAGE_ORIGIN_ID
{
    IMO_UNAVAILABLE = 0,
    IMO_HARDWARE = 1,
    IMO_INJECTED = 2,
    IMO_SYSTEM = 4,
}
