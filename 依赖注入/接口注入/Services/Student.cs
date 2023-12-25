namespace Dependency_Injection.Services;

public class Student:IDriver
{
    public void Driver(ICar car)
    {
         car.Run();
    }
}