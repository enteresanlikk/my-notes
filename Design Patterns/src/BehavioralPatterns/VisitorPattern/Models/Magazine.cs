using VisitorPattern.Abstractions;

namespace VisitorPattern.Models;

public class Magazine : Book
{
    public Magazine(string name, string author, string categoryName) : base(name, author, categoryName)
    {

    }

    public override void Accept(IBookExportVisitor visitor)
    {
        visitor.ExportVisit(this);
    }
}
