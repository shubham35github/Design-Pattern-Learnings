using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.StrategyPattern
{
    public class Bicycle : Vehicle
    {
        public Bicycle() : base(new NormalDrive())  { }
    }
}
