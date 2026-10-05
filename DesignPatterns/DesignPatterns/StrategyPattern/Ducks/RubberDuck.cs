using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.SwimBehaviour;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
            swimBehavior = new Swim();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck, I am a tool for endless bathtime fun.");
        }
    }
}
