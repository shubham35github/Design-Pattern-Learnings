using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.StrategyPattern.SortingApplication
{
    internal class SortingContext
    {
        ISortingStrategy strategy;
        public SortingContext(ISortingStrategy strategy)
        {
            this.strategy = strategy;
        }
        
        public void Sort(string numbers)
        {
            strategy.Sort(numbers);
        }

    }
}
