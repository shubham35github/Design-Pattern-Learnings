using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ObserverDesignPattern.Observer
{
    public class TabDisplay:IObserver
    {
        public void UpdateWhether(string whether)
        {
            Console.WriteLine("Tab Diaplays : " + whether);
        }
    }
}
