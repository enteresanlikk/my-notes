using AdapterPattern.Abstractions;
using AdapterPattern.Models;

namespace AdapterPattern.APIs;

public class XMLBankAPI : IBankAPI
{
    public bool ExecuteTransaction(TransferTransaction transferTransaction)
    {
        string xml = $"""
                    <TransferTransaction>
                            <From>{transferTransaction.From}</From>
                            <To>{transferTransaction.To}</To>
                            <Amount>{transferTransaction.Amount:C2}</Amount>
                        </TransferTransaction>
                    """;

        Console.WriteLine($"{GetType().Name} worked.");

        return true;
    }
}
