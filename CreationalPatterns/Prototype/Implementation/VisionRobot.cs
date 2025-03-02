using Prototype.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implementation
{
    class VisionRobot : IRobot
    {
        public string TagName { get; set; }

        public VisionRobot()
        {
            
        }

        public VisionRobot(VisionRobot visionRobot)
        {
            this.TagName = visionRobot.TagName;
        }

        public IRobot Clone()
        {
            return new VisionRobot(this);
        }
    }
}
