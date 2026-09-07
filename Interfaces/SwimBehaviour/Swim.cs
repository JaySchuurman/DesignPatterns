using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehaviour
{
    internal class Swim : SwimBehaviour
    {
        void SwimBehaviour.Swim()
        {
            Console.WriteLine("Swimming!");
        }
    }
}
