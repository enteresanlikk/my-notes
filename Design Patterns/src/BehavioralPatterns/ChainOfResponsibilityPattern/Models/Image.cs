using ChainOfResponsibilityPattern.Enums;

namespace ChainOfResponsibilityPattern.Models;

public class Image
{
    public string Name { get; set; }
    public ImageExtensions Extension { get; set; }

    public Image(string name, ImageExtensions extension)
    {
        Name = name;
        Extension = extension;
    }
}
