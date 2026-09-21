using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.Pizzas
{
    internal class VeggiePizza : Pizza
    {
        public VeggiePizza(string name, PizzaIngredientFactory ingredientFactory) : base(name, ingredientFactory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}
