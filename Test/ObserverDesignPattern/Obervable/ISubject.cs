using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ObserverDesignPattern.Observer;

namespace Test.ObserverDesignPattern.Obervable
{
    public interface ISubject
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObserver();

    }
}
