using Sample3;

ILogger logger = new ConsoleLogger();
logger.Log();

ILogger logger2 = new FileLogger();
logger2.Log();