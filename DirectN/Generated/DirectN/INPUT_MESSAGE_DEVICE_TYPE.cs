#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ne-winuser-input_message_device_type
public enum INPUT_MESSAGE_DEVICE_TYPE
{
    IMDT_UNAVAILABLE = 0,
    IMDT_KEYBOARD = 1,
    IMDT_MOUSE = 2,
    IMDT_TOUCH = 4,
    IMDT_PEN = 8,
    IMDT_TOUCHPAD = 16,
}
