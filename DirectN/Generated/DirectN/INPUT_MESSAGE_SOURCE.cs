#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-input_message_source
public partial struct INPUT_MESSAGE_SOURCE
{
    public INPUT_MESSAGE_DEVICE_TYPE deviceType;
    public INPUT_MESSAGE_ORIGIN_ID originId;
}
