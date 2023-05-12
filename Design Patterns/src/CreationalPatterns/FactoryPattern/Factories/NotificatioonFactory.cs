using FactoryPattern.Abstractions;
using FactoryPattern.Enums;
using FactoryPattern.Notifications;

namespace FactoryPattern.Factories;

public class NotificationFactory
{
    public INotify CreateNotify(NotifyTypes notifyType)
    {
        if (notifyType == NotifyTypes.SMS)
        {
            return new SmsNotification();
        }
        else if (notifyType == NotifyTypes.EMAIL)
        {
            return new EmailNotification();
        }

        throw new NotImplementedException("Notify type is not implemented yet.");
    }
}
