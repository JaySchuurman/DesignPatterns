using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace FactoryPattern
{
    public class BeverageFactory
    {
        public static Beverage Create(string beverage)
        {
            switch (beverage.ToLower())
            {
                case "espresso":
                    return new Espresso();

                case "doppio":
                    Beverage doppio = new Espresso();
                    doppio = new EspressoCondiment(doppio);
                    return doppio;

                case "lungo":
                    Beverage lungo = new Espresso();
                    lungo = new Water(lungo);
                    return lungo;

                case "macchiato":
                    Beverage macchiato = new Espresso();
                    macchiato = new MilkFoam(macchiato);
                    return macchiato;

                case "correctta":
                    Beverage correctta = new Espresso();
                    correctta = new Liqour(correctta);
                    return correctta;

                case "conPanna":
                    Beverage conPanna = new Espresso();
                    conPanna = new Whip(conPanna);
                    return conPanna;

                case "cappucino": 
                    Beverage cappucino = new Espresso();
                    cappucino = new SteamedMilk(cappucino);
                    cappucino = new MilkFoam(cappucino);
                    return cappucino;

                case "americano":
                    Beverage americano = new Espresso();
                    americano = new Water(americano);
                    americano = new Water(americano);
                    return americano;

                case "cafféLatte":
                    Beverage cafféLatte = new Espresso();
                    cafféLatte = new SteamedMilk(cafféLatte);
                    cafféLatte = new SteamedMilk(cafféLatte);
                    cafféLatte = new MilkFoam(cafféLatte);
                    return cafféLatte;

                case "flatWhite":
                    Beverage flatWhite = new Espresso();
                    flatWhite = new SteamedMilk(flatWhite);
                    flatWhite = new SteamedMilk(flatWhite);
                    return flatWhite;

                case "romana":
                    Beverage romana = new Espresso();
                    romana = new Lemon(romana);
                    return romana;

                case "morrochino":
                    Beverage morrochino = new Espresso();
                    morrochino = new ChocolateCondiment(morrochino);
                    morrochino = new MilkFoam(morrochino);
                    return morrochino;

                case "mocha":
                    Beverage mocha = new Espresso();
                    mocha = new ChocolateCondiment(mocha);
                    mocha = new SteamedMilk(mocha);
                    mocha = new Whip(mocha);
                    return mocha;

                case "bicerin":
                    Beverage bicerin = new Espresso();
                    bicerin = new BlackChocolate(bicerin);
                    bicerin = new WhiteChocolate(bicerin);
                    return bicerin;

                case "breve":
                    Beverage breve = new Espresso();
                    breve = new MilkFoam(breve);
                    breve = new HalfMilk(breve);
                    return breve;

                case "rafCoffee":
                    Beverage rafCoffee = new Espresso();
                    rafCoffee = new VanillaSugar(rafCoffee);
                    rafCoffee = new Cream(rafCoffee);
                    return rafCoffee;

                case "meadRaf":
                    Beverage meadRaf = new Espresso();
                    meadRaf = new Honey(meadRaf);
                    meadRaf = new Cream(meadRaf);
                    return meadRaf;

                case "galao":
                    Beverage galao = new Espresso();
                    galao = new MilkFoam(galao);
                    galao = new MilkFoam(galao);
                    return galao;

                case "caffeAffogato":
                    Beverage caffeAffogato = new Espresso();
                    caffeAffogato = new EspressoCondiment(caffeAffogato);
                    caffeAffogato = new IceCream(caffeAffogato);
                    return caffeAffogato;

                case "viennaCoffee":
                    Beverage viennaCoffee = new Espresso();
                    viennaCoffee = new EspressoCondiment(viennaCoffee);
                    viennaCoffee = new Whip(viennaCoffee);
                    viennaCoffee = new Whip(viennaCoffee);
                    return viennaCoffee;

                case "glace":
                    Beverage glace = new Espresso();
                    glace = new Ice(glace);
                    return glace;

                case "chocolateMilk":
                    Beverage chocolateMilk = new Chocolate();
                    chocolateMilk = new Milk(chocolateMilk);
                    chocolateMilk = new Milk(chocolateMilk);
                    return chocolateMilk;

                case "demiCreme":
                    Beverage demiCreme = new Espresso();
                    demiCreme = new EspressoCondiment(demiCreme);
                    demiCreme = new Cream(demiCreme);
                    demiCreme = new Cream(demiCreme);
                    return demiCreme;

                case "latteMacchiato":
                    Beverage latteMacchiato = new Espresso();
                    latteMacchiato = new SteamedMilk(latteMacchiato);
                    latteMacchiato = new SteamedMilk(latteMacchiato);
                    latteMacchiato = new MilkFoam(latteMacchiato);
                    return latteMacchiato;

                case "freddo":
                    Beverage freddo = new Espresso();
                    freddo = new Liqour(freddo);
                    freddo = new Ice(freddo);
                    return freddo;

                case "frappucino":
                    Beverage frappucino = new Espresso();
                    frappucino = new Ice(frappucino);
                    frappucino = new SteamedMilk(frappucino);
                    frappucino = new Whip(frappucino);
                    return frappucino;

                case "caramelFrappucino":
                    Beverage caramelFrappucino = new Espresso();
                    caramelFrappucino = new Ice(caramelFrappucino);
                    caramelFrappucino = new SteamedMilk(caramelFrappucino);
                    caramelFrappucino = new Cream(caramelFrappucino);
                    caramelFrappucino = new Syrup(caramelFrappucino);
                    return caramelFrappucino;

                case "frappe":
                    Beverage frappe = new Espresso();
                    frappe = new SteamedMilk(frappe);
                    frappe = new SteamedMilk(frappe);
                    frappe = new IceCream(frappe);
                    return frappe;

                case "irishCoffee":
                    Beverage irishCoffee = new Espresso();
                    irishCoffee = new EspressoCondiment(irishCoffee);
                    irishCoffee = new Whiskey(irishCoffee);
                    irishCoffee = new Whip(irishCoffee);
                    return irishCoffee;





                default:
                    throw new ArgumentException("Unknown beverage");
            }
        }
    }
}
