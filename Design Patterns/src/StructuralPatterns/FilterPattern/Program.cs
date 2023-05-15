using FilterPattern.Filters;
using FilterPattern.Managers;
using FilterPattern.Services;

try
{
    FilterManager filterManager = new(new CustomerService());

    filterManager.Add(new AuthenticationFilter());
    filterManager.Add(new ValidationFilter());

    filterManager.Run();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();