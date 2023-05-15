using FlyweightPattern.Enums;

namespace FlyweightPattern.Models;

public class BlackBox : Box
{
    public BlackBox(int width, int height) : base(width, height, BoxColors.Black)
    {
    }

    public override void Draw(Position position)
    {
        Console.WriteLine($"{BoxColor} box drawn. {position}");
    }
}
