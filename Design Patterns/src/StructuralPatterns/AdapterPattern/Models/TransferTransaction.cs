namespace AdapterPattern.Models;

public class TransferTransaction
{
    public string From { get; private set; }
    public string To { get; private set; }
    public decimal Amount { get; private set; }

    public TransferTransaction(string from, string to, decimal amount)
    {
        From = from;
        To = to;
        Amount = amount;
    }
}