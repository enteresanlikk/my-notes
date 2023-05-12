using BridgePattern.Abstractions;

namespace BridgePattern.Models;

public class ClientB : IBridge
{
    public string Run()
    {
        return "ClientA";
    }
}
