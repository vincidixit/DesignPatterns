using Prototype.Abstraction;

namespace Prototype.Client
{
    public class Application
    {
        public void Run()
        {
            IRobot ultron = RobotFactory.GetRobot("ultron");
            Console.WriteLine($"New {ultron.GetType().Name} created. HashCode - {ultron.GetHashCode()}");

            IRobot vision = RobotFactory.GetRobot("vision");
            Console.WriteLine($"New {vision.GetType().Name} created. HashCode - {vision.GetHashCode()}");
        }

    }
}
