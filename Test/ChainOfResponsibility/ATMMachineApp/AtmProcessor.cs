using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ChainOfResponsibility.ATMMachineApp
{
    public enum CurrencyType
    {
        Rs100,
        Rs500,
        Rs2000
    }
    public abstract class AtmProcessor
    {
        AtmProcessor? nextCurrencyProcessor = null;
        public AtmProcessor(AtmProcessor nextCurrencyProcessor)
        {
            this.nextCurrencyProcessor = nextCurrencyProcessor;
        }
        public virtual void Process(CurrencyType type,string message)
        {
            if(nextCurrencyProcessor != null)
            {
                nextCurrencyProcessor.Process(type,message);
            }
        }
    }
}
