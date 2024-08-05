using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ChainOfResponsibility.ATMMachineApp
{
    public class HundredRsProcessor:AtmProcessor
    {
        public HundredRsProcessor(AtmProcessor processor) : base(processor) { }
        public override void Process(CurrencyType type,string message)
        {
            if(type==CurrencyType.Rs100)
            {
                Console.WriteLine(message);
            }
            else
            {
                base.Process(type,message);
            }
        }
    }
}
