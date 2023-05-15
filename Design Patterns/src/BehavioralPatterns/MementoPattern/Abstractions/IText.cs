namespace MementoPattern.Abstractions;

public interface IText
{
    string Text { get; set; }
    int CursorPosition { get; set; }
}
