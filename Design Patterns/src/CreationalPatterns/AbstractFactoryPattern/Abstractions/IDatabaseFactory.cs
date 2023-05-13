using AbstractFactoryPattern.Models.Common;

namespace AbstractFactoryPattern.Abstractions;

public interface IDatabaseFactory
{
    Connection CreateConnection();
    Command CreateCommand();
}
