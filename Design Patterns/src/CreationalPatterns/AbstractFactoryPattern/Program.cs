using AbstractFactoryPattern.DatabaseFactories;

DatabaseFactory databaseFactory = new(new MySQLDatabaseFactory());
databaseFactory.RemoveById(1);

Console.ReadLine();