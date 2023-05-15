using IteratorPattern.Models;

namespace IteratorPattern.Abstractions;

public interface IUserAggregate
{
    IIterator<User> CreateIterator();
}
