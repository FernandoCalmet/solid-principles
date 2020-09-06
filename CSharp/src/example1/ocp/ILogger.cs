using System;

namespace CSharp.src.example1.ocp
{
    public interface ILogger
    {
        void Info(string message);
        void Error(string message, Exception e);
        void Fatal(string message, Exception e);
    }
}