using AbstractFactoryPattern.Models.Common;

namespace AbstractFactoryPattern.Models.MySQL;

public class MySQLConnection : Connection
{
    public override bool OpenConnection()
    {
        return true;
    }

    public override bool CloseConnection()
    {
        return true;
    }
}
