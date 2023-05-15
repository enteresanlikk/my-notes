using FlyweightPattern.Enums;
using FlyweightPattern.Models;

namespace FlyweightPattern.Factories;

public class BoxFactory
{
    private Dictionary<BoxColors, Box> _boxes = new();

    public Box Get(BoxColors boxColor)
    {
        if (_boxes.ContainsKey(boxColor))
        {
            return _boxes[boxColor];
        }

        Box box = null;

        if (boxColor == BoxColors.Black)
        {
            box = new BlackBox(20, 20);
        }
        else if (boxColor == BoxColors.Blue)
        {
            box = new BlueBox(20, 20);
        }

        _boxes.Add(boxColor, box);
        return box;
    }
}
