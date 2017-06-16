using DecoratorPatternApp.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp.ConcreteComponent
{
    public class Vanilla : IceCream
    {
        public override double Cost()
        {
            return 1;
        }
    }
}
