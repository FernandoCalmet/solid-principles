using System;

namespace CSharp.src.example1.isp
{
    public interface ILogging
    {
        void Info(string message);
        void Error(string message, Exception e);
        void Fatal(string message, Exception e);
    }
}