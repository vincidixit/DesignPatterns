using Prototype.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implementation
{
    public class UltronRobot : IRobot
    {
        public string TagName { get; set; }

        public UltronRobot()
        {
            
        }

        private UltronRobot(UltronRobot ultronRobot)
        {
            this.TagName = ultronRobot.TagName;
        }

        public IRobot Clone()
        {
            return new UltronRobot(this);
        }
    }
}
