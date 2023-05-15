using StatePattern.Abstractions;
using StatePattern.Models;

namespace StatePattern.States;

public class PreparingState : State
{
    public override void Handle(VendingMachine context)
    {
        Console.WriteLine($"{GetType().Name} is running...");

        context.SetState(new DeliveryState());
    }
}
