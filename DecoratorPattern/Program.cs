using DecoratorPatternApp.Component;
using DecoratorPatternApp.ConcreteComponent;
using DecoratorPatternApp.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCream iceCream = new Chocolate();
            iceCream = new Sprinkle(iceCream);
            iceCream = new Fudge(iceCream);
            Console.WriteLine(iceCream.Cost());
            Console.ReadKey();
        }
    }
}
