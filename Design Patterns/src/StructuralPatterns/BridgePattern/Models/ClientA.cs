using BridgePattern.Abstractions;

namespace BridgePattern.Models;

public class ClientA : IBridge
{
    public string Run()
    {
        return "ClientA";
    }
}
