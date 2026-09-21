using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class Lemon : CondimentDecorator
    {
        private Beverage _beverage;

        public Lemon(Beverage beverage): base(beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Lemon";
        }

        public override double cost()
        {
            return 0.15 + base.cost() + _beverage.cost();
        }
    }
}
