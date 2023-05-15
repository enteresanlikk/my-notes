using IteratorPattern.Abstractions;
using IteratorPattern.Iterators;
using IteratorPattern.Models;

namespace IteratorPattern.Aggregations;

public class UserAggregate : IUserAggregate
{
    private List<User> _users = new();

    public void Add(User user)
    {
        _users.Add(user);
    }

    public int Count => _users.Count;

    public User Get(int index) => _users[index];

    public IIterator<User> CreateIterator()
    {
        return new UserIterator(this);
    }
}
