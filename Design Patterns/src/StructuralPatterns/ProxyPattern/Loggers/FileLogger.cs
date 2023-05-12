using ProxyPattern.Abstractions;

namespace ProxyPattern.Loggers;

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        message = $"{DateTime.Now} - {message}";
        Console.WriteLine(message);
        //File.AppendAllText("file-log.txt", message);
    }
}
