using AbstractFactoryPattern.Models.Common;

namespace AbstractFactoryPattern.Models.MySQL;

public class MySQLCommand : Command
{
    public override void ExecuteCommand(string query)
    {
        Console.WriteLine($"{query} run with {GetType().Name}.");
    }
}
