using StrategyPattern.Abstractions;
using StrategyPattern.Models;

namespace StrategyPattern.PaymentServices;

public class HalkbankPaymentService : IPaymentServiceStrategy
{
    public bool Pay(Payment payment)
    {
        Console.WriteLine($"{GetType().Name} called.");
        return true;
    }
}
