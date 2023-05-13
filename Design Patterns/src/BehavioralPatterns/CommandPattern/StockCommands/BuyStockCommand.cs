using CommandPattern.Abstractions;
using CommandPattern.Models;

namespace CommandPattern.StockCommands;

public class BuyStockCommand : IOrderCommand
{
    private StockManager _stockManager;

    public BuyStockCommand(StockManager stockManager)
    {
        _stockManager = stockManager;
    }

    public void Execute()
    {
        _stockManager.Buy();
    }
}
