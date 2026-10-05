using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();
            Duck modelDuck = new ModelDuck();

            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.Swim();
            mallardDuck.Display();

            //redheadDuck.PerformQuack();
            //redheadDuck.PerformFly();

            //decoyDuck.PerformQuack();
            //decoyDuck.PerformFly();

            //rubberDuck.PerformQuack();
            //rubberDuck.PerformFly();

            //robotDuck.PerformQuack();
            //robotDuck.PerformFly();

            //modelDuck.PerformQuack();
            //modelDuck.PerformFly();

        }
    }
}