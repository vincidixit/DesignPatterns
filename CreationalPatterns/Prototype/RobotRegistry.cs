using Prototype.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class RobotRegistry
    {
        private Dictionary<string, IRobot> _collection = new Dictionary<string, IRobot>();

        public void Register(string key ,IRobot robot)
        {
            _collection.Add(key, robot);
            Console.WriteLine($"Added {robot.GetType().Name} in registry. Hashcode - {robot.GetHashCode()}");
        }

        public IRobot Get(string key)
        {
            var robot = _collection[key];
            return robot.Clone();
        }

    }
}
