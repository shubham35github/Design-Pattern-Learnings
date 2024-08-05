using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.StrategyPattern
{
    public class SportDrive:IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Sport Drive");
        }
    }
}
