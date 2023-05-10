using AdapterPattern.Abstractions;
using AdapterPattern.APIs;
using AdapterPattern.Models;

namespace AdapterPattern.Adapters;

public class JSONBankAdapter : IBankAPI
{
    private JSONBankAPI _jsonBankAPI;

    public JSONBankAdapter()
    {
        _jsonBankAPI = new();
    }

    public bool ExecuteTransaction(TransferTransaction transferTransaction)
    {
        return _jsonBankAPI.ExecuteTransaction(transferTransaction);
    }
}
