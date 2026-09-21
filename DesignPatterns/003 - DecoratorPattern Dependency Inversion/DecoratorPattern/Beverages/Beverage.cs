using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        private Size size;

        protected string description = "Unknown";

        public virtual string GetDescription()
        {
            return description;
        }

        public virtual double cost()
        {
           switch (size)
            {
                case Size.TALL:
                    return 1.99;
                case Size.GRANDE:
                    return 2.49;
                case Size.VENDI:
                    return 2.99;
                default:
                    return 0.0;
            }
        }
    }
}
