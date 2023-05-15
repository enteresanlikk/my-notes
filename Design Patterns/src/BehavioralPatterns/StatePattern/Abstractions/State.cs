using StatePattern.Models;

namespace StatePattern.Abstractions;

public abstract class State
{
    public abstract void Handle(VendingMachine context);
}
