using System;
using MiniDuckSimulator.Behaviors;
using MiniDuckSimulator.Ducks;

namespace MiniDuckSimulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            Duck rubberDuckie = new RubberDuck();
            Duck decoy = new DecoyDuck();
            Duck model = new ModelDuck();

            mallard.PerformQuack();
            rubberDuckie.PerformQuack();
            decoy.PerformQuack();

            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();

            Console.ReadKey();
        }
    }
}
