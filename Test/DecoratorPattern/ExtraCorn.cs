using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DecoratorPattern
{
    public class ExtraCorn:ToppingDecorator
    {
        PizzaBase pizzaBase;
        public ExtraCorn(PizzaBase pizza)
        {
            this.pizzaBase = pizza;
        }
        public override int Cost()
        {
            return this.pizzaBase.Cost()+20;
        }
    }
}
