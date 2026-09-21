using AbstractFactory.Classes.Pizzas;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.New_York
{
    internal class NyPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string type)
        {
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if(type.Equals("cheese"))
            {
                return new CheesePizza("New York Style Cheese Pizza", ingredientFactory);
            }
            else if(type.Equals("veggie"))
            {
                return new VeggiePizza("New York Style Veggie Pizza", ingredientFactory);
            }
            else if (type.Equals("clam"))
            {
                return new ClamPizza("New York Style Clam Pizza", ingredientFactory);
            }
            else if (type.Equals("pepperoni"))
            {
                return new PepperoniPizza("New York Style Pepperoni Pizza", ingredientFactory);
            }
            else
            {
                return null;
            }
        }
    }
}
