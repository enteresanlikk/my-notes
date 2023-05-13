using InterpreterPattern.Models;

namespace InterpreterPattern.Abstractions;

public interface IJobExpression
{
    void Interpret(Context context);
}
