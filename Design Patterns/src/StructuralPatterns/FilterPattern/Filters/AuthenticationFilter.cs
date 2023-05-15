using FilterPattern.Abstractions;
using System.Security.Authentication;

namespace FilterPattern.Filters;

public class AuthenticationFilter : IFilter
{
    public void Execute()
    {
        // Validation rules
        if (true)
        {
            Console.WriteLine($"{nameof(AuthenticationFilter)} passed.");
            return;
        }

        throw new AuthenticationException();
    }
}
