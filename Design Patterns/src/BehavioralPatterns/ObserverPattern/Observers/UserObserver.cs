using ObserverPattern.Abstractions;
using ObserverPattern.Models;

namespace ObserverPattern.Observers;

public class UserObserver : IObserver
{
    public string FullName { get; set; }

    public UserObserver(string fullName)
    {
        FullName = fullName;
    }

    public void Update(Product product)
    {
        //email, notification etc.
        Console.WriteLine($"Dear {FullName}, {product.Name} is available now.");
    }
}
