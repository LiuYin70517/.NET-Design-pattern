namespace Simple_Factory_Design_Pattern.Services;

public class Mul:ICalculator
{
    public double GetResult(double d1, double d2)
    {
        return d1 * d2;
    }
}