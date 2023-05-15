using VisitorPattern.Abstractions;
using VisitorPattern.Models;
using VisitorPattern.Visitors;

Book earth = new Encyclopedia("Big Earth!", "Jose S. Massey", "Encyclopedia");
Book daily = new Magazine("Daily Magazine", "Wayne D. Eakin", "Magazine");

IBookExportVisitor xmlExportVisitor = new XmlExportVisitor();
IBookExportVisitor jsonExportVisitor = new JsonExportVisitor();

earth.Accept(xmlExportVisitor);
daily.Accept(jsonExportVisitor);

Console.ReadLine();