namespace AbstractFactoryPattern.Models.Common;

public abstract class Connection
{
    public abstract bool OpenConnection();
    public abstract bool CloseConnection();
}
