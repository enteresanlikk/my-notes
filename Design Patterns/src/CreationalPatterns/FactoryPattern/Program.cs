using FactoryPattern.Abstractions;
using FactoryPattern.Enums;
using FactoryPattern.Factories;
using FactoryPattern.Models;

NotificationFactory notificationFactory = new();
User user1 = new("Bilal", "Demir");
User user2 = new("Abc", "Def.");

INotify smsNotification = notificationFactory.CreateNotify(NotifyTypes.SMS);
INotify emailNotification = notificationFactory.CreateNotify(NotifyTypes.EMAIL);

smsNotification.Send(user1);

Task.Delay(2000).GetAwaiter().GetResult();

emailNotification.Send(user2);

Console.ReadLine();