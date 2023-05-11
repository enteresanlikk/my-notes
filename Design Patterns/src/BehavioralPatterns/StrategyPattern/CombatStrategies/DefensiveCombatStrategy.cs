using StrategyPattern.Abstractions;

namespace StrategyPattern.CombatStrategies;

public class DefensiveCombatStrategy : ICombatStrategy
{
    public void Attack()
    {
        Console.WriteLine($"{GetType().Name}");
    }
}