namespace Simple_Factory_Design_Pattern.Services;

public class Factory
{
    public static ICalculator GetCalculator(string oper)
    {
        ICalculator calculator = oper switch
        {
            "+" => new Add(),
            "-" => new Sub(),
            "*" => new Mul(),
            "/" => new Div()
        };
        return calculator;

    }
    
        
    
}