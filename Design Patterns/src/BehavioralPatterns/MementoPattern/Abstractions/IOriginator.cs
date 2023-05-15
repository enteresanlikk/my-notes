namespace MementoPattern.Abstractions;

public interface IOriginator
{
    void Save();
    void Undo();
}
