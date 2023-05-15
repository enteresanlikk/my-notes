using FlyweightPattern.Enums;

namespace FlyweightPattern.Models;

public class BlueBox : Box
{
    public BlueBox(int width, int height) : base(width, height, BoxColors.Blue)
    {
    }

    public override void Draw(Position position)
    {
        Console.WriteLine($"{BoxColor} box drawn. {position}");
    }
}
