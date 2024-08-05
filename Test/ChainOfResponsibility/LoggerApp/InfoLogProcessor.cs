using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ChainOfResponsibility.LoggerApp
{
    public class InfoLogProcessor : LogProcessor
    {
        public InfoLogProcessor(LogProcessor logProcessor) : base(logProcessor) { }

        public override void Log(LoggerType type, string message)
        {
            if (type == LoggerType.INFO)
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
