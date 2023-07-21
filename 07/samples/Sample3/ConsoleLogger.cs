namespace Sample3;

public class ConsoleLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("ConsoleLogger.Log()");
    }
}