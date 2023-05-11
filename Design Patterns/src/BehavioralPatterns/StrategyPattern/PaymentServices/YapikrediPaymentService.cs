using StrategyPattern.Abstractions;
using StrategyPattern.Models;

namespace StrategyPattern.PaymentServices;

public class YapikrediPaymentService : IPaymentServiceStrategy
{
    public bool Pay(Payment payment)
    {
        Console.WriteLine($"{GetType().Name} called.");
        return true;
    }
}
