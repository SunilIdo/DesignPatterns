using DecoratorPatternApp.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp.Decorator
{
    public abstract class Topping:IceCream
    {
        protected IceCream IceCream { get; set; }
        public Topping(IceCream ic)
        {
            IceCream = ic;
        }
    }
}
