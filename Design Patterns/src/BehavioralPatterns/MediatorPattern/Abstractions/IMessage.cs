namespace MediatorPattern.Abstractions;

public interface IMessage
{
    void ReceiveMessage(string message);
    void SendMessage(string message, int userId);
}
