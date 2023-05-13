using ChainOfResponsibilityPattern.Enums;
using ChainOfResponsibilityPattern.ImageHandlers;
using ChainOfResponsibilityPattern.Models;

Image image = new("converted-image", ImageExtensions.JPG);

JpegHandler jpegHandler = new();
JpgHandler jpgHandler = new();
OtherHandler otherHandler = new();

jpegHandler.SetNextHandler(jpgHandler);
jpgHandler.SetNextHandler(otherHandler);

jpegHandler.Execute(image);

Console.ReadLine();