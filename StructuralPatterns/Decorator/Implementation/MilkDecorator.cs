using Decorator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Implementation
{
    class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
            
        }

        public override double GetCost()
        {
            return base.GetCost() + 2;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Milk";
        }
    }
}
