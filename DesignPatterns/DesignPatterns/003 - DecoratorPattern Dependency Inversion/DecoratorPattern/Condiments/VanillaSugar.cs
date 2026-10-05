using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class VanillaSugar : CondimentDecorator
    {
        public VanillaSugar(Beverage beverage): base(beverage) 
        {
            this.baseBeverage = beverage;
        }
        public override double cost()
        {
            return 2.00 + base.cost() + baseBeverage.cost();
        }
        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Vanilla Sugar";
        }
    }
    }
