using FilterPattern.Abstractions;

namespace FilterPattern.Services;

public class EmployeeService : ITarget
{
    public void Handle()
    {
        Console.WriteLine($"{nameof(EmployeeService)} successfully finished.");
    }
}
