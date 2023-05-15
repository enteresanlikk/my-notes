using MementoPattern.Abstractions;
using MementoPattern.Caretakers;
using MementoPattern.Models;

namespace MementoPattern.Originators;

public class TextOriginator : IText, IOriginator
{
    public string Text { get; set; }
    public int CursorPosition { get; set; }

    private TextUndoCaretaker _textCaretaker = new();

    public void Save()
    {
        int cursorPosition = Text.Length;
        CursorPosition = cursorPosition;

        _textCaretaker.TextMemento = new TextMemento
        {
            CursorPosition = cursorPosition,
            Text = Text
        };
    }

    public void Undo()
    {
        TextMemento previousTextMemento = _textCaretaker.TextMemento;

        CursorPosition = previousTextMemento.CursorPosition;
        Text = previousTextMemento.Text;
    }

    public override string ToString()
    {
        return $"Text: {Text}, Cursor Position: {CursorPosition}";
    }
}
