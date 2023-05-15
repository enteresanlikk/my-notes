namespace CompositePattern.Models;

public class BaseModel
{
    public string Name { get; set; }
    public BaseModel(string name)
    {
        Name = name;
    }
}
