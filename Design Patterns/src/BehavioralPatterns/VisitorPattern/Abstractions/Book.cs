namespace VisitorPattern.Abstractions;

public abstract class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public string CategoryName { get; set; }

    protected Book(string name, string author, string categoryName)
    {
        Name = name;
        Author = author;
        CategoryName = categoryName;
    }

    public override string ToString()
    {
        return $"{Name} by {Author} in {CategoryName} category";
    }

    public abstract void Accept(IBookExportVisitor visitor);
}
