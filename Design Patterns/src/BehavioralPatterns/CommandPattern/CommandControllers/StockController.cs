using CommandPattern.Abstractions;

namespace CommandPattern.CommandControllers;

public class StockController
{
    private List<IOrderCommand> _orderCommands;

    public StockController()
    {
        _orderCommands = new List<IOrderCommand>();
    }

    public void TakeOrder(IOrderCommand command)
    {
        _orderCommands.Add(command);
    }

    public void PlaceOrders()
    {
        foreach (IOrderCommand command in _orderCommands)
        {
            command.Execute();
        }

        _orderCommands.Clear();
    }
}
