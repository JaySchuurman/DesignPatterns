using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Beverage.HookedBeverages
{
    internal class ChocolateMilkWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Mixing Chocolate Powder with Milk");
        }
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Whipped Cream");
        }
        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like whipped cream with your chocolate milk (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith('y');
        }
    }
}
