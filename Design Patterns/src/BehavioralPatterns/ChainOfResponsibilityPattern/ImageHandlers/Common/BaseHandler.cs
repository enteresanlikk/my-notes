using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.ImageHandlers.Common;

public abstract class BaseHandler
{
    protected BaseHandler _nextHandler;
    public void SetNextHandler(BaseHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public abstract void Execute(Image image);
}
