using FactoryPattern.Models;

namespace FactoryPattern.Abstractions;

public interface INotify
{
    void Send(User user);
}
