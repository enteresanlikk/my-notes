using InterpreterPattern.Abstractions;
using InterpreterPattern.Enums;
using InterpreterPattern.Models;

namespace InterpreterPattern.Expressions;

public class DeveloperExpression : IJobExpression
{
    public void Interpret(Context context)
    {
        if (context.Formulas.Contains(Formulas.D))
        {
            Console.WriteLine($"{nameof(DeveloperExpression)} called");
            context.TotalPoint += 4000;
        }
    }
}
