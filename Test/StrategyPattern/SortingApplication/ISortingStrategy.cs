using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.StrategyPattern.SortingApplication
{
    public interface ISortingStrategy
    {
        public void Sort(string numbers);
    }
}
