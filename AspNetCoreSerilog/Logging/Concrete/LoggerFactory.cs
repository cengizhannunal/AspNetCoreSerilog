namespace AspNetCoreSerilog.Logging.Concrete
{
    public class LoggerFactory
    {
        private LoggerFactory()
        {

        }
        static readonly object _lock = new object();
        private static DatabaseLogger _databaseLogger;
        private static FileLogger _fileLogger;


        public static DatabaseLogger DatabaseLogManager()
        {
            if (_databaseLogger == null)//double check singleton
            {
                lock (_lock)//thread safe singleton
                {
                    if (_databaseLogger == null)
                        _databaseLogger = new DatabaseLogger();
                }
            }
            return _databaseLogger;
        }

        public static FileLogger FileLogManager()
        {
            if (_fileLogger == null)
            {
                lock (_lock)
                {
                    if (_fileLogger == null)
                        _fileLogger = new FileLogger();
                }
            }
            return _fileLogger;
        }
    }
}
