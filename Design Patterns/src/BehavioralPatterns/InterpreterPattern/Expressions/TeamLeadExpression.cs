using InterpreterPattern.Abstractions;
using InterpreterPattern.Enums;
using InterpreterPattern.Models;

namespace InterpreterPattern.Expressions;

public class TeamLeadExpression : IJobExpression
{
    public void Interpret(Context context)
    {
        if (context.Formulas.Contains(Formulas.T))
        {
            Console.WriteLine($"{nameof(TeamLeadExpression)} called");
            context.TotalPoint += 7000;
        }
    }
}
