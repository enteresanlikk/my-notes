using DecoratorPattern.Models.Common;

namespace DecoratorPattern.Decorators;

public class LaptopDecorator : Laptop
{
    public virtual void OpenLid()
    {
        Console.WriteLine($"{GetType().Name} open lid before");

        base.OpenLid();

        Console.WriteLine($"{GetType().Name} open lid after");
    }

    public virtual void CloseLid()
    {
        Console.WriteLine($"{GetType().Name} close lid before");

        base.CloseLid();

        Console.WriteLine($"{GetType().Name} close lid after");
    }
}
