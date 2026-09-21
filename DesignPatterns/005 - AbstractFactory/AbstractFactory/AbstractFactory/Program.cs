using AbstractFactory.Classes.New_York;
using AbstractFactory.Classes.Pizzas;
using AbstractFactory.Interfaces;
using System.Security.Claims;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new NyPizzaStore();
            store.orderPizza("pepperoni");
        }
    }
}