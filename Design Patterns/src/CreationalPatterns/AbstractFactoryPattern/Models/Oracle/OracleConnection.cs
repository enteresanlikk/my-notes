using AbstractFactoryPattern.Models.Common;

namespace AbstractFactoryPattern.Models.Oracle;

public class OracleConnection : Connection
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
