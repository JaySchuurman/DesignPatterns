using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace FactoryPattern
{
    public class BeverageFactory
    {
        private static Beverage OrderDrink(string beverage)
        {
            Beverage orderedBeverage;

            switch (beverage.ToLower())
            {
                case "espresso":
                    orderedBeverage = new Espresso();
                    break;

                case "doppio":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new EspressoCondiment(orderedBeverage);
                    break;

                case "lungo":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new Water(orderedBeverage);
                    break;

                case "macchiato":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new MilkFoam(orderedBeverage);
                    orderedBeverage.Size = Size.VENDI;
                    break;

                case "correctta":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new Liqour(orderedBeverage);
                    break;

                case "conpanna":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new Whip(orderedBeverage);
                    break;

                case "cappucino":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new MilkFoam(orderedBeverage);
                    break;

                case "americano":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new Water(orderedBeverage);
                    orderedBeverage = new Water(orderedBeverage);
                    break;

                case "caffélatte":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new MilkFoam(orderedBeverage);
                    break;

                case "flatwhite":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    break;

                case "romana":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new Lemon(orderedBeverage);
                    break;

                case "morrochino":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new ChocolateCondiment(orderedBeverage);
                    orderedBeverage = new MilkFoam(orderedBeverage);
                    break;

                case "mocha":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new ChocolateCondiment(orderedBeverage);
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new Whip(orderedBeverage);
                    break;

                case "bicerin":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new BlackChocolate(orderedBeverage);
                    orderedBeverage = new WhiteChocolate(orderedBeverage);
                    break;

                case "breve":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new MilkFoam(orderedBeverage);
                    orderedBeverage = new HalfMilk(orderedBeverage);
                    break;

                case "rafcoffee":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new VanillaSugar(orderedBeverage);
                    orderedBeverage = new Cream(orderedBeverage);
                    break;

                case "meadraf":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new Honey(orderedBeverage);
                    orderedBeverage = new Cream(orderedBeverage);
                    break;

                case "galao":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new MilkFoam(orderedBeverage);
                    orderedBeverage = new MilkFoam(orderedBeverage);
                    break;

                case "caffeaffogato":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new EspressoCondiment(orderedBeverage);
                    orderedBeverage = new IceCream(orderedBeverage);
                    break;

                case "viennacoffee":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new EspressoCondiment(orderedBeverage);
                    orderedBeverage = new Whip(orderedBeverage);
                    orderedBeverage = new Whip(orderedBeverage);
                    break;

                case "glace":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new Ice(orderedBeverage);
                    break;

                case "chocolatemilk":
                    orderedBeverage = new Chocolate();
                    orderedBeverage = new Milk(orderedBeverage);
                    orderedBeverage = new Milk(orderedBeverage);
                    break;

                case "demicreme":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new EspressoCondiment(orderedBeverage);
                    orderedBeverage = new Cream(orderedBeverage);
                    orderedBeverage = new Cream(orderedBeverage);
                    break;

                case "lattemacchiato":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new MilkFoam(orderedBeverage);
                    break;

                case "freddo":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new Liqour(orderedBeverage);
                    orderedBeverage = new Ice(orderedBeverage);
                    break;

                case "frappucino":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new Ice(orderedBeverage);
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new Whip(orderedBeverage);
                    break;

                case "caramelfrappucino":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new Ice(orderedBeverage);
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new Cream(orderedBeverage);
                    orderedBeverage = new Syrup(orderedBeverage);
                    break;

                case "frappe":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new SteamedMilk(orderedBeverage);
                    orderedBeverage = new IceCream(orderedBeverage);
                    break;

                case "irishcoffee":
                    orderedBeverage = new Espresso();
                    orderedBeverage = new EspressoCondiment(orderedBeverage);
                    orderedBeverage = new Whiskey(orderedBeverage);
                    orderedBeverage = new Whip(orderedBeverage);
                    orderedBeverage.Size = Size.VENDI;
                    break;

                default:
                    throw new ArgumentException("Unknown beverage");
            }

            PrintBeverage(orderedBeverage);
            return orderedBeverage;
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(
                beverage.GetDescription() + " $" +
                beverage.cost().ToString("#.##")
            );
        }
    }
}