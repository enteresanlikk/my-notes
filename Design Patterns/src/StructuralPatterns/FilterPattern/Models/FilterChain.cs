using FilterPattern.Abstractions;

namespace FilterPattern.Models;

public class FilterChain
{
    private readonly List<IFilter> _filters = new();
    public ITarget Target { get; set; }

    public FilterChain()
    {

    }

    public FilterChain(ITarget target)
    {
        Target = target;
    }

    public void Add(IFilter filter)
    {
        _filters.Add(filter);
    }

    public void Remove(IFilter filter)
    {
        _filters.Remove(filter);
    }

    public void Run()
    {
        _filters.ForEach(filter => filter.Execute());
        Target.Handle();
    }
}
