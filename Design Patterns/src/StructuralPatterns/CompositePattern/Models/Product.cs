using CompositePattern.Abstractions;

namespace CompositePattern.Models;

public class Product : BaseModel, ICatalogComponent
{

    public Product(string name) : base(name)
    {
    }

    public void DrawHierarchy()
    {
        Console.WriteLine(Name);
    }
}
