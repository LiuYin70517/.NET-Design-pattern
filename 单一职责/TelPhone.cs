using Design_pattern.Services;

namespace Design_pattern;

public class TelPhone
{
    private readonly IDial _dial;

    private readonly IHangUp _hangUp;

    private readonly ISendMessage _sendMessage;

    private readonly IReceiveMessage _receiveMessage;


    public TelPhone(IDial dial, IHangUp hangUp, ISendMessage sendMessage, IReceiveMessage receiveMessage)
    {
        _dial = dial;
        _hangUp = hangUp;
        _sendMessage = sendMessage;
        _receiveMessage = receiveMessage;
    }


    public void DialPhoneNumber(string phoneNumber)
    {
        _dial.DialNumber(phoneNumber);
    }

    public void HangUpNumber(string phoneNumber)
    {
        _hangUp.HangUpNumber(phoneNumber);
    }

    public void SendMessage(string message)
    {
        _sendMessage.SendMessage(message);
    }

    public void ReceiveMessage(string message)
    {
        _receiveMessage.ReceiveMessage(message);
    }
}