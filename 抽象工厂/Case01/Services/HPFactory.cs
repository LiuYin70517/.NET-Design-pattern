namespace Abstract_Factory.Services;

public class HPFactory:IFactory
{
    public IKeyboard GetKeyboard()
    {
        return new HPKeyboard();
    }

    public IMouse GetMouse()
    {
        return new HPMouse();
    }
}