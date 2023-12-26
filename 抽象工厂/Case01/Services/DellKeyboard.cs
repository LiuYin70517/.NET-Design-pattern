namespace Abstract_Factory.Services;

public class DellKeyboard:IKeyboard
{
    public void ShowKeyboardBrand()
    {
        Console.WriteLine("我是戴尔品牌的键盘");
    }
}