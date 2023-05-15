using VisitorPattern.Models;

namespace VisitorPattern.Abstractions;

public interface IBookExportVisitor
{
    void ExportVisit<T>(T book) where T : Book;
}
