namespace Abstract_Factory.Services;

public class DellFactory:IFactory
{
    public IKeyboard GetKeyboard()
    {
        return new DellKeyboard();
    }

    public IMouse GetMouse()
    {
        return new DellMouse();
    }
}