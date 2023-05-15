using VisitorPattern.Abstractions;
using VisitorPattern.Models;

namespace VisitorPattern.Visitors;

public class JsonExportVisitor : IBookExportVisitor
{
    public void ExportVisit<T>(T book) where T : Book
    {
        Console.WriteLine($"{book.Name} exported by {GetType().Name}");
    }
}
