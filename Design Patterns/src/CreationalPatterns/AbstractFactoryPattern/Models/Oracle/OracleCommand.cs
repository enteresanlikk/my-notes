using AbstractFactoryPattern.Models.Common;

namespace AbstractFactoryPattern.Models.Oracle;

public class OracleCommand : Command
{
    public override void ExecuteCommand(string query)
    {
        Console.WriteLine($"{query} run with {GetType().Name}.");
    }
}
