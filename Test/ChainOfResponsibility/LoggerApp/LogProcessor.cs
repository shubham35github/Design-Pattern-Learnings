using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ChainOfResponsibility.LoggerApp
{
    public enum LoggerType
    {
        INFO,
        WARNING,
        ERROR
    }
    public abstract class LogProcessor
    {
        public LogProcessor nextLoggerProcessor;
        public LogProcessor(LogProcessor loggerProcessor)
        {
            nextLoggerProcessor = loggerProcessor;
        }
        public virtual void Log(LoggerType type, string message)
        {
            if (nextLoggerProcessor != null)
            {
                nextLoggerProcessor.Log(type, message);
            }
        }
    }
}
