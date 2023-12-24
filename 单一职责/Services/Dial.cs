namespace Design_pattern.Services;

public class Dial:IDial
{
    public void DialNumber(string phoneNumber)
    {
        Console.WriteLine($"给{phoneNumber}拨打电话");
    }
}