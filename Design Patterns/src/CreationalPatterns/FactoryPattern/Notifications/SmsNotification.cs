using FactoryPattern.Abstractions;
using FactoryPattern.Models;

namespace FactoryPattern.Notifications;

public class SmsNotification : INotify
{
    public void Send(User user)
    {
        Console.WriteLine($"SMS sent to {user}");
    }
}
