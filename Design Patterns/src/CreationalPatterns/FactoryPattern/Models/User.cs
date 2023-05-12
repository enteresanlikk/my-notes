namespace FactoryPattern.Models;

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public User(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public override string ToString()
    {
        return $"{Name} {Surname.ToUpperInvariant()}";
    }
}
