namespace Design_pattern.Services;

public class SendMessageClass : ISendMessage
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"发送{message}");
    }
}