namespace Design_pattern.Services;

public class ReceiveMessageClass : IReceiveMessage
{
    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"接收{message}");
    }
}