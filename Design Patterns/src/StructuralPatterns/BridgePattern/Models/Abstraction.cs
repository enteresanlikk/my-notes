using BridgePattern.Abstractions;

namespace BridgePattern.Models;

public class Abstraction
{
    private readonly IBridge _bridge;

    public Abstraction(IBridge bridge)
    {
        _bridge = bridge;
    }

    public string Run()
    {
        string result = _bridge.Run();

        Console.WriteLine($"Abstraction: {result}");

        return result;
    }
}
