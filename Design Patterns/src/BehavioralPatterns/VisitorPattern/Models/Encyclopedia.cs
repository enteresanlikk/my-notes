using VisitorPattern.Abstractions;

namespace VisitorPattern.Models;

public class Encyclopedia : Book
{
    public Encyclopedia(string name, string author, string categoryName) : base(name, author, categoryName)
    {

    }

    public override void Accept(IBookExportVisitor visitor)
    {
        visitor.ExportVisit(this);
    }
}
