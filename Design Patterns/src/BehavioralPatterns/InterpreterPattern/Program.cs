using InterpreterPattern.Enums;
using InterpreterPattern.Managers;
using InterpreterPattern.Models;

List<Formulas> formulas = new()
{
    Formulas.D,
    Formulas.D,
    Formulas.A,
    Formulas.T
};

Context context = new(formulas, 0);

JobManager jobManager = new();
jobManager.RunExpression(context);

Console.WriteLine(context);

Console.ReadLine();