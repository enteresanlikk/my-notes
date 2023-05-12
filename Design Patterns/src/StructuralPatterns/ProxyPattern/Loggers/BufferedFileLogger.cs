using ProxyPattern.Abstractions;

namespace ProxyPattern.Loggers;

public class BufferedFileLogger : ILogger
{
    private readonly int _size;
    private readonly FileLogger _fileLogger;
    private List<string> _messages;

    public BufferedFileLogger(int size)
    {
        _size = size;
        _fileLogger = new();
        _messages = new(capacity: size);
    }

    public void Log(string message)
    {
        _messages.Add(message);

        if (_messages.Count >= _size)
        {
            foreach (var log in _messages)
            {
                _fileLogger.Log(log);
            }
            _messages.Clear();
        }
    }
}
