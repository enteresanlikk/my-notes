using FilterPattern.Abstractions;

namespace FilterPattern.Services;

public class CustomerService : ITarget
{
    public void Handle()
    {
        Console.WriteLine($"{nameof(CustomerService)} successfully finished.");
    }
}
