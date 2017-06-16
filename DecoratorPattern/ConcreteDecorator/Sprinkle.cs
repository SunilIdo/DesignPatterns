using DecoratorPatternApp.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPatternApp.Component;

namespace DecoratorPatternApp.ConcreteDecorator
{
    public class Sprinkle : Topping
    {
        public Sprinkle(IceCream ic) : base(ic)
        {
        }

        public override double Cost()
        {
            return 0.5 + IceCream.Cost();
        }
    }
}
