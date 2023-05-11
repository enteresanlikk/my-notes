using StrategyPattern.Models;
using StrategyPattern.PaymentServices;

namespace StrategyPattern.Abstractions;

public interface IPaymentService
{
    void SetPaymentService(IPaymentServiceStrategy paymentServiceStrategy);

    bool Pay(Payment payment);
}
