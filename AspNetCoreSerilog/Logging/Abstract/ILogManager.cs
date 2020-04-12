namespace AspNetCoreSerilog.Logging.Abstract
{
    public interface ILogManager
    {
        void Verbose(string message);
        void Verbose<T>(string message, T t);
        void Fatal(string message);
        void Fatal<T>(string message, T t);
        void Information(string message);
        void Information<T>(string message, T t);
        void Warning(string message);
        void Warning<T>(string message, T t);
        void Debug(string message);
        void Debug<T>(string message, T t);
        void Error(string message);
        void Error<T>(string message, T t);
    }
}
