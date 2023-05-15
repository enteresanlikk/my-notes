using MediatorPattern.Abstractions;

namespace MediatorPattern.Models;

public class ChatUser : User
{
    public ChatUser(IChatRoomMediator chatRoomMediator, int id, string name) : base(chatRoomMediator, id, name)
    {

    }
}
