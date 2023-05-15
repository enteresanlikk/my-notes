using FacadePattern.Managers;
using FacadePattern.Models;
using FacadePattern.Services;

namespace FacadePattern.Facades;

public class CreditCardFacade
{
    public void CreateCreditCart(Customer customer)
    {
        CreditCardManager creditCardManager = new();
        BlackListService blackListService = new();

        if (!blackListService.CheckEmployeeIsTheBlackList(customer))
        {
            creditCardManager.CreateCreditCart(customer);
        }
    }
}
