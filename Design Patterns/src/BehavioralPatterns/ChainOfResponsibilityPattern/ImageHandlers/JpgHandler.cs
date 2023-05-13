using ChainOfResponsibilityPattern.Enums;
using ChainOfResponsibilityPattern.ImageHandlers.Common;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.ImageHandlers;

public class JpgHandler : BaseHandler
{
    public override void Execute(Image image)
    {
        if (image.Extension == ImageExtensions.JPG)
        {
            Console.WriteLine("JPG to PNG");
            return;
        }

        _nextHandler.Execute(image);
    }
}
