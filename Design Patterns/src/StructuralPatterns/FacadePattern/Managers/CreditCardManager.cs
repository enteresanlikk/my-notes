using FacadePattern.Models;

namespace FacadePattern.Managers;

public class CreditCardManager
{
    public void CreateCreditCart(Customer customer)
    {
        Console.WriteLine($"Credit cart created for {customer}");
    }
}
