using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.StrategyPattern.SortingApplication
{
    internal class MergeSortStrategy:ISortingStrategy
    {
        public void Sort(string numbers)
        {
            Console.WriteLine("Sorting Done: " + numbers);
        }
    }
}
