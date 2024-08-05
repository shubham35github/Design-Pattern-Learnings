using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.StrategyPattern
{
    public class NormalDrive:IDriveStrategy
    {
        public void Drive() {
            Console.WriteLine("Normal Drive");
        } 
    }
}
