using Decorator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Implementation
{
    class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {

        }

        public override double GetCost()
        {
            return base.GetCost() + 1;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }
    }
}
