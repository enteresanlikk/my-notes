using ChainOfResponsibilityPattern.ImageHandlers.Common;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.ImageHandlers;

public class OtherHandler : BaseHandler
{
    public override void Execute(Image image)
    {
        Console.WriteLine("Other to PNG");
    }
}
