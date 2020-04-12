using Serilog.Core;

namespace AspNetCoreSerilog.Logging.Concrete
{
    public abstract class LoggingConfiguration
    {
        protected abstract Logger GetLogger();

        public Logger InstanceLogger()
        {
            return default(Logger);
        }

    }
}
