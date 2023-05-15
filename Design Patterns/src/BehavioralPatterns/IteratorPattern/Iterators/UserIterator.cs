using IteratorPattern.Abstractions;
using IteratorPattern.Aggregations;
using IteratorPattern.Models;

namespace IteratorPattern.Iterators;

public class UserIterator : IIterator<User>
{
    private UserAggregate _userAggregate;
    private int _currentIndex;

    public UserIterator(UserAggregate userAggregate)
    {
        _userAggregate = userAggregate;
        _currentIndex = 0;
    }

    public User GetCurrentItem() => _userAggregate.Get(_currentIndex++);

    public bool HasNext() => _userAggregate.Count > _currentIndex;
}
