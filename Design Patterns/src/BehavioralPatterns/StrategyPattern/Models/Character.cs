using StrategyPattern.Abstractions;

namespace StrategyPattern.Models;

public class Character : ICharacter
{
    private ICombatStrategy _combatStrategy;

    public Character() { }

    public Character(ICombatStrategy combatStrategy)
    {
        _combatStrategy = combatStrategy;
    }

    public void SetCombatStrategy(ICombatStrategy combatStrategy)
    {
        _combatStrategy = combatStrategy;
    }

    public void ApplyStrategy()
    {
        _combatStrategy.Attack();
    }
}
