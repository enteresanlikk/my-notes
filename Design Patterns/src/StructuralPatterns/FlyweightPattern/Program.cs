using FlyweightPattern.Enums;
using FlyweightPattern.Factories;
using FlyweightPattern.Models;

BoxFactory boxFactory = new();

Box blackBox1 = boxFactory.Get(BoxColors.Black);
Box blackBox2 = boxFactory.Get(BoxColors.Black);
Box blackBox3 = boxFactory.Get(BoxColors.Black);
Box blueBox1 = boxFactory.Get(BoxColors.Blue);

blackBox1.Draw(new(97, 37));
blackBox2.Draw(new(34, 78));
blackBox3.Draw(new(74, 193));
blueBox1.Draw(new(1, 4));

Console.ReadLine();