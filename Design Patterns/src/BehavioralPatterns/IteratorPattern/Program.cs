using IteratorPattern.Aggregations;
using IteratorPattern.Models;

UserAggregate userAggregate = new();

User user1 = new(1, "Bilal", "Demir");
User user2 = new(2, "Demir", "Demir");
User user3 = new(3, "Ahmet", "Altun");

userAggregate.Add(user1);
userAggregate.Add(user2);
userAggregate.Add(user3);

var iterator = userAggregate.CreateIterator();

while (iterator.HasNext())
{
    User currentItem = iterator.GetCurrentItem();
    Console.WriteLine(currentItem);
}

Console.ReadLine();