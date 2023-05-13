using AbstractFactoryPattern.Abstractions;
using AbstractFactoryPattern.Models.Common;
using AbstractFactoryPattern.Models.MySQL;

namespace AbstractFactoryPattern.DatabaseFactories;

public class MySQLDatabaseFactory : IDatabaseFactory
{
    public Command CreateCommand()
    {
        return new MySQLCommand();
    }

    public Connection CreateConnection()
    {
        return new MySQLConnection();
    }
}
