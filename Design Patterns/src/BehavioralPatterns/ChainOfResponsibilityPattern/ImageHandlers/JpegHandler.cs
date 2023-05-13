using ChainOfResponsibilityPattern.Enums;
using ChainOfResponsibilityPattern.ImageHandlers.Common;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.ImageHandlers;

public class JpegHandler : BaseHandler
{
    public override void Execute(Image image)
    {
        if (image.Extension == ImageExtensions.JPEG)
        {
            Console.WriteLine("JPEG to PNG");
            return;
        }

        _nextHandler.Execute(image);
    }
}
