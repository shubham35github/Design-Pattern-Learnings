using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DecoratorPattern
{
    public class ExtraChess:ToppingDecorator
    {
        PizzaBase pizzaBase;
        public ExtraChess(PizzaBase pizzaBase)
        {
            this.pizzaBase = pizzaBase;
        }

        public override int Cost()
        {
            return this.pizzaBase.Cost()+30;
        }
    }
}
