using FactoryPattern.Abstractions;
using FactoryPattern.Models;

namespace FactoryPattern.Notifications;

public class EmailNotification : INotify
{
    public void Send(User user)
    {
        Console.WriteLine($"Email sent to {user}");
    }
}
