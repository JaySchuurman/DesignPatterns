using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehaviour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck : Duck
    {
        public RobotDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
            swimBehavior = new Dive();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck gimme some malware to feast upon");
        }
    }
}
