using System.Security.Claims;

namespace SimpleFactoryToAbstract.Stores
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new ChicagoStyleVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new ChicagoStylePepperoniPizza();
            }

            return pizza;
        }
    }
}