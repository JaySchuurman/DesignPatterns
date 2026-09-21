using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.Pizzas
{
    internal class ClamPizza : Pizza
    {
        public ClamPizza(string name, PizzaIngredientFactory ingredientFactory) : base(name, ingredientFactory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            clam = ingredientFactory.createClams(); 
        }
    }
}
