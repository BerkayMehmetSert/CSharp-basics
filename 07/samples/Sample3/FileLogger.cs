namespace Sample3;

public class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("FileLogger.Log()");
    }
}