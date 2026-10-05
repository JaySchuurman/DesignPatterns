using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehaviour
{
    internal class Dive : SwimBehaviour
    {
        void SwimBehaviour.Swim()
        {
            Console.WriteLine("Diving!");
        }
    }
}
