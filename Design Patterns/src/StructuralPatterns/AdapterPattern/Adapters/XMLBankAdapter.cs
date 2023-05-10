using AdapterPattern.Abstractions;
using AdapterPattern.APIs;
using AdapterPattern.Models;

namespace AdapterPattern.Adapters;

public class XMLBankAdapter : IBankAPI
{
    private XMLBankAPI _xmlBankAPI;

    public XMLBankAdapter()
    {
        _xmlBankAPI = new();
    }

    public bool ExecuteTransaction(TransferTransaction transferTransaction)
    {
        return _xmlBankAPI.ExecuteTransaction(transferTransaction);
    }
}
