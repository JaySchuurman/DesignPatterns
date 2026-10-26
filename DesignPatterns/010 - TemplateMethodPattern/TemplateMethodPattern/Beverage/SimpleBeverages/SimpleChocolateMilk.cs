using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Beverage.SimpleBeverages
{
    internal class SimpleChocolateMilk
    {
        public void PrepareRecipe()
        {
            BoilWater();
            AddCacaoPowder();
            PourInCup();
            AddWhippedCream();
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void AddCacaoPowder()
        {
            Console.WriteLine("Adding Cacao Powder");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }
        public void AddWhippedCream()
        {
            Console.WriteLine("Adding Whipped Cream");
        }
    }
}