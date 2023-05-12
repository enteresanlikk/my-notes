using ProxyPattern.Abstractions;
using ProxyPattern.Loggers;

ILogger logger = new BufferedFileLogger(10);

for (int i = 0; i < 19; i++)
{
    logger.Log("First log");
}

Console.ReadLine();