using AbstractFactoryPattern.Abstractions;
using AbstractFactoryPattern.Models.Common;

namespace AbstractFactoryPattern.DatabaseFactories;

public class DatabaseFactory
{
    IDatabaseFactory _databaseFactory;
    Connection _connection;
    Command _command;

    public DatabaseFactory(IDatabaseFactory databaseFactory)
    {
        _databaseFactory = databaseFactory;
        _command = _databaseFactory.CreateCommand();
        _connection = _databaseFactory.CreateConnection();
    }

    public void RemoveById(int id)
    {
        _connection.OpenConnection();
        _command.ExecuteCommand("DELETE FROM TABLE WHERE ID = " + id);
        _connection.CloseConnection();
    }
}
