using AbstractFactory.Interfaces;
using AbstractFactory.Classes;
using AbstractFactory.Classes.Veggies;
using AbstractFactory.Classes.New_York;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.New_York
{
    internal class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public Clams createClams()
        {
            return new FreshClams();
        }

        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Veggie[] createVeggies()
        {
            return new Veggie[] { new Garlic(), new Onion(), new RedPepper()};
        }
    }
}
