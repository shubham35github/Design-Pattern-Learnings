using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ChainOfResponsibility.ATMMachineApp
{
    public class TwoThusandRsProcessor:AtmProcessor
    {
        public TwoThusandRsProcessor(AtmProcessor processor):base(processor) { }
        public override void Process(CurrencyType type, string message)
        {
            if(type==CurrencyType.Rs2000)
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
