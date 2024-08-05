using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DecoratorPattern
{
    public class PaneerPizza:PizzaBase
    {
        public override int Cost()
        {
            return 200;
        }
    }
}
