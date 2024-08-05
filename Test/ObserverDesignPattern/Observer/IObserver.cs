using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ObserverDesignPattern.Observer
{
    public interface IObserver
    {
        public void UpdateWhether(string whether);
    }
}
