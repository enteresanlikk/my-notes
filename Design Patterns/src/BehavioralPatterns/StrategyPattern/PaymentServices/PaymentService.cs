using StrategyPattern.Abstractions;
using StrategyPattern.Models;

namespace StrategyPattern.PaymentServices;

public class PaymentService : IPaymentService
{
    private IPaymentServiceStrategy _paymentServiceStrategy;

    public PaymentService()
    {
    }

    public PaymentService(IPaymentServiceStrategy paymentServiceStrategy)
    {
        _paymentServiceStrategy = paymentServiceStrategy;
    }

    public void SetPaymentService(IPaymentServiceStrategy paymentServiceStrategy)
    {
        _paymentServiceStrategy = paymentServiceStrategy;
    }

    public bool Pay(Payment payment)
    {
        return _paymentServiceStrategy.Pay(payment);
    }
}
