using FlyweightPattern.Enums;

namespace FlyweightPattern.Models;

public abstract class Box
{
    public int Width { get; set; }
    public int Height { get; set; }
    public BoxColors BoxColor { get; set; }

    public Box(int width, int height, BoxColors boxColor)
    {
        Width = width;
        Height = height;
        BoxColor = boxColor;
    }

    public abstract void Draw(Position position);
}
