using MementoPattern.Models;

namespace MementoPattern.Caretakers;

public class TextUndoCaretaker
{
    private Stack<TextMemento> _mementos;

    public TextUndoCaretaker()
    {
        _mementos = new Stack<TextMemento>();
    }

    public TextMemento TextMemento
    {
        get
        {
            return _mementos.Pop();
        }
        set
        {
            _mementos.Push(value);
        }
    }
}
