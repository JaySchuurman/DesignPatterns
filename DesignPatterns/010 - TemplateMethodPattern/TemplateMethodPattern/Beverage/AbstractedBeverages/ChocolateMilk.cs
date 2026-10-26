using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Beverage.AbstractedBeverages
{
    public class ChocolateMilk : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Mixing Chocolate Powder with Milk");
        }
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Whipped Cream");
        }
    }
}
