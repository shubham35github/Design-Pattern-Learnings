using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ObserverDesignPattern.Observer;

namespace Test.ObserverDesignPattern.Obervable
{
    public class WhetherStation:ISubject
    {
        private List<IObserver> _observers =new List<IObserver>();
        private string _whether=string.Empty;
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer) { 
            _observers.Remove(observer);
        }
        public void NotifyObserver()
        {
            foreach (IObserver observer in _observers)
            {
                observer.UpdateWhether(_whether);
            }
        }
        public void AddWhether(string whether)
        {
            this._whether = whether;
            NotifyObserver();
        }
    }
}
