using InterpreterPattern.Abstractions;
using InterpreterPattern.Enums;
using InterpreterPattern.Expressions;
using InterpreterPattern.Models;

namespace InterpreterPattern.Managers;

public class JobManager
{
    private List<IJobExpression> CreateExpressionTree(List<Formulas> formulas)
    {
        List<IJobExpression> tree = new List<IJobExpression>();

        foreach (Formulas role in formulas)
        {
            switch (role)
            {
                case Formulas.D:
                    tree.Add(new DeveloperExpression());
                    break;
                case Formulas.A:
                    tree.Add(new AccountingExpression());
                    break;
                case Formulas.T:
                    tree.Add(new TeamLeadExpression());
                    break;
                default:
                    throw new Exception($"Unexpected role: {role}!");
            }
        }
        return tree;
    }

    public void RunExpression(Context context)
    {
        foreach (IJobExpression expression in CreateExpressionTree(context.Formulas))
        {
            expression.Interpret(context);
        }
    }
}
