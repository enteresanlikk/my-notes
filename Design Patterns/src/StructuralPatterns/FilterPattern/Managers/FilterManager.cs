using FilterPattern.Abstractions;
using FilterPattern.Models;

namespace FilterPattern.Managers;

public class FilterManager
{
    private readonly FilterChain _filterChain;

    public FilterManager(ITarget target)
    {
        _filterChain = new(target);
    }

    public void Add(IFilter filter)
    {
        _filterChain.Add(filter);
    }

    public void Remove(IFilter filter)
    {
        _filterChain.Remove(filter);
    }

    public void Run()
    {
        _filterChain.Run();
    }
}
