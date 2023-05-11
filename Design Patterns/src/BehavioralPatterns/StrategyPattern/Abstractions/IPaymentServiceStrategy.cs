using StrategyPattern.Models;

namespace StrategyPattern.Abstractions;

public interface IPaymentServiceStrategy
{
    bool Pay(Payment payment);
}
