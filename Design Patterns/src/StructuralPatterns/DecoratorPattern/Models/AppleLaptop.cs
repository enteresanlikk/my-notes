using DecoratorPattern.Decorators;
using System.Diagnostics;

namespace DecoratorPattern.Models;

public class AppleLaptop : LaptopDecorator
{
    public override void OpenLid()
    {
        Console.WriteLine($"{GetType().Name} is waking up");
        base.OpenLid();
    }
    
    public override void CloseLid()
    {
        base.CloseLid();
        Debug.WriteLine($"{GetType().Name} is sleeping");
    }
}
