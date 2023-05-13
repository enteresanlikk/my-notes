using CommandPattern.Abstractions;
using CommandPattern.Models;

namespace CommandPattern.StockCommands;

public class SellStockCommand : IOrderCommand
{
    private StockManager _stockManager;

    public SellStockCommand(StockManager stockManager)
    {
        _stockManager = stockManager;
    }

    public void Execute()
    {
        _stockManager.Sell();
    }
}
