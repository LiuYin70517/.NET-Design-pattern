namespace Abstract_Factory.Services;

public class LenovoKeyboard:IKeyboard
{
    public void ShowKeyboardBrand()
    {
        Console.WriteLine("我是联想品牌的键盘");
    }
}