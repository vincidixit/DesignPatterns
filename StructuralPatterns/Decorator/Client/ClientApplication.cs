using Decorator.Abstraction;
using Decorator.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Client
{
    public class ClientApplication
    {
        private ICoffee _coffee;

        public ClientApplication(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public void CustomizeCoffee(bool addMilk, bool addSugar)
        {
            if (addMilk) 
                _coffee = new MilkDecorator(_coffee);

            if (addSugar) 
                _coffee = new SugarDecorator(_coffee);
        }

        public void GetCoffeeDescription()
        {
            Console.WriteLine($"{ _coffee.GetDescription()} - Costs ${_coffee.GetCost()}");
        }
    }
}
