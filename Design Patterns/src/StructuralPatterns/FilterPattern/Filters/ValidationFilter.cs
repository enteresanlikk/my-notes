using FilterPattern.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace FilterPattern.Filters;

public class ValidationFilter : IFilter
{
    public void Execute()
    {
        // Validation rules
        if (true)
        {
            Console.WriteLine($"{nameof(ValidationFilter)} passed.");
            return;
        }

        throw new ValidationException();
    }
}
