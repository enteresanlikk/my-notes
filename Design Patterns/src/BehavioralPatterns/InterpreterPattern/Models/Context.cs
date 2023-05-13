using InterpreterPattern.Enums;

namespace InterpreterPattern.Models;

public class Context
{
    public List<Formulas> Formulas { get; set; }
    public int TotalPoint { get; set; }

    public Context(List<Formulas> formulas, int totalPoint = 0)
    {
        Formulas = formulas;
        TotalPoint = totalPoint;
    }

    public override string ToString()
    {
        return $"{string.Join("", Formulas)}: {TotalPoint}";
    }
}
