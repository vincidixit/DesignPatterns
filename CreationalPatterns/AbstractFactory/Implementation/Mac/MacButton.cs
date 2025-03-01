using AbstractFactory.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation.Mac
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine($"Rendering {this.GetType().Name}");
        }
    }
}
