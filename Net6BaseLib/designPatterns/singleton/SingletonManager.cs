namespace Net6BaseLib.designPatterns.singleton;

public class SingletonManager
{
    public SingletonManager()
    {
        Logger logger1 = Logger.GetLoggerInstance();
        Logger logger2 = Logger.GetLoggerInstance();
        Logger logger3 = Logger.GetLoggerInstance();

        logger1.LogMessage("l1", LogLevel.INFO);
        logger2.LogMessage("l2", LogLevel.INFO);
        logger3.LogMessage("l3", LogLevel.INFO);
    }
}