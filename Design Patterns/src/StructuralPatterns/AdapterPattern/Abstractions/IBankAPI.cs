using AdapterPattern.Models;

namespace AdapterPattern.Abstractions;

public interface IBankAPI
{
    bool ExecuteTransaction(TransferTransaction transferTransaction);
}
