using AdapterPattern.Abstractions;
using AdapterPattern.Models;

namespace AdapterPattern.APIs;

public class JSONBankAPI : IBankAPI
{
    public bool ExecuteTransaction(TransferTransaction transferTransaction)
    {
        string json = $$""""
                    {
                            ""From"": ""{{transferTransaction.From}}"",
                            ""To"": ""{{transferTransaction.To}}"",
                            ""Amount"": ""{{transferTransaction.Amount:C2}}""
                        }
                    """";

        Console.WriteLine($"{GetType().Name} worked.");

        return true;
    }
}
