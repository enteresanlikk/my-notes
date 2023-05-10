using AdapterPattern.Adapters;
using AdapterPattern.Models;

TransferTransaction transaction = new("1", "2", 150);

JSONBankAdapter adapter = new();
bool status = adapter.ExecuteTransaction(transaction);

Console.WriteLine($"Transaction status: {status}");

XMLBankAdapter adapter2 = new();
bool status2 = adapter2.ExecuteTransaction(transaction);

Console.WriteLine($"Transaction status: {status2}");

Console.ReadLine();