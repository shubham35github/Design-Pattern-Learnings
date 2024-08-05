using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DecoratorPattern
{
    public class MargheritaPizza:PizzaBase
    {
        public override int Cost()
        {
            return 50;
        }
    }
}
