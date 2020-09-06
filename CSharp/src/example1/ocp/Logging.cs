using Serilog;
using System;

namespace CSharp.src.example1.ocp
{
    public class Logging : ILogger
    {
        public void Info(string message)
        {
            Log.Information(message);
        }
        public void Error(string message, Exception e)
        {
            Log.Error(e, message);
        }
        public void Fatal(string message, Exception e)
        {
            Log.Fatal(e, message);
        }
    }
}