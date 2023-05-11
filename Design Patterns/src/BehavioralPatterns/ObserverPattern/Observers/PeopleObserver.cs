using ObserverPattern.Abstractions;
using ObserverPattern.Models;

namespace ObserverPattern.Observers;

public class PeopleObserver : IObserver
{
    public string FullName { get; set; }

    public PeopleObserver(string fullName)
    {
        FullName = fullName;
    }

    public void Update(Product product)
    {
        //email, notification etc.
        Console.WriteLine($"{FullName} People, {product.Name} is available now.");
    }
}
