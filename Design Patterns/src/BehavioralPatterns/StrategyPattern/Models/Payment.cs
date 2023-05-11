namespace StrategyPattern.Models;

public class Payment
{
    public string CardNumber { get; private set; }
    public string CardHolderName { get; private set; }
    public int ExpirationYear { get; private set; }
    public int ExpirationMonth { get; private set; }
    public string CVV { get; private set; }
    public decimal Amount { get; private set; }

    public Payment(string cardNumber, string cardHolderName, int expirationYear, int expirationMonth, string cVV, decimal amount)
    {
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
        ExpirationYear = expirationYear;
        ExpirationMonth = expirationMonth;
        CVV = cVV;
        Amount = amount;
    }
}
