using MediatorPattern.Abstractions;
using MediatorPattern.Mediators;
using MediatorPattern.Models;

IChatRoomMediator chatRoom = new ChatRoomMediator();

User user1 = new ChatUser(chatRoom, 1, "Robert");
User user2 = new ChatUser(chatRoom, 2, "John");
User user3 = new ChatUser(chatRoom, 3, "Julie");
User user4 = new ChatUser(chatRoom, 4, "Lora");

chatRoom.AddUserInRoom(user1);
chatRoom.AddUserInRoom(user2);
chatRoom.AddUserInRoom(user3);
chatRoom.AddUserInRoom(user4);

user1.SendMessage("Hi", user2.Id);
Console.WriteLine("---------------");
user2.SendMessage("Hello", user1.Id);

Console.ReadLine();