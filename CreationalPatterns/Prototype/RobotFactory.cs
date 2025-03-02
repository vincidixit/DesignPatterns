using Prototype.Abstraction;
using Prototype.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public static class RobotFactory
    {
        private static RobotRegistry registry = new RobotRegistry();

        static RobotFactory()
        {   
            LoadPrototypes();
        }

        /// <summary>
        /// Create and load different types of robot prototypes
        /// </summary>
        private static void LoadPrototypes()
        {
            Console.WriteLine("Loading Prototypes...");
            registry.Register("ultron", new UltronRobot { TagName = "ultron_v1" });
            registry.Register("vision", new VisionRobot { TagName = "vision_v1" });
            Console.WriteLine("Prototypes to be used");
        }

        public static IRobot GetRobot(string key)
        {
            return registry.Get(key);
        }
    }
}
