namespace Design_pattern.Services;

public class HangUp : IHangUp
{
    public void HangUpNumber(string phoneNumber)
    {
        Console.WriteLine($"挂断{phoneNumber}通话");
    }
}