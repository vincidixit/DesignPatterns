using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstraction
{
    public interface IComponentFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
