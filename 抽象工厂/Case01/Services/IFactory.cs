namespace Abstract_Factory.Services;

public interface IFactory
{
    IKeyboard GetKeyboard();

    IMouse GetMouse();
}