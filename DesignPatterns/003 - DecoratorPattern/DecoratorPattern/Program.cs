using FactoryPattern;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory.OrderDrink("espresso");
            BeverageFactory.OrderDrink("doppio");
            BeverageFactory.OrderDrink("lungo");
            BeverageFactory.OrderDrink("macchiato");
            BeverageFactory.OrderDrink("correctta");
            BeverageFactory.OrderDrink("conPanna");
            BeverageFactory.OrderDrink("cappucino");
            BeverageFactory.OrderDrink("americano");
            BeverageFactory.OrderDrink("cafféLatte");
            BeverageFactory.OrderDrink("flatWhite");
            BeverageFactory.OrderDrink("romana");
            BeverageFactory.OrderDrink("morrochino");
            BeverageFactory.OrderDrink("mocha");
            BeverageFactory.OrderDrink("bicerin");
            BeverageFactory.OrderDrink("breve");
            BeverageFactory.OrderDrink("rafCoffee");
            BeverageFactory.OrderDrink("meadRaf");
            BeverageFactory.OrderDrink("galao");
            BeverageFactory.OrderDrink("caffeAffogato");
            BeverageFactory.OrderDrink("viennaCoffee");
            BeverageFactory.OrderDrink("glace");
            BeverageFactory.OrderDrink("chocolateMilk");
            BeverageFactory.OrderDrink("demiCreme");
            BeverageFactory.OrderDrink("latteMacchiato");
            BeverageFactory.OrderDrink("freddo");
            BeverageFactory.OrderDrink("frappucino");
            BeverageFactory.OrderDrink("caramelFrappucino");
            BeverageFactory.OrderDrink("frappe");
            BeverageFactory.OrderDrink("irishCoffee");
        }
    }
}