using StrategyPattern.Abstractions;

namespace StrategyPattern.CombatStrategies;

public class AggressiveCombatStrategy : ICombatStrategy
{
    public void Attack()
    {
        Console.WriteLine($"{GetType().Name}");
    }
}
