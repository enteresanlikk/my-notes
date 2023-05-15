using MementoPattern.Abstractions;

namespace MementoPattern.Models;

public class TextMemento : IText
{
    public string Text { get; set; }
    public int CursorPosition { get; set; }
}
