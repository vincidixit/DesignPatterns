using AbstractFactory.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation.Windows
{
    public class WinCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine($"Rendering {this.GetType().Name}");
        }
    }
}
