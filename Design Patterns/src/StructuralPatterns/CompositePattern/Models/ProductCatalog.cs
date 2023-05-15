using CompositePattern.Abstractions;

namespace CompositePattern.Models;

public class ProductCatalog : BaseModel, ICatalogComponent
{

    private List<ICatalogComponent> _components = new();

    public ProductCatalog(string name) : base(name)
    {

    }

    public void Add(ICatalogComponent catalogComponent)
    {
        _components.Add(catalogComponent);
    }

    public void Remove(ICatalogComponent catalogComponent)
    {
        _components.Remove(catalogComponent);
    }

    public void DrawHierarchy()
    {
        Console.WriteLine(Name);
        foreach (ICatalogComponent component in _components)
        {
            component.DrawHierarchy();
        }
    }
}
