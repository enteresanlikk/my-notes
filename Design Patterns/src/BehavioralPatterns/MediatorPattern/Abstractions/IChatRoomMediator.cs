using MediatorPattern.Models;

namespace MediatorPattern.Abstractions;

public interface IChatRoomMediator
{
    void SendMessage(string message, int userId);
    void AddUserInRoom(User user);
}
