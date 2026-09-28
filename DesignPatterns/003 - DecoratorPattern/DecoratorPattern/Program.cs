using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using FactoryPattern;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = BeverageFactory.Create("espresso");
            PrintBeverage(espresso);

            Beverage doppio = BeverageFactory.Create("doppio");
            PrintBeverage(doppio);

            Beverage lungo = BeverageFactory.Create("lungo");
            PrintBeverage(lungo);

            Beverage macchiato = BeverageFactory.Create("macchiato");  
            PrintBeverage(macchiato);

            Beverage correctta = BeverageFactory.Create("correctta");
            PrintBeverage(correctta);

            Beverage conPanna = BeverageFactory.Create("conPanna");
            PrintBeverage(conPanna);

            Beverage cappucino = BeverageFactory.Create("cappucino");
            PrintBeverage(cappucino);

            Beverage americano = BeverageFactory.Create("americano");
            PrintBeverage(americano);

            Beverage cafféLatte = BeverageFactory.Create("cafféLatte");
            PrintBeverage(cafféLatte);

            Beverage flatWhite = BeverageFactory.Create("flatWhite");
            PrintBeverage(flatWhite);

            Beverage romana = BeverageFactory.Create("romana");
            PrintBeverage(romana);

            Beverage morrochino = BeverageFactory.Create("morrochino");
            PrintBeverage(morrochino);

            Beverage mocha = BeverageFactory.Create("mocha");
            PrintBeverage(mocha);

            Beverage bicerin = BeverageFactory.Create("bicerin");
            PrintBeverage(bicerin);

            Beverage breve = BeverageFactory.Create("breve");
            PrintBeverage(breve);

            Beverage rafCoffee = BeverageFactory.Create("rafCoffee");
            PrintBeverage(rafCoffee);

            Beverage meadRaf = BeverageFactory.Create("meadRaf");
            PrintBeverage(meadRaf);

            Beverage galao = BeverageFactory.Create("galao");
            PrintBeverage(galao);

            Beverage caffeAffogato = BeverageFactory.Create("caffeAffogato");
            PrintBeverage(caffeAffogato);

            Beverage viennaCoffee = BeverageFactory.Create("viennaCoffee");
            PrintBeverage(viennaCoffee);

            Beverage glace = BeverageFactory.Create("glace");
            PrintBeverage(glace);

            Beverage chocolateMilk = BeverageFactory.Create("chocolateMilk");
            PrintBeverage(chocolateMilk);

            Beverage demiCreme = BeverageFactory.Create("demiCreme");
            PrintBeverage(demiCreme);

            Beverage latteMacchiato = BeverageFactory.Create("latteMacchiato");
            PrintBeverage(latteMacchiato);

            Beverage freddo = BeverageFactory.Create("freddo");
            PrintBeverage(freddo);

            Beverage frappucino = BeverageFactory.Create("frappucino");
            PrintBeverage(frappucino);

            Beverage caramelFrappucino = BeverageFactory.Create("caramelFrappucino");
            PrintBeverage(caramelFrappucino);

            Beverage frappe = BeverageFactory.Create("frappe");
            PrintBeverage(frappe);


            Beverage irishCoffee = BeverageFactory.Create("irishCoffee");
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}