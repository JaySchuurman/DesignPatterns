using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.Pizzas
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza(string? name, PizzaIngredientFactory? ingredientFactory) : base(name, ingredientFactory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            this.dough = ingredientFactory.createDough();
            this.sauce = ingredientFactory.createSauce();
            this.cheese = ingredientFactory.createCheese();
        }
    }
}
