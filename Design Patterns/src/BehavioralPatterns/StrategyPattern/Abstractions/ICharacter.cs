namespace StrategyPattern.Abstractions;

public interface ICharacter
{
    void SetCombatStrategy(ICombatStrategy combatStrategy);

    void ApplyStrategy();
}
