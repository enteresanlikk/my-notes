using MediatorPattern.Abstractions;
using MediatorPattern.Models;

namespace MediatorPattern.Mediators;

public class ChatRoomMediator : IChatRoomMediator
{
    private Dictionary<int, User> _chatRoom = new();

    public void AddUserInRoom(User user)
    {
        _chatRoom.Add(user.Id, user);
    }

    public void SendMessage(string message, int userId)
    {
        User user = _chatRoom[userId];
        user.ReceiveMessage(message);
    }
}
