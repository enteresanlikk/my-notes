using AbstractFactoryPattern.Abstractions;
using AbstractFactoryPattern.Models.Common;
using AbstractFactoryPattern.Models.Oracle;

namespace AbstractFactoryPattern.DatabaseFactories;

public class OracleDatabaseFactory : IDatabaseFactory
{
    public Command CreateCommand()
    {
        return new OracleCommand();
    }

    public Connection CreateConnection()
    {
        return new OracleConnection();
    }
}
