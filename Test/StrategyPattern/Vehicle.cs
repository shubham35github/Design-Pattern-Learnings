using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.StrategyPattern
{
    public class Vehicle
    {
        private IDriveStrategy driveStrategy;
        public Vehicle(IDriveStrategy driveStrategy) { 
            this.driveStrategy = driveStrategy;
        }

        public void Drive()
        {
            driveStrategy.Drive();
        }
    }
}
