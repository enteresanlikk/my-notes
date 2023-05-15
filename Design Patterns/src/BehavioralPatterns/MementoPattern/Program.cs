using MementoPattern.Originators;

TextOriginator textOriginator = new();

Console.WriteLine("----- SAVE -----");

textOriginator.Text = "bi";
textOriginator.Save();
Console.WriteLine(textOriginator.ToString());

textOriginator.Text += "la";
textOriginator.Save();
Console.WriteLine(textOriginator.ToString());

textOriginator.Text += "l demir";
textOriginator.Save();
Console.WriteLine(textOriginator.ToString());

Console.WriteLine("----- UNDO -----");

textOriginator.Undo();
Console.WriteLine(textOriginator.ToString());

textOriginator.Undo();
Console.WriteLine(textOriginator.ToString());

textOriginator.Undo();
Console.WriteLine(textOriginator.ToString());

Console.ReadLine();