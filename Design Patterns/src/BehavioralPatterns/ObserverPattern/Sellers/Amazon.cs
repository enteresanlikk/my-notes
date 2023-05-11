using ObserverPattern.Abstractions;
using ObserverPattern.Models;

namespace ObserverPattern.Sellers;

public class Amazon
{
    private Dictionary<IObserver, Product> observers = new();

    public void Register(IObserver observer, Product product)
    {
        observers.TryAdd(observer, product);
    }

    public void UnRegister(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyAll()
    {
        foreach (var dic in observers)
        {
            dic.Key.Update(dic.Value);
        }
    }

    public void NotifyAllForProductName(string productName)
    {
        foreach (var dic in observers)
        {
            if (dic.Value.Name == productName)
            {
                dic.Key.Update(dic.Value);
            }
        }
    }
}
