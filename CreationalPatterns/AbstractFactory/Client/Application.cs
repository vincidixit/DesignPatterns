using AbstractFactory.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Client
{
    public class Application
    {
        private readonly IComponentFactory _factory;
        public Application(IComponentFactory factory)
        {
            _factory = factory;
        }

        public void Run()
        {
            Console.WriteLine($"Render application using {_factory.GetType().Name}");

            IButton button = _factory.CreateButton();
            button.Render(); 

            ICheckbox checkbox = _factory.CreateCheckbox();
            checkbox.Render();
        }


    }
}
