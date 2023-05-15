using StatePattern.Abstractions;
using StatePattern.Models;

namespace StatePattern.States;

public class WaitingState : State
{
    public override void Handle(VendingMachine context)
    {
        Console.WriteLine($"{GetType().Name} is running...");
    }
}
