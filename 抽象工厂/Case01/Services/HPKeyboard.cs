namespace Abstract_Factory.Services;

public class HPKeyboard:IKeyboard
{
    public void ShowKeyboardBrand()
    {
        Console.WriteLine("我是惠普品牌的键盘");
    }
}