using InterpreterPattern.Abstractions;
using InterpreterPattern.Enums;
using InterpreterPattern.Models;

namespace InterpreterPattern.Expressions;

public class AccountingExpression : IJobExpression
{
    public void Interpret(Context context)
    {
        if (context.Formulas.Contains(Formulas.A))
        {
            Console.WriteLine($"{nameof(AccountingExpression)} called");
            context.TotalPoint += 3000;
        }
    }
}
