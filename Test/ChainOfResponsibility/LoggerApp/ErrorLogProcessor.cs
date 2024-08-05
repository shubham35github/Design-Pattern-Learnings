using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ChainOfResponsibility.LoggerApp
{
    public class ErrorLogProcessor : LogProcessor
    {
        public ErrorLogProcessor(LogProcessor logProcessor) : base(logProcessor) { }

        public void Log(LoggerType type, string message)
        {
            if (type == LoggerType.ERROR)
            {
                Console.WriteLine(message);
            }
            else
            {
                base.Log(type, message);
            }
        }
    }
}
