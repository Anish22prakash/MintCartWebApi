namespace MintCartWebApi.LoggerService
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void LogError(string message, Exception exception = null);
        void LogDebug(string message);
        void LogWarning(string message);
        // added the changes in logger service
    }
}
