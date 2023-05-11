// ex. Ef Core SaveChanges, Middleware, ActionFilter

using DecoratorPattern.Models;

AppleLaptop appleLaptop = new();
appleLaptop.OpenLid();
Console.WriteLine("---");
appleLaptop.Start();
Console.WriteLine("---");
appleLaptop.CloseLid();

Console.WriteLine("--------------------------------------------------");

AsusLaptop asusLaptop = new();
asusLaptop.OpenLid();
Console.WriteLine("---");
asusLaptop.Start();
Console.WriteLine("---");
asusLaptop.ShutDown();
Console.WriteLine("---");
asusLaptop.CloseLid();

Console.ReadLine();