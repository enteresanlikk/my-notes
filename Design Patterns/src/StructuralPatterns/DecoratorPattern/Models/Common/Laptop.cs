namespace DecoratorPattern.Models.Common;

public class Laptop : Computer
{
    public void OpenLid()
    {
        Console.WriteLine($"{GetType().Name}'s lid is opening");
    }

    public void CloseLid()
    {
        Console.WriteLine($"{GetType().Name}'s lid is closing");
    }
}
