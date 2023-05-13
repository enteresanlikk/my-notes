namespace CommandPattern.Models;

public class StockManager
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public StockManager(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"[ Name: {Name}, Quantity: {Quantity} ]";
    }

    public void Buy()
    {
        Console.WriteLine($"{this} bought!");
    }

    public void Sell()
    {
        Console.WriteLine($"{this} sold!");
    }
}
