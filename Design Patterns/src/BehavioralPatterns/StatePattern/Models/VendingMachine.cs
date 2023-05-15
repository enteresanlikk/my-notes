using StatePattern.Abstractions;
using StatePattern.States;

namespace StatePattern.Models;

public class VendingMachine
{
    private State _state;

    public VendingMachine()
    {
        SetState(new InitializeState());
    }

    public void SetState(State state)
    {
        _state = state;
        _state.Handle(this);
    }

    public void RequestProduct(string productName, double price)
    {
        Console.WriteLine($"[Selected] Product: {productName} - Price: {price}");

        SetState(new PreparingState());
    }
}
