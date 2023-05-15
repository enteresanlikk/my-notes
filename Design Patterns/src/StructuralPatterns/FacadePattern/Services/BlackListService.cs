using FacadePattern.Models;

namespace FacadePattern.Services;

public class BlackListService
{
    public bool CheckEmployeeIsTheBlackList(Customer customer)
    {
        bool result = customer.Id != 2;
        if (result)
        {
            Console.WriteLine($"{customer} in the blacklist!");
        }
        return result;
    }
}
