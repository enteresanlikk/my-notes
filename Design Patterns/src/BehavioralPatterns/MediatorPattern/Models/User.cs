using MediatorPattern.Abstractions;

namespace MediatorPattern.Models;

public abstract class User : IMessage
{
    public int Id { get; set; }
    public string Name { get; set; }

    private IChatRoomMediator _chatRoomMediator;

    protected User(IChatRoomMediator chatRoomMediator, int id, string name)
    {
        Id = id;
        Name = name;
        _chatRoomMediator = chatRoomMediator;
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{Name} received new message. Message: {message}");
    }

    public void SendMessage(string message, int userId)
    {
        Console.WriteLine($"{Name} send new message to: {userId} user.");
        _chatRoomMediator.SendMessage(message, userId);
    }
}
