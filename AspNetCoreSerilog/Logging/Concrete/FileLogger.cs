using AspNetCoreSerilog.Logging.Abstract;
using Serilog;
using Serilog.Core;
using System.IO;

namespace AspNetCoreSerilog.Logging.Concrete
{
    public class FileLogger : LoggingConfiguration, ILogManager
    {
        private const string LogFolder = @"\LogFiles\";
        protected override Logger GetLogger()
        {
            return new LoggerConfiguration()
                    .WriteTo.File(string.Format("{0}{1}", Directory.GetCurrentDirectory() + LogFolder, ".txt"),
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: null,
                    fileSizeLimitBytes: 5000000,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}")
                    .CreateLogger();
        }

        public void Verbose(string message) => GetLogger().Verbose(message);
        public void Verbose<T>(string message, T t) => GetLogger().Verbose(message, t);
        public void Fatal(string message) => GetLogger().Fatal(message);
        public void Fatal<T>(string message, T t) => GetLogger().Fatal(message, t);
        public void Information(string message) => GetLogger().Information(message);
        public void Information<T>(string message, T t) => GetLogger().Information(message, t);
        public void Warning(string message) => GetLogger().Warning(message);
        public void Warning<T>(string message, T t) => GetLogger().Warning(message, t);
        public void Debug(string message) => GetLogger().Debug(message);
        public void Debug<T>(string message, T t) => GetLogger().Debug(message, t);
        public void Error(string message) => GetLogger().Error(message);
        public void Error<T>(string message, T t) => GetLogger().Error(message, t);
    }
}
