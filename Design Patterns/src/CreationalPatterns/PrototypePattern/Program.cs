using PrototypePattern.Models;

User user = new(1, "Bilal", "Demir", 24);
User user2 = (User)user.Clone();

string message = "Users are not equal";
if (user.Equals(user2))
{
    message = "Users are equal";
}
Console.WriteLine(message);

Console.ReadLine();