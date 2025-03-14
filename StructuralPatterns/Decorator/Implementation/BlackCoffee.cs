using Decorator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Implementation
{
    class BlackCoffee : ICoffee
    {
        public double GetCost()
        {
            return 1.0;
        }

        public string GetDescription()
        {
            return "Black Coffee";
        }
    }
}
