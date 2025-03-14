using Decorator.Abstraction;
using Decorator.Client;
using Decorator.Implementation;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coffee = new BlackCoffee();

            var client = new ClientApplication(coffee);
            client.GetCoffeeDescription();

            client.CustomizeCoffee(addMilk: true, addSugar: true);

            client.GetCoffeeDescription();
        }
    }
}
