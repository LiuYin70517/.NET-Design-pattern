namespace Abstract_Factory.Services;

public class LenovoFactory:IFactory
{
    public IKeyboard GetKeyboard()
    {
        return new LenovoKeyboard();
    }

    public IMouse GetMouse()
    {
        return new LenovoMouse();
    }
}