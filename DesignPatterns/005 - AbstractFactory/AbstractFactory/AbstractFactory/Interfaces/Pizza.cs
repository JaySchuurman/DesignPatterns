using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    internal abstract class Pizza
    {
        public string Name { get; set; }
        protected Dough dough;
        protected Sauce sauce;
        protected Veggie[] veggie;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clam;
        protected PizzaIngredientFactory ingredientFactory;
        public abstract void Prepare();
        protected Pizza(string name, PizzaIngredientFactory ingredientFactory)
        {
            Name = name;
            this.ingredientFactory = ingredientFactory;
        }


        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in an official PizzaStore box");
        }
    }
}
