using ObserverPattern.Models;

namespace ObserverPattern.Abstractions;

public interface IObserver
{
    string FullName { get; set; }

    void Update(Product product);
}
