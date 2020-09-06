using System;

namespace CSharp.src.example1.dip
{
    public class DatabaseLog : ILogging
    {
        private readonly LogRepository logRepo;
        private readonly Logging loggingOriginal;
        public DatabaseLog()
        {
            logRepo = new LogRepository();
            loggingOriginal = new Logging();
        }

        public void Info(string message) => loggingOriginal.Info(message);

        public void Error(string message, Exception e) => loggingOriginal.Error(message, e);

        public void Fatal(string message, Exception e)
        {
            logRepo.AlmacenarError(message, e);
            loggingOriginal.Fatal(message, e);
        }
    }
}