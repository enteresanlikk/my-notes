namespace IteratorPattern.Abstractions;

public interface IIterator<T>
{
    bool HasNext();
    T GetCurrentItem();
}